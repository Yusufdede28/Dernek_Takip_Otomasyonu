using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    //veri tabanında bulunan tablonun sütunlarını tanımlıyoruz ve entity katmanını oluşturuyoruz.
    public class EntityUye
    {
        public int TC_No { get; set; }
        public string Uye_Ad { get; set; }
        public string Uye_Soyad { get; set; }
        public int Yas { get; set; }
        public string Sehir { get; set; }
        public DateTime Kayit_Tarihi { get; set; }
        public string Kan_Grubu { get; set; }
        public int Aidat { get; set; }
        public string Mail_Adress { get; set; }
        public bool Aktif { get; set; }


    }
}
