using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CSCAssignment2Client
{
    public partial class ChangePassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            oldPasswordText.Attributes["type"] = "password";
            newPasswordText.Attributes["type"] = "password";
            TextBox2.Attributes["type"] = "password";
            bool val1 = (System.Web.HttpContext.Current.User != null) && System.Web.HttpContext.Current.User.Identity.IsAuthenticated;
            if (val1 == true)
            {
                lblUser.Visible = true;
                lblUser.Text = Context.User.Identity.Name;
                lblLogin.Visible = false;
                lblGallery.Visible = true;
                lblLogout.Visible = true;
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
                lblChangePassword.Visible = false;
                lblProfile.Visible = false;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int userID = 6;
            string inNewPass;
            string inOldPass;
            int count;

            inNewPass = newPasswordText.Text;
            inOldPass = oldPasswordText.Text;

            profileservice.UserProfileWebService svc = new profileservice.UserProfileWebService();
           count = svc.changePassword(userID,inOldPass,inNewPass);
           if (count == 1)
           {
               Label1.Text = "Your password has been successfully changed!";
           }
           else
           {
               Label1.Text = "Fail";
           }

           newPasswordText.Text="";
           oldPasswordText.Text="";
           TextBox2.Text = "";
        }
    }
}