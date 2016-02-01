using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CSCAssignment2Client
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bool val1 = (System.Web.HttpContext.Current.User != null) && System.Web.HttpContext.Current.User.Identity.IsAuthenticated;
            if (val1 == true)
            {
                //lblWelcome.Text = "Welcome to Smiling Image Sharing!" + Context.User.Identity.Name;
                lblLogin.Text = "Logout";
                lblWelcome.Text="Welcome to Smiling Image Sharing!" + HttpContext.Current.Session["UserName"];
            }
        }
  

        protected void loginButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}