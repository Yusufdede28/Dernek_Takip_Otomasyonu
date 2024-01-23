using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;
using EntityLayer;
using BusinessLayer;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace Proje_dernek
{
    public partial class YöneticiEkranı : Form
    {
        public YöneticiEkranı()
        {
            InitializeComponent();
        }

        public void listele () //listele adında bir method oluşturuyorum ve bu sayede advancedDataGridView'da değişiklil olduğunda yenilememizi sağlıyor
        {
            //yenileme işleminde nesneleri boş hale getiriyor
            advancedDataGridView1.DataSource = BLUye.uyeListele();
            txt_TC.Text = "";
            txt_AD.Text = "";
            txt_SOYAD.Text = "";
            txt_YAS.Text = "";
            txt_SEHİR.Text = "";
            dT_TARIH.Text = "";
            comboBox_KAN.Text = "";
            txt_AIDAT.Text = "";
            txt_MAIL.Text = "";
            

        }
        SqlConnection baglan = new SqlConnection("server = DESKTOP-HTPJI1K\\SQLEXPRESS; initial catalog = gorseldb; integrated security = true"); //sql bağlantısı 
        DataTable dt = new DataTable();// datatable'a dt adını atıyoruz

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adtr = new SqlDataAdapter("Select * from Uyeler",baglan); //uyeler tablosundan seçim yapıyorz
            adtr.Fill(dt);
            advancedDataGridView1.DataSource= dt;
            
            listele();
            string[] kan_gruplar = { "A rH+", "A rH-", "B rH+", "B rH-", "0 rH+", "0 rH-", "AB rH+", "AB rH-" }; //ComboBox'ta olması gereken değerleri atıyoruz
            comboBox_KAN.Items.AddRange(kan_gruplar);
        }

       

        

        private void btn_yeniuye_Click(object sender, EventArgs e) //üye ekleme butonu
        {
            // eğer üye ekleme esnasında boş bir nesne olması durumunda uyarı mesajı ekliyoruz
            if(txt_AD.Text == "" || txt_SOYAD.Text == "" || txt_YAS.Text == "" || txt_SEHİR.Text == "" || dT_TARIH.Text == "" || comboBox_KAN.Text == "" || txt_AIDAT.Text == "" || txt_MAIL.Text== "" )
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız.");
            }
            //boş bir nesne yoksa üye ekleme işlemini gerçekleştiriyoruz
            else
            {
                EntityUye yeniuye = new EntityUye();
                yeniuye.Uye_Ad = txt_AD.Text;
                yeniuye.Uye_Soyad = txt_SOYAD.Text;
                yeniuye.Yas= int.Parse(txt_YAS.Text); // yas int tipi olduğu için stringe dönüştürmek için parse kullanıyoruz
                yeniuye.Sehir = txt_SEHİR.Text;
                yeniuye.Kayit_Tarihi = DateTime.Parse(dT_TARIH.Text);// tarih datetime tipi olduğu için stringe dönüştürmek için parse kullanıyoruz
                yeniuye.Kan_Grubu = comboBox_KAN.Text;
                yeniuye.Aidat = int.Parse(txt_AIDAT.Text);// aidat int tipi olduğu için stringe dönüştürmek için parse kullanıyoruz
                yeniuye.Mail_Adress = txt_MAIL.Text;
                yeniuye.Aktif = checkBox_AKTIF.Checked;

                BLUye.uyeEkle(yeniuye); //businesslayer'da yapmış olduğuz uye ekleme işlemini çağırıyoruz
                MessageBox.Show("Yeni Üye Eklendi");
            }
            

            listele();
        }

        private void btn_Mevcutuye_Click(object sender, EventArgs e) //üye güncelle butonu
        {
            // eğer üye güncelleme esnasında boş bir nesne olması durumunda uyarı mesajı ekliyoruz
            if (txt_AD.Text == "" || txt_SOYAD.Text == "" || txt_YAS.Text == "" || txt_SEHİR.Text == "" || dT_TARIH.Text == "" || comboBox_KAN.Text == "" || txt_AIDAT.Text == "" || txt_MAIL.Text == "" )
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız.");
            }
            //boş bir nesne yoksa üye güncelleme işlemini gerçekleştiriyoruz
            else
            {
                EntityUye yeniuye = new EntityUye();

                yeniuye.Uye_Ad = txt_AD.Text;
                yeniuye.Uye_Soyad = txt_SOYAD.Text;
                yeniuye.Yas = int.Parse(txt_YAS.Text); // yas int tipi olduğu için stringe dönüştürmek için parse kullanıyoruz
                yeniuye.Sehir = txt_SEHİR.Text;
                yeniuye.Kayit_Tarihi = DateTime.Parse(dT_TARIH.Text); // tarih datetime tipi olduğu için stringe dönüştürmek için parse kullanıyoruz
                yeniuye.Kan_Grubu = comboBox_KAN.Text;
                yeniuye.Aidat = int.Parse(txt_AIDAT.Text); // aidat int tipi olduğu için stringe dönüştürmek için parse kullanıyoruz
                yeniuye.Mail_Adress = txt_MAIL.Text;
                yeniuye.Aktif = checkBox_AKTIF.Checked;

                BLUye.uyeGuncelle(yeniuye); //businesslayer'da yapmış olduğuz uye ekleme işlemini çağırıyoruz
                MessageBox.Show("Üye Düzenlendi");
            }
            

            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btn_Uyesil_Click(object sender, EventArgs e)//silme butonu
        {
            if(txt_TC.Text == "")
            {
                MessageBox.Show("Lütfen silinecek kişiyi seçiniz");
            }
            else
            {
                EntityUye yeniuye = new EntityUye();
                yeniuye.TC_No = int.Parse(txt_TC.Text);
                BLUye.uyeSil(yeniuye);

                MessageBox.Show("Üye silindi");
            }
            listele(); //sayfayı yeniliyor
        }

        private void advancedDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //ekranda gözüken isimlere çift tıklandığında karşılığı olan nesneye değerleri yerleştiren kod bloğu
            txt_TC.Text = advancedDataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_AD.Text = advancedDataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_SOYAD.Text = advancedDataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_YAS.Text = advancedDataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_SEHİR.Text = advancedDataGridView1.CurrentRow.Cells[4].Value.ToString();
            dT_TARIH.Text = advancedDataGridView1.CurrentRow.Cells[5].Value.ToString();
            comboBox_KAN.Text = advancedDataGridView1.CurrentRow.Cells[6].Value.ToString();
            txt_AIDAT.Text = advancedDataGridView1.CurrentRow.Cells[7].Value.ToString();
            txt_MAIL.Text = advancedDataGridView1.CurrentRow.Cells[8].Value.ToString();
            checkBox_AKTIF.Text = advancedDataGridView1.CurrentRow.Cells[9].Value.ToString();


        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            listele(); //yenile butonu
        }

        private void advancedDataGridView1_SortStringChanged(object sender, EventArgs e)
        {
            dt.DefaultView.Sort = advancedDataGridView1.SortString; // A-Z , Z-A sıralama yapmayı sağlayan kod bloğu
        }

        private void advancedDataGridView1_FilterStringChanged(object sender, EventArgs e)
        {
           dt.DefaultView.RowFilter= advancedDataGridView1.FilterString;// filtreleme yapmamızı sağlayan kod bloğu
        }

        private void btn_Grafik_Click(object sender, EventArgs e) //grafik formuna gitmemizi sağlayan kod bloğu
        {
            ÜyeGrafik frm = new ÜyeGrafik();
            frm.ShowDialog();

        }
    }
}
