using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PNFun.Models
{
    public class RecreationSite
    {
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Page { get; set; }

        public string PhotoLocation { get; set; }

        [Required]
        public string AltDescription { get; set; }

        [Range (0, 10)]
        public float Rating { get; set; }

        [Display(Name = "Ease of Access")]
        public Access access { get; set; }

        [Display(Name = "Restroom Type")]
        public Restrooms restrooms { get; set; }

        [Range(1, 100)]
        [DataType(DataType.Currency)]
        public decimal Cost { get; set; }

        public string Directions { get; set; }
        public string ImageString { get; set; }

        public string MapLink { get; set; }

        public string Zipcode { get; set; }

        public virtual IList<Comments> comments { get; set; }
        public virtual IList<PhotoLink> PhotoLinks { get; set; }
    }

    public enum Access { NA = 1, easy, moderate, average, difficult, impossible}
    public enum Restrooms { NA = 1, none, portables, hole, flush}
}
