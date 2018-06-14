using AdventureDataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;


namespace WesServiceAW2014
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public List<Employee> ListEmployees()
        {
            List<Employee> lstE = new List<Employee>();

            DataTable tb = DataHelper.getEmployee();
          
            foreach(DataRow dr in tb.Rows)
            {
                Employee emp = new Employee();
                emp.AddressLine1 = dr["AddressLine1"].ToString();
                emp.AddressLine2 = dr["AddressLine2"].ToString();
                emp.BusinessEntityID = int.Parse(dr["BusinessEntityID"].ToString());
                emp.City = dr["City"].ToString();
                emp.Email = dr["EmailAddress"].ToString();
                emp.FirstName = dr["FirstName"].ToString();
                emp.LastName = dr["LastName"].ToString();
                emp.JobTitle = dr["JobTitle"].ToString();
                emp.PhoneNumber = dr["PhoneNumber"].ToString();
                emp.State = dr["StateProvinceName"].ToString();
                emp.Zip = dr["PostalCode"].ToString();

                lstE.Add(emp);

            }

            return lstE;
        }

    }
}
