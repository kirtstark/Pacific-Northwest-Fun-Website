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
    public class LinkSubCategoryToSiteController : Controller
    {
        private PNFContext db = new PNFContext();

        // GET: /LinkSubCategoryToSite/
        public ActionResult Index()
        {
            return View(db.LinkSubCategoryToSiteDb.ToList());
        }

        // GET: /LinkSubCategoryToSite/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LinkSubCategoryToSite linksubcategorytosite = db.LinkSubCategoryToSiteDb.Find(id);
            if (linksubcategorytosite == null)
            {
                return HttpNotFound();
            }
            return View(linksubcategorytosite);
        }

        // GET: /LinkSubCategoryToSite/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /LinkSubCategoryToSite/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="ID,CategoryId,LinkedToId")] LinkSubCategoryToSite linksubcategorytosite)
        {
            if (ModelState.IsValid)
            {
                db.LinkSubCategoryToSiteDb.Add(linksubcategorytosite);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(linksubcategorytosite);
        }

        // GET: /LinkSubCategoryToSite/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LinkSubCategoryToSite linksubcategorytosite = db.LinkSubCategoryToSiteDb.Find(id);
            if (linksubcategorytosite == null)
            {
                return HttpNotFound();
            }
            return View(linksubcategorytosite);
        }

        // POST: /LinkSubCategoryToSite/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="ID,CategoryId,LinkedToId")] LinkSubCategoryToSite linksubcategorytosite)
        {
            if (ModelState.IsValid)
            {
                db.Entry(linksubcategorytosite).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(linksubcategorytosite);
        }

        // GET: /LinkSubCategoryToSite/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LinkSubCategoryToSite linksubcategorytosite = db.LinkSubCategoryToSiteDb.Find(id);
            if (linksubcategorytosite == null)
            {
                return HttpNotFound();
            }
            return View(linksubcategorytosite);
        }

        // POST: /LinkSubCategoryToSite/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LinkSubCategoryToSite linksubcategorytosite = db.LinkSubCategoryToSiteDb.Find(id);
            db.LinkSubCategoryToSiteDb.Remove(linksubcategorytosite);
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
