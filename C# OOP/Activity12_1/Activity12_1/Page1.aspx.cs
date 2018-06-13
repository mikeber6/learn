using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Activity12_1
{
    public partial class Page1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                lblMessage.Text = "Hello " + txtName.Text;
            }
        }

        protected void rblFontColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(rblFontColor.SelectedItem.Value == "Red")
            {
                lblMessage.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lblMessage.ForeColor = System.Drawing.Color.Black;
            }
        }
    }
}