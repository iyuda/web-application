using Adventure14.DataWebService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Adventure14.Views.PopUp
{
    public partial class EmployeeDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                if(Request.QueryString.Count > 0)
                {
                    int empl = int.Parse(Request.QueryString[0].ToString());
                    LoadData(empl);
                }
            }

        }

        private void LoadData(int employeeID)
        {
            WebService1SoapClient ws1 = new WebService1SoapClient();
            List<DataWebService.Employee> allEmployees = ws1.getListEmployees().ToList();

            var employee = (from E in allEmployees
                           where E.BusinessEntityID == employeeID
                           select E).FirstOrDefault();

            tdName.InnerHtml = "<h2>[" + employee.BusinessEntityID + "]&nbsp;&nbsp;" + employee.LastName.Trim() + ", " + employee.FirstName + "</h2>";

            StringBuilder sb = new StringBuilder();

            sb.Append(employee.AddressLine1);
            sb.Append(Environment.NewLine);
            if (!String.IsNullOrEmpty(employee.AddressLine2))
            {
                sb.Append(employee.AddressLine2);
                sb.Append(Environment.NewLine);
            }
            sb.Append(employee.City.Trim() + ", " + employee.State.Trim() + " " + employee.Zip);

            TextArea1.InnerText = sb.ToString();

        }

    }
}