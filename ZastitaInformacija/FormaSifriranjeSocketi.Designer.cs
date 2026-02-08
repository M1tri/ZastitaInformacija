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
            label1 = new Label();
            label2 = new Label();
            txtBoxIpRcv = new TextBox();
            txtBoxPortRcv = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            dugmePokreniSrv = new Button();
            dugmeUgasiSrv = new Button();
            groupBox2 = new GroupBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            label3 = new Label();
            label4 = new Label();
            txtBoxIPSend = new TextBox();
            txtBoxPortSend = new TextBox();
            label5 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            radioPlayfair = new RadioButton();
            radioRC6 = new RadioButton();
            radioPCBC = new RadioButton();
            label6 = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            txtBoxImeFajla = new TextBox();
            dumeFajl = new Button();
            dugmeSend = new Button();
            tableLayoutPanel6 = new TableLayoutPanel();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Location = new Point(53, 8);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(338, 197);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Prihvatanje paketa";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(txtBoxIpRcv, 1, 0);
            tableLayoutPanel1.Controls.Add(txtBoxPortRcv, 1, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 2);
            tableLayoutPanel1.Location = new Point(17, 21);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(310, 170);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(10, 20);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 0;
            label1.Text = "IP adresa:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(22, 76);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 1;
            label2.Text = "Port:";
            // 
            // txtBoxIpRcv
            // 
            txtBoxIpRcv.Anchor = AnchorStyles.None;
            txtBoxIpRcv.Location = new Point(98, 16);
            txtBoxIpRcv.Name = "txtBoxIpRcv";
            txtBoxIpRcv.Size = new Size(190, 23);
            txtBoxIpRcv.TabIndex = 2;
            // 
            // txtBoxPortRcv
            // 
            txtBoxPortRcv.Anchor = AnchorStyles.None;
            txtBoxPortRcv.Location = new Point(98, 72);
            txtBoxPortRcv.Name = "txtBoxPortRcv";
            txtBoxPortRcv.Size = new Size(190, 23);
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
            tableLayoutPanel2.Location = new Point(3, 115);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(304, 52);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // dugmePokreniSrv
            // 
            dugmePokreniSrv.Anchor = AnchorStyles.None;
            dugmePokreniSrv.Location = new Point(38, 14);
            dugmePokreniSrv.Name = "dugmePokreniSrv";
            dugmePokreniSrv.Size = new Size(75, 23);
            dugmePokreniSrv.TabIndex = 4;
            dugmePokreniSrv.Text = "Pokreni";
            dugmePokreniSrv.UseVisualStyleBackColor = true;
            dugmePokreniSrv.Click += dugmePokreniSrv_Click;
            // 
            // dugmeUgasiSrv
            // 
            dugmeUgasiSrv.Anchor = AnchorStyles.None;
            dugmeUgasiSrv.Enabled = false;
            dugmeUgasiSrv.Location = new Point(190, 14);
            dugmeUgasiSrv.Name = "dugmeUgasiSrv";
            dugmeUgasiSrv.Size = new Size(75, 23);
            dugmeUgasiSrv.TabIndex = 5;
            dugmeUgasiSrv.TabStop = false;
            dugmeUgasiSrv.Text = "Prekini";
            dugmeUgasiSrv.UseVisualStyleBackColor = true;
            dugmeUgasiSrv.Click += dugmeUgasiSrv_Click;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.None;
            groupBox2.Controls.Add(tableLayoutPanel4);
            groupBox2.Location = new Point(9, 220);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(427, 309);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Slanje paketa";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tableLayoutPanel4.Controls.Add(label3, 0, 0);
            tableLayoutPanel4.Controls.Add(label4, 0, 1);
            tableLayoutPanel4.Controls.Add(txtBoxIPSend, 1, 0);
            tableLayoutPanel4.Controls.Add(txtBoxPortSend, 1, 1);
            tableLayoutPanel4.Controls.Add(label5, 0, 2);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel3, 1, 2);
            tableLayoutPanel4.Controls.Add(label6, 0, 3);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 1, 3);
            tableLayoutPanel4.Controls.Add(dugmeSend, 0, 4);
            tableLayoutPanel4.Location = new Point(16, 27);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 5;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 20.000494F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 20.0005016F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 20.0005016F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 19.9985027F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 19.9999981F));
            tableLayoutPanel4.Size = new Size(389, 276);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(20, 20);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 0;
            label3.Text = "IP adresa:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(32, 75);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 1;
            label4.Text = "Port:";
            // 
            // txtBoxIPSend
            // 
            txtBoxIPSend.Anchor = AnchorStyles.None;
            txtBoxIPSend.Location = new Point(148, 16);
            txtBoxIPSend.Name = "txtBoxIPSend";
            txtBoxIPSend.Size = new Size(190, 23);
            txtBoxIPSend.TabIndex = 2;
            // 
            // txtBoxPortSend
            // 
            txtBoxPortSend.Anchor = AnchorStyles.None;
            txtBoxPortSend.Location = new Point(148, 71);
            txtBoxPortSend.Name = "txtBoxPortSend";
            txtBoxPortSend.Size = new Size(190, 23);
            txtBoxPortSend.TabIndex = 3;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(17, 130);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 4;
            label5.Text = "Algoritam:";
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
            tableLayoutPanel3.Location = new Point(100, 113);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(286, 49);
            tableLayoutPanel3.TabIndex = 5;
            // 
            // radioPlayfair
            // 
            radioPlayfair.Anchor = AnchorStyles.None;
            radioPlayfair.AutoSize = true;
            radioPlayfair.Checked = true;
            radioPlayfair.Location = new Point(14, 15);
            radioPlayfair.Name = "radioPlayfair";
            radioPlayfair.Size = new Size(66, 19);
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
            radioRC6.Location = new Point(119, 15);
            radioRC6.Name = "radioRC6";
            radioRC6.Size = new Size(46, 19);
            radioRC6.TabIndex = 1;
            radioRC6.Text = "RC6";
            radioRC6.UseVisualStyleBackColor = true;
            radioRC6.CheckedChanged += radioRC6_CheckedChanged;
            // 
            // radioPCBC
            // 
            radioPCBC.Anchor = AnchorStyles.None;
            radioPCBC.AutoSize = true;
            radioPCBC.Location = new Point(210, 15);
            radioPCBC.Name = "radioPCBC";
            radioPCBC.Size = new Size(55, 19);
            radioPCBC.TabIndex = 2;
            radioPCBC.Text = "PCBC";
            radioPCBC.UseVisualStyleBackColor = true;
            radioPCBC.CheckedChanged += radioPCBC_CheckedChanged;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Location = new Point(34, 185);
            label6.Name = "label6";
            label6.Size = new Size(28, 15);
            label6.TabIndex = 6;
            label6.Text = "Fajl:";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel5.Controls.Add(txtBoxImeFajla, 0, 0);
            tableLayoutPanel5.Controls.Add(dumeFajl, 1, 0);
            tableLayoutPanel5.Location = new Point(100, 168);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(286, 49);
            tableLayoutPanel5.TabIndex = 7;
            // 
            // txtBoxImeFajla
            // 
            txtBoxImeFajla.Anchor = AnchorStyles.None;
            txtBoxImeFajla.Location = new Point(4, 13);
            txtBoxImeFajla.Name = "txtBoxImeFajla";
            txtBoxImeFajla.ReadOnly = true;
            txtBoxImeFajla.Size = new Size(234, 23);
            txtBoxImeFajla.TabIndex = 0;
            // 
            // dumeFajl
            // 
            dumeFajl.Anchor = AnchorStyles.None;
            dumeFajl.Location = new Point(246, 13);
            dumeFajl.Name = "dumeFajl";
            dumeFajl.Size = new Size(37, 23);
            dumeFajl.TabIndex = 1;
            dumeFajl.Text = "...";
            dumeFajl.UseVisualStyleBackColor = true;
            dumeFajl.Click += dumeFajl_Click;
            // 
            // dugmeSend
            // 
            dugmeSend.Anchor = AnchorStyles.None;
            tableLayoutPanel4.SetColumnSpan(dugmeSend, 2);
            dugmeSend.Location = new Point(157, 236);
            dugmeSend.Name = "dugmeSend";
            dugmeSend.Size = new Size(75, 23);
            dugmeSend.TabIndex = 8;
            dugmeSend.Text = "Pošalji";
            dugmeSend.UseVisualStyleBackColor = true;
            dugmeSend.Click += dugmeSend_Click;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Controls.Add(groupBox2, 0, 1);
            tableLayoutPanel6.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel6.Location = new Point(8, 12);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel6.Size = new Size(445, 536);
            tableLayoutPanel6.TabIndex = 2;
            // 
            // FormaSifriranjeSocketi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 560);
            Controls.Add(tableLayoutPanel6);
            Name = "FormaSifriranjeSocketi";
            Text = "FormaSifriranjeSocketi";
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
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
        private Label label1;
        private Label label2;
        private TextBox txtBoxIpRcv;
        private TextBox txtBoxPortRcv;
        private TableLayoutPanel tableLayoutPanel2;
        private Button dugmePokreniSrv;
        private Button dugmeUgasiSrv;
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
    }
}