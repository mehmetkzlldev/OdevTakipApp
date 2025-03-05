namespace OdevTakipApp
{
    partial class Form1
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label8 = new Label();
            lbOgr = new ListBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            rtbKonu = new RichTextBox();
            rbEvet = new RadioButton();
            label7 = new Label();
            tbNo = new TextBox();
            tbAd = new TextBox();
            tbSoyad = new TextBox();
            tbPuan = new TextBox();
            btnKaydet = new Button();
            btnEkle = new Button();
            btnYeni = new Button();
            btnSil = new Button();
            rbHayir = new RadioButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(639, 100);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(128, 128, 255);
            pictureBox1.Image = Properties.Resources.book;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(239, 94);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Verdana", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(188, 0);
            label1.Name = "label1";
            label1.Size = new Size(426, 100);
            label1.TabIndex = 0;
            label1.Text = "Odev Takip App";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(139, 444);
            label8.Name = "label8";
            label8.Size = new Size(121, 28);
            label8.TabIndex = 2;
            label8.Text = "Ödev Puani :";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbOgr
            // 
            lbOgr.BackColor = Color.FromArgb(128, 128, 255);
            lbOgr.FormattingEnabled = true;
            lbOgr.ItemHeight = 17;
            lbOgr.Location = new Point(15, 115);
            lbOgr.Name = "lbOgr";
            lbOgr.Size = new Size(239, 327);
            lbOgr.TabIndex = 1;
            lbOgr.SelectedIndexChanged += lbOgr_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(292, 115);
            label2.Name = "label2";
            label2.Size = new Size(152, 28);
            label2.TabIndex = 2;
            label2.Text = "Öğrenci No :";
            // 
            // label3
            // 
            label3.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(292, 164);
            label3.Name = "label3";
            label3.Size = new Size(152, 28);
            label3.TabIndex = 2;
            label3.Text = "Öğrenci Adi :";
            // 
            // label4
            // 
            label4.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(292, 213);
            label4.Name = "label4";
            label4.Size = new Size(152, 28);
            label4.TabIndex = 2;
            label4.Text = "Öğrenci Soyadi :";
            // 
            // label5
            // 
            label5.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(292, 264);
            label5.Name = "label5";
            label5.Size = new Size(152, 28);
            label5.TabIndex = 2;
            label5.Text = "Öğrenci Sinifi :";
            // 
            // label6
            // 
            label6.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(292, 318);
            label6.Name = "label6";
            label6.Size = new Size(152, 28);
            label6.TabIndex = 2;
            label6.Text = "Ödev Konusu :";
            // 
            // rtbKonu
            // 
            rtbKonu.Location = new Point(292, 342);
            rtbKonu.Name = "rtbKonu";
            rtbKonu.Size = new Size(343, 96);
            rtbKonu.TabIndex = 3;
            rtbKonu.Text = "";
            // 
            // rbEvet
            // 
            rbEvet.Font = new Font("Verdana", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            rbEvet.Location = new Point(15, 474);
            rbEvet.Name = "rbEvet";
            rbEvet.Size = new Size(65, 27);
            rbEvet.TabIndex = 4;
            rbEvet.TabStop = true;
            rbEvet.Text = "Evet";
            rbEvet.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(12, 445);
            label7.Name = "label7";
            label7.Size = new Size(129, 28);
            label7.TabIndex = 2;
            label7.Text = "Ödevi Yaptı mı :";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbNo
            // 
            tbNo.Location = new Point(419, 112);
            tbNo.Name = "tbNo";
            tbNo.Size = new Size(216, 25);
            tbNo.TabIndex = 6;
            // 
            // tbAd
            // 
            tbAd.Location = new Point(419, 162);
            tbAd.Name = "tbAd";
            tbAd.Size = new Size(216, 25);
            tbAd.TabIndex = 6;
            // 
            // tbSoyad
            // 
            tbSoyad.Location = new Point(450, 211);
            tbSoyad.Name = "tbSoyad";
            tbSoyad.Size = new Size(185, 25);
            tbSoyad.TabIndex = 6;
            // 
            // tbPuan
            // 
            tbPuan.Location = new Point(151, 474);
            tbPuan.Name = "tbPuan";
            tbPuan.Size = new Size(103, 25);
            tbPuan.TabIndex = 6;
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.DarkCyan;
            btnKaydet.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnKaydet.ForeColor = Color.White;
            btnKaydet.Location = new Point(480, 445);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(155, 41);
            btnKaydet.TabIndex = 7;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.ForestGreen;
            btnEkle.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnEkle.ForeColor = Color.White;
            btnEkle.Location = new Point(480, 492);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(155, 41);
            btnEkle.TabIndex = 7;
            btnEkle.Text = "Ekle / Güncelle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnYeni
            // 
            btnYeni.BackColor = Color.Gold;
            btnYeni.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnYeni.ForeColor = Color.White;
            btnYeni.Location = new Point(292, 445);
            btnYeni.Name = "btnYeni";
            btnYeni.Size = new Size(155, 41);
            btnYeni.TabIndex = 7;
            btnYeni.Text = "Yeni";
            btnYeni.UseVisualStyleBackColor = false;
            btnYeni.Click += btnYeni_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.FromArgb(192, 0, 0);
            btnSil.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnSil.ForeColor = Color.White;
            btnSil.Location = new Point(292, 492);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(155, 41);
            btnSil.TabIndex = 7;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // rbHayir
            // 
            rbHayir.Font = new Font("Verdana", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            rbHayir.Location = new Point(76, 474);
            rbHayir.Name = "rbHayir";
            rbHayir.Size = new Size(80, 27);
            rbHayir.TabIndex = 4;
            rbHayir.TabStop = true;
            rbHayir.Text = "Hayir";
            rbHayir.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(650, 538);
            Controls.Add(btnYeni);
            Controls.Add(btnEkle);
            Controls.Add(label8);
            Controls.Add(btnSil);
            Controls.Add(btnKaydet);
            Controls.Add(tbSoyad);
            Controls.Add(tbPuan);
            Controls.Add(tbAd);
            Controls.Add(tbNo);
            Controls.Add(rbHayir);
            Controls.Add(rbEvet);
            Controls.Add(rtbKonu);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbOgr);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OdevTakipApp";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private ListBox lbOgr;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private RichTextBox rtbKonu;
        private RadioButton rbEvet;
        private Label label7;
        private NumericUpDown nudPuan;
        private Label label8;
        private TextBox tbNo;
        private TextBox tbAd;
        private TextBox tbSoyad;
        private TextBox tbPuan;
        private Button btnKaydet;
        private Button btnEkle;
        private Button btnYeni;
        private Button btnSil;
        private RadioButton rbHayir;
    }
}