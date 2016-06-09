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
    public class MessageBoardController : Controller
    {
        private PNFContext db = new PNFContext();

        // GET: /MessageBoard/
        public ActionResult Index()
        {
            return View(db.MessageBoardsDb.ToList());
        }

        // GET: /MessageBoard/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MessageBoard messageboard = db.MessageBoardsDb.Find(id);
            if (messageboard == null)
            {
                return HttpNotFound();
            }
            return View(messageboard);
        }

        // GET: /MessageBoard/Create
        public ActionResult Create()
        {
            MessageBoard messageboard = new MessageBoard();
            messageboard.UserName = "temp";
            messageboard.UserID = 1;
            return View(messageboard);
        }

        // POST: /MessageBoard/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="ID,Title,UserName,UserID")] MessageBoard messageboard)
        {
            if (ModelState.IsValid)
            {
                db.MessageBoardsDb.Add(messageboard);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(messageboard);
        }

        // GET: /MessageBoard/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MessageBoard messageboard = db.MessageBoardsDb.Find(id);
            if (messageboard == null)
            {
                return HttpNotFound();
            }
            return View(messageboard);
        }

        // POST: /MessageBoard/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="ID,Title,UserName,UserID")] MessageBoard messageboard)
        {
            if (ModelState.IsValid)
            {
                db.Entry(messageboard).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(messageboard);
        }

        // GET: /MessageBoard/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MessageBoard messageboard = db.MessageBoardsDb.Find(id);
            if (messageboard == null)
            {
                return HttpNotFound();
            }
            return View(messageboard);
        }

        // POST: /MessageBoard/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MessageBoard messageboard = db.MessageBoardsDb.Find(id);
            db.MessageBoardsDb.Remove(messageboard);
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
