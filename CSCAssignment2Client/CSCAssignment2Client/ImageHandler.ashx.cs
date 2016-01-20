using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace CSCAssignment2Client
{
    /// <summary>
    /// Summary description for ImageHandler
    /// </summary>
    public class ImageHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.Clear();
            context.Response.ContentType = "image/jpeg";
            imgservice.ImgWebService svc = new imgservice.ImgWebService();


            //try catch to be removed after testing


            if (context.Request.QueryString["imageID"] != null)
            {
                int ID = 0;
                //ID =  Convert.ToInt32(context.Request.QueryString["imageID"]);
                ID = 98;
                MemoryStream memoryStream = new MemoryStream(
                    svc.getImagesByImageID(ID),false
                    );
                System.Drawing.Image imgFromDataBase = System.Drawing.Image.FromStream(memoryStream);
                imgFromDataBase.Save(context.Response.OutputStream, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}