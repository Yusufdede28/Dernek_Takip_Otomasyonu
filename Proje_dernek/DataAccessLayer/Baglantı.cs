using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class Baglantı
    {
        public static SqlConnection baglan = new SqlConnection("server = DESKTOP-HTPJI1K\\SQLEXPRESS; initial catalog = gorseldb; integrated security = true");
        DataTable dt = new DataTable();
        SqlDataAdapter adtr = new SqlDataAdapter("Select * from Uyeler", baglan);
        

    }
}
