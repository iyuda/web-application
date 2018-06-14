using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string name = Session["name"] as string;

        if (name != null)
        {
            Label1.Text = name;
        }
        else
        {
            Label1.Text = "nothing entered so far";
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (TextBox1.Text.Trim() != string.Empty)
        {
            Session["name"] = TextBox1.Text;
            Label1.Text = Session["name"] as string;
            TextBox1.Text = string.Empty;
        }
    }
}
