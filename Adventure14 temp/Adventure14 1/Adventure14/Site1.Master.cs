using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Adventure14
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            tdFooter.InnerHtml = "Copyright " + DateTime.Now.Year.ToString() + "&nbsp;&nbsp;All rights reserved.";

        }
    }
}