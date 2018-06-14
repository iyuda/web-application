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

        public static DataTable getDepartment()
        {
            DataTable tD = new DataTable();
            string strSQL = ConfigurationManager.ConnectionStrings["localSQL"].ToString();

            using (SqlConnection cn = new SqlConnection(strSQL))
            {
                SqlCommand cmd = new SqlCommand("[HumanResources].[AllDepartments]", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                cn.Open();
                da.Fill(tD);
                cn.Close();
            }

            return tD;
        }

        public static DataTable getDepartmentEmployee(string department)
        {
            DataTable tDE = new DataTable();
            string strSQL = ConfigurationManager.ConnectionStrings["localSQL"].ToString();

            using (SqlConnection cn = new SqlConnection(strSQL))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM [AdventureWorks2014].[HumanResources].[vEmployeeDepartment] WHERE Department = '" + department + "'", cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                cn.Open();
                da.Fill(tDE);
                cn.Close();
            }

            return tDE;
        }

    }
}
