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
            tableLayoutPanel4 = new TableLayoutPanel();
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            groupBox2 = new GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            radioSifriaj = new RadioButton();
            radioDesifriraj = new RadioButton();
            chkBoxHash = new CheckBox();
            dugmeBirajFajl = new Button();
            txtBoxSifra = new TextBox();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Location = new Point(3, 4);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(288, 291);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Algoritam šifriranja";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(radioPlayfair, 0, 0);
            tableLayoutPanel1.Controls.Add(radioRC6, 0, 1);
            tableLayoutPanel1.Controls.Add(radioPCBC, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 3);
            tableLayoutPanel1.Location = new Point(7, 25);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25.0006237F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25.0006275F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25.0006275F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 24.9981289F));
            tableLayoutPanel1.Size = new Size(275, 266);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // radioPlayfair
            // 
            radioPlayfair.Anchor = AnchorStyles.Left;
            radioPlayfair.AutoSize = true;
            radioPlayfair.Checked = true;
            radioPlayfair.Location = new Point(3, 21);
            radioPlayfair.Margin = new Padding(3, 4, 3, 4);
            radioPlayfair.Name = "radioPlayfair";
            radioPlayfair.Padding = new Padding(11, 0, 0, 0);
            radioPlayfair.Size = new Size(140, 24);
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
            radioRC6.Location = new Point(3, 87);
            radioRC6.Margin = new Padding(3, 4, 3, 4);
            radioRC6.Name = "radioRC6";
            radioRC6.Padding = new Padding(11, 0, 0, 0);
            radioRC6.Size = new Size(67, 24);
            radioRC6.TabIndex = 1;
            radioRC6.Text = "RC6";
            radioRC6.UseVisualStyleBackColor = true;
            radioRC6.CheckedChanged += radioRC6_CheckedChanged;
            // 
            // radioPCBC
            // 
            radioPCBC.Anchor = AnchorStyles.Left;
            radioPCBC.AutoSize = true;
            radioPCBC.Location = new Point(3, 153);
            radioPCBC.Margin = new Padding(3, 4, 3, 4);
            radioPCBC.Name = "radioPCBC";
            radioPCBC.Padding = new Padding(11, 0, 0, 0);
            radioPCBC.Size = new Size(76, 24);
            radioPCBC.TabIndex = 2;
            radioPCBC.Text = "PCBC";
            radioPCBC.UseVisualStyleBackColor = true;
            radioPCBC.CheckedChanged += radioPCBC_CheckedChanged;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel4.Controls.Add(label1, 0, 0);
            tableLayoutPanel4.Controls.Add(txtBoxSifra, 1, 0);
            tableLayoutPanel4.Location = new Point(3, 201);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(269, 62);
            tableLayoutPanel4.TabIndex = 3;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(5, 21);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 0;
            label1.Text = "Sifra:";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0000038F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0000038F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel2.Controls.Add(groupBox2, 1, 0);
            tableLayoutPanel2.Controls.Add(dugmeBirajFajl, 0, 1);
            tableLayoutPanel2.Location = new Point(14, 16);
            tableLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Size = new Size(593, 374);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.None;
            groupBox2.Controls.Add(tableLayoutPanel3);
            groupBox2.Location = new Point(320, 47);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(248, 204);
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
            tableLayoutPanel3.Location = new Point(7, 25);
            tableLayoutPanel3.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel3.Size = new Size(234, 171);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // radioSifriaj
            // 
            radioSifriaj.Anchor = AnchorStyles.None;
            radioSifriaj.AutoSize = true;
            radioSifriaj.Checked = true;
            radioSifriaj.Location = new Point(8, 30);
            radioSifriaj.Margin = new Padding(3, 4, 3, 4);
            radioSifriaj.Name = "radioSifriaj";
            radioSifriaj.Padding = new Padding(11, 0, 0, 0);
            radioSifriaj.Size = new Size(100, 24);
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
            radioDesifriraj.Location = new Point(64, 116);
            radioDesifriraj.Margin = new Padding(3, 4, 3, 4);
            radioDesifriraj.Name = "radioDesifriraj";
            radioDesifriraj.Size = new Size(106, 24);
            radioDesifriraj.TabIndex = 1;
            radioDesifriraj.Text = "Desifriranje";
            radioDesifriraj.UseVisualStyleBackColor = true;
            radioDesifriraj.CheckedChanged += radioDesifriraj_CheckedChanged;
            // 
            // chkBoxHash
            // 
            chkBoxHash.Anchor = AnchorStyles.None;
            chkBoxHash.AutoSize = true;
            chkBoxHash.Location = new Point(137, 30);
            chkBoxHash.Margin = new Padding(3, 4, 3, 4);
            chkBoxHash.Name = "chkBoxHash";
            chkBoxHash.Size = new Size(77, 24);
            chkBoxHash.TabIndex = 2;
            chkBoxHash.Text = "Hesiraj";
            chkBoxHash.UseVisualStyleBackColor = true;
            chkBoxHash.CheckedChanged += chkBoxHash_CheckedChanged;
            // 
            // dugmeBirajFajl
            // 
            dugmeBirajFajl.Anchor = AnchorStyles.None;
            tableLayoutPanel2.SetColumnSpan(dugmeBirajFajl, 2);
            dugmeBirajFajl.Location = new Point(241, 311);
            dugmeBirajFajl.Margin = new Padding(3, 4, 3, 4);
            dugmeBirajFajl.Name = "dugmeBirajFajl";
            dugmeBirajFajl.Size = new Size(110, 51);
            dugmeBirajFajl.TabIndex = 2;
            dugmeBirajFajl.Text = "Izaberi fajl";
            dugmeBirajFajl.UseVisualStyleBackColor = true;
            dugmeBirajFajl.Click += dugmeBirajFajl_Click;
            // 
            // txtBoxSifra
            // 
            txtBoxSifra.Anchor = AnchorStyles.None;
            txtBoxSifra.Location = new Point(59, 17);
            txtBoxSifra.Name = "txtBoxSifra";
            txtBoxSifra.Size = new Size(203, 27);
            txtBoxSifra.TabIndex = 1;
            // 
            // FormaRucnoSifriranje
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(621, 403);
            Controls.Add(tableLayoutPanel2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormaRucnoSifriranje";
            Text = "FormaRucnoSifriranje";
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
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
        private TableLayoutPanel tableLayoutPanel4;
        private Label label1;
        private TextBox txtBoxSifra;
    }
}