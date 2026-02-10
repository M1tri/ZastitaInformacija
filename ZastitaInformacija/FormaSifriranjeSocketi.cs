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
        Cypher selectedCypher;
        private PlayFairCypher playFairCypher;
        private RC6 rc6Cypher;
        private PCBC pcbcCypher;
        private string m_encryptionAlgo;

        TcpListener m_listener;
        CancellationTokenSource m_cts;
        List<TcpClient> m_clients = new List<TcpClient>();
        bool m_pokrenutServer = false;

        string m_IpListen = "";
        int m_pListenPort = 0;

        string m_SendIP = "";
        int m_pSendPort = 0;

        private string ofdFilter = "Text fajlovi (*.txt)|*.txt";

        public FormaSifriranjeSocketi(PlayFairCypher playFairCypher, RC6 rc6Cypher, PCBC pcbcCypher)
        {
            this.playFairCypher = playFairCypher;
            this.rc6Cypher = rc6Cypher;
            this.pcbcCypher = pcbcCypher;

            this.selectedCypher = this.playFairCypher;
            m_encryptionAlgo = "Playfair";

            InitializeComponent();
        }

        private async void PokreniServer()
        {
            m_cts = new CancellationTokenSource();

            if (!System.Net.IPAddress.TryParse(m_IpListen, out System.Net.IPAddress? ip))
            {
                MessageBox.Show("Nevalidan IP");
                return;
            }

            m_listener = new TcpListener(System.Net.IPAddress.Any, m_pListenPort);
            m_listener.Start();
            m_pokrenutServer = true;

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

                    byte[] ExpectedHash = await ReadExactlyAsync(ns, 20, ct);

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
                    byte[] hash = SHA1.Hash(encryptedData);

                    if (!hash.SequenceEqual(ExpectedHash))
                        throw new Exception("Hash se ne poklapa!");
                    
                    Cypher cypher;
                    if (fileMetaData.EncryptionAlgorithm == "Playfair")
                    {
                        cypher = playFairCypher;
                    }
                    else if (fileMetaData.EncryptionAlgorithm == "RC6")
                    {
                        cypher = rc6Cypher;
                    }
                    else if (fileMetaData.EncryptionAlgorithm == "PCBC")
                    {
                        cypher = pcbcCypher;
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
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
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

            byte[] encrypted = selectedCypher.Encrypt(data, fileMetaData);
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
        }

        private void dugmePokreniSrv_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxIpRcv.Text))
            {
                MessageBox.Show("Upisi IP");
                return;
            }

            m_IpListen = txtBoxIpRcv.Text;

            if (string.IsNullOrEmpty(txtBoxPortRcv.Text))
            {
                MessageBox.Show("Upisi port");
                return;
            }

            if (!int.TryParse(txtBoxPortRcv.Text, out m_pListenPort))
            {
                MessageBox.Show("Nevalidan port");
                return;
            }

            dugmePokreniSrv.Enabled = false;
            dugmeUgasiSrv.Enabled = true;

            txtBoxIpRcv.Enabled = false;
            txtBoxPortRcv.Enabled = false;

            PokreniServer();
        }

        private void dugmeUgasiSrv_Click(object sender, EventArgs e)
        {
            dugmePokreniSrv.Enabled = true;
            dugmeUgasiSrv.Enabled = false;

            txtBoxIpRcv.Enabled = true;
            txtBoxPortRcv.Enabled = true;

            UgasiServer();
        }

        private void dugmeSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxIPSend.Text))
            {
                MessageBox.Show("IP send majmune lol");
                return;
            }
            m_SendIP = txtBoxIPSend.Text;

            if (string.IsNullOrEmpty(txtBoxPortSend.Text))
            {
                MessageBox.Show("Port send majmune lol");
                return;
            }

            if (!int.TryParse(txtBoxPortSend.Text, out m_pSendPort))
            {
                MessageBox.Show("Nevalidan port!");
                return;
            }

            if (string.IsNullOrEmpty(txtBoxImeFajla.Text))
            {
                MessageBox.Show("Fajl majmune lol");
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
                selectedCypher = playFairCypher;
                ofdFilter = "Text fajlovi (*.txt)|*.txt";
                m_encryptionAlgo = "Playfair";
            }
        }

        private void radioRC6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioRC6.Checked)
            {
                selectedCypher = rc6Cypher;
                ofdFilter = "Tekst i slike (*.txt;*.png;*.jpg;*.jpeg;*.bmp)|*.txt;*.png;*.jpg;*.jpeg;*.bmp";
                m_encryptionAlgo = "RC6";
            }
        }

        private void radioPCBC_CheckedChanged(object sender, EventArgs e)
        {
            if (radioPCBC.Checked)
            {
                selectedCypher = pcbcCypher;
                ofdFilter = "Tekst i slike (*.txt;*.png;*.jpg;*.jpeg;*.bmp)|*.txt;*.png;*.jpg;*.jpeg;*.bmp";
                m_encryptionAlgo = "PCBC";
            }
        }

        private void FormaSifriranjeSocketi_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (m_pokrenutServer)
                UgasiServer();
        }
    }
}
