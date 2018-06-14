using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Adventure14.DataWebService;
using System.Web.Script.Serialization;
using System.Threading;

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
                //To do based on hidde value get right method....
                if(txtParams.Value != string.Empty)
                {
                    if(txtParams.Value.IndexOf("Search") > -1)
                    {
                        var par = txtParams.Value.Split(Convert.ToChar(":"));
                        DoSearch(par[1]);
                    }
                }
                
            }

            //imgFilter.Attributes.Add("onclick", "javascript: return SearchMe('" + cboDepartment.ClientID + "');");
            //btnSeachMe.OnClientClick = "return SearchMe('" + cboDepartment.ClientID + "');";  //Regular ASP button
            btnSearchMe.OnClientClick = "return SearchMe('" + cboDepartment.ClientID + "');";


        }


        #region Main

        private void LoadComboDepartment()
        {
            WebService1SoapClient ws = new WebService1SoapClient();
            List<Departments> lstD = ws.getListDepartments().ToList();

            foreach(Departments d in lstD)
            {
                cboDepartment.Items.Add(new ListItem(d.Name, d.Name));
            }

            cboDepartment.Items.Insert(0, AppGlobal.itemSelect());
            ws = null;
        }
        private void DoSearch(string searchValue)
        {
            WebService1SoapClient ws1 = new WebService1SoapClient();
            List<DepartmentEmployee> lstDE =  ws1.getEmployeeByDepartment(searchValue).ToList();
            ViewState["data"] = lstDE;
            txtParams.Value = string.Empty;
            GridView1.DataSource = lstDE;
            GridView1.DataBind();

        }

        #endregion

        protected void btnSearchMe_Click(object sender, ImageClickEventArgs e)
        {
            ListItem li = (ListItem)cboDepartment.SelectedItem;
            DoSearch(li.Value);
        }
        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if(e.Row.RowType == DataControlRowType.DataRow)
            {
                LinkButton hp = (LinkButton)e.Row.Cells[0].FindControl("LinkButton1");
                if(hp != null)
                {
                    DepartmentEmployee ditem = (DepartmentEmployee)e.Row.DataItem;
                    hp.Text = ditem.BusinessEntityID.ToString();
                    hp.OnClientClick = "return ClickTheLink('" + ditem.BusinessEntityID + "');";
                }
            }

        }
        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            if (ViewState["data"] != null)
            {
                GridView1.DataSource = (List<DepartmentEmployee>)ViewState["data"];
            }
            GridView1.DataBind();
        }
    }
}