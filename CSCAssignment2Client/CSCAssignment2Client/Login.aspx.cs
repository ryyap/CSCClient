﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace CSCAssignment2Client
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            passwordText.Attributes["type"] = "password";
        }

       

        protected void loginButton_Click(object sender, EventArgs e)
        { 

            //Goes to Registration Web Service to process registration
            registerservice.RegisterWebService obj = new registerservice.RegisterWebService();
            bool login = obj.UserLogin(emailText.Text, passwordText.Text);
            if (login == true)
            {
                Session["UserName"] = emailText.Text;
                FormsAuthenticationTicket tkt;
                string cookiestr;
                HttpCookie ck;
                tkt = new FormsAuthenticationTicket(1, emailText.Text, DateTime.Now,
          DateTime.Now.AddMinutes(30), chkPersistCookie.Checked, "your custom data");
                cookiestr = FormsAuthentication.Encrypt(tkt);
                ck = new HttpCookie(FormsAuthentication.FormsCookieName, cookiestr);
                if (chkPersistCookie.Checked)
                    ck.Expires = tkt.Expiration;
                ck.Path = FormsAuthentication.FormsCookiePath;
                Response.Cookies.Add(ck);

                string strRedirect;

                Session["ID"] = obj.getUserID(emailText.Text, passwordText.Text);

                strRedirect = Request["ReturnUrl"];
                if (strRedirect == null)
                    strRedirect = "DisplayImages.aspx";
                Response.Redirect(strRedirect, true);
                

                /*
                id = (string)(Session["ID"]);

                string script = "<script type=\"text/javascript\">alert('" + id + "');</script>";
                ClientScript.RegisterClientScriptBlock(this.GetType(), "Alert", script);
                 * */
            }
            else
            {
                emailText.Text = string.Empty;
                passwordText.Text = string.Empty;
                Label1.Text = "Invalid UserName or Password. Please Try again.";
            }
        }

        protected void registerButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }
    }
}