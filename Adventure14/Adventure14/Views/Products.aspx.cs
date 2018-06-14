using Adventure14.DataWebService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace Adventure14.Views
{
    public partial class Products : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["Menu"] = 3;

            //if(!IsPostBack)
            //{
                if (optCultureEN.Checked) { GetData("en"); }
          //  }
          Button2.OnClientClick = "return UserWelcome('" + "1" + "');";
        }


        #region Main

        private void GetData(string culture)
        {
            WebService1SoapClient ws1 = new WebService1SoapClient();
            List<ProductView> lstProd = ws1.getProductCulture(culture).ToList();
            tdRecodrCount.InnerHtml = "Total # of records: " + lstProd.Count() + "&nbsp;&nbsp; &nbsp;Culture: " + culture;
            MakeGrid(lstProd);
        }

        private void MakeGrid(List<ProductView> lst)
        {
            HtmlTable tbl = new HtmlTable();
            HtmlTableRow tr;
            HtmlTableCell tc;

            //Header
            tr = new HtmlTableRow();

            tc = new HtmlTableCell();
            tc.Attributes.Add("style", "background-color:#507CD1;font-weight:bold;color: white;");
            tc.InnerHtml = "ProductID";
            tr.Controls.Add(tc);

            tc = new HtmlTableCell();
            tc.Attributes.Add("style", "background-color:#507CD1;font-weight:bold;color:white;");
            tc.InnerHtml = "Name";
            tr.Controls.Add(tc);

            tc = new HtmlTableCell();
            tc.Attributes.Add("style", "background-color:#507CD1;font-weight:bold;color:white;");
            tc.InnerHtml = "Model";
            tr.Controls.Add(tc);

            tc = new HtmlTableCell();
            tc.Attributes.Add("style", "background-color:#507CD1;font-weight:bold;color:white;");
            tc.InnerHtml = "Description";
            tr.Controls.Add(tc);

            tbl.Controls.Add(tr);

            int r = 1;
            //Table content
            foreach(var p in lst)
            {
                tr = new HtmlTableRow();
                tc = new HtmlTableCell();
                
                if (r % 2 != 0) //Odd
                {
                    tr.Attributes.Add("style", "background-color:#CBD4D3;color:black;");
                }
                else //Even
                {
                    tr.Attributes.Add("style", "background-color:white;color:black;");
                }
                tc.Align = "right";
               // tc.InnerHtml = p.ProductID;
              //  tc.InnerHtml = "<a href = \"javascript: ClickTheLink('" + p.ProductID + "')\">" + p.ProductID + "</ a >";
                LinkButton lb = new LinkButton();
                lb.Text = p.ProductID;
                lb.OnClientClick = "ClickTheLink('" + p.ProductID + "');";
                tc.Controls.Add(lb);
               // tc.InnerHtml += "< a href = "http://coffeecup.com" > &nbsp;</ a ></ td >
                tr.Controls.Add(tc);

                tc = new HtmlTableCell();
                tc.Align = "left";
                tc.InnerHtml = p.Name;
                tr.Controls.Add(tc);

                tc = new HtmlTableCell();
                tc.Align = "left";
                tc.InnerHtml = p.ProductModel;
                tr.Controls.Add(tc);


                tc = new HtmlTableCell();
                tc.Align = "left";
                tc.InnerHtml = p.Description;
                tr.Controls.Add(tc);

                r += 1;
                tbl.Controls.Add(tr);

            }

            tdContent.Controls.Add(tbl);
        }

        #endregion

        protected void optCultureEN_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;

            switch (rb.ID)
            {
                case "optCultureAR":
                    GetData("ar");
                    break;
                case "optCultureHR":
                    GetData("he");
                    break;
                case "optCultureFR":
                    GetData("fr");
                    break;
                case "optCultureGE":
                    GetData("th");
                    break;
                default: //English
                    GetData("en");
                    break;
            }
            
        }
    }
}