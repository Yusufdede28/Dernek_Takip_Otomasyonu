using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

namespace BusinessLayer
{
    public class BLUye

    {
        //üye ekleme işleminde dikkat edilmesi gerek kuralları oluşturuyoruz
        public static int uyeEkle(EntityUye p)
        {
            if (p.Uye_Ad != null && p.Uye_Soyad !=null && p.Uye_Ad.Length > 2 && p.Uye_Ad.Length<50 && p.Yas != null 
                && p.Sehir != null && p.Kayit_Tarihi != null && p.Kan_Grubu !=null && p.Aidat !=null && p.Mail_Adress !=null && p.Aktif!=null)
                    return DALuye.uyeEkle(p);
            return -1;
        }
        
        // üye silme işleminde dikkat edilmesi gereken kuralları oluşturuyoruz
        public static int uyeSil(EntityUye p)
        {
            if (p.TC_No>0)
                    return DALuye.uyeSil(p);
            return -1;
        }

        // üye güncelleme işleminde dikkat edilmesi gereken kuralları oluşturuyoruz
        public static int uyeGuncelle(EntityUye p)
        {
            if (p.Uye_Ad != null && p.Uye_Soyad != null && p.Uye_Ad.Length > 2 && p.Uye_Ad.Length < 50
                && p.Yas != null && p.Sehir != null && p.Kayit_Tarihi != null && p.Kan_Grubu != null && p.Aidat != null && p.Mail_Adress != null && p.Aktif != null && p.TC_No>0)
                    return DALuye.uyeGuncelle(p);
            return -1;
        }

        //uyeListesini çağırıyoruz.
        public static List<EntityUye> uyeListele()
        {
            return DALuye.uyeListele();
        }
    }
}
