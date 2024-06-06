namespace UcakRezervasyonForm
{
    partial class Rota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rota));
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            lblSonuc = new Label();
            btnSec = new Button();
            btnDevam = new Button();
            listBoxUcus = new ListBox();
            rotaNo = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85.04039F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.95961F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(lblSonuc, 0, 4);
            tableLayoutPanel1.Controls.Add(btnSec, 1, 3);
            tableLayoutPanel1.Controls.Add(btnDevam, 1, 4);
            tableLayoutPanel1.Controls.Add(listBoxUcus, 0, 1);
            tableLayoutPanel1.Controls.Add(rotaNo, 0, 3);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(778, 579);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(3, 14);
            label1.Name = "label1";
            label1.Size = new Size(485, 28);
            label1.TabIndex = 0;
            label1.Text = "Seçtiğiniz konumlara ait uçuş bilgileri aşağıdadır :";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(3, 275);
            label2.Name = "label2";
            label2.Size = new Size(423, 25);
            label2.TabIndex = 1;
            label2.Text = "Listelenen Uçuşlardan birinin numarasını giriniz : ";
            // 
            // lblSonuc
            // 
            lblSonuc.Anchor = AnchorStyles.Left;
            lblSonuc.AutoSize = true;
            lblSonuc.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblSonuc.ForeColor = SystemColors.ControlLightLight;
            lblSonuc.Location = new Point(3, 505);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(0, 28);
            lblSonuc.TabIndex = 2;
            // 
            // btnSec
            // 
            btnSec.Anchor = AnchorStyles.Right;
            btnSec.Location = new Point(681, 388);
            btnSec.Name = "btnSec";
            btnSec.Size = new Size(94, 29);
            btnSec.TabIndex = 3;
            btnSec.Text = "Seç";
            btnSec.UseVisualStyleBackColor = true;
            btnSec.Click += btnSec_Click;
            // 
            // btnDevam
            // 
            btnDevam.Anchor = AnchorStyles.Right;
            btnDevam.Location = new Point(681, 505);
            btnDevam.Name = "btnDevam";
            btnDevam.Size = new Size(94, 29);
            btnDevam.TabIndex = 4;
            btnDevam.Text = "Devam";
            btnDevam.UseVisualStyleBackColor = true;
            btnDevam.Visible = false;
            btnDevam.Click += btnDevam_Click;
            // 
            // listBoxUcus
            // 
            listBoxUcus.BackColor = SystemColors.Menu;
            listBoxUcus.FormattingEnabled = true;
            listBoxUcus.Location = new Point(3, 60);
            listBoxUcus.Name = "listBoxUcus";
            listBoxUcus.Size = new Size(655, 144);
            listBoxUcus.TabIndex = 5;
            // 
            // rotaNo
            // 
            rotaNo.Anchor = AnchorStyles.Left;
            rotaNo.Location = new Point(3, 389);
            rotaNo.Name = "rotaNo";
            rotaNo.Size = new Size(125, 27);
            rotaNo.TabIndex = 6;
            // 
            // Rota
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(802, 603);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Rota";
            Text = "Rota";
            Load += Rota_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Button btnDevam;
        private Label lblSonuc;
        private Button btnSec;
        private ListBox listBoxUcus;
        private TextBox rotaNo;
    }
}