using System.ComponentModel;
using System.Text.Json;

namespace OdevTakipApp
{
    public partial class Form1 : Form
    {
        BindingList<Ogrenci> liste = new();
        Ogrenci gosterilenOgrenci;


        public Form1()
        {
            InitializeComponent();



            if (File.Exists("OgrenciBilgileri.txt"))
            {
                string metin = File.ReadAllText("OgrenciBilgileri.txt");

                var okunanListe = JsonSerializer.Deserialize<List<Ogrenci>>(metin);
                liste = new(okunanListe);
            }



            lbOgr.DataSource = liste;
            lbOgr.DisplayMember = "AdSoyad";

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (gosterilenOgrenci == null)
                YeniEkle();
            else
                Guncelle();
        }


        void YeniEkle()
        {
            Ogrenci yeniOgr = new();
            yeniOgr.Ad = tbAd.Text;
            yeniOgr.Soyad = tbSoyad.Text;
            yeniOgr.No = tbNo.Text;
            yeniOgr.Sinif = tbPuan.Text;
            yeniOgr.Konu = rtbKonu.Text;
            yeniOgr.Puan = tbPuan.Text;
            yeniOgr.OdevYaptiMi = rbEvet.Checked;

            liste.Add(yeniOgr);

            tbAd.Clear();
            tbSoyad.Clear();
            tbNo.Clear();
            tbPuan.Clear();

            tbAd.Focus();
        }



        private void lbOgr_SelectedIndexChanged(object sender, EventArgs e)
        {

            Ogrenci ogr = lbOgr.SelectedItem as Ogrenci;

            if (ogr != null)
            {

                tbAd.Text = ogr.Ad;
                tbSoyad.Text = ogr.Soyad;
                tbNo.Text = ogr.No.ToString();
                tbPuan.Text = ogr.Sinif;
                rtbKonu.Text = ogr.Konu;
                tbPuan.Text = ogr.Puan;
                rbEvet.Checked = ogr.OdevYaptiMi;


                gosterilenOgrenci = ogr;

            }
            else
            {
                gosterilenOgrenci = null;

                tbAd.Clear();
                tbSoyad.Clear();
                tbNo.Clear();
                tbPuan.Clear();
                rtbKonu.Clear();
                tbPuan.Clear();
                rbEvet.Enabled = false;
                tbAd.Focus();

            }
        }



        void Guncelle()
        {
            gosterilenOgrenci.Ad = tbAd.Text;
            gosterilenOgrenci.Soyad = tbSoyad.Text;
            gosterilenOgrenci.No = tbNo.Text;
            gosterilenOgrenci.Sinif = tbPuan.Text;
            gosterilenOgrenci.Konu = rtbKonu.Text;
            gosterilenOgrenci.Puan = tbPuan.Text;
            gosterilenOgrenci.OdevYaptiMi = rbEvet.Checked;



            liste.ResetBindings();
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {


            lbOgr.SelectedIndex = -1;

            tbAd.Clear();
            tbSoyad.Clear();
            tbNo.Clear();
            tbPuan.Clear();
            rtbKonu.Clear();
            tbPuan.Clear();
            tbAd.Focus();
            rbEvet.Enabled = false;

        }


        //
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string metin = JsonSerializer.Serialize(liste);

            File.WriteAllText("OgrenciBilgileri.txt", metin);

            MessageBox.Show("Bilgiler kayit edildi!");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (gosterilenOgrenci == null)
                return;

            DialogResult cevap = MessageBox.Show(
                gosterilenOgrenci.AdSoyad + " isimli öðrenciyi silmek istedi?inize emin misiniz?",
                "Uyari", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (cevap == DialogResult.Yes)
            {
                liste.Remove(gosterilenOgrenci);

                lbOgr.SelectedIndex = -1;
            }
        }


    }
}