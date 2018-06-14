using Adventure14.DataWebService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Adventure14.Views
{
    public partial class Products : System.Web.UI.Page
    {
        private void LoadComboProduct()
        {
            WebService1SoapClient ws = new WebService1SoapClient();
            List<Departments> lstD = ws.getListDepartments().ToList();

            foreach (Departments d in lstD)
            {
                cboProduct.Items.Add(new ListItem(d.Name, d.Name));
            }

            cboProduct.Items.Insert(0, AppGlobal.itemSelect());
            ws = null;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["Menu"] = 3;
            if (!IsPostBack)
            {
                LoadComboProduct();
            }
            else
            {
                //To do based on hidde value get right method....
                if (txtParams.Value != string.Empty)
                {
                    if (txtParams.Value.IndexOf("Search") > -1)
                    {
                        var par = txtParams.Value.Split(Convert.ToChar(":"));
                        DoSearch(par[1]);
                    }
                }

            }

            //imgFilter.Attributes.Add("onclick", "javascript: return SearchMe('" + cboDepartment.ClientID + "');");
            //btnSeachMe.OnClientClick = "return SearchMe('" + cboDepartment.ClientID + "');";  //Regular ASP button
            btnSearchMe.OnClientClick = "return SearchMe('" + cboProduct.ClientID + "');";
        }
    }
}