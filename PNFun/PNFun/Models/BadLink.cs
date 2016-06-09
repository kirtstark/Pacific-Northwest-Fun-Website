using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PNFun.Models
{
    public class BadLink
    {
        public int ID { get; set; }
        public DateTime ReportedDate { get; set; }
        public int RecreactionSiteID { get; set; }
        public int BadUserID { get; set; }


        public bool extraa { get; set; }
    }
}