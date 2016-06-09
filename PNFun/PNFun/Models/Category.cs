using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace PNFun.Models
{
    public class Category
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
        public static string LinkString { get { return "/SubCategory/Select"; } }
        

        public List<SubCategory> SubCategories { get; set; }        
    }
}