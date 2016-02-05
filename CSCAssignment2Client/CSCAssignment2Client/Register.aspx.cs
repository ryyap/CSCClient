using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CSCAssignment2Client
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            passwordText.Attributes["type"] = "password";
        }

        protected void RegisterButton_Click(object sender, EventArgs e)
        {
            //Goes to Registration Web Service to process registration

            registerservice.RegisterWebService obj = new registerservice.RegisterWebService();
             bool register=obj.RegisterUser(usernameText.Text, passwordText.Text, dateofbirthCal.SelectedDate.ToString(),emailText.Text);
            if (register==true)

            {   //Login user and set session id
                emailservice.EmailWebService em = new emailservice.EmailWebService();
               

            
                string id = obj.getUserID(emailText.Text, passwordText.Text);
                Session["ID"] = id;

                int intID = Int32.Parse(id);
                em.SendActivationEmail(intID,emailText.Text,usernameText.Text);
                Response.Redirect("Login.aspx");
               
            }
            else
            {
                usernameText.Text = passwordText.Text = emailText.Text = string.Empty;
                Label1.Text = "Registration failed as either Username or email has already been used! Please Try again!";
            }
        }

        protected void homeButton_Click(object sender, EventArgs e)
        { 
            Response.Redirect("Default.aspx");
        }
    }
}