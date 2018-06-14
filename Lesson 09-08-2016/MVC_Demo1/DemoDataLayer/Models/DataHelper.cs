using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DemoDataLayer
{
    public class DataHelper
    {
        public static DataTable GetTableExecuted(string tableName)
        {
            string strSQL = "SELECT * FROM " + tableName;
            DataTable tbl = new DataTable();
            string conString = ConfigurationManager.ConnectionStrings["localDB"].ToString();

            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                using (SqlCommand commd = new SqlCommand(strSQL, con))
                {
                    SqlDataAdapter da = new SqlDataAdapter(commd);
                    da.Fill(tbl);
                }
                con.Close();
            }

            return tbl;
        }

    }
}
