using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Adventure14.DataWebService;

namespace Adventure14.Views
{
    public partial class Employee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["Menu"] = 3;
            
            if(!IsPostBack)
            {
                LoadComboDepartment();
            }
            else
            {
                //To do based on hidden value get right method....

                if (txtSearch.Value != "")
                {
                    LoadComboEmployeesByDepartment(txtSearch.Value);
                   // 
                }
            }

            imgFilter.Attributes.Add("onclick", "javascript: return SearchMe('" + cboDepartment.ClientID + "');");
        }


        #region Main
        private void LoadComboEmployeesByDepartment(string Dept)
        {

            WebService1SoapClient ws = new WebService1SoapClient();
            List<DepartmentEmployee > lstD = ws.getEmployeeByDepartment (Dept).ToList();

            foreach (DepartmentEmployee d in lstD)
            {
                cboEmployees .Items.Add(new ListItem(d.EmployeeName , d.EmployeeName ));
            }

        //    cboEmployees.Items.Insert(0, AppGlobal.itemSelect());
        }
        private void LoadComboDepartment()
        {

            WebService1SoapClient ws = new WebService1SoapClient();
            List<Departments> lstD = ws.getListDepartments().ToList();

            foreach(Departments d in lstD)
            {
                cboDepartment.Items.Add(new ListItem(d.Name, d.Name));
            }

            cboDepartment.Items.Insert(0, AppGlobal.itemSelect());
        }

        #endregion
    }

}