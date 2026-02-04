using System.IO;
using System.Security.Cryptography;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace ZastitaInformacija
{
    public enum ALGORITHMS
    {
        PLAYFAIR = 0,
        RC6 = 1,
        PCBC = 2,
        SHA1 = 3
    };

    public partial class GlavnaForma : Form
    {
        private string ofdFilter = "Text fajlovi (*.txt)|*.txt";

        private Cypher SelectedCypher;

        private readonly PlayFairCypher playFairCypher;
        private readonly RC6 rc6;
        private readonly PCBC pcbc;

        private FileSystemWatcher fileSystemWatcher;

        private string lastFileProcessed = "";

        public GlavnaForma()
        {
            InitializeComponent();

            PodesiKomponente();

            string key = "MONARCHYMONARCHY";
            playFairCypher = new PlayFairCypher(key);

            rc6 = new RC6(Encoding.UTF8.GetBytes(key));

            byte[] iv = new byte[16];
            for (int i = 0; i < 16; i++)
                iv[i] = (byte)i;
            pcbc = new PCBC(Encoding.UTF8.GetBytes(key), iv);

            SelectedCypher = playFairCypher;

            fileSystemWatcher = new FileSystemWatcher();

            fileSystemWatcher.NotifyFilter = NotifyFilters.FileName;
            fileSystemWatcher.Created += DodatFajl;

            fileSystemWatcher.EnableRaisingEvents = false;

            UpisiULog("Aplikacija uspešno pokrenuta!");
        }
        private void PodesiKomponente()
        {
            logTextBox.Text = "";
            chkBoxSifriraj.Checked = true;
        }

        private void Sifriraj(string path, string outPath)
        {
            try
            {
                SelectedCypher.EncryptFile(path, outPath);
            }
            catch (CypherException ce)
            {
                MessageBox.Show(
                    ce.Message,
                    "Greška tokom ulazno/izlazne radnje",
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
                    "Greška tokom ulazno/izlazne radnje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void Desifriraj(string path)
        {
            try
            {
                SelectedCypher.DecryptFile(path);
            }
            catch (CypherException ce)
            {
                MessageBox.Show(
                    "Greška tokom dekriptovanja fajla",
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

        private void dugmePosmatraniDir_Click(object sender, EventArgs e)
        {
            string folder = GetFolder();

            string stariFolder = txtBoxIzabraniDir.Text;
            string msg;
            if (string.IsNullOrEmpty(txtBoxIzabraniDir.Text))
            {
                msg = $"Promenjen posmatrani direktorijum sa {stariFolder} na {folder}";
            }
            else
            {
                msg = $"Posmatrni direktorijum postavljen na {folder}";
            }
            UpisiULog(msg);

            txtBoxIzabraniDir.Text = folder;
        }

        private string GetFolder()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.CheckFileExists = false;
            ofd.CheckPathExists = true;
            ofd.FileName = "Izaberite direktorijum";
            ofd.Filter = "Folder|.";

            DialogResult dr = ofd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string folderPath = Path.GetDirectoryName(ofd.FileName)!;
                return folderPath;
            }

            return "";
        }

        private void dugmeIzlazniDir_Click(object sender, EventArgs e)
        {
            string folder = GetFolder();
            string stariFolder = txtBoxIzlazniDir.Text;
            string msg;
            if (string.IsNullOrEmpty(stariFolder))
            {
                msg = $"Promenjen izlazni direktorijum sa {stariFolder} na {folder}";
            }
            else
            {
                msg = $"Izlazni direktorijum postavljen na {folder}";
            }
            UpisiULog(msg);
            txtBoxIzlazniDir.Text = folder;
        }

        private void chkBoxSifriraj_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkBoxHesiraj.Checked && !chkBoxSifriraj.Checked)
            {
                MessageBox.Show(
                    "Barem jedna od radnji šifriranje/heširanje mora biti aktivna",
                    "Upozorenje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
                chkBoxSifriraj.Checked = true;
                return;
            }

            groupBoxSifriranje.Enabled = chkBoxSifriraj.Checked;

            if (chkBoxSifriraj.Checked)
            {
                UpisiULog("Aktivirano šifriranje");
            }
            else
            {
                UpisiULog("Deaktivirano šifriranje");
            }
        }

        private void chkBoxHesiraj_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkBoxHesiraj.Checked && !chkBoxSifriraj.Checked)
            {
                MessageBox.Show(
                    "Barem jedna od radnji šifriranje/heširanje mora biti aktivna",
                    "Upozorenje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
                chkBoxHesiraj.Checked = true;
                return;
            }

            groupBoxHesiranje.Enabled = chkBoxHesiraj.Checked;

            if (chkBoxHesiraj.Checked)
            {
                UpisiULog("Aktivirano heširanje");
            }
            else
            {
                UpisiULog("Deaktivirano heširanje");
            }
        }
        private void UpisiULog(string logMessage)
        {
            string time = DateTime.Now.ToString();
            logTextBox.Text = logTextBox.Text + time + ": " + logMessage + "\n";
        }

        private void radioPlayfair_CheckedChanged(object sender, EventArgs e)
        {
            if (radioPlayfair.Checked)
            {
                SelectedCypher = playFairCypher;
                ofdFilter = "Text fajlovi (*.txt)|*.txt";

                UpisiULog("Aktivni algoritam šifriranja postavljen na Playfair Cipher");
            }
        }

        private void radioRC6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioRC6.Checked)
            {
                SelectedCypher = rc6;
                ofdFilter = "Tekst i slike (*.txt;*.png;*.jpg;*.jpeg;*.bmp)|*.txt;*.png;*.jpg;*.jpeg;*.bmp";

                UpisiULog("Aktivni algoritam heiširanja postavljen na RC6");
            }
        }

        private void radioPCBC_CheckedChanged(object sender, EventArgs e)
        {
            if (radioPCBC.Checked)
            {
                SelectedCypher = pcbc;
                ofdFilter = "Tekst i slike (*.txt;*.png;*.jpg;*.jpeg;*.bmp)|*.txt;*.png;*.jpg;*.jpeg;*.bmp";

                UpisiULog("Aktivni algoritam heiširanja postavljen na PCBC");
            }
        }

        private void dugmeRucniRad_Click(object sender, EventArgs e)
        {
            FormaRucnoSifriranje forma = new FormaRucnoSifriranje(playFairCypher, rc6, pcbc);
            this.Hide();

            forma.ShowDialog();
            foreach (var logMsg in forma.log)
            {
                logTextBox.Text += logMsg;
            }

            this.Show();
        }

        private void dugmeUpaliFSW_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxIzabraniDir.Text))
            {
                MessageBox.Show("Morate izabrati direktorijum za posmatranje",
                    "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txtBoxIzlazniDir.Text))
            {
                MessageBox.Show("Morate izabrati direktorijum za upis šifrovanih fajlova",
                    "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            fileSystemWatcher.Path = txtBoxIzabraniDir.Text;
            fileSystemWatcher.EnableRaisingEvents = true;

            dugmeUpaliFSW.Enabled = false;
            dugmePosmatraniDir.Enabled = false;
            dugmeIzlazniDir.Enabled = false;

            dugmeIsključiFSW.Enabled = true;

            UpisiULog("Upaljen File System Watcher");
        }

        private void dugmeIsključiFSW_Click(object sender, EventArgs e)
        {

            dugmeUpaliFSW.Enabled = true;
            dugmePosmatraniDir.Enabled = true;
            dugmeIzlazniDir.Enabled = true;

            dugmeIsključiFSW.Enabled = false;

            fileSystemWatcher.EnableRaisingEvents = false;

            UpisiULog("Isključen File System Watcher");
        }

        private void DodatFajl(object source, FileSystemEventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => DodatFajl(source, e)));
            }

            if (lastFileProcessed == e.FullPath)
            {
                return;
            }

            if (chkBoxSifriraj.Checked)
            {
                Sifriraj(e.FullPath, txtBoxIzlazniDir.Text);

                string algo;
                if (radioPlayfair.Checked)
                    algo = "Playfair cypher";
                else if (radioRC6.Checked)
                    algo = "RC6";
                else
                    algo = "PCBC";

                string msg = $"Fajl sa lokacije {e.FullPath} je uspešno šifrovan algoritmom {algo} rezultujući fajl je na lokaciji {txtBoxIzlazniDir.Text}";
                UpisiULog(msg);
                MessageBox.Show(msg, "Uspešno", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (chkBoxHesiraj.Checked)
            {
                MessageBox.Show("Cu hesiram " + e.FullPath);
            }

            lastFileProcessed = e.FullPath;
        }
        private void GlavnaForma_FormClosing(object sender, FormClosingEventArgs e)
        {
            string time = DateTime.Now.ToString("yyyy-mm-dd_HH-mm--ss");
            string logName = "log_" +time+ ".txt";
            string dir = Directory.GetCurrentDirectory();

            string logPath = Path.Combine(dir, logName);
            UpisiULog($"Gašenje aplikacije, log upisan fajlu na putanji {logPath}");

//            File.WriteAllText(logPath, logTextBox.Text);
        }
    }
}
