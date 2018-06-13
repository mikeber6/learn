using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Page3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Write("Session: " + Session["SessionStartTime"]);
        Response.Write("<br/>");
        Response.Write("App: " + Application["ApplicationStartTime"]);
    }
}