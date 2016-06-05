using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using WebAplikacija.Models;

namespace WebAplikacija.Controllers
{
    public class VlasnikServiceController : ApiController
    {
        private ObjekatDbContext db = new ObjekatDbContext();

        // GET: api/VlasnikService
        public IQueryable<Vlasnik> GetVlasniici()
        {
            return db.Vlasniici;
        }

        // GET: api/VlasnikService/5
        [ResponseType(typeof(Vlasnik))]
        public async Task<IHttpActionResult> GetVlasnik(int id)
        {
            Vlasnik vlasnik = await db.Vlasniici.FindAsync(id);
            if (vlasnik == null)
            {
                return NotFound();
            }

            return Ok(vlasnik);
        }

        // PUT: api/VlasnikService/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutVlasnik(int id, Vlasnik vlasnik)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != vlasnik.Id)
            {
                return BadRequest();
            }

            db.Entry(vlasnik).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VlasnikExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/VlasnikService
        [ResponseType(typeof(Vlasnik))]
        public async Task<IHttpActionResult> PostVlasnik(Vlasnik vlasnik)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Vlasniici.Add(vlasnik);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = vlasnik.Id }, vlasnik);
        }

        // DELETE: api/VlasnikService/5
        [ResponseType(typeof(Vlasnik))]
        public async Task<IHttpActionResult> DeleteVlasnik(int id)
        {
            Vlasnik vlasnik = await db.Vlasniici.FindAsync(id);
            if (vlasnik == null)
            {
                return NotFound();
            }

            db.Vlasniici.Remove(vlasnik);
            await db.SaveChangesAsync();

            return Ok(vlasnik);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool VlasnikExists(int id)
        {
            return db.Vlasniici.Count(e => e.Id == id) > 0;
        }
    }
}