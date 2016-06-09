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
    public class SubCategoryController : Controller
    {
        private PNFContext db = new PNFContext();

        // GET: /RecreationSite/Select/ID
        public ActionResult Select(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index", "Home");
            }

            Category cat = db.CategoryDb.Find(id);

            var subcategories = (from sc in db.SubCategoryDb
                                 where (from link in db.LinkCategoryToSiteDb
                                            where link.CategoryId == id
                                            select link.LinkedToId).Contains(sc.ID)
                                 select sc).OrderBy(p => p.Ranking).ToList();

            ViewBag.Background = cat.BackgroundPhotoLocation;
            ViewBag.LinkString = SubCategory.LinkString;
            ViewBag.Categories = subcategories;
            return View();
        }

        // GET: /SubCategory/
        public ActionResult Index()
        {
            return View(db.SubCategoryDb.ToList());
        }

        // GET: /SubCategory/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SubCategory subcategory = db.SubCategoryDb.Find(id);
            if (subcategory == null)
            {
                return HttpNotFound();
            }
            return View(subcategory);
        }

        // GET: /SubCategory/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /SubCategory/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="ID,Name,PhotoLocation,BackgroundPhotoLocation,AltDescription,Hits,Ranking")] SubCategory subcategory)
        {
            if (ModelState.IsValid)
            {
                db.SubCategoryDb.Add(subcategory);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(subcategory);
        }

        // GET: /SubCategory/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SubCategory subcategory = db.SubCategoryDb.Find(id);
            if (subcategory == null)
            {
                return HttpNotFound();
            }
            return View(subcategory);
        }

        // POST: /SubCategory/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="ID,Name,PhotoLocation,BackgroundPhotoLocation,AltDescription,Hits,Ranking")] SubCategory subcategory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(subcategory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(subcategory);
        }

        // GET: /SubCategory/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SubCategory subcategory = db.SubCategoryDb.Find(id);
            if (subcategory == null)
            {
                return HttpNotFound();
            }
            return View(subcategory);
        }

        // POST: /SubCategory/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SubCategory subcategory = db.SubCategoryDb.Find(id);
            db.SubCategoryDb.Remove(subcategory);
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
