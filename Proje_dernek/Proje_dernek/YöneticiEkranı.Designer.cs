namespace Proje_dernek
{
    partial class YöneticiEkranı
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.advancedDataGridView1 = new ADGV.AdvancedDataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox_AKTIF = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_MAIL = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox_KAN = new System.Windows.Forms.ComboBox();
            this.txt_SEHİR = new System.Windows.Forms.TextBox();
            this.txt_AIDAT = new System.Windows.Forms.TextBox();
            this.dT_TARIH = new System.Windows.Forms.DateTimePicker();
            this.txt_TC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_AD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_SOYAD = new System.Windows.Forms.TextBox();
            this.txt_YAS = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Uyesil = new System.Windows.Forms.Button();
            this.btn_Grafik = new System.Windows.Forms.Button();
            this.btn_Mevcutuye = new System.Windows.Forms.Button();
            this.btn_yeniuye = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // advancedDataGridView1
            // 
            this.advancedDataGridView1.AutoGenerateContextFilters = true;
            this.advancedDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.advancedDataGridView1.DateWithTime = false;
            this.advancedDataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.advancedDataGridView1.Location = new System.Drawing.Point(0, 0);
            this.advancedDataGridView1.Name = "advancedDataGridView1";
            this.advancedDataGridView1.Size = new System.Drawing.Size(1043, 814);
            this.advancedDataGridView1.TabIndex = 0;
            this.advancedDataGridView1.TimeFilter = false;
            this.advancedDataGridView1.SortStringChanged += new System.EventHandler(this.advancedDataGridView1_SortStringChanged);
            this.advancedDataGridView1.FilterStringChanged += new System.EventHandler(this.advancedDataGridView1_FilterStringChanged);
            this.advancedDataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.advancedDataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.checkBox_AKTIF);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt_MAIL);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.comboBox_KAN);
            this.groupBox1.Controls.Add(this.txt_SEHİR);
            this.groupBox1.Controls.Add(this.txt_AIDAT);
            this.groupBox1.Controls.Add(this.dT_TARIH);
            this.groupBox1.Controls.Add(this.txt_TC);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_AD);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_SOYAD);
            this.groupBox1.Controls.Add(this.txt_YAS);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(1061, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(529, 571);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Üye Bilgileri / Yeni Üye";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(253, 483);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(242, 64);
            this.button1.TabIndex = 40;
            this.button1.Text = "Temizle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox_AKTIF
            // 
            this.checkBox_AKTIF.AutoSize = true;
            this.checkBox_AKTIF.Location = new System.Drawing.Point(77, 483);
            this.checkBox_AKTIF.Name = "checkBox_AKTIF";
            this.checkBox_AKTIF.Size = new System.Drawing.Size(47, 17);
            this.checkBox_AKTIF.TabIndex = 39;
            this.checkBox_AKTIF.Text = "Aktif";
            this.checkBox_AKTIF.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "TC_No :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 487);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Aktiflik :";
            // 
            // txt_MAIL
            // 
            this.txt_MAIL.Location = new System.Drawing.Point(77, 434);
            this.txt_MAIL.Name = "txt_MAIL";
            this.txt_MAIL.Size = new System.Drawing.Size(121, 20);
            this.txt_MAIL.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 437);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Mail Adres :";
            // 
            // comboBox_KAN
            // 
            this.comboBox_KAN.FormattingEnabled = true;
            this.comboBox_KAN.Location = new System.Drawing.Point(77, 340);
            this.comboBox_KAN.Name = "comboBox_KAN";
            this.comboBox_KAN.Size = new System.Drawing.Size(121, 21);
            this.comboBox_KAN.TabIndex = 37;
            // 
            // txt_SEHİR
            // 
            this.txt_SEHİR.Location = new System.Drawing.Point(77, 242);
            this.txt_SEHİR.Name = "txt_SEHİR";
            this.txt_SEHİR.Size = new System.Drawing.Size(100, 20);
            this.txt_SEHİR.TabIndex = 34;
            // 
            // txt_AIDAT
            // 
            this.txt_AIDAT.Location = new System.Drawing.Point(77, 386);
            this.txt_AIDAT.Name = "txt_AIDAT";
            this.txt_AIDAT.Size = new System.Drawing.Size(121, 20);
            this.txt_AIDAT.TabIndex = 35;
            // 
            // dT_TARIH
            // 
            this.dT_TARIH.Location = new System.Drawing.Point(77, 289);
            this.dT_TARIH.Name = "dT_TARIH";
            this.dT_TARIH.Size = new System.Drawing.Size(200, 20);
            this.dT_TARIH.TabIndex = 38;
            // 
            // txt_TC
            // 
            this.txt_TC.Location = new System.Drawing.Point(77, 50);
            this.txt_TC.Name = "txt_TC";
            this.txt_TC.ReadOnly = true;
            this.txt_TC.Size = new System.Drawing.Size(100, 20);
            this.txt_TC.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Şehir :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 389);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Aidat :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Ad :";
            // 
            // txt_AD
            // 
            this.txt_AD.Location = new System.Drawing.Point(77, 100);
            this.txt_AD.Name = "txt_AD";
            this.txt_AD.Size = new System.Drawing.Size(100, 20);
            this.txt_AD.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Soyad :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 343);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Kan Grubu :";
            // 
            // txt_SOYAD
            // 
            this.txt_SOYAD.Location = new System.Drawing.Point(77, 150);
            this.txt_SOYAD.Name = "txt_SOYAD";
            this.txt_SOYAD.Size = new System.Drawing.Size(100, 20);
            this.txt_SOYAD.TabIndex = 32;
            // 
            // txt_YAS
            // 
            this.txt_YAS.Location = new System.Drawing.Point(77, 196);
            this.txt_YAS.Name = "txt_YAS";
            this.txt_YAS.Size = new System.Drawing.Size(100, 20);
            this.txt_YAS.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Yaş :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Kayıt Tarihi :";
            // 
            // btn_Uyesil
            // 
            this.btn_Uyesil.Image = global::Proje_dernek.Properties.Resources.sil;
            this.btn_Uyesil.Location = new System.Drawing.Point(1223, 633);
            this.btn_Uyesil.Name = "btn_Uyesil";
            this.btn_Uyesil.Size = new System.Drawing.Size(156, 133);
            this.btn_Uyesil.TabIndex = 7;
            this.btn_Uyesil.Text = "Üye Sil";
            this.btn_Uyesil.UseVisualStyleBackColor = true;
            this.btn_Uyesil.Click += new System.EventHandler(this.btn_Uyesil_Click);
            // 
            // btn_Grafik
            // 
            this.btn_Grafik.ForeColor = System.Drawing.Color.Red;
            this.btn_Grafik.Image = global::Proje_dernek.Properties.Resources.gggg;
            this.btn_Grafik.Location = new System.Drawing.Point(1562, 633);
            this.btn_Grafik.Name = "btn_Grafik";
            this.btn_Grafik.Size = new System.Drawing.Size(156, 136);
            this.btn_Grafik.TabIndex = 4;
            this.btn_Grafik.Text = "Üye Grafiği";
            this.btn_Grafik.UseVisualStyleBackColor = true;
            this.btn_Grafik.Click += new System.EventHandler(this.btn_Grafik_Click);
            // 
            // btn_Mevcutuye
            // 
            this.btn_Mevcutuye.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Mevcutuye.ForeColor = System.Drawing.Color.Black;
            this.btn_Mevcutuye.Image = global::Proje_dernek.Properties.Resources.aaa;
            this.btn_Mevcutuye.Location = new System.Drawing.Point(1385, 633);
            this.btn_Mevcutuye.Name = "btn_Mevcutuye";
            this.btn_Mevcutuye.Size = new System.Drawing.Size(156, 133);
            this.btn_Mevcutuye.TabIndex = 2;
            this.btn_Mevcutuye.Text = "Üye Güncelle";
            this.btn_Mevcutuye.UseVisualStyleBackColor = true;
            this.btn_Mevcutuye.Click += new System.EventHandler(this.btn_Mevcutuye_Click);
            // 
            // btn_yeniuye
            // 
            this.btn_yeniuye.Image = global::Proje_dernek.Properties.Resources.indir;
            this.btn_yeniuye.Location = new System.Drawing.Point(1061, 633);
            this.btn_yeniuye.Name = "btn_yeniuye";
            this.btn_yeniuye.Size = new System.Drawing.Size(156, 133);
            this.btn_yeniuye.TabIndex = 1;
            this.btn_yeniuye.Text = "Yeni Üye Ekle";
            this.btn_yeniuye.UseVisualStyleBackColor = true;
            this.btn_yeniuye.Click += new System.EventHandler(this.btn_yeniuye_Click);
            // 
            // YöneticiEkranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1789, 814);
            this.Controls.Add(this.btn_Uyesil);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Grafik);
            this.Controls.Add(this.btn_Mevcutuye);
            this.Controls.Add(this.btn_yeniuye);
            this.Controls.Add(this.advancedDataGridView1);
            this.Name = "YöneticiEkranı";
            this.Text = "Yönetici";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ADGV.AdvancedDataGridView advancedDataGridView1;
        private System.Windows.Forms.Button btn_yeniuye;
        private System.Windows.Forms.Button btn_Mevcutuye;
        private System.Windows.Forms.Button btn_Grafik;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox_AKTIF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_MAIL;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox_KAN;
        private System.Windows.Forms.TextBox txt_SEHİR;
        private System.Windows.Forms.TextBox txt_AIDAT;
        private System.Windows.Forms.DateTimePicker dT_TARIH;
        private System.Windows.Forms.TextBox txt_TC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_AD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_SOYAD;
        private System.Windows.Forms.TextBox txt_YAS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Uyesil;
        private System.Windows.Forms.Button button1;
    }
}

