using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using AdventureDataLayer;
using System.Configuration;

namespace WesServiceAW2014
{
    public class DataHelper
    {
        public static DataTable getEmployee()
        {
            DataTable tE = new DataTable();
            string strSQL = ConfigurationManager.ConnectionStrings["localSQL"].ToString();

            using (SqlConnection cn = new SqlConnection(strSQL))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM [AdventureWorks2014].[HumanResources].[vEmployee]", cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                cn.Open();
                da.Fill(tE);
                cn.Close();
            }

           return tE;
        }
    }
}
