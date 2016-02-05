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
                lblWelcome.Text = "Welcome to Smiling Image Sharing," + HttpContext.Current.User.Identity.Name + "!";
                lblUser.Visible = true;
                lblUser.Text = Context.User.Identity.Name;
                lblLogin.Visible = false;
                lblGallery.Visible = true;
                lblLogout.Visible = true;
                loginButton.Visible = false;
                uploadButton.Visible = true;
                lblChangePassword.Visible = true;
                lblProfile.Visible = true;
               
            }
            else
            {
                lblUser.Text = "";
                lblUser.Visible = false;
                lblLogin.Visible = true;
                lblLogout.Visible = false;
                lblGallery.Visible = false;
                lblWelcome.Text = "Welcome to Smiling Image Sharing !";
                loginButton.Visible = true;
                uploadButton.Visible = false;
                lblChangePassword.Visible = true;
                lblProfile.Visible = true;
                lblChangePassword.Visible = false;
                lblProfile.Visible = false;
            }
        }
  

        protected void loginButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void uploadButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("upload.aspx");
        }
    }
}