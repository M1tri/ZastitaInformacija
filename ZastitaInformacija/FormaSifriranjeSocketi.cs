using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZastitaInformacija
{
    public partial class FormaSifriranjeSocketi : Form
    {
        Cypher selectedCypherClient;

        private PlayFairCypher playFairCypherClient;
        private RC6 rc6CypherClient;
        private PCBC pcbcCypherClient;
        private string m_encryptionAlgo;

        private PlayFairCypher playFairCypherServer;
        private RC6 rc6CypherServer;
        private PCBC pcbcCypherServer;

        TcpListener m_listener;
        CancellationTokenSource m_cts;
        List<TcpClient> m_clients = new List<TcpClient>();
        bool m_pokrenutServer = false;

        string m_IpListen = "";
        int m_pListenPort = 0;

        string m_SendIP = "";
        int m_pSendPort = 0;

        private string ofdFilter = "Text fajlovi (*.txt)|*.txt";

        private GlavnaForma parent;

        public FormaSifriranjeSocketi(GlavnaForma parentForm)
        {
            parent = parentForm;

            string initalSifra = "MONARCHY";
            this.playFairCypherClient = new PlayFairCypher(initalSifra);
            this.rc6CypherClient = new RC6(initalSifra);

            byte[] iv = new byte[16];
            this.pcbcCypherClient = new PCBC(initalSifra);

            this.playFairCypherServer = new PlayFairCypher(initalSifra);
            this.rc6CypherServer = new RC6(initalSifra);

            this.pcbcCypherServer = new PCBC(initalSifra);

            this.selectedCypherClient = this.playFairCypherClient;
            m_encryptionAlgo = "Playfair";

            InitializeComponent();

            txtSifra.Text = initalSifra;
            txtSifraClient.Text = initalSifra;
        }

        private async void PokreniServer()
        {
            m_cts = new CancellationTokenSource();

            m_listener = new TcpListener(System.Net.IPAddress.Any, m_pListenPort);
            m_listener.Start();
            m_pokrenutServer = true;

            parent.UpisiULog($"Server uspešno pokrenut na portu {m_pListenPort}");

            try
            {
                while (!m_cts.IsCancellationRequested)
                {
                    TcpClient client = await m_listener.AcceptTcpClientAsync();
                    lock (m_clients)
                    {
                        m_clients.Add(client);
                    }
                    _ = ObradiZahtev(client, m_cts.Token);
                }
            }
            catch (ObjectDisposedException)
            {
                // normalno pri gasenju
            }
            catch (SocketException)
            {
                // normalno pri gasenju
            }
        }

        private void UgasiServer()
        {
            m_cts.Cancel();
            m_listener.Stop();

            lock (m_clients)
            {
                foreach (var c in m_clients)
                {
                    c.Close();
                }
                m_clients.Clear();
            }

            m_pokrenutServer = false;

            parent.UpisiULog("Server ugašen");
        }

        private async Task<byte[]> ReadExactlyAsync(NetworkStream ns,
            int count, CancellationToken ct)
        {
            byte[] buffer = new byte[count];
            int offset = 0;

            while (offset < count)
            {
                int read = await ns.ReadAsync(buffer, offset, count - offset, ct);
                if (read == 0)
                    throw new IOException("Client disconnected");

                offset += read;
            }

            return buffer;
        }


        private async Task ObradiZahtev(TcpClient client, CancellationToken ct)
        {
            try
            {
                using (client)
                using (NetworkStream ns = client.GetStream())
                {
                    byte[] lenBytes = await ReadExactlyAsync(ns, 4, ct);
                    int metaLen = BitConverter.ToInt32(lenBytes, 0);

                    byte[] metaData = await ReadExactlyAsync(ns, metaLen, ct);
                    string json = Encoding.UTF8.GetString(metaData);
                    FileMetaData fileMetaData = JsonSerializer.Deserialize<FileMetaData>(json)!;

                    byte[] ExpectedHash = new byte[0];
                    bool hasHash = false;
                    if (fileMetaData.HashAlgorithm == "SHA-1")
                    {
                        ExpectedHash = await ReadExactlyAsync(ns, 20, ct);
                        hasHash = true;
                    }

                    List<byte> data = new List<byte>();
                    byte[] buffer = new byte[1024];

                    while (!ct.IsCancellationRequested)
                    {
                        int read = await ns.ReadAsync(buffer, 0, buffer.Length, ct);
                        if (read == 0)
                            break;

                        data.AddRange(buffer.AsSpan(0, read).ToArray());
                    }

                    byte[] encryptedData = data.ToArray();
                    if (hasHash)
                    {
                        byte[] hash = SHA1.Hash(encryptedData);
                        if (!hash.SequenceEqual(ExpectedHash))
                            throw new Exception("Hash se ne poklapa!");
                    }

                    Cypher cypher;
                    if (fileMetaData.EncryptionAlgorithm == "Playfair")
                    {
                        cypher = playFairCypherServer;
                    }
                    else if (fileMetaData.EncryptionAlgorithm == "RC6")
                    {
                        cypher = rc6CypherServer;
                    }
                    else if (fileMetaData.EncryptionAlgorithm == "PCBC")
                    {
                        cypher = pcbcCypherServer;
                    }
                    else
                    {
                        throw new Exception("Neočekivan аlgoritam!");
                    }

                    byte[] decrypted = cypher.Decrypt(encryptedData, fileMetaData);

                    string serverDir = Path.Combine(Directory.GetCurrentDirectory(), "Server");
                    Directory.CreateDirectory(serverDir);

                    string outPath = Path.Combine(serverDir, fileMetaData.OriginalFileName);

                    File.WriteAllBytes(outPath, decrypted);

                    parent.UpisiULog(
                        $"Uspešno primljen i dešifrovan fajl {fileMetaData.OriginalFileName} " + 
                        $"algoritmom {fileMetaData.EncryptionAlgorithm} " +
                        $"rezultujući fajl je na lokaciji {outPath}");
                }
            }
            catch (ObjectDisposedException)
            {
                // ocekivano pri gasenju
            }
            catch (SocketException)
            {
                // ocekivano pri gasenju
            }
            catch (CypherException se)
            {
                parent.UpisiULog($"Greška pri dešifrovanju pristiglog fajla: {se.Message}");
                MessageBox.Show("Došlo je do greške pri obradi pristiglog paketa",
                                "Greška",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            catch (Exception e)
            {
                parent.UpisiULog($"Greška pri obradi pristiglog paketa: {e.Message}");
                MessageBox.Show("Došlo je do greške pri obradi pristiglog paketa",
                                "Greška",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            finally
            {
                lock (m_clients)
                {
                    m_clients.Remove(client);
                }
            }
        }

        private async Task PosaljiZahtev(byte[] data)
        {
            FileMetaData fileMetaData = new FileMetaData
            {
                CreationTime = DateTime.Now,
                OriginalFileName = Path.GetFileName(txtBoxImeFajla.Text),
                FileSize = data.Length,
                HashAlgorithm = "SHA-1",
                EncryptionAlgorithm = m_encryptionAlgo
            };

            try
            {
                byte[] encrypted = selectedCypherClient.Encrypt(data, fileMetaData);
                byte[] hash = SHA1.Hash(encrypted);

                string json = fileMetaData.ToJson();
                byte[] metaData = Encoding.UTF8.GetBytes(json);

                using (TcpClient client = new TcpClient())
                {
                    await client.ConnectAsync(m_SendIP, m_pSendPort);

                    using (NetworkStream stream = client.GetStream())
                    {
                        byte[] len = BitConverter.GetBytes(metaData.Length);
                        await stream.WriteAsync(len);
                        await stream.WriteAsync(metaData);
                        await stream.WriteAsync(hash);
                        await stream.WriteAsync(encrypted);
                    }
                }

                parent.UpisiULog(
                    $"Fajl {fileMetaData.OriginalFileName} sifrovan algoritmom {fileMetaData.EncryptionAlgorithm} " +
                    $"poslat je na adresu {m_SendIP}:{m_pSendPort}");
            }
            catch (SocketException se)
            {
                parent.UpisiULog($"Neuspešna konekcija ka {m_SendIP}:{m_pSendPort}. Greška: {se.Message}");
                MessageBox.Show("Ne može da se uspostavi konekcija sa serverom.",
                                "Greška",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            catch (CypherException ce)
            {
                parent.UpisiULog($"Greška pri šifrovanjua fajla {fileMetaData.OriginalFileName}: {ce.Message}");
                MessageBox.Show("Došlo je do greške pri slanju fajla.",
                                "Greška",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            catch (Exception e)
            {
                parent.UpisiULog($"Greška pri slanju fajla: {e.Message}");
                MessageBox.Show("Došlo je do greške pri slanju fajla.",
                                "Greška",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void dugmePokreniSrv_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxPortRcv.Text))
            {
                MessageBox.Show(
                    "Polje Port ne može biti prazno",
                    "Upozorenje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation
                );

                return;
            }

            if (!int.TryParse(txtBoxPortRcv.Text, out m_pListenPort))
            {
                MessageBox.Show(
                            "Uneti port nije validan",
                            "Upozorenje",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation
                        );

                return;
            }

            dugmePokreniSrv.Enabled = false;
            dugmeUgasiSrv.Enabled = true;

            txtBoxPortRcv.Enabled = false;
            txtSifra.Enabled = false;
            btnPotvrdi.Enabled = false;

            PokreniServer();
        }

        private void dugmeUgasiSrv_Click(object sender, EventArgs e)
        {
            dugmePokreniSrv.Enabled = true;
            dugmeUgasiSrv.Enabled = false;

            txtBoxPortRcv.Enabled = true;
            txtSifra.Enabled = true;
            btnPotvrdi.Enabled = true;

            UgasiServer();
        }

        private void dugmeSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxIPSend.Text))
            {
                MessageBox.Show(
                    "Polje IP adresa ne može biti prazno",
                    "Upozorenje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation
                );

                return;
            }
            m_SendIP = txtBoxIPSend.Text;

            if (string.IsNullOrEmpty(txtBoxPortSend.Text))
            {
                MessageBox.Show(
                            "Polje Port ne može biti prazno",
                            "Upozorenje",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation
                        );

                return;
            }

            if (!int.TryParse(txtBoxPortSend.Text, out m_pSendPort))
            {
                MessageBox.Show(
                        "Uneti port nije validan",
                        "Upozorenje",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation
                    );

                return;
            }

            if (string.IsNullOrEmpty(txtBoxImeFajla.Text))
            {
                MessageBox.Show(
                            "Morate izabrati fajl za slanje",
                            "Upozorenje",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation
                        );

                return;
            }

            byte[] data = File.ReadAllBytes(txtBoxImeFajla.Text);
            _ = PosaljiZahtev(data);
        }

        private void dumeFajl_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = ofdFilter;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string path = ofd.FileName;
                txtBoxImeFajla.Text = path;
            }
        }

        private void radioPlayfair_CheckedChanged(object sender, EventArgs e)
        {
            if (radioPlayfair.Checked)
            {
                selectedCypherClient = playFairCypherClient;
                ofdFilter = "Text fajlovi (*.txt)|*.txt";
                m_encryptionAlgo = "Playfair";
            }
        }

        private void radioRC6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioRC6.Checked)
            {
                selectedCypherClient = rc6CypherClient;
                ofdFilter = "Tekst i slike (*.txt;*.png;*.jpg;*.jpeg;*.bmp;*.gif)|*.txt;*.png;*.jpg;*.jpeg;*.bmp;*.gif";
                m_encryptionAlgo = "RC6";
            }
        }

        private void radioPCBC_CheckedChanged(object sender, EventArgs e)
        {
            if (radioPCBC.Checked)
            {
                selectedCypherClient = pcbcCypherClient;
                ofdFilter = "Tekst i slike (*.txt;*.png;*.jpg;*.jpeg;*.bmp;*.gif)|*.txt;*.png;*.jpg;*.jpeg;*.bmp;*.gif";
                m_encryptionAlgo = "PCBC";
            }
        }

        private void FormaSifriranjeSocketi_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (m_pokrenutServer)
                UgasiServer();
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSifra.Text))
            {
                MessageBox.Show(
                    "Sifra ne može biti prazna!",
                    "Upozorenje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            playFairCypherServer.Key = txtSifra.Text;
            rc6CypherServer.Key = txtSifra.Text;
            pcbcCypherServer.Key = txtSifra.Text;
        }

        private void btnSifraClient_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSifraClient.Text))
            {
                MessageBox.Show(
                    "Sifra ne može biti prazna!",
                    "Upozorenje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            playFairCypherClient.Key = txtSifraClient.Text;
            rc6CypherClient.Key = txtSifraClient.Text;
            pcbcCypherClient.Key = txtSifraClient.Text;
        }
    }
}
