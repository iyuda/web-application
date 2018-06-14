using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPPoliticalReview
{
    public partial class PoliticalPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            { 
                DataHelper dH = new DataHelper();
                cboPoliticians.DataSource = dH.getPoliticians();
                cboPoliticians.DataBind();
            }
        }

        protected void cboPoliticians_SelectedIndexChanged(object sender, EventArgs e)
        {
            var jp = cboPoliticians.SelectedItem;
            DataHelper dH = new DataHelper();
            List<Politician> lstJ = dH.getPoliticians();
           
            foreach(Politician j in lstJ)
            {
                if (j.ToString().Equals(jp.Text))
                {
                    txtJob.Text = j.JobTitle;
                    txtYOF.Text = j.YearsInOffice.ToString();
                    chkLiberal.Checked = j.isLiberal;
                    break;
                }
            }

           
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}