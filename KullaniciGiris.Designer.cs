namespace OdevTakipApp
{
    partial class KullaniciGiris
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            panel1 = new Panel();
            label3 = new Label();
            btnGiris = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(26, 52);
            label1.Name = "label1";
            label1.Size = new Size(114, 18);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı adı :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(26, 98);
            label2.Name = "label2";
            label2.Size = new Size(141, 18);
            label2.TabIndex = 0;
            label2.Text = "Kullanıcı Şifresi :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(173, 52);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(173, 98);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(125, 23);
            textBox2.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnGiris);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(345, 213);
            panel1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(15, 11);
            label3.Name = "label3";
            label3.Size = new Size(312, 18);
            label3.TabIndex = 3;
            label3.Text = "LUTFEN KULLANICI GİRİŞİ YAPINIZ";
            // 
            // btnGiris
            // 
            btnGiris.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnGiris.Location = new Point(190, 139);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(108, 28);
            btnGiris.TabIndex = 2;
            btnGiris.Text = "GİRİŞ";
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += btnGiris_Click;
            // 
            // KullaniciGiris
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(369, 237);
            ControlBox = false;
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "KullaniciGiris";
            Text = "KullaniciGiris";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Panel panel1;
        private Button btnGiris;
        private Label label3;
    }
}