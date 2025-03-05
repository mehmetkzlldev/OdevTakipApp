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
            label8 = new Label();
            lbOgr = new ListBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
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
            OGRENCILER = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // label8
            // 
            label8.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(789, 476);
            label8.Name = "label8";
            label8.Size = new Size(121, 25);
            label8.TabIndex = 2;
            label8.Text = "Ödev Puani :";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbOgr
            // 
            lbOgr.BackColor = Color.FromArgb(128, 128, 255);
            lbOgr.FormattingEnabled = true;
            lbOgr.ItemHeight = 15;
            lbOgr.Location = new Point(12, 81);
            lbOgr.Name = "lbOgr";
            lbOgr.Size = new Size(239, 544);
            lbOgr.TabIndex = 1;
            lbOgr.SelectedIndexChanged += lbOgr_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(295, 197);
            label2.Name = "label2";
            label2.Size = new Size(152, 25);
            label2.TabIndex = 2;
            label2.Text = "Öğrenci No :";
            // 
            // label3
            // 
            label3.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(295, 246);
            label3.Name = "label3";
            label3.Size = new Size(152, 25);
            label3.TabIndex = 2;
            label3.Text = "Öğrenci Adi :";
            // 
            // label4
            // 
            label4.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(298, 303);
            label4.Name = "label4";
            label4.Size = new Size(152, 25);
            label4.TabIndex = 2;
            label4.Text = "Öğrenci Soyadi :";
            // 
            // label6
            // 
            label6.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(295, 456);
            label6.Name = "label6";
            label6.Size = new Size(152, 25);
            label6.TabIndex = 2;
            label6.Text = "Ödev Konusu :";
            // 
            // rtbKonu
            // 
            rtbKonu.Location = new Point(295, 477);
            rtbKonu.Name = "rtbKonu";
            rtbKonu.Size = new Size(343, 85);
            rtbKonu.TabIndex = 3;
            rtbKonu.Text = "";
            // 
            // rbEvet
            // 
            rbEvet.Font = new Font("Verdana", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            rbEvet.Location = new Point(665, 502);
            rbEvet.Name = "rbEvet";
            rbEvet.Size = new Size(65, 24);
            rbEvet.TabIndex = 4;
            rbEvet.TabStop = true;
            rbEvet.Text = "Evet";
            rbEvet.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(662, 477);
            label7.Name = "label7";
            label7.Size = new Size(129, 25);
            label7.TabIndex = 2;
            label7.Text = "Ödevi Yaptı mı :";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbNo
            // 
            tbNo.Location = new Point(425, 197);
            tbNo.Name = "tbNo";
            tbNo.Size = new Size(216, 23);
            tbNo.TabIndex = 6;
            // 
            // tbAd
            // 
            tbAd.Location = new Point(425, 246);
            tbAd.Name = "tbAd";
            tbAd.Size = new Size(216, 23);
            tbAd.TabIndex = 6;
            // 
            // tbSoyad
            // 
            tbSoyad.Location = new Point(456, 303);
            tbSoyad.Name = "tbSoyad";
            tbSoyad.Size = new Size(185, 23);
            tbSoyad.TabIndex = 6;
            // 
            // tbPuan
            // 
            tbPuan.Location = new Point(801, 502);
            tbPuan.Name = "tbPuan";
            tbPuan.Size = new Size(103, 23);
            tbPuan.TabIndex = 6;
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.DarkCyan;
            btnKaydet.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnKaydet.ForeColor = Color.White;
            btnKaydet.Location = new Point(483, 568);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(155, 36);
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
            btnEkle.Location = new Point(483, 609);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(155, 36);
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
            btnYeni.Location = new Point(295, 568);
            btnYeni.Name = "btnYeni";
            btnYeni.Size = new Size(155, 36);
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
            btnSil.Location = new Point(295, 609);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(155, 36);
            btnSil.TabIndex = 7;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // rbHayir
            // 
            rbHayir.Font = new Font("Verdana", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            rbHayir.Location = new Point(726, 502);
            rbHayir.Name = "rbHayir";
            rbHayir.Size = new Size(80, 24);
            rbHayir.TabIndex = 4;
            rbHayir.TabStop = true;
            rbHayir.Text = "Hayir";
            rbHayir.UseVisualStyleBackColor = true;
            // 
            // OGRENCILER
            // 
            OGRENCILER.AutoSize = true;
            OGRENCILER.Font = new Font("Verdana", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            OGRENCILER.Location = new Point(12, 60);
            OGRENCILER.Name = "OGRENCILER";
            OGRENCILER.Size = new Size(118, 18);
            OGRENCILER.TabIndex = 8;
            OGRENCILER.Text = "ÖGRENCİLER";
            // 
            // label1
            // 
            label1.Font = new Font("Verdana", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(4, 9);
            label1.Name = "label1";
            label1.Size = new Size(994, 39);
            label1.TabIndex = 9;
            label1.Text = "ÖGRENCİ ÖDEV TAKİBİ ";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(1003, 671);
            Controls.Add(label1);
            Controls.Add(OGRENCILER);
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
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbOgr);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OdevTakipApp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox lbOgr;
        private Label label2;
        private Label label3;
        private Label label4;
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
        private Label OGRENCILER;
        private Label label1;
    }
}