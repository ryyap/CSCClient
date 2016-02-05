using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CSCAssignment2Client
{
    public partial class Email : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            passwordText.Attributes["type"] = "password";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string inEmail;
            string inPassword;
            string inReceiver;
            string inBody;
            string inSubject;

            string result;

            inEmail = gmailText.Text;
            inPassword = passwordText.Text;
            inReceiver = receiverText.Text;
            inSubject = subjectText.Text;
            inBody = bodyText.Text;

            emailservice.EmailWebService svc = new emailservice.EmailWebService();
            result = svc.SendEmail(inEmail,inPassword,inReceiver,inSubject,inBody);

            if (result.Equals("OK"))
            {
                Label1.Text = "Success";
            }
            else {
                Label1.Text = "Something went wrong";
            }
        }
    }
}