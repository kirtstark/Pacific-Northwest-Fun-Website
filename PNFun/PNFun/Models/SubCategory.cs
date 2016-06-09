using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PNFun.Models
{
    public class SubCategory
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string PhotoLocation { get; set; }
        [Required]
        public string BackgroundPhotoLocation { get; set; }
        [Required]
        public string AltDescription { get; set; }
        public int Hits { get; set; }
        public int Ranking { get; set; }
        public static string LinkString { get { return "/RecreationSite/Select"; } }

        public List<RecreationSite> RecreationSites { get; set; }  
    }
}