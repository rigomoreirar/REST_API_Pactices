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
using adventureworks2019_api.Models;

namespace adventureworks2019_api.Controllers
{
    public class UnitMeasureController : ApiController
    {
        private AdventureWorks2019Entities db = new AdventureWorks2019Entities();

        // GET: api/UnitMeasure
        public IQueryable<UnitMeasure> GetUnitMeasures()
        {
            return db.UnitMeasures;
        }

        // GET: api/UnitMeasure/5
        [ResponseType(typeof(UnitMeasure))]
        public IHttpActionResult GetUnitMeasure(string id)
        {
            UnitMeasure unitMeasure = db.UnitMeasures.Find(id);
            if (unitMeasure == null)
            {
                return NotFound();
            }

            return Ok(unitMeasure);
        }

        // PUT: api/UnitMeasure/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutUnitMeasure(string id, UnitMeasure unitMeasure)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != unitMeasure.UnitMeasureCode)
            {
                return BadRequest();
            }

            db.Entry(unitMeasure).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UnitMeasureExists(id))
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

        // POST: api/UnitMeasure
        [ResponseType(typeof(UnitMeasure))]
        public IHttpActionResult PostUnitMeasure(UnitMeasure unitMeasure)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.UnitMeasures.Add(unitMeasure);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (UnitMeasureExists(unitMeasure.UnitMeasureCode))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = unitMeasure.UnitMeasureCode }, unitMeasure);
        }

        // DELETE: api/UnitMeasure/5
        [ResponseType(typeof(UnitMeasure))]
        public IHttpActionResult DeleteUnitMeasure(string id)
        {
            UnitMeasure unitMeasure = db.UnitMeasures.Find(id);
            if (unitMeasure == null)
            {
                return NotFound();
            }

            db.UnitMeasures.Remove(unitMeasure);
            db.SaveChanges();

            return Ok(unitMeasure);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool UnitMeasureExists(string id)
        {
            return db.UnitMeasures.Count(e => e.UnitMeasureCode == id) > 0;
        }
    }
}