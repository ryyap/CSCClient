using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace CSCAssignment2Client
{
    public partial class DisplayImages : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                int userID = 6;
                //userID = Int32.Parse(Request.QueryString["userid"]);
                imgservice.ImgWebService svc = new imgservice.ImgWebService();
                DataSet workDS = new DataSet();
                workDS = svc.getRecordsByUser(userID);

                imgData.DataSource = svc.getRecordsByUser(userID);
                imgData.DataBind();
            }
            bool val1 = (System.Web.HttpContext.Current.User != null) && System.Web.HttpContext.Current.User.Identity.IsAuthenticated;
            if (val1 == true)
            {
                lblUser.Visible = true;
                lblUser.Text = Context.User.Identity.Name;
                lblLogin.Visible = false;
                lblGallery.Visible = true;
                lblLogout.Visible = true;


            }
            else
            {
                lblUser.Text = "";
                lblUser.Visible = false;
                lblLogin.Visible = true;
                lblLogout.Visible = false;
                lblGallery.Visible = false;
            }
        }

        protected void imgData_RowDataBound(object sender, GridViewRowEventArgs e)
        {

            /*
            imgservice.ImgWebService svc = new imgservice.ImgWebService();
            DataSet workDS = new DataSet();
            workDS = svc.getTenRecentImages();
            foreach (DataRow dr in workDS.Tables[0].Rows)
            {

            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                
                    e.Row.Cells[1].Text = "<img src=ImageHandler.ashx?imageID=" + dr["ID"] + "&height='42' width='42'/><br/><br/>";

                }
                //  e.Row.Cells[1].Text = "<img src=ImageHandler.ashx?imageID=98 height='42' width='42'/><br/><br/>";

            }
            */

           
        }

        protected void imgData_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            imgservice.ImgWebService svc = new imgservice.ImgWebService();
            string rowIndex = e.CommandArgument.ToString();
            int id = Int32.Parse(imgData.DataKeys[Int32.Parse(rowIndex)].Value.ToString());
            if (e.CommandName == "deleteCommand")
            {
                svc.deleteOneImageRecord(id);

                DataSet workDS = new DataSet();
                workDS = svc.getTenRecentImages();


                imgData.DataSource = svc.getTenRecentImages();
                imgData.DataBind();
            }
            {
            }
        }

        protected void uploadButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("upload.aspx");
        }
    }
}