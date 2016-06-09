using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PNFun.Models
{
    public class Comments
    {
        public int ID { get; set; }


        [StringLength(556, MinimumLength = 3)]
        public string Comment { get; set; }

        public int UserID { get; set; }

        public int RecreationSiteId { get; set; }
        public virtual RecreationSite RecreationSite { get; set; }

    }
}