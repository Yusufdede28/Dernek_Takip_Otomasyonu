using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace DataAccessLayer
{
    public class DALuye
    {
        public static int uyeEkle(EntityUye p)
        {
            //veri tabanı bağlantısı yapıldıktan sonra Uyeler tablosundaki verileri yeni üye ekleme işlemi için parametre oluşturuyoruz
            SqlCommand komut = new SqlCommand("insert into Uyeler (Ad, Soyad, Yas, Sehir, Kayit_Tarihi, Kan_Grubu, Aidat, Mail_Adress, Aktif) values (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9)", Baglantı.baglan);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@p1", p.Uye_Ad);
            komut.Parameters.AddWithValue("@p2", p.Uye_Soyad);
            komut.Parameters.AddWithValue("@p3", p.Yas);
            komut.Parameters.AddWithValue("@p4", p.Sehir);
            komut.Parameters.AddWithValue("@p5", p.Kayit_Tarihi);
            komut.Parameters.AddWithValue("@p6", p.Kan_Grubu);
            komut.Parameters.AddWithValue("@p7", p.Aidat);
            komut.Parameters.AddWithValue("@p8", p.Mail_Adress);
            komut.Parameters.AddWithValue("@p9", p.Aktif);
            
            return komut.ExecuteNonQuery();
        }
       
        

        public static int uyeSil(EntityUye p)
        {
            // üye silme işlemi için Uyeler tablosundan TC_No sil işlemi yapılıyor.
            SqlCommand komut = new SqlCommand("delete from Uyeler where TC_No = @p1  ", Baglantı.baglan);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@p1", p.TC_No);
            

            return komut.ExecuteNonQuery();
        }

        public static int uyeGuncelle(EntityUye p)
        {
            // uyeleri hakkındaki bilgileri güncelleme işlemi için parametreler oluşturuluyor.
            SqlCommand komut = new SqlCommand("uptade Uyeler set Ad = @p1, Soyad = @p2, Yas = @p3, Sehir = @p4, Kayit_Tarihi = @p5, Kan_Grubu = @p6, Aidat = @p7, Mail_Adress = @p8, Aktif = @p9 where TC_No = @p10", Baglantı.baglan);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@p1", p.Uye_Ad);
            komut.Parameters.AddWithValue("@p2", p.Uye_Soyad);
            komut.Parameters.AddWithValue("@p3", p.Yas);
            komut.Parameters.AddWithValue("@p4", p.Sehir);
            komut.Parameters.AddWithValue("@p5", p.Kayit_Tarihi);
            komut.Parameters.AddWithValue("@p6", p.Kan_Grubu);
            komut.Parameters.AddWithValue("@p7", p.Aidat);
            komut.Parameters.AddWithValue("@p8", p.Mail_Adress);
            komut.Parameters.AddWithValue("@p9", p.Aktif);
            komut.Parameters.AddWithValue("@p10", p.TC_No);
            
            return komut.ExecuteNonQuery();
            ;

        }
       
        public static List<EntityUye> uyeListele()
        {
            // üyeleri listelemek için 
            SqlCommand komut = new SqlCommand("select * from Uyeler", Baglantı.baglan);
            DataTable dt = new DataTable();
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
          
            SqlDataReader dr = komut.ExecuteReader();

            List<EntityUye> uyeler = new List<EntityUye>();
            // üye listelesi oluşturuluyor ve string tipine dönüştürülüyor
            while (dr.Read())
            {
                EntityUye ent = new EntityUye();
                ent.TC_No = int.Parse(dr[0].ToString());
                ent.Uye_Ad = dr[1].ToString();
                ent.Uye_Soyad = dr[2].ToString();
                ent.Yas = int.Parse(dr[3].ToString());
                ent.Sehir = dr[4].ToString();
                ent.Kayit_Tarihi = DateTime.Parse(dr[5].ToString());
                ent.Kan_Grubu = dr[6].ToString();
                ent.Aidat =int.Parse(dr[7].ToString());
                ent.Mail_Adress = dr[8].ToString();
                ent.Aktif = bool.Parse(dr[9].ToString());

                uyeler.Add(ent);
            }
            dr.Close(); 
            return uyeler;
        }
    }


}

