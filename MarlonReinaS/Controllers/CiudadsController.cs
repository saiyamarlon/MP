using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using MarlonReinaS.Models;

namespace MarlonReinaS.Controllers
{
    public class CiudadsController : ApiController
    {
        private readonly MrContext db = new MrContext();

        // GET: api/Ciudads
        public IQueryable<Ciudad> GetCiudads()
        {
            return db.Ciudads;
        }

        // GET: api/Ciudads/5
        [ResponseType(typeof(Ciudad))]
        public IHttpActionResult GetCiudad(int id)
        {
            Ciudad ciudad = db.Ciudads.Find(id);
            if (ciudad == null)
            {
                return NotFound();
            }

            return Ok(ciudad);
        }

        // PUT: api/Ciudads/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCiudad(int id, Ciudad ciudad)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != ciudad.id)
            {
                return BadRequest();
            }

            db.Entry(ciudad).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CiudadExists(id))
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

        // POST: api/Ciudads
        [ResponseType(typeof(Ciudad))]
        public IHttpActionResult PostCiudad(Ciudad ciudad)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Ciudads.Add(ciudad);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = ciudad.id }, ciudad);
        }

        // DELETE: api/Ciudads/5
        [ResponseType(typeof(Ciudad))]
        public IHttpActionResult DeleteCiudad(int id)
        {
            Ciudad ciudad = db.Ciudads.Find(id);
            if (ciudad == null)
            {
                return NotFound();
            }

            db.Ciudads.Remove(ciudad);
            db.SaveChanges();

            return Ok(ciudad);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CiudadExists(int id)
        {
            return db.Ciudads.Count(e => e.id == id) > 0;
        }
    }
}