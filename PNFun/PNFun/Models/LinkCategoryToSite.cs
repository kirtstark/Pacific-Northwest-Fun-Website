using PNFun.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PNFun.Models
{
    public class LinkCategoryToSubCategory
    {
        private PNFContext db;
        public int ID { get; set; }
        [Display(Name = "Category")]
        public int CategoryId { get; set; }
        [Display(Name = "Recreational Site")]
        public int LinkedToId { get; set; }

       // public int ExtraCrap { get; set; }

        public LinkCategoryToSubCategory()
        {
            db = new PNFContext();
        }

        public IEnumerable<SelectListItem> AllSubCategories
        {
            get
            {
                var ModelList = (from RecreationSite site in db.RecreationSiteDb
                                select new { ID = site.ID, Name = site.Name }).ToList();
                var ModelSelectList = new SelectList(ModelList, "ID", "Name");
                return ModelSelectList;
            }
        }

        public IEnumerable<SelectListItem> AllCategories
        {
            get
            {
                var ModelList = (from Category category in db.CategoryDb
                                select new { ID = category.ID, Name = category.Name }).ToList();
                var ModelSelectList = new SelectList(ModelList, "ID", "Name");
                return ModelSelectList;
            }
        }

        ~LinkCategoryToSubCategory()
        {            
                db.Dispose();
        }
    }

    public class LinkSubCategoryToSite
    {
        private PNFContext db;
        public int ID { get; set; }
        [Display(Name = "Category")]
        public int SubCategoryId { get; set; }
        [Display(Name = "Recreational Site")]
        public int LinkedToId { get; set; }

        public LinkSubCategoryToSite()
        {
            db = new PNFContext();
        }

        public IEnumerable<SelectListItem> AllRecreationSites
        {
            get
            {
                var ModelList = (from RecreationSite site in db.RecreationSiteDb
                                 select new { ID = site.ID, Name = site.Name }).ToList();
                var ModelSelectList = new SelectList(ModelList, "ID", "Name");
                return ModelSelectList;
            }
        }

        public IEnumerable<SelectListItem> AllCategories
        {
            get
            {
                var ModelList = (from Category category in db.CategoryDb
                                 select new { ID = category.ID, Name = category.Name }).ToList();
                var ModelSelectList = new SelectList(ModelList, "ID", "Name");
                return ModelSelectList;
            }
        }

        ~LinkSubCategoryToSite()
        {            
                db.Dispose();
        }
    }
}