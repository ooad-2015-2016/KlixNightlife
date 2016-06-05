using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebAplikacija.Models;

namespace WebAplikacija.Controllers
{
    public class ObjekatsController : Controller
    {
        private ObjekatDbContext db = new ObjekatDbContext();

        // GET: Objekats
        public async Task<ActionResult> Index()
        {
            var objekti = db.Objekti.Include(o => o.Vlasnik);
            return View(await objekti.ToListAsync());
        }

        // GET: Objekats/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Objekat objekat = await db.Objekti.FindAsync(id);
            if (objekat == null)
            {
                return HttpNotFound();
            }
            return View(objekat);
        }

        // GET: Objekats/Create
        public ActionResult Create()
        {
            ViewBag.VlasnikId = new SelectList(db.Vlasniici, "Id", "Ime");
            return View();
        }

        // POST: Objekats/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Naziv,Adresa,Mjesto,VlasnikId")] Objekat objekat)
        {
            if (ModelState.IsValid)
            {
                db.Objekti.Add(objekat);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.VlasnikId = new SelectList(db.Vlasniici, "Id", "Ime", objekat.VlasnikId);
            return View(objekat);
        }

        // GET: Objekats/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Objekat objekat = await db.Objekti.FindAsync(id);
            if (objekat == null)
            {
                return HttpNotFound();
            }
            ViewBag.VlasnikId = new SelectList(db.Vlasniici, "Id", "Ime", objekat.VlasnikId);
            return View(objekat);
        }

        // POST: Objekats/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Naziv,Adresa,Mjesto,VlasnikId")] Objekat objekat)
        {
            if (ModelState.IsValid)
            {
                db.Entry(objekat).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.VlasnikId = new SelectList(db.Vlasniici, "Id", "Ime", objekat.VlasnikId);
            return View(objekat);
        }

        // GET: Objekats/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Objekat objekat = await db.Objekti.FindAsync(id);
            if (objekat == null)
            {
                return HttpNotFound();
            }
            return View(objekat);
        }

        // POST: Objekats/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Objekat objekat = await db.Objekti.FindAsync(id);
            db.Objekti.Remove(objekat);
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
