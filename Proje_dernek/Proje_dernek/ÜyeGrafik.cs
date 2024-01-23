using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Proje_dernek
{
    public partial class ÜyeGrafik : Form
    {

        public ÜyeGrafik()
        {

            InitializeComponent();
            

        }
        //Grafik formu
        private void ÜyeGrafik_Load(object sender, EventArgs e) 
        {
            SqlConnection baglan = new SqlConnection("server = DESKTOP-HTPJI1K\\SQLEXPRESS; initial catalog = gorseldb; integrated security = true");//veri tabanı bağlantısı

            string query = "SELECT Sehir, COUNT(*) as CityCount FROM Uyeler GROUP BY Sehir"; // Şehirleri saymak için sorgu

            Dictionary<string, int> cityCounts = new Dictionary<string, int>();

            using (SqlConnection connection = baglan)
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string city = reader["Sehir"].ToString();
                        int count = Convert.ToInt32(reader["CityCount"]);
                        cityCounts.Add(city, count);
                    }
                    reader.Close();
                }
            }

            // Grafik oluşturma
            Chart chart = new Chart();
            chart.Size = new System.Drawing.Size(800, 600);
            this.Controls.Add(chart);

            // Grafik tipini belirleme (örneğin, sütun grafiği)
            chart.ChartAreas.Add("chartArea");
            chart.Series.Add("CityCount");
            chart.Series["CityCount"].ChartType = SeriesChartType.Column;

            // Verileri grafiğe ekleme
            foreach (var cityCount in cityCounts)
            {
                chart.Series["CityCount"].Points.AddXY(cityCount.Key, cityCount.Value);
            }
        }
    }
}
