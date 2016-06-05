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
    public class VlasniksController : Controller
    {
        private ObjekatDbContext db = new ObjekatDbContext();

        // GET: Vlasniks
        public async Task<ActionResult> Index()
        {
            return View(await db.Vlasniici.ToListAsync());
        }

        // GET: Vlasniks/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vlasnik vlasnik = await db.Vlasniici.FindAsync(id);
            if (vlasnik == null)
            {
                return HttpNotFound();
            }
            return View(vlasnik);
        }

        // GET: Vlasniks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Vlasniks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Ime,DatumRodjenja,EMail")] Vlasnik vlasnik)
        {
            if (ModelState.IsValid)
            {
                db.Vlasniici.Add(vlasnik);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(vlasnik);
        }

        // GET: Vlasniks/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vlasnik vlasnik = await db.Vlasniici.FindAsync(id);
            if (vlasnik == null)
            {
                return HttpNotFound();
            }
            return View(vlasnik);
        }

        // POST: Vlasniks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Ime,DatumRodjenja,EMail")] Vlasnik vlasnik)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vlasnik).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(vlasnik);
        }

        // GET: Vlasniks/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vlasnik vlasnik = await db.Vlasniici.FindAsync(id);
            if (vlasnik == null)
            {
                return HttpNotFound();
            }
            return View(vlasnik);
        }

        // POST: Vlasniks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Vlasnik vlasnik = await db.Vlasniici.FindAsync(id);
            db.Vlasniici.Remove(vlasnik);
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
