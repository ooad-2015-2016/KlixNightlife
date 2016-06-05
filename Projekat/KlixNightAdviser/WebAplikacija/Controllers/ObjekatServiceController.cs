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
    public class ObjekatServiceController : ApiController
    {
        private ObjekatDbContext db = new ObjekatDbContext();

        // GET: api/ObjekatService
        public IQueryable<Objekat> GetObjekti()
        {
            return db.Objekti;
        }

        // GET: api/ObjekatService/5
        [ResponseType(typeof(Objekat))]
        public async Task<IHttpActionResult> GetObjekat(int id)
        {
            Objekat objekat = await db.Objekti.FindAsync(id);
            if (objekat == null)
            {
                return NotFound();
            }

            return Ok(objekat);
        }

        // PUT: api/ObjekatService/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutObjekat(int id, Objekat objekat)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != objekat.Id)
            {
                return BadRequest();
            }

            db.Entry(objekat).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ObjekatExists(id))
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

        // POST: api/ObjekatService
        [ResponseType(typeof(Objekat))]
        public async Task<IHttpActionResult> PostObjekat(Objekat objekat)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Objekti.Add(objekat);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = objekat.Id }, objekat);
        }

        // DELETE: api/ObjekatService/5
        [ResponseType(typeof(Objekat))]
        public async Task<IHttpActionResult> DeleteObjekat(int id)
        {
            Objekat objekat = await db.Objekti.FindAsync(id);
            if (objekat == null)
            {
                return NotFound();
            }

            db.Objekti.Remove(objekat);
            await db.SaveChangesAsync();

            return Ok(objekat);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ObjekatExists(int id)
        {
            return db.Objekti.Count(e => e.Id == id) > 0;
        }
    }
}