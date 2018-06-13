using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Page1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        int count;
        if (IsPostBack)
        {
            if(ViewState["count"] != null)
            {
                count = (int)ViewState["count"];
                count++;
                ViewState["count"] = count;
            }
            else
            {
                count = 1;
                ViewState.Add("count", count);
            }

        }
        Response.Write(ViewState["count"]);
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        HttpCookie visitor = new HttpCookie("visitor");
        visitor.Expires = DateTime.Now.AddDays(1);
        visitor.Value = TextBox1.Text;
        Response.Cookies.Add(visitor);
        Server.Transfer("page2.aspx");
    }
}