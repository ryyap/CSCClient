using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace CSCAssignment2Client
{
    public partial class Activation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {   string activationCode = !string.IsNullOrEmpty(Request.QueryString["ActivationCode"]) ? Request.QueryString["ActivationCode"] : Guid.Empty.ToString();
                
                emailservice.EmailWebService em =new emailservice.EmailWebService();
                bool validated=em.ValidateActivation(activationCode);
                
                            if (validated == true)
                            {
                               lblMessage.Text= "Activation successful. ";
                           
                            }
                            else
                            {
                                lblMessage.Text = "Invalid Activation code.";
                            }
                        }
                    }
                }
            }
