
namespace ZastitaInformacija
{
    partial class GlavnaForma
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox3 = new GroupBox();
            tableLayoutPanel6 = new TableLayoutPanel();
            groupBox7 = new GroupBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            txtBoxIzlazniDir = new TextBox();
            dugmeIzlazniDir = new Button();
            groupBox6 = new GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            txtBoxIzabraniDir = new TextBox();
            dugmePosmatraniDir = new Button();
            tableLayoutPanel7 = new TableLayoutPanel();
            dugmeUpaliFSW = new Button();
            dugmeIsključiFSW = new Button();
            groupBox2 = new GroupBox();
            groupBoxHesiranje = new GroupBox();
            label2 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            groupBox9 = new GroupBox();
            dugmePotvrdiSifru = new Button();
            txtSifra = new TextBox();
            groupBoxSifriranje = new GroupBox();
            radioPCBC = new RadioButton();
            radioRC6 = new RadioButton();
            radioPlayfair = new RadioButton();
            groupBox8 = new GroupBox();
            tableLayoutPanel8 = new TableLayoutPanel();
            chkBoxSifriraj = new CheckBox();
            chkBoxHesiraj = new CheckBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            dugmeOcistiLog = new Button();
            logTextBox = new RichTextBox();
            toolTipDugmeIzabraniDir = new ToolTip(components);
            groupBox4 = new GroupBox();
            groupBox5 = new GroupBox();
            tableLayoutPanel9 = new TableLayoutPanel();
            dugmeRucniRad = new Button();
            dugmeRazmena = new Button();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupBox3.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            groupBox7.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            groupBox6.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBoxHesiranje.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            groupBox9.SuspendLayout();
            groupBoxSifriranje.SuspendLayout();
            groupBox8.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Location = new Point(590, 17);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(448, 636);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Podešavanja";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(groupBox3, 0, 1);
            tableLayoutPanel1.Controls.Add(groupBox2, 0, 0);
            tableLayoutPanel1.Location = new Point(7, 29);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.Size = new Size(435, 597);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tableLayoutPanel6);
            groupBox3.Location = new Point(3, 302);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(429, 291);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "File System Watcher";
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Controls.Add(groupBox7, 0, 1);
            tableLayoutPanel6.Controls.Add(groupBox6, 0, 0);
            tableLayoutPanel6.Controls.Add(tableLayoutPanel7, 0, 2);
            tableLayoutPanel6.Location = new Point(6, 26);
            tableLayoutPanel6.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 3;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 37.5F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 37.5F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel6.Size = new Size(410, 257);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(tableLayoutPanel5);
            groupBox7.Location = new Point(3, 100);
            groupBox7.Margin = new Padding(3, 4, 3, 4);
            groupBox7.Name = "groupBox7";
            groupBox7.Padding = new Padding(3, 4, 3, 4);
            groupBox7.Size = new Size(404, 76);
            groupBox7.TabIndex = 2;
            groupBox7.TabStop = false;
            groupBox7.Text = "Izlazni direktorijum";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel5.Controls.Add(txtBoxIzlazniDir, 0, 0);
            tableLayoutPanel5.Controls.Add(dugmeIzlazniDir, 1, 0);
            tableLayoutPanel5.Location = new Point(10, 25);
            tableLayoutPanel5.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            tableLayoutPanel5.Size = new Size(377, 43);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // txtBoxIzlazniDir
            // 
            txtBoxIzlazniDir.Anchor = AnchorStyles.None;
            txtBoxIzlazniDir.Location = new Point(7, 8);
            txtBoxIzlazniDir.Margin = new Padding(3, 4, 3, 4);
            txtBoxIzlazniDir.Name = "txtBoxIzlazniDir";
            txtBoxIzlazniDir.ReadOnly = true;
            txtBoxIzlazniDir.Size = new Size(305, 27);
            txtBoxIzlazniDir.TabIndex = 5;
            // 
            // dugmeIzlazniDir
            // 
            dugmeIzlazniDir.Anchor = AnchorStyles.None;
            dugmeIzlazniDir.Location = new Point(332, 6);
            dugmeIzlazniDir.Margin = new Padding(3, 4, 3, 4);
            dugmeIzlazniDir.Name = "dugmeIzlazniDir";
            dugmeIzlazniDir.Size = new Size(33, 31);
            dugmeIzlazniDir.TabIndex = 6;
            dugmeIzlazniDir.Text = "...";
            dugmeIzlazniDir.UseVisualStyleBackColor = true;
            dugmeIzlazniDir.Click += dugmeIzlazniDir_Click;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(tableLayoutPanel3);
            groupBox6.Location = new Point(3, 4);
            groupBox6.Margin = new Padding(3, 4, 3, 4);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(3, 4, 3, 4);
            groupBox6.Size = new Size(404, 76);
            groupBox6.TabIndex = 1;
            groupBox6.TabStop = false;
            groupBox6.Text = "Posmatrani direktorijum";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel3.Controls.Add(txtBoxIzabraniDir, 0, 0);
            tableLayoutPanel3.Controls.Add(dugmePosmatraniDir, 1, 0);
            tableLayoutPanel3.Location = new Point(9, 29);
            tableLayoutPanel3.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(377, 39);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // txtBoxIzabraniDir
            // 
            txtBoxIzabraniDir.Anchor = AnchorStyles.None;
            txtBoxIzabraniDir.Location = new Point(5, 6);
            txtBoxIzabraniDir.Margin = new Padding(3, 4, 3, 4);
            txtBoxIzabraniDir.Name = "txtBoxIzabraniDir";
            txtBoxIzabraniDir.ReadOnly = true;
            txtBoxIzabraniDir.Size = new Size(309, 27);
            txtBoxIzabraniDir.TabIndex = 0;
            // 
            // dugmePosmatraniDir
            // 
            dugmePosmatraniDir.Anchor = AnchorStyles.None;
            dugmePosmatraniDir.Location = new Point(332, 4);
            dugmePosmatraniDir.Margin = new Padding(3, 4, 3, 4);
            dugmePosmatraniDir.Name = "dugmePosmatraniDir";
            dugmePosmatraniDir.Size = new Size(33, 31);
            dugmePosmatraniDir.TabIndex = 1;
            dugmePosmatraniDir.Text = "...";
            dugmePosmatraniDir.UseVisualStyleBackColor = true;
            dugmePosmatraniDir.Click += dugmePosmatraniDir_Click;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Controls.Add(dugmeUpaliFSW, 0, 0);
            tableLayoutPanel7.Controls.Add(dugmeIsključiFSW, 1, 0);
            tableLayoutPanel7.Location = new Point(3, 196);
            tableLayoutPanel7.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanel7.Size = new Size(393, 57);
            tableLayoutPanel7.TabIndex = 3;
            // 
            // dugmeUpaliFSW
            // 
            dugmeUpaliFSW.Anchor = AnchorStyles.None;
            dugmeUpaliFSW.Location = new Point(55, 13);
            dugmeUpaliFSW.Margin = new Padding(3, 4, 3, 4);
            dugmeUpaliFSW.Name = "dugmeUpaliFSW";
            dugmeUpaliFSW.Size = new Size(86, 31);
            dugmeUpaliFSW.TabIndex = 0;
            dugmeUpaliFSW.Text = "Uključi";
            dugmeUpaliFSW.UseVisualStyleBackColor = true;
            dugmeUpaliFSW.Click += dugmeUpaliFSW_Click;
            // 
            // dugmeIsključiFSW
            // 
            dugmeIsključiFSW.Anchor = AnchorStyles.None;
            dugmeIsključiFSW.Enabled = false;
            dugmeIsključiFSW.Location = new Point(251, 13);
            dugmeIsključiFSW.Margin = new Padding(3, 4, 3, 4);
            dugmeIsključiFSW.Name = "dugmeIsključiFSW";
            dugmeIsključiFSW.Size = new Size(86, 31);
            dugmeIsključiFSW.TabIndex = 1;
            dugmeIsključiFSW.Text = "Isključi";
            dugmeIsključiFSW.UseVisualStyleBackColor = true;
            dugmeIsključiFSW.Click += dugmeIsključiFSW_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBoxHesiranje);
            groupBox2.Controls.Add(tableLayoutPanel2);
            groupBox2.Location = new Point(3, 4);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(429, 290);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Algoritmi";
            // 
            // groupBoxHesiranje
            // 
            groupBoxHesiranje.Controls.Add(label2);
            groupBoxHesiranje.Enabled = false;
            groupBoxHesiranje.Location = new Point(317, 31);
            groupBoxHesiranje.Margin = new Padding(3, 4, 3, 4);
            groupBoxHesiranje.Name = "groupBoxHesiranje";
            groupBoxHesiranje.Padding = new Padding(3, 4, 3, 4);
            groupBoxHesiranje.Size = new Size(99, 77);
            groupBoxHesiranje.TabIndex = 1;
            groupBoxHesiranje.TabStop = false;
            groupBoxHesiranje.Text = "Heširanje";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(26, 36);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 0;
            label2.Text = "SHA 1";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(groupBox9, 0, 1);
            tableLayoutPanel2.Controls.Add(groupBoxSifriranje, 0, 0);
            tableLayoutPanel2.Controls.Add(groupBox8, 0, 2);
            tableLayoutPanel2.Location = new Point(6, 27);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 86F));
            tableLayoutPanel2.Size = new Size(418, 256);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(dugmePotvrdiSifru);
            groupBox9.Controls.Add(txtSifra);
            groupBox9.Location = new Point(3, 88);
            groupBox9.Name = "groupBox9";
            groupBox9.Size = new Size(407, 70);
            groupBox9.TabIndex = 3;
            groupBox9.TabStop = false;
            groupBox9.Text = "Ključ";
            // 
            // dugmePotvrdiSifru
            // 
            dugmePotvrdiSifru.Location = new Point(327, 24);
            dugmePotvrdiSifru.Name = "dugmePotvrdiSifru";
            dugmePotvrdiSifru.Size = new Size(74, 29);
            dugmePotvrdiSifru.TabIndex = 1;
            dugmePotvrdiSifru.Text = "Potvrdi";
            dugmePotvrdiSifru.UseVisualStyleBackColor = true;
            dugmePotvrdiSifru.Click += dugmePotvrdiSifru_Click;
            // 
            // txtSifra
            // 
            txtSifra.BackColor = SystemColors.Control;
            txtSifra.Location = new Point(8, 26);
            txtSifra.Name = "txtSifra";
            txtSifra.Size = new Size(313, 27);
            txtSifra.TabIndex = 0;
            // 
            // groupBoxSifriranje
            // 
            groupBoxSifriranje.Controls.Add(radioPCBC);
            groupBoxSifriranje.Controls.Add(radioRC6);
            groupBoxSifriranje.Controls.Add(radioPlayfair);
            groupBoxSifriranje.Location = new Point(3, 4);
            groupBoxSifriranje.Margin = new Padding(3, 4, 3, 4);
            groupBoxSifriranje.Name = "groupBoxSifriranje";
            groupBoxSifriranje.Padding = new Padding(3, 4, 3, 4);
            groupBoxSifriranje.Size = new Size(302, 77);
            groupBoxSifriranje.TabIndex = 2;
            groupBoxSifriranje.TabStop = false;
            groupBoxSifriranje.Text = "Šifriranje";
            // 
            // radioPCBC
            // 
            radioPCBC.Anchor = AnchorStyles.Left;
            radioPCBC.AutoSize = true;
            radioPCBC.Location = new Point(219, 33);
            radioPCBC.Margin = new Padding(3, 4, 3, 4);
            radioPCBC.Name = "radioPCBC";
            radioPCBC.Padding = new Padding(11, 1, 1, 1);
            radioPCBC.Size = new Size(77, 26);
            radioPCBC.TabIndex = 2;
            radioPCBC.Text = "PCBC";
            radioPCBC.UseVisualStyleBackColor = true;
            radioPCBC.CheckedChanged += radioPCBC_CheckedChanged;
            // 
            // radioRC6
            // 
            radioRC6.Anchor = AnchorStyles.Left;
            radioRC6.AutoSize = true;
            radioRC6.Location = new Point(148, 33);
            radioRC6.Margin = new Padding(3, 4, 3, 4);
            radioRC6.Name = "radioRC6";
            radioRC6.Padding = new Padding(11, 1, 1, 1);
            radioRC6.Size = new Size(68, 26);
            radioRC6.TabIndex = 1;
            radioRC6.Text = "RC6";
            radioRC6.UseVisualStyleBackColor = true;
            radioRC6.CheckedChanged += radioRC6_CheckedChanged;
            // 
            // radioPlayfair
            // 
            radioPlayfair.Anchor = AnchorStyles.Left;
            radioPlayfair.AutoSize = true;
            radioPlayfair.Checked = true;
            radioPlayfair.Location = new Point(6, 33);
            radioPlayfair.Margin = new Padding(3, 4, 3, 4);
            radioPlayfair.Name = "radioPlayfair";
            radioPlayfair.Padding = new Padding(11, 1, 1, 1);
            radioPlayfair.RightToLeft = RightToLeft.No;
            radioPlayfair.Size = new Size(136, 26);
            radioPlayfair.TabIndex = 0;
            radioPlayfair.TabStop = true;
            radioPlayfair.Text = "Playfair cipher";
            radioPlayfair.UseVisualStyleBackColor = true;
            radioPlayfair.CheckedChanged += radioPlayfair_CheckedChanged;
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(tableLayoutPanel8);
            groupBox8.Location = new Point(3, 174);
            groupBox8.Margin = new Padding(3, 4, 3, 4);
            groupBox8.Name = "groupBox8";
            groupBox8.Padding = new Padding(3, 4, 3, 4);
            groupBox8.Size = new Size(407, 76);
            groupBox8.TabIndex = 1;
            groupBox8.TabStop = false;
            groupBox8.Text = "Aktivne radnje";
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 2;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Controls.Add(chkBoxSifriraj, 0, 0);
            tableLayoutPanel8.Controls.Add(chkBoxHesiraj, 1, 0);
            tableLayoutPanel8.Location = new Point(6, 28);
            tableLayoutPanel8.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 1;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
            tableLayoutPanel8.Size = new Size(391, 34);
            tableLayoutPanel8.TabIndex = 1;
            // 
            // chkBoxSifriraj
            // 
            chkBoxSifriraj.Anchor = AnchorStyles.None;
            chkBoxSifriraj.AutoSize = true;
            chkBoxSifriraj.Checked = true;
            chkBoxSifriraj.CheckState = CheckState.Checked;
            chkBoxSifriraj.Location = new Point(60, 5);
            chkBoxSifriraj.Margin = new Padding(3, 4, 3, 4);
            chkBoxSifriraj.Name = "chkBoxSifriraj";
            chkBoxSifriraj.Size = new Size(74, 24);
            chkBoxSifriraj.TabIndex = 0;
            chkBoxSifriraj.Text = "Šifriraj";
            chkBoxSifriraj.UseVisualStyleBackColor = true;
            chkBoxSifriraj.CheckedChanged += chkBoxSifriraj_CheckedChanged;
            // 
            // chkBoxHesiraj
            // 
            chkBoxHesiraj.Anchor = AnchorStyles.None;
            chkBoxHesiraj.AutoSize = true;
            chkBoxHesiraj.Location = new Point(254, 5);
            chkBoxHesiraj.Margin = new Padding(3, 4, 3, 4);
            chkBoxHesiraj.Name = "chkBoxHesiraj";
            chkBoxHesiraj.Size = new Size(77, 24);
            chkBoxHesiraj.TabIndex = 1;
            chkBoxHesiraj.Text = "Heširaj";
            chkBoxHesiraj.UseVisualStyleBackColor = true;
            chkBoxHesiraj.CheckedChanged += chkBoxHesiraj_CheckedChanged;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(dugmeOcistiLog, 0, 1);
            tableLayoutPanel4.Controls.Add(logTextBox, 0, 0);
            tableLayoutPanel4.Location = new Point(9, 28);
            tableLayoutPanel4.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 93F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 7F));
            tableLayoutPanel4.Size = new Size(566, 553);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // dugmeOcistiLog
            // 
            dugmeOcistiLog.Anchor = AnchorStyles.None;
            dugmeOcistiLog.Location = new Point(236, 519);
            dugmeOcistiLog.Name = "dugmeOcistiLog";
            dugmeOcistiLog.Size = new Size(94, 29);
            dugmeOcistiLog.TabIndex = 1;
            dugmeOcistiLog.Text = "Očisti log";
            dugmeOcistiLog.UseVisualStyleBackColor = true;
            dugmeOcistiLog.Click += dugmeOcistiLog_Click;
            // 
            // logTextBox
            // 
            logTextBox.Cursor = Cursors.Hand;
            logTextBox.Font = new Font("Segoe UI", 8F);
            logTextBox.Location = new Point(3, 4);
            logTextBox.Margin = new Padding(3, 4, 3, 4);
            logTextBox.Name = "logTextBox";
            logTextBox.ReadOnly = true;
            logTextBox.Size = new Size(560, 502);
            logTextBox.TabIndex = 0;
            logTextBox.Text = "";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(tableLayoutPanel4);
            groupBox4.Location = new Point(3, 0);
            groupBox4.Margin = new Padding(3, 4, 3, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 4, 3, 4);
            groupBox4.Size = new Size(581, 591);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "Log";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(tableLayoutPanel9);
            groupBox5.Location = new Point(3, 589);
            groupBox5.Margin = new Padding(3, 4, 3, 4);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(3, 4, 3, 4);
            groupBox5.Size = new Size(574, 64);
            groupBox5.TabIndex = 2;
            groupBox5.TabStop = false;
            groupBox5.Text = "Dodatne mogućnosti";
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 2;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.Controls.Add(dugmeRucniRad, 0, 0);
            tableLayoutPanel9.Controls.Add(dugmeRazmena, 1, 0);
            tableLayoutPanel9.Location = new Point(3, 25);
            tableLayoutPanel9.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 1;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel9.Size = new Size(563, 39);
            tableLayoutPanel9.TabIndex = 0;
            // 
            // dugmeRucniRad
            // 
            dugmeRucniRad.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            dugmeRucniRad.Location = new Point(3, 4);
            dugmeRucniRad.Margin = new Padding(3, 4, 3, 4);
            dugmeRucniRad.Name = "dugmeRucniRad";
            dugmeRucniRad.Size = new Size(273, 31);
            dugmeRucniRad.TabIndex = 0;
            dugmeRucniRad.Text = "Rucni rad sa fajlovima";
            dugmeRucniRad.UseVisualStyleBackColor = true;
            dugmeRucniRad.Click += dugmeRucniRad_Click;
            // 
            // dugmeRazmena
            // 
            dugmeRazmena.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            dugmeRazmena.Location = new Point(284, 4);
            dugmeRazmena.Margin = new Padding(3, 4, 3, 4);
            dugmeRazmena.Name = "dugmeRazmena";
            dugmeRazmena.Size = new Size(275, 31);
            dugmeRazmena.TabIndex = 1;
            dugmeRazmena.Text = "Razmena fajlova na daljinu";
            dugmeRazmena.UseVisualStyleBackColor = true;
            dugmeRazmena.Click += dugmeRazmena_Click;
            // 
            // GlavnaForma
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1042, 660);
            Controls.Add(groupBox4);
            Controls.Add(groupBox1);
            Controls.Add(groupBox5);
            Margin = new Padding(3, 4, 3, 4);
            Name = "GlavnaForma";
            Text = "Zastita Informacija";
            FormClosing += GlavnaForma_FormClosing;
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            groupBox7.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            groupBox6.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel7.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBoxHesiranje.ResumeLayout(false);
            groupBoxHesiranje.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            groupBox9.ResumeLayout(false);
            groupBox9.PerformLayout();
            groupBoxSifriranje.ResumeLayout(false);
            groupBoxSifriranje.PerformLayout();
            groupBox8.ResumeLayout(false);
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            tableLayoutPanel9.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox2;
        private RadioButton radioPlayfair;
        private RadioButton radioRC6;
        private RadioButton radioPCBC;
        private GroupBox groupBox3;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private GroupBox groupBoxHesiranje;
        private Label label2;
        private GroupBox groupBoxSifriranje;
        private ToolTip toolTipDugmeIzabraniDir;
        private TextBox txtBoxIzabraniDir;
        private Button dugmePosmatraniDir;
        private GroupBox groupBox6;
        private GroupBox groupBox7;
        private TableLayoutPanel tableLayoutPanel5;
        private TextBox txtBoxIzlazniDir;
        private Button dugmeIzlazniDir;
        private TableLayoutPanel tableLayoutPanel6;
        private TableLayoutPanel tableLayoutPanel7;
        private Button dugmeUpaliFSW;
        private Button dugmeIsključiFSW;
        private TableLayoutPanel tableLayoutPanel8;
        private CheckBox chkBoxSifriraj;
        private CheckBox chkBoxHesiraj;
        private GroupBox groupBox4;
        private RichTextBox logTextBox;
        private GroupBox groupBox5;
        private GroupBox groupBox8;
        private TableLayoutPanel tableLayoutPanel9;
        private Button dugmeRucniRad;
        private Button dugmeRazmena;
        private GroupBox groupBox9;
        private TableLayoutPanel tableLayoutPanel2;
        private Button dugmePotvrdiSifru;
        private TextBox txtSifra;
        private Button dugmeOcistiLog;
    }
}
