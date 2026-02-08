using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
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

        TcpListener m_listener;
        CancellationTokenSource m_cts;
        List<TcpClient> m_clients = new List<TcpClient>();
        bool m_pokrenutServer = false;

        string m_SendIP = "";
        int m_pSendPort = 0;

        private string ofdFilter = "Text fajlovi (*.txt)|*.txt";

        public FormaSifriranjeSocketi(PlayFairCypher playFairCypher, RC6 rc6Cypher, PCBC pcbcCypher)
        {
            this.playFairCypher = playFairCypher;
            this.rc6Cypher = rc6Cypher;
            this.pcbcCypher = pcbcCypher;

            this.selectedCypher = this.playFairCypher;
                
            InitializeComponent();
        }

        private async void PokreniServer()
        {
            m_cts = new CancellationTokenSource();
            m_listener = new TcpListener(System.Net.IPAddress.Any, 9000);
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
        }

        private async Task ObradiZahtev(TcpClient client, CancellationToken ct)
        {
            try
            {
                using (client)
                using (NetworkStream ns = client.GetStream())
                {
                    List<byte> bytes = new List<byte>();
                    byte[] buffer = new byte[1024];

                    while (!ct.IsCancellationRequested)
                    {
                        // ovde ce citamo mora se dogovorimo kako
                    }

                    // obrada neki algoritam zavisi
                }
            }
            catch (ObjectDisposedException)
            {

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
            using (TcpClient client = new TcpClient())
            {
                await client.ConnectAsync(m_SendIP, m_pSendPort);

                using (NetworkStream stream = client.GetStream())
                {
                    await stream.WriteAsync(data, 0, data.Length);
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

            if (string.IsNullOrEmpty(txtBoxPortRcv.Text))
            {
                MessageBox.Show("Upisi port");
                return;
            }

            dugmePokreniSrv.Enabled = false;
            dugmeUgasiSrv.Enabled = true;

            //PokreniServer();
        }

        private void dugmeUgasiSrv_Click(object sender, EventArgs e)
        {
            dugmePokreniSrv.Enabled = true;
            dugmeUgasiSrv.Enabled = false;

            //UgasiServer();
        }

        private void dugmeSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxIPSend.Text))
            {
                MessageBox.Show("IP send majmune lol");
                return;
            }

            if (string.IsNullOrEmpty(txtBoxPortSend.Text))
            {
                MessageBox.Show("Port send majmune lol");
                return;
            }

            if (string.IsNullOrEmpty(txtBoxImeFajla.Text))
            {
                MessageBox.Show("Fajl majmune lol");
                return;
            }

            byte[] data = File.ReadAllBytes(txtBoxImeFajla.Text);
            // TODO pripremi i posalji data
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
            }
        }

        private void radioRC6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioRC6.Checked)
            {
                selectedCypher = rc6Cypher;
                ofdFilter = "Tekst i slike (*.txt;*.png;*.jpg;*.jpeg;*.bmp)|*.txt;*.png;*.jpg;*.jpeg;*.bmp";
            }
        }

        private void radioPCBC_CheckedChanged(object sender, EventArgs e)
        {
            if (radioPCBC.Checked)
            {
                selectedCypher = pcbcCypher;
                ofdFilter = "Tekst i slike (*.txt;*.png;*.jpg;*.jpeg;*.bmp)|*.txt;*.png;*.jpg;*.jpeg;*.bmp";
            }
        }
    }
}
