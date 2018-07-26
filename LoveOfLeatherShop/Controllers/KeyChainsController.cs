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
// Create controller for Admin page.
namespace LoveOfLeatherShop.Controllers
{
    public class KeyChainsController : Controller
    {
        private Context db = new Context();

        // Get KeyChains Objects from database
        public ActionResult Index()
        {
            return View(db.KeyChains.ToList());
        }

        // Get keyChains from Seed data in DataBaseInitializer.
        public ActionResult Details(int? id)
        {
            // returns a Bad Request message in string is empty or null.
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

        // Creates the keychain.
        public ActionResult Create()
        {
            return View();
        }

        // Post the keychain to the admin page.
        
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

        // Edits individual keychains in the database.
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

        // Edits individual keychain objects on admin page
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

        // Deletes keychains
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
