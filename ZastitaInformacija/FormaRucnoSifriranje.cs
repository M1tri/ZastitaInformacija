using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace ZastitaInformacija
{
    public partial class FormaRucnoSifriranje : Form
    {
        Cypher selectedCypher;
        private PlayFairCypher playFairCypher;
        private RC6 rc6Cypher;
        private PCBC pcbcCypher;
        private string ofdFilter = "Text fajlovi (*.txt)|*.txt";
        public List<string> log;

        public FormaRucnoSifriranje(PlayFairCypher playFairCypher, RC6 rc6Cypher, PCBC pcbcCypher)
        {
            InitializeComponent();
            this.playFairCypher = playFairCypher;
            this.rc6Cypher = rc6Cypher;
            this.pcbcCypher = pcbcCypher;

            selectedCypher = playFairCypher;
            log = new List<string>();
        }

        private void UpdateOFDFilter()
        {
            if (radioSifriaj.Checked)
            {
                if (radioPlayfair.Checked)    
                    ofdFilter = "Text fajlovi (*.txt)|*.txt";
                else
                    ofdFilter = "Tekst i slike (*.txt;*.png;*.jpg;*.jpeg;*.bmp)|*.txt;*.png;*.jpg;*.jpeg;*.bmp";
            }
            else
            {
                if (radioPlayfair.Checked)
                    ofdFilter = "Playfair (*.pfc)|*.pfc";
                else if (radioRC6.Checked)
                    ofdFilter = "RC6 (*.rc6)|*.rc6";
                else
                    ofdFilter = "PCBC (*.pcbc)|*.pcbc";
            }
        }

        private void radioPlayfair_CheckedChanged(object sender, EventArgs e)
        {
            if (radioPlayfair.Checked)
            {
                selectedCypher = playFairCypher;
                UpdateOFDFilter();
            }
        }

        private void radioRC6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioRC6.Checked)
            {
                selectedCypher = rc6Cypher;
                UpdateOFDFilter();
            }
        }

        private void radioPCBC_CheckedChanged(object sender, EventArgs e)
        {
            if (radioPCBC.Checked)
            {
                selectedCypher = pcbcCypher;
                UpdateOFDFilter();
            }
        }

        private void UpisiULog(string message)
        {
            string time = DateTime.Now.ToString();
            string logMessage = time + ": " + message + "\n";

            log.Add(logMessage);
        }

        private void radioSifriaj_CheckedChanged(object sender, EventArgs e)
        {
            if (radioSifriaj.Checked)
            {
                chkBoxHash.Enabled = true;
            }
            UpdateOFDFilter();
        }

        private void chkBoxHash_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioDesifriraj_CheckedChanged(object sender, EventArgs e)
        {
            if (radioDesifriraj.Checked)
            {
                chkBoxHash.Enabled = false;
                chkBoxHash.Checked = false;
            }
            UpdateOFDFilter();
        }

        private void dugmeBirajFajl_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = ofdFilter;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string path = ofd.FileName;

                ofd.CheckFileExists = false;
                ofd.CheckPathExists = true;
                ofd.FileName = "Izaberite direktorijum";
                ofd.Filter = "Folder|.";

                DialogResult dr = ofd.ShowDialog();
                string outPath;
                if (dr == DialogResult.OK)
                {
                    outPath = Path.GetDirectoryName(ofd.FileName)!;
                }
                else
                {
                    MessageBox.Show("Prekinuta radnja jer niste izabrali izlazni direktorijum",
                        "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (radioSifriaj.Checked)
                {
                    Sifriraj(path, outPath);
                }
                else
                {
                    Desifriraj(path, outPath);
                }
            }
        }

        private void Sifriraj(string path, string outPath)
        {
            try
            {
                string outFile = selectedCypher.EncryptFile(path, chkBoxHash.Checked, outPath);
                string algo;
                if (radioPlayfair.Checked)
                    algo = "Playfair cypher";
                else if (radioRC6.Checked)
                    algo = "RC6";
                else
                    algo = "PCBC";

                string msg = $"Fajl sa lokacije {path} je uspešno šifrovan algoritmom {algo} rezultujući fajl je na lokaciji {outFile}";
                UpisiULog(msg);
                MessageBox.Show(msg, "Uspešno", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (CypherException ce)
            {
                MessageBox.Show(
                    "Greška tokom enkriptovanja fajla",
                    ce.Message,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            catch (IOException iox)
            {
                MessageBox.Show(
                    "Greška tokom ulazno/izlazne radnje",
                    iox.Message,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Greška",
                    ex.Message,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void Desifriraj(string path, string outPath)
        {
            try
            {
                string outFile = selectedCypher.DecryptFile(path, chkBoxHash.Checked, outPath);
                string algo;
                if (radioPlayfair.Checked)
                    algo = "Playfair cypher";
                else if (radioRC6.Checked)
                    algo = "RC6";
                else
                    algo = "PCBC";

                string msg = $"Fajl sa lokacije {path} je uspešno dešifrovan algoritmom {algo} rezultujući fajl je na lokaciji {outFile}";
                UpisiULog(msg);
                MessageBox.Show(msg, "Uspešno", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (CypherException ce)
            {
                MessageBox.Show(
                    ce.Message,
                    "Greška tokom dekriptovanja fajla",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            catch (IOException iox)
            {
                MessageBox.Show(
                    iox.Message,
                    "Greška tokom ulazno/izlazne radnje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
