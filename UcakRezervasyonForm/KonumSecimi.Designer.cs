namespace UcakRezervasyonForm
{
    partial class KonumSecimi
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
            components = new System.ComponentModel.Container();
            tableLayoutPanel1 = new TableLayoutPanel();
            listBoxForChoice = new ListBox();
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnDevam = new Button();
            label3 = new Label();
            label2 = new Label();
            Kalkis = new TextBox();
            btnKalkis = new Button();
            lblKalkis = new Label();
            Varis = new TextBox();
            btnVaris = new Button();
            lblVaris = new Label();
            lblDevam = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(listBoxForChoice, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            tableLayoutPanel1.Size = new Size(778, 282);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // listBoxForChoice
            // 
            listBoxForChoice.FormattingEnabled = true;
            listBoxForChoice.Location = new Point(3, 45);
            listBoxForChoice.Name = "listBoxForChoice";
            listBoxForChoice.Size = new Size(772, 224);
            listBoxForChoice.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.5F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(3, 7);
            label1.Name = "label1";
            label1.Size = new Size(739, 28);
            label1.TabIndex = 2;
            label1.Text = "Seçim yapabileceğiniz konumlar(true olanlar kapalıdır!!!) aşağıda verilmiştir:";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.Transparent;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(btnDevam, 0, 4);
            tableLayoutPanel2.Controls.Add(label3, 1, 0);
            tableLayoutPanel2.Controls.Add(label2, 0, 0);
            tableLayoutPanel2.Controls.Add(Kalkis, 0, 1);
            tableLayoutPanel2.Controls.Add(btnKalkis, 0, 2);
            tableLayoutPanel2.Controls.Add(lblKalkis, 0, 3);
            tableLayoutPanel2.Controls.Add(Varis, 1, 1);
            tableLayoutPanel2.Controls.Add(btnVaris, 1, 2);
            tableLayoutPanel2.Controls.Add(lblVaris, 1, 3);
            tableLayoutPanel2.Controls.Add(lblDevam, 0, 4);
            tableLayoutPanel2.ForeColor = Color.Transparent;
            tableLayoutPanel2.Location = new Point(12, 300);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Size = new Size(775, 291);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // btnDevam
            // 
            btnDevam.Anchor = AnchorStyles.Right;
            btnDevam.BackColor = Color.DarkTurquoise;
            btnDevam.ForeColor = Color.Black;
            btnDevam.Location = new Point(678, 247);
            btnDevam.Name = "btnDevam";
            btnDevam.Size = new Size(94, 29);
            btnDevam.TabIndex = 9;
            btnDevam.Text = "Devam";
            btnDevam.UseVisualStyleBackColor = false;
            btnDevam.Visible = false;
            btnDevam.Click += btnDevam_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(390, 0);
            label3.Name = "label3";
            label3.Size = new Size(184, 23);
            label3.TabIndex = 1;
            label3.Text = "Varış Konum Numarası";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(195, 23);
            label2.TabIndex = 0;
            label2.Text = "Kalkış Konum Numarası:";
            // 
            // Kalkis
            // 
            Kalkis.Location = new Point(3, 61);
            Kalkis.Name = "Kalkis";
            Kalkis.Size = new Size(125, 27);
            Kalkis.TabIndex = 2;
            // 
            // btnKalkis
            // 
            btnKalkis.ForeColor = Color.Black;
            btnKalkis.Location = new Point(3, 119);
            btnKalkis.Name = "btnKalkis";
            btnKalkis.Size = new Size(94, 29);
            btnKalkis.TabIndex = 3;
            btnKalkis.Text = "Seç";
            btnKalkis.UseVisualStyleBackColor = true;
            btnKalkis.Click += btnKalkis_Click;
            // 
            // lblKalkis
            // 
            lblKalkis.AutoSize = true;
            lblKalkis.Font = new Font("Segoe UI", 10F);
            lblKalkis.Location = new Point(3, 174);
            lblKalkis.Name = "lblKalkis";
            lblKalkis.Size = new Size(0, 23);
            lblKalkis.TabIndex = 4;
            // 
            // Varis
            // 
            Varis.Location = new Point(390, 61);
            Varis.Name = "Varis";
            Varis.Size = new Size(125, 27);
            Varis.TabIndex = 5;
            Varis.Visible = false;
            // 
            // btnVaris
            // 
            btnVaris.ForeColor = Color.Black;
            btnVaris.Location = new Point(390, 119);
            btnVaris.Name = "btnVaris";
            btnVaris.Size = new Size(94, 29);
            btnVaris.TabIndex = 6;
            btnVaris.Text = "Seç";
            btnVaris.UseVisualStyleBackColor = true;
            btnVaris.Visible = false;
            btnVaris.Click += btnVaris_Click;
            // 
            // lblVaris
            // 
            lblVaris.AutoSize = true;
            lblVaris.Font = new Font("Segoe UI", 10F);
            lblVaris.Location = new Point(390, 174);
            lblVaris.Name = "lblVaris";
            lblVaris.Size = new Size(0, 23);
            lblVaris.TabIndex = 7;
            // 
            // lblDevam
            // 
            lblDevam.Anchor = AnchorStyles.Right;
            lblDevam.AutoSize = true;
            lblDevam.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblDevam.Location = new Point(63, 247);
            lblDevam.Name = "lblDevam";
            lblDevam.Size = new Size(321, 28);
            lblDevam.TabIndex = 8;
            lblDevam.Text = "Devam etmek için devama basınız";
            lblDevam.Visible = false;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // KonumSecimi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.sky_view;
            ClientSize = new Size(802, 603);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "KonumSecimi";
            Text = "KonumSecimi";
            Load += KonumSecimi_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private ListBox listBoxForChoice;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label2;
        private Label label3;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox Kalkis;
        private Button btnKalkis;
        private Label lblKalkis;
        private TextBox Varis;
        private Button btnVaris;
        private Label lblVaris;
        private Label lblDevam;
        private Button btnDevam;
    }
}