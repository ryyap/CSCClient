using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CSCAssignment2Client
{
    public class ImageClass
    {
        public int ID { get; set; }
        public int UploadedBy { get; set; }
        public byte[] ImageData { get; set; }
        public DateTime CreatedAt { get; set; }
        public string URI { get; set; }
    }
}