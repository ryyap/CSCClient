using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CSCAssignment2Client
{
    public partial class upload : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bool val1 = (System.Web.HttpContext.Current.User != null) && System.Web.HttpContext.Current.User.Identity.IsAuthenticated;
            if (val1 == true)
            {
                lblUser.Visible = true;
               lblUser.Text=Context.User.Identity.Name;
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            int length = FileUpload1.PostedFile.ContentLength;
            string fileName = FileUpload1.FileName.ToString();
            int userid =  Convert.ToInt32(TextBox1.Text);
            imgservice.ImgWebService imgSvc = new imgservice.ImgWebService();
            blobservice.BlobManager blobSvc = new blobservice.BlobManager();

            byte[] Image = null;


                if (FileUpload1.PostedFile != null && FileUpload1.PostedFile.FileName != "")
                {
                    Image = new byte[FileUpload1.PostedFile.ContentLength];
                    HttpPostedFile UploadedImage = FileUpload1.PostedFile;
                    UploadedImage.InputStream.Read(Image, 0, (int)FileUpload1.PostedFile.ContentLength);

                    string uri = blobSvc.UploadFile(Image, length, fileName); 

                    imgSvc.addImage(userid, Image, uri);

                    //add this line
                    msg.InnerHtml += "<br/> Successfully Added";
                }
                  
            
            else
            {
                msg.InnerHtml = "<br/> Invalid Admin Number";
            }
        }

      
    }
}