namespace ZastitaInformacija
{
    partial class FormaSifriranjeSocketi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            label2 = new Label();
            txtBoxPortRcv = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            dugmePokreniSrv = new Button();
            dugmeUgasiSrv = new Button();
            label1 = new Label();
            tableLayoutPanel7 = new TableLayoutPanel();
            txtSifra = new TextBox();
            btnPotvrdi = new Button();
            groupBox2 = new GroupBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel8 = new TableLayoutPanel();
            txtSifraClient = new TextBox();
            btnSifraClient = new Button();
            label3 = new Label();
            label4 = new Label();
            txtBoxIPSend = new TextBox();
            txtBoxPortSend = new TextBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            radioPlayfair = new RadioButton();
            radioRC6 = new RadioButton();
            radioPCBC = new RadioButton();
            dugmeSend = new Button();
            label6 = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            dumeFajl = new Button();
            txtBoxImeFajla = new TextBox();
            label5 = new Label();
            label7 = new Label();
            tableLayoutPanel6 = new TableLayoutPanel();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Location = new Point(30, 11);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(448, 264);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Prihvatanje paketa";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(txtBoxPortRcv, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 2);
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel7, 1, 1);
            tableLayoutPanel1.Location = new Point(19, 28);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(420, 227);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(33, 27);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 1;
            label2.Text = "Port:";
            // 
            // txtBoxPortRcv
            // 
            txtBoxPortRcv.Anchor = AnchorStyles.None;
            txtBoxPortRcv.Location = new Point(154, 24);
            txtBoxPortRcv.Margin = new Padding(3, 4, 3, 4);
            txtBoxPortRcv.Name = "txtBoxPortRcv";
            txtBoxPortRcv.Size = new Size(217, 27);
            txtBoxPortRcv.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel1.SetColumnSpan(tableLayoutPanel2, 2);
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(dugmePokreniSrv, 0, 0);
            tableLayoutPanel2.Controls.Add(dugmeUgasiSrv, 1, 0);
            tableLayoutPanel2.Location = new Point(3, 154);
            tableLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 69F));
            tableLayoutPanel2.Size = new Size(413, 69);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // dugmePokreniSrv
            // 
            dugmePokreniSrv.Anchor = AnchorStyles.None;
            dugmePokreniSrv.Location = new Point(60, 19);
            dugmePokreniSrv.Margin = new Padding(3, 4, 3, 4);
            dugmePokreniSrv.Name = "dugmePokreniSrv";
            dugmePokreniSrv.Size = new Size(86, 31);
            dugmePokreniSrv.TabIndex = 4;
            dugmePokreniSrv.Text = "Pokreni";
            dugmePokreniSrv.UseVisualStyleBackColor = true;
            dugmePokreniSrv.Click += dugmePokreniSrv_Click;
            // 
            // dugmeUgasiSrv
            // 
            dugmeUgasiSrv.Anchor = AnchorStyles.None;
            dugmeUgasiSrv.Enabled = false;
            dugmeUgasiSrv.Location = new Point(266, 19);
            dugmeUgasiSrv.Margin = new Padding(3, 4, 3, 4);
            dugmeUgasiSrv.Name = "dugmeUgasiSrv";
            dugmeUgasiSrv.Size = new Size(86, 31);
            dugmeUgasiSrv.TabIndex = 5;
            dugmeUgasiSrv.TabStop = false;
            dugmeUgasiSrv.Text = "Prekini";
            dugmeUgasiSrv.UseVisualStyleBackColor = true;
            dugmeUgasiSrv.Click += dugmeUgasiSrv_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(31, 102);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 5;
            label1.Text = "Sifra:";
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel7.Controls.Add(txtSifra, 0, 0);
            tableLayoutPanel7.Controls.Add(btnPotvrdi, 1, 0);
            tableLayoutPanel7.Location = new Point(108, 78);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Size = new Size(308, 69);
            tableLayoutPanel7.TabIndex = 6;
            // 
            // txtSifra
            // 
            txtSifra.Anchor = AnchorStyles.None;
            txtSifra.Location = new Point(6, 21);
            txtSifra.Name = "txtSifra";
            txtSifra.Size = new Size(202, 27);
            txtSifra.TabIndex = 6;
            // 
            // btnPotvrdi
            // 
            btnPotvrdi.Anchor = AnchorStyles.None;
            btnPotvrdi.Location = new Point(218, 20);
            btnPotvrdi.Name = "btnPotvrdi";
            btnPotvrdi.Size = new Size(87, 29);
            btnPotvrdi.TabIndex = 7;
            btnPotvrdi.Text = "Potvrdi";
            btnPotvrdi.UseVisualStyleBackColor = true;
            btnPotvrdi.Click += btnPotvrdi_Click;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.None;
            groupBox2.Controls.Add(tableLayoutPanel4);
            groupBox2.Location = new Point(10, 294);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(488, 412);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Slanje paketa";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tableLayoutPanel4.Controls.Add(tableLayoutPanel8, 1, 3);
            tableLayoutPanel4.Controls.Add(label3, 0, 0);
            tableLayoutPanel4.Controls.Add(label4, 0, 1);
            tableLayoutPanel4.Controls.Add(txtBoxIPSend, 1, 0);
            tableLayoutPanel4.Controls.Add(txtBoxPortSend, 1, 1);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel3, 1, 2);
            tableLayoutPanel4.Controls.Add(dugmeSend, 0, 5);
            tableLayoutPanel4.Controls.Add(label6, 0, 4);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 1, 4);
            tableLayoutPanel4.Controls.Add(label5, 0, 2);
            tableLayoutPanel4.Controls.Add(label7, 0, 3);
            tableLayoutPanel4.Location = new Point(18, 36);
            tableLayoutPanel4.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 6;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6670761F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6670856F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6670856F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6654167F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(445, 368);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 2;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel8.Controls.Add(txtSifraClient, 0, 0);
            tableLayoutPanel8.Controls.Add(btnSifraClient, 1, 0);
            tableLayoutPanel8.Location = new Point(114, 186);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 1;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.Size = new Size(323, 55);
            tableLayoutPanel8.TabIndex = 10;
            // 
            // txtSifraClient
            // 
            txtSifraClient.Anchor = AnchorStyles.None;
            txtSifraClient.Location = new Point(12, 14);
            txtSifraClient.Name = "txtSifraClient";
            txtSifraClient.Size = new Size(202, 27);
            txtSifraClient.TabIndex = 6;
            // 
            // btnSifraClient
            // 
            btnSifraClient.Anchor = AnchorStyles.None;
            btnSifraClient.Location = new Point(231, 13);
            btnSifraClient.Name = "btnSifraClient";
            btnSifraClient.Size = new Size(87, 29);
            btnSifraClient.TabIndex = 7;
            btnSifraClient.Text = "Potvrdi";
            btnSifraClient.UseVisualStyleBackColor = true;
            btnSifraClient.Click += btnSifraClient_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(19, 20);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 0;
            label3.Text = "IP adresa:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(36, 81);
            label4.Name = "label4";
            label4.Size = new Size(38, 20);
            label4.TabIndex = 1;
            label4.Text = "Port:";
            // 
            // txtBoxIPSend
            // 
            txtBoxIPSend.Anchor = AnchorStyles.None;
            txtBoxIPSend.Location = new Point(169, 17);
            txtBoxIPSend.Margin = new Padding(3, 4, 3, 4);
            txtBoxIPSend.Name = "txtBoxIPSend";
            txtBoxIPSend.Size = new Size(217, 27);
            txtBoxIPSend.TabIndex = 2;
            // 
            // txtBoxPortSend
            // 
            txtBoxPortSend.Anchor = AnchorStyles.None;
            txtBoxPortSend.Location = new Point(169, 78);
            txtBoxPortSend.Margin = new Padding(3, 4, 3, 4);
            txtBoxPortSend.Name = "txtBoxPortSend";
            txtBoxPortSend.Size = new Size(217, 27);
            txtBoxPortSend.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.Controls.Add(radioPlayfair, 0, 0);
            tableLayoutPanel3.Controls.Add(radioRC6, 1, 0);
            tableLayoutPanel3.Controls.Add(radioPCBC, 2, 0);
            tableLayoutPanel3.Location = new Point(114, 126);
            tableLayoutPanel3.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            tableLayoutPanel3.Size = new Size(327, 53);
            tableLayoutPanel3.TabIndex = 5;
            // 
            // radioPlayfair
            // 
            radioPlayfair.Anchor = AnchorStyles.None;
            radioPlayfair.AutoSize = true;
            radioPlayfair.Checked = true;
            radioPlayfair.Location = new Point(14, 14);
            radioPlayfair.Margin = new Padding(3, 4, 3, 4);
            radioPlayfair.Name = "radioPlayfair";
            radioPlayfair.Size = new Size(80, 24);
            radioPlayfair.TabIndex = 0;
            radioPlayfair.TabStop = true;
            radioPlayfair.Text = "PlayFair";
            radioPlayfair.UseVisualStyleBackColor = true;
            radioPlayfair.CheckedChanged += radioPlayfair_CheckedChanged;
            // 
            // radioRC6
            // 
            radioRC6.Anchor = AnchorStyles.None;
            radioRC6.AutoSize = true;
            radioRC6.Location = new Point(135, 14);
            radioRC6.Margin = new Padding(3, 4, 3, 4);
            radioRC6.Name = "radioRC6";
            radioRC6.Size = new Size(56, 24);
            radioRC6.TabIndex = 1;
            radioRC6.Text = "RC6";
            radioRC6.UseVisualStyleBackColor = true;
            radioRC6.CheckedChanged += radioRC6_CheckedChanged;
            // 
            // radioPCBC
            // 
            radioPCBC.Anchor = AnchorStyles.None;
            radioPCBC.AutoSize = true;
            radioPCBC.Location = new Point(240, 14);
            radioPCBC.Margin = new Padding(3, 4, 3, 4);
            radioPCBC.Name = "radioPCBC";
            radioPCBC.Size = new Size(65, 24);
            radioPCBC.TabIndex = 2;
            radioPCBC.Text = "PCBC";
            radioPCBC.UseVisualStyleBackColor = true;
            radioPCBC.CheckedChanged += radioPCBC_CheckedChanged;
            // 
            // dugmeSend
            // 
            dugmeSend.Anchor = AnchorStyles.None;
            tableLayoutPanel4.SetColumnSpan(dugmeSend, 2);
            dugmeSend.Location = new Point(179, 321);
            dugmeSend.Margin = new Padding(3, 4, 3, 4);
            dugmeSend.Name = "dugmeSend";
            dugmeSend.Size = new Size(86, 31);
            dugmeSend.TabIndex = 8;
            dugmeSend.Text = "Pošalji";
            dugmeSend.UseVisualStyleBackColor = true;
            dugmeSend.Click += dugmeSend_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Location = new Point(38, 264);
            label6.Name = "label6";
            label6.Size = new Size(34, 20);
            label6.TabIndex = 6;
            label6.Text = "Fajl:";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel5.Controls.Add(dumeFajl, 1, 0);
            tableLayoutPanel5.Controls.Add(txtBoxImeFajla, 0, 0);
            tableLayoutPanel5.Location = new Point(114, 248);
            tableLayoutPanel5.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(327, 53);
            tableLayoutPanel5.TabIndex = 7;
            // 
            // dumeFajl
            // 
            dumeFajl.Anchor = AnchorStyles.None;
            dumeFajl.Location = new Point(281, 11);
            dumeFajl.Margin = new Padding(3, 4, 3, 4);
            dumeFajl.Name = "dumeFajl";
            dumeFajl.Size = new Size(42, 31);
            dumeFajl.TabIndex = 1;
            dumeFajl.Text = "...";
            dumeFajl.UseVisualStyleBackColor = true;
            dumeFajl.Click += dumeFajl_Click;
            // 
            // txtBoxImeFajla
            // 
            txtBoxImeFajla.Anchor = AnchorStyles.None;
            txtBoxImeFajla.Location = new Point(5, 13);
            txtBoxImeFajla.Margin = new Padding(3, 4, 3, 4);
            txtBoxImeFajla.Name = "txtBoxImeFajla";
            txtBoxImeFajla.ReadOnly = true;
            txtBoxImeFajla.Size = new Size(267, 27);
            txtBoxImeFajla.TabIndex = 0;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(16, 142);
            label5.Name = "label5";
            label5.Size = new Size(79, 20);
            label5.TabIndex = 4;
            label5.Text = "Algoritam:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Location = new Point(34, 203);
            label7.Name = "label7";
            label7.Size = new Size(42, 20);
            label7.TabIndex = 9;
            label7.Text = "Sifra:";
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Controls.Add(groupBox2, 0, 1);
            tableLayoutPanel6.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel6.Location = new Point(9, 16);
            tableLayoutPanel6.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel6.Size = new Size(509, 715);
            tableLayoutPanel6.TabIndex = 2;
            // 
            // FormaSifriranjeSocketi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(533, 747);
            Controls.Add(tableLayoutPanel6);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormaSifriranjeSocketi";
            Text = "FormaSifriranjeSocketi";
            FormClosing += FormaSifriranjeSocketi_FormClosing;
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            groupBox2.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private TextBox txtBoxPortRcv;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label3;
        private Label label4;
        private TextBox txtBoxIPSend;
        private TextBox txtBoxPortSend;
        private Label label5;
        private TableLayoutPanel tableLayoutPanel3;
        private RadioButton radioPlayfair;
        private RadioButton radioRC6;
        private RadioButton radioPCBC;
        private Label label6;
        private TableLayoutPanel tableLayoutPanel5;
        private TextBox txtBoxImeFajla;
        private Button dumeFajl;
        private Button dugmeSend;
        private TableLayoutPanel tableLayoutPanel6;
        private TableLayoutPanel tableLayoutPanel2;
        private Button dugmePokreniSrv;
        private Button dugmeUgasiSrv;
        private Label label1;
        private TextBox txtSifra;
        private TableLayoutPanel tableLayoutPanel7;
        private Button btnPotvrdi;
        private TableLayoutPanel tableLayoutPanel8;
        private TextBox txtSifraClient;
        private Button btnSifraClient;
        private Label label7;
    }
}