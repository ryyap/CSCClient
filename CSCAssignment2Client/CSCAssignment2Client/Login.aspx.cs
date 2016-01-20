using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CSCAssignment2Client
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

       

        protected void loginButton_Click(object sender, EventArgs e)
        {
            //Goes to Registration Web Service to process registration
            registerservice.RegisterWebService obj = new registerservice.RegisterWebService();
            bool login = obj.UserLogin(emailText.Text, passwordText.Text);
            if (login == true)
            {
                Response.Redirect("Default.aspx");
            }
            else
            {
                Label1.Text = "Invalid UserName or Password.";
            }
        }

        protected void registerButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }
    }
}