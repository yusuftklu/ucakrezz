namespace UcakRezervasyonForm
{
    partial class MusteriBilgileri
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
            tableLayoutPanel1 = new TableLayoutPanel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtCins = new TextBox();
            txtYas = new TextBox();
            txtEngel = new TextBox();
            Kaydet = new Button();
            lblUyarı = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.Controls.Add(label2, 1, 0);
            tableLayoutPanel1.Controls.Add(label3, 1, 2);
            tableLayoutPanel1.Controls.Add(label4, 1, 4);
            tableLayoutPanel1.Controls.Add(label5, 1, 6);
            tableLayoutPanel1.Controls.Add(label6, 1, 8);
            tableLayoutPanel1.Controls.Add(txtAd, 1, 1);
            tableLayoutPanel1.Controls.Add(txtSoyad, 1, 3);
            tableLayoutPanel1.Controls.Add(txtCins, 1, 5);
            tableLayoutPanel1.Controls.Add(txtYas, 1, 7);
            tableLayoutPanel1.Controls.Add(txtEngel, 1, 9);
            tableLayoutPanel1.Controls.Add(Kaydet, 2, 9);
            tableLayoutPanel1.Controls.Add(lblUyarı, 1, 10);
            tableLayoutPanel1.Location = new Point(12, 80);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 11;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.Size = new Size(778, 511);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label2.ForeColor = Color.DarkOrange;
            label2.Location = new Point(372, 11);
            label2.Name = "label2";
            label2.Size = new Size(31, 23);
            label2.TabIndex = 0;
            label2.Text = "Ad";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label3.ForeColor = Color.DarkOrange;
            label3.Location = new Point(359, 103);
            label3.Name = "label3";
            label3.Size = new Size(57, 23);
            label3.TabIndex = 1;
            label3.Text = "Soyad";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label4.ForeColor = Color.DarkOrange;
            label4.Location = new Point(353, 195);
            label4.Name = "label4";
            label4.Size = new Size(70, 23);
            label4.TabIndex = 2;
            label4.Text = "Cinsiyet";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.BackColor = Color.SteelBlue;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label5.ForeColor = Color.DarkOrange;
            label5.Location = new Point(371, 287);
            label5.Name = "label5";
            label5.Size = new Size(34, 23);
            label5.TabIndex = 3;
            label5.Text = "Yaş";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.BackColor = Color.SteelBlue;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label6.ForeColor = Color.Orange;
            label6.Location = new Point(204, 379);
            label6.Name = "label6";
            label6.Size = new Size(368, 23);
            label6.TabIndex = 4;
            label6.Text = "Herhangi bir engeliniz var mı (E veya H giriniz)";
            // 
            // txtAd
            // 
            txtAd.Anchor = AnchorStyles.None;
            txtAd.Location = new Point(325, 55);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(125, 27);
            txtAd.TabIndex = 5;
            // 
            // txtSoyad
            // 
            txtSoyad.Anchor = AnchorStyles.None;
            txtSoyad.Location = new Point(325, 147);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(125, 27);
            txtSoyad.TabIndex = 6;
            // 
            // txtCins
            // 
            txtCins.Anchor = AnchorStyles.None;
            txtCins.Location = new Point(325, 239);
            txtCins.Name = "txtCins";
            txtCins.Size = new Size(125, 27);
            txtCins.TabIndex = 7;
            // 
            // txtYas
            // 
            txtYas.Anchor = AnchorStyles.None;
            txtYas.Location = new Point(325, 331);
            txtYas.Name = "txtYas";
            txtYas.Size = new Size(125, 27);
            txtYas.TabIndex = 8;
            // 
            // txtEngel
            // 
            txtEngel.Anchor = AnchorStyles.None;
            txtEngel.Location = new Point(325, 423);
            txtEngel.Name = "txtEngel";
            txtEngel.Size = new Size(125, 27);
            txtEngel.TabIndex = 9;
            // 
            // Kaydet
            // 
            Kaydet.Anchor = AnchorStyles.None;
            Kaydet.BackColor = Color.Chartreuse;
            Kaydet.Location = new Point(672, 422);
            Kaydet.Name = "Kaydet";
            Kaydet.Size = new Size(94, 29);
            Kaydet.TabIndex = 10;
            Kaydet.Text = "Kaydet";
            Kaydet.UseVisualStyleBackColor = false;
            Kaydet.Click += Kaydet_Click;
            // 
            // lblUyarı
            // 
            lblUyarı.Anchor = AnchorStyles.None;
            lblUyarı.AutoSize = true;
            lblUyarı.BackColor = Color.SteelBlue;
            lblUyarı.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblUyarı.ForeColor = Color.Black;
            lblUyarı.Location = new Point(388, 474);
            lblUyarı.Name = "lblUyarı";
            lblUyarı.Size = new Size(0, 23);
            lblUyarı.TabIndex = 11;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.Transparent;
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Location = new Point(12, 12);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(778, 62);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.HighlightText;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(687, 28);
            label1.TabIndex = 1;
            label1.Text = "İşleminizi tamamlayabilmemiz için aşağıdaki müşteri bilgilerini doldurunuz";
            // 
            // MusteriBilgileri
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.sky4;
            ClientSize = new Size(802, 603);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "MusteriBilgileri";
            Text = "MusteriBilgileri";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtCins;
        private TextBox txtYas;
        private TextBox txtEngel;
        private Button Kaydet;
        private Label lblUyarı;
    }
}