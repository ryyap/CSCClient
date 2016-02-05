using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CSCAssignment2Client
{
    public partial class Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string id ="";
                id= (string)(Session["ID"]);

                int userID = Int32.Parse(id);
                profileservice.UserProfileWebService svc = new profileservice.UserProfileWebService();
                DataSet workDS = new DataSet();
                workDS = svc.getUserProfile(userID);

                usernameText.Text = workDS.Tables[0].Rows[0]["Username"].ToString();
                dobText.Text = workDS.Tables[0].Rows[0]["DateOfBirth"].ToString();
                emailText.Text = workDS.Tables[0].Rows[0]["Email"].ToString();
            }

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
            int count;

            string inUser;
            string inDOB;
            string inEmail;
            string inPass;

            inUser =  usernameText.Text;
            inDOB = dobText.Text;
            inEmail = emailText.Text;
            inPass = passwordText.Text;

            profileservice.UserProfileWebService svc = new profileservice.UserProfileWebService();
            count = svc.updateUserProfile(userID, inPass,inUser, inDOB, inEmail );
            if (count == 1)
            {
                Label1.Text = "Success";
            }
            else {
                Label1.Text = "Fail";
            }
            passwordText.Text="";

        }

        protected void changePasswordButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("ChangePassword.aspx");
        }
    }
}