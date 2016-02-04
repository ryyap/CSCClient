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
                int userID = 1;
                profileservice.UserProfileWebService svc = new profileservice.UserProfileWebService();
                DataSet workDS = new DataSet();
                workDS = svc.getUserProfile(userID);

                usernameText.Text = workDS.Tables[0].Rows[0]["Username"].ToString();
                dobText.Text = workDS.Tables[0].Rows[0]["DateOfBirth"].ToString();
                emailText.Text = workDS.Tables[0].Rows[0]["Email"].ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int userID = 1;
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
    }
}