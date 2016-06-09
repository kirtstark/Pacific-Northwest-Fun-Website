using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PNFun.Models;
using PNFun.DAL;

namespace PNFun.Controllers
{
    public class RecreationSiteController : Controller
    {
        private PNFContext db = new PNFContext();
        int? holdID;

        // GET: /RecreationSite/
        public ActionResult Index(string category)
        {
            ViewBag.Category = category;
            return View(db.RecreationSiteDb.ToList());
        }

        // GET: /RecreationSite/Select/ID
        public ActionResult Select(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index", "Home");
            }
            holdID = id;
            SubCategory subcat = db.SubCategoryDb.Find(id);

            var recsites = db.RecreationSiteDb.Where(b => (db.LinkSubCategoryToSiteDb.Where(a => a.SubCategoryId == id).Select(a => a.LinkedToId)).Contains(b.ID)).ToList();

            ViewBag.Background = subcat.BackgroundPhotoLocation;
            ViewBag.Sites = recsites;
            return View(recsites);
        }

        // GET: /RecreationSite/PhotoList
        public ActionResult PhotoList(string category)
        {
            // query for matching category
            ViewBag.Category = category;
            return View(db.RecreationSiteDb.ToList());
        }

        // GET: /RecreationSite/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RecreationSite recreationsite = db.RecreationSiteDb.Find(id);
            if (recreationsite == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID = holdID;
            ViewBag.weather = "http://www.weather.com/weather/today/";
            return View(recreationsite);
        }

        // GET: /RecreationSite/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /RecreationSite/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="ID,Name,Rating,access,restrooms,Cost,Directions,ImageString,MapLink,Zipcode")] RecreationSite recreationsite)
        {
            if (ModelState.IsValid)
            {
                db.RecreationSiteDb.Add(recreationsite);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(recreationsite);
        }

        // GET: /RecreationSite/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RecreationSite recreationsite = db.RecreationSiteDb.Find(id);
            if (recreationsite == null)
            {
                return HttpNotFound();
            }
            return View(recreationsite);
        }

        // POST: /RecreationSite/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="ID,Name,Rating,access,restrooms,Cost,Directions,ImageString,MapLink,Zipcode")] RecreationSite recreationsite)
        {
            if (ModelState.IsValid)
            {
                db.Entry(recreationsite).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(recreationsite);
        }

        // GET: /RecreationSite/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RecreationSite recreationsite = db.RecreationSiteDb.Find(id);
            if (recreationsite == null)
            {
                return HttpNotFound();
            }
            return View(recreationsite);
        }

        // POST: /RecreationSite/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RecreationSite recreationsite = db.RecreationSiteDb.Find(id);
            db.RecreationSiteDb.Remove(recreationsite);
            db.SaveChanges();
            return RedirectToAction("Index");
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
