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
    public class LinkCategoryToSubCategoryController : Controller
    {
        private PNFContext db = new PNFContext();

        // GET: /LinkCategoryToSubCategory/
        public ActionResult Index()
        {
            return View(db.LinkCategoryToSiteDb.ToList());
        }

        // GET: /LinkCategoryToSubCategory/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LinkCategoryToSubCategory linkcategorytosubcategory = db.LinkCategoryToSiteDb.Find(id);
            if (linkcategorytosubcategory == null)
            {
                return HttpNotFound();
            }
            return View(linkcategorytosubcategory);
        }

        // GET: /LinkCategoryToSubCategory/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /LinkCategoryToSubCategory/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="ID,CategoryId,LinkedToId")] LinkCategoryToSubCategory linkcategorytosubcategory)
        {
            if (ModelState.IsValid)
            {
                db.LinkCategoryToSiteDb.Add(linkcategorytosubcategory);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(linkcategorytosubcategory);
        }

        // GET: /LinkCategoryToSubCategory/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LinkCategoryToSubCategory linkcategorytosubcategory = db.LinkCategoryToSiteDb.Find(id);
            if (linkcategorytosubcategory == null)
            {
                return HttpNotFound();
            }
            return View(linkcategorytosubcategory);
        }

        // POST: /LinkCategoryToSubCategory/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="ID,CategoryId,LinkedToId")] LinkCategoryToSubCategory linkcategorytosubcategory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(linkcategorytosubcategory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(linkcategorytosubcategory);
        }

        // GET: /LinkCategoryToSubCategory/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LinkCategoryToSubCategory linkcategorytosubcategory = db.LinkCategoryToSiteDb.Find(id);
            if (linkcategorytosubcategory == null)
            {
                return HttpNotFound();
            }
            return View(linkcategorytosubcategory);
        }

        // POST: /LinkCategoryToSubCategory/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LinkCategoryToSubCategory linkcategorytosubcategory = db.LinkCategoryToSiteDb.Find(id);
            db.LinkCategoryToSiteDb.Remove(linkcategorytosubcategory);
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
