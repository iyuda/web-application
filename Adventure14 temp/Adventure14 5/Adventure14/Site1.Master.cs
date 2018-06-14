using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

namespace Adventure14
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        public object ClientScript { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            Response.AppendHeader("Refresh", Convert.ToString((Session.Timeout * 60)) + "; URL=SessionOut.html");
            Response.CacheControl = "no-cache";
            Response.AddHeader("Pragma", "no-cache");
            Response.Expires = -1;
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Cache.SetExpires(DateTime.Now.AddSeconds(-1));
            Response.Cache.SetNoStore();

            LoadMenu();
            LoadInfoValue();

            if (!IsPostBack)
            {
                LoadFooter();
                            
            }
            else
            {
                if(txtCommand.Value == "LogOut")
                {
                    LogOutMe();
                }
            }
            

            SetMenu();
        }


        #region Main

        private void LoadFooter()
        {
            tdFooter.InnerHtml = "Copyright " + DateTime.Now.Year.ToString() + "&nbsp;&nbsp;All rights reserved.";
        }
        private void LoadMenu()
        {
            DataSet ds = new DataSet();
            ds.ReadXml(Server.MapPath("~/XML/MenuTop.xml"));
            topMenu.Items.Clear();

            DataView dv = new DataView(ds.Tables[0], "isCHILD='0'", "SORT", DataViewRowState.CurrentRows);
            DataView dvC = new DataView(ds.Tables[0], "isCHILD='1'", "SORT", DataViewRowState.CurrentRows);

            foreach (DataRowView dr in dv)
            {
                MenuItem mi = new MenuItem()
                {
                    Text = dr["NAME"].ToString(),
                    Value = dr["ID"].ToString(),
                    NavigateUrl = dr["URL"].ToString(),
                    ToolTip = dr["HELP"].ToString()
                };

                switch(mi.Value)
                {
                    case ("3"):
                        foreach(DataRowView drC in dvC)
                        {
                            MenuItem miC = new MenuItem()
                            {
                                Text = drC["NAME"].ToString(),
                                Value = drC["ID"].ToString(),
                                NavigateUrl = drC["URL"].ToString(),
                                ToolTip = drC["HELP"].ToString()
                            };
                            
                            mi.ChildItems.Add(miC);
                        }
                        break;
                }

                topMenu.Items.Add(mi);
            }


        }
        private void SetMenu()
        {
            MenuItemCollection mCol = topMenu.Items;
            if(Session["Menu"] != null)
            {
                string page = Session["Menu"].ToString();

                foreach(MenuItem mi in mCol)
                {
                    if(mi.Value.Equals(page))
                    {
                        mi.Selected = true;
                        break;
                    }
                }
            }
            
           

        }
        private void LoadInfoValue()
        {
            string computerIndetity = WindowsIdentity.GetCurrent().Name;

            string [] _splitCI = computerIndetity.Split(Convert.ToChar("\\"));

            topInfo.InnerHtml = "Machine: " + _splitCI[0] + " | " + "User: " +
                 "<a href = \"javascript: UserWelcome('" +  _splitCI[1] + "')\">" + _splitCI[1] + "</ a >";

            Button btnLO = new Button();

            btnLO.ID = "btnLogour";
            btnLO.CssClass = "menuButton";
            btnLO.Text = "Log Out";
            btnLO.Width = new Unit(80);
            btnLO.OnClientClick = "return LogOutApp()";
          

            logOut.Controls.Add(btnLO);

        }

        private void LogOutMe()
        {
            Session.Abandon();
            Application.Clear();
            Response.Redirect("Logout.html");

            //Server.Transfer("Logout.html");

            //StringBuilder sb = new StringBuilder();

            //sb.Append(@"<script language='javascript'>");
            //sb.Append(@"self.close();");
            //sb.Append(@"</script>");

            ////Page.RegisterClientScriptBlock("JSClose", sb.ToString());  //Workable but obsolete....

            //Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "JSClose", sb.ToString());

        }

        #endregion

    }
}