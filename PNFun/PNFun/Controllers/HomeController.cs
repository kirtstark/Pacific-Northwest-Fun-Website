using PNFun.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PNFun.Controllers
{
    public class HomeController : Controller
    {
        private PNFContext db = new PNFContext();
        public ActionResult Index()
        {
            var PreList = from p in db.CategoryDb
                          select p;
            PreList = PreList.OrderBy(p => p.Ranking);

            ViewBag.Categories = PreList.ToList();
            ViewBag.LinkString = PNFun.Models.Category.LinkString;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Article()
        {
            return View();
        }

        public ActionResult Search()
        {
            ViewBag.SubCategories = new MultiSelectList(db.SubCategoryDb.Select(a => a.Name).ToList());

            List<string> distance = new List<string>();
            string add;
            for (int i = 1; i < 41; i++ )
            {
                add = ((i * 5).ToString() + " miles");
                distance.Add(add);
            }

            ViewBag.Distance = new SelectList(distance);
                return View();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}