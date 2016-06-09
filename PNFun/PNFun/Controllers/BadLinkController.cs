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
    public class BadLinkController : Controller
    {
        private PNFContext db = new PNFContext();

        //Temperary view for demo
        public ActionResult Fire()
        {
            return View();
        }
        // GET: /BadLink/
        public ActionResult Index()
        {
            return View(db.BadLinkDb.ToList());
        }

        // GET: /BadLink/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BadLink badlink = db.BadLinkDb.Find(id);
            if (badlink == null)
            {
                return HttpNotFound();
            }
            return View(badlink);
        }

        // GET: /BadLink/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /BadLink/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="ID,ReportedDate,RecreactionSiteID,BadUserID")] BadLink badlink)
        {
            if (ModelState.IsValid)
            {
                db.BadLinkDb.Add(badlink);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(badlink);
        }

        // GET: /BadLink/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BadLink badlink = db.BadLinkDb.Find(id);
            if (badlink == null)
            {
                return HttpNotFound();
            }
            return View(badlink);
        }

        // POST: /BadLink/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="ID,ReportedDate,RecreactionSiteID,BadUserID")] BadLink badlink)
        {
            if (ModelState.IsValid)
            {
                db.Entry(badlink).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(badlink);
        }

        // GET: /BadLink/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BadLink badlink = db.BadLinkDb.Find(id);
            if (badlink == null)
            {
                return HttpNotFound();
            }
            return View(badlink);
        }

        // POST: /BadLink/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BadLink badlink = db.BadLinkDb.Find(id);
            db.BadLinkDb.Remove(badlink);
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
