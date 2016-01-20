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
            imgservice.ImgWebService svc = new imgservice.ImgWebService();
            DataSet workDS = new DataSet(); 
            workDS = svc.getTenRecentImages();

            foreach (DataRow dr in workDS.Tables[0].Rows)
            {
                display.InnerHtml+="ID :"+ dr["ID"]+"<br/>";
                display.InnerHtml += "Image : <img src=ImageHandler.ashx?imageID=" + dr["ID"] + "height='42' width='42'/><br/><br/>";

            }
        }
    }
}