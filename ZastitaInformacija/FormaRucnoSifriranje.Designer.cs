namespace ZastitaInformacija
{
    partial class FormaRucnoSifriranje
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
            radioPlayfair = new RadioButton();
            radioRC6 = new RadioButton();
            radioPCBC = new RadioButton();
            tableLayoutPanel2 = new TableLayoutPanel();
            groupBox2 = new GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            radioSifriaj = new RadioButton();
            radioDesifriraj = new RadioButton();
            chkBoxHash = new CheckBox();
            dugmeBirajFajl = new Button();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(216, 159);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Algoritam šifriranja";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(radioPlayfair, 0, 0);
            tableLayoutPanel1.Controls.Add(radioRC6, 0, 1);
            tableLayoutPanel1.Controls.Add(radioPCBC, 0, 2);
            tableLayoutPanel1.Location = new Point(6, 19);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(204, 134);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // radioPlayfair
            // 
            radioPlayfair.Anchor = AnchorStyles.Left;
            radioPlayfair.AutoSize = true;
            radioPlayfair.Checked = true;
            radioPlayfair.Location = new Point(3, 12);
            radioPlayfair.Name = "radioPlayfair";
            radioPlayfair.Padding = new Padding(10, 0, 0, 0);
            radioPlayfair.Size = new Size(115, 19);
            radioPlayfair.TabIndex = 0;
            radioPlayfair.TabStop = true;
            radioPlayfair.Text = "Playfair Cypher";
            radioPlayfair.UseVisualStyleBackColor = true;
            radioPlayfair.CheckedChanged += radioPlayfair_CheckedChanged;
            // 
            // radioRC6
            // 
            radioRC6.Anchor = AnchorStyles.Left;
            radioRC6.AutoSize = true;
            radioRC6.Location = new Point(3, 56);
            radioRC6.Name = "radioRC6";
            radioRC6.Padding = new Padding(10, 0, 0, 0);
            radioRC6.Size = new Size(56, 19);
            radioRC6.TabIndex = 1;
            radioRC6.Text = "RC6";
            radioRC6.UseVisualStyleBackColor = true;
            radioRC6.CheckedChanged += radioRC6_CheckedChanged;
            // 
            // radioPCBC
            // 
            radioPCBC.Anchor = AnchorStyles.Left;
            radioPCBC.AutoSize = true;
            radioPCBC.Location = new Point(3, 101);
            radioPCBC.Name = "radioPCBC";
            radioPCBC.Padding = new Padding(10, 0, 0, 0);
            radioPCBC.Size = new Size(65, 19);
            radioPCBC.TabIndex = 2;
            radioPCBC.Text = "PCBC";
            radioPCBC.UseVisualStyleBackColor = true;
            radioPCBC.CheckedChanged += radioPCBC_CheckedChanged;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 43.47826F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.04348F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 43.4782639F));
            tableLayoutPanel2.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel2.Controls.Add(groupBox2, 2, 0);
            tableLayoutPanel2.Controls.Add(dugmeBirajFajl, 0, 1);
            tableLayoutPanel2.Location = new Point(12, 12);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.Size = new Size(519, 245);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.None;
            groupBox2.Controls.Add(tableLayoutPanel3);
            groupBox2.Location = new Point(297, 9);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(217, 153);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Radnja";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(radioSifriaj, 0, 0);
            tableLayoutPanel3.Controls.Add(radioDesifriraj, 0, 1);
            tableLayoutPanel3.Controls.Add(chkBoxHash, 1, 0);
            tableLayoutPanel3.Location = new Point(6, 19);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(205, 128);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // radioSifriaj
            // 
            radioSifriaj.Anchor = AnchorStyles.None;
            radioSifriaj.AutoSize = true;
            radioSifriaj.Checked = true;
            radioSifriaj.Location = new Point(10, 22);
            radioSifriaj.Name = "radioSifriaj";
            radioSifriaj.Padding = new Padding(10, 0, 0, 0);
            radioSifriaj.Size = new Size(81, 19);
            radioSifriaj.TabIndex = 0;
            radioSifriaj.TabStop = true;
            radioSifriaj.Text = "Sifriranje";
            radioSifriaj.UseVisualStyleBackColor = true;
            radioSifriaj.CheckedChanged += radioSifriaj_CheckedChanged;
            // 
            // radioDesifriraj
            // 
            radioDesifriraj.Anchor = AnchorStyles.None;
            radioDesifriraj.AutoSize = true;
            tableLayoutPanel3.SetColumnSpan(radioDesifriraj, 2);
            radioDesifriraj.Location = new Point(60, 86);
            radioDesifriraj.Name = "radioDesifriraj";
            radioDesifriraj.Size = new Size(84, 19);
            radioDesifriraj.TabIndex = 1;
            radioDesifriraj.Text = "Desifriranje";
            radioDesifriraj.UseVisualStyleBackColor = true;
            radioDesifriraj.CheckedChanged += radioDesifriraj_CheckedChanged;
            // 
            // chkBoxHash
            // 
            chkBoxHash.Anchor = AnchorStyles.None;
            chkBoxHash.AutoSize = true;
            chkBoxHash.Location = new Point(122, 22);
            chkBoxHash.Name = "chkBoxHash";
            chkBoxHash.Size = new Size(62, 19);
            chkBoxHash.TabIndex = 2;
            chkBoxHash.Text = "Hesiraj";
            chkBoxHash.UseVisualStyleBackColor = true;
            chkBoxHash.CheckedChanged += chkBoxHash_CheckedChanged;
            // 
            // dugmeBirajFajl
            // 
            dugmeBirajFajl.Anchor = AnchorStyles.None;
            tableLayoutPanel2.SetColumnSpan(dugmeBirajFajl, 3);
            dugmeBirajFajl.Location = new Point(211, 189);
            dugmeBirajFajl.Name = "dugmeBirajFajl";
            dugmeBirajFajl.Size = new Size(96, 38);
            dugmeBirajFajl.TabIndex = 2;
            dugmeBirajFajl.Text = "Izaberi fajl";
            dugmeBirajFajl.UseVisualStyleBackColor = true;
            dugmeBirajFajl.Click += dugmeBirajFajl_Click;
            // 
            // FormaRucnoSifriranje
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(543, 269);
            Controls.Add(tableLayoutPanel2);
            Name = "FormaRucnoSifriranje";
            Text = "FormaRucnoSifriranje";
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private RadioButton radioPlayfair;
        private RadioButton radioRC6;
        private RadioButton radioPCBC;
        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel3;
        private RadioButton radioSifriaj;
        private RadioButton radioDesifriraj;
        private CheckBox chkBoxHash;
        private Button dugmeBirajFajl;
    }
}