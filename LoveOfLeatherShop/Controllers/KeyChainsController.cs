using System.Data.Entity;
using System.Threading.Tasks;
using System.Net;
using System.Web.Mvc;
using LoveOfLeatherShop.DAL;
using LoveOfLeatherShop.Models;

// Create controller for Admin pagee.

namespace LoveOfLeatherShop.Controllers
{
    public class KeyChainsController : Controller
    {
        private Context db = new Context();

        // Get KeyChains Objects from database

        public async Task<ActionResult> Index()
        {
            return View(await db.KeyChains.ToListAsync());
        }

        // Get keyChains from Seed data in DataBaseInitializer.

        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                // Returns a bad request message if strin is empty or null.

                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KeyChain keyChain = await db.KeyChains.FindAsync(id);
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
        public async Task<ActionResult> Create([Bind(Include = "Id,Color,EndType,Engraved")] KeyChain keyChain)
        {
            if (ModelState.IsValid)
            {
                db.KeyChains.Add(keyChain);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(keyChain);
        }

        // Edits individual keychain objects on admin page

        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KeyChain keyChain = await db.KeyChains.FindAsync(id);
            if (keyChain == null)
            {
                return HttpNotFound();
            }
            return View(keyChain);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Color,EndType,Engraved")] KeyChain keyChain)
        {
            if (ModelState.IsValid)
            {
                db.Entry(keyChain).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(keyChain);
        }

        // Deletes keychains

        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KeyChain keyChain = await db.KeyChains.FindAsync(id);
            if (keyChain == null)
            {
                return HttpNotFound();
            }
            return View(keyChain);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            KeyChain keyChain = await db.KeyChains.FindAsync(id);
            db.KeyChains.Remove(keyChain);
            await db.SaveChangesAsync();
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
