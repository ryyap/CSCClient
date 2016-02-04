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

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int userID = 1;
            string inNewPass;
            string inOldPass;
            int count;

            inNewPass = newPasswordText.Text;
            inOldPass = oldPasswordText.Text;

            profileservice.UserProfileWebService svc = new profileservice.UserProfileWebService();
           count = svc.changePassword(userID,inOldPass,inNewPass);
           if (count == 1)
           {
               Label1.Text = "Success";
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