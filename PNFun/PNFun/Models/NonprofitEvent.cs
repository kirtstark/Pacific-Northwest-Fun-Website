using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PNFun.Models
{
    public class NonprofitEvent
    {
        public int ID { get; set; }
        [Required]
        [DataType(DataType.Html)]
        public object Link { get; set; }
        public string PhotoURL { get; set; }
        public string Description { get; set; }
        [Required]
        public string Organization { get; set; }
        [Required]
        public string ContactName { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public object contactPhone { get; set; }
        public bool Verified { get; set; }

        [Required]
        public DateTime Expiration { get; set; }
    }
}