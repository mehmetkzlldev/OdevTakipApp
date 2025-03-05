using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdevTakipApp
{
    public class Ogrenci
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string No { get; set; }
        public string Sinif { get; set; }
        public string Konu { get; set; }
        public string Puan { get; set; }
        public bool OdevYaptiMi { get; set; }



        public string AdSoyad
        {
            get { return Ad + " " + Soyad; }
        }

    }
}
