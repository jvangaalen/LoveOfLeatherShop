using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LoveOfLeatherShop.DAL;
using LoveOfLeatherShop.Models;

namespace LoveOfLeatherShop.Controllers
{
    public class KeyChainsController : Controller
    {
        private Context db = new Context();

        // GET: KeyChains
        public ActionResult Index()
        {
            return View(db.KeyChains.ToList());
        }

        // GET: KeyChains/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KeyChain keyChain = db.KeyChains.Find(id);
            if (keyChain == null)
            {
                return HttpNotFound();
            }
            return View(keyChain);
        }

        // GET: KeyChains/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: KeyChains/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Color,EndType,Engraved")] KeyChain keyChain)
        {
            if (ModelState.IsValid)
            {
                db.KeyChains.Add(keyChain);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(keyChain);
        }

        // GET: KeyChains/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KeyChain keyChain = db.KeyChains.Find(id);
            if (keyChain == null)
            {
                return HttpNotFound();
            }
            return View(keyChain);
        }

        // POST: KeyChains/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Color,EndType,Engraved")] KeyChain keyChain)
        {
            if (ModelState.IsValid)
            {
                db.Entry(keyChain).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(keyChain);
        }

        // GET: KeyChains/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KeyChain keyChain = db.KeyChains.Find(id);
            if (keyChain == null)
            {
                return HttpNotFound();
            }
            return View(keyChain);
        }

        // POST: KeyChains/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            KeyChain keyChain = db.KeyChains.Find(id);
            db.KeyChains.Remove(keyChain);
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
