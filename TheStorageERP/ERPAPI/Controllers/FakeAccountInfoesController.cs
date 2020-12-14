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
using ERPDatabase;

namespace ERPAPI.Controllers
{
    public class FakeAccountInfoesController : ApiController
    {
        private ERPEntities db = new ERPEntities();

        // GET: api/FakeAccountInfoes
        public IQueryable<FakeAccountInfo> GetFakeAccountInfoes()
        {
            return db.FakeAccountInfoes;
        }

        // GET: api/FakeAccountInfoes/5
        [ResponseType(typeof(FakeAccountInfo))]
        public async Task<IHttpActionResult> GetFakeAccountInfo(DateTime id)
        {
            FakeAccountInfo fakeAccountInfo = await db.FakeAccountInfoes.FindAsync(id);
            if (fakeAccountInfo == null)
            {
                return NotFound();
            }

            return Ok(fakeAccountInfo);
        }

        // PUT: api/FakeAccountInfoes/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutFakeAccountInfo(DateTime id, FakeAccountInfo fakeAccountInfo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != fakeAccountInfo.Date)
            {
                return BadRequest();
            }

            db.Entry(fakeAccountInfo).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FakeAccountInfoExists(id))
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

        // POST: api/FakeAccountInfoes
        [ResponseType(typeof(FakeAccountInfo))]
        public async Task<IHttpActionResult> PostFakeAccountInfo(FakeAccountInfo fakeAccountInfo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.FakeAccountInfoes.Add(fakeAccountInfo);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (FakeAccountInfoExists(fakeAccountInfo.Date))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = fakeAccountInfo.Date }, fakeAccountInfo);
        }

        // DELETE: api/FakeAccountInfoes/5
        [ResponseType(typeof(FakeAccountInfo))]
        public async Task<IHttpActionResult> DeleteFakeAccountInfo(DateTime id)
        {
            FakeAccountInfo fakeAccountInfo = await db.FakeAccountInfoes.FindAsync(id);
            if (fakeAccountInfo == null)
            {
                return NotFound();
            }

            db.FakeAccountInfoes.Remove(fakeAccountInfo);
            await db.SaveChangesAsync();

            return Ok(fakeAccountInfo);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool FakeAccountInfoExists(DateTime id)
        {
            return db.FakeAccountInfoes.Count(e => e.Date == id) > 0;
        }
    }
}