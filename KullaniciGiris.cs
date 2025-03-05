using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace OdevTakipApp
{
    public partial class KullaniciGiris : Form
    {
        public KullaniciGiris()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string Kullanici;
            string sifre;

            Kullanici = textBox1.Text;
            sifre = textBox2.Text;

            if (Kullanici == "Tekno00" && sifre == "000035")
            {
                this.Hide();
                Form1 frm = new Form1();
                frm.Show();
                this.Close();
            }
            else
            {
                label3.Hide();
                MessageBox.Show(" Yalnış kullanıcı adı ya da parola");
            }



        }

    }
}

