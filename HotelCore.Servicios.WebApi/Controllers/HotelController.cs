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
using HotelCore.infraestructura.datos.Modelo;
using HotelCore.dominio.entidades.Objetos;

namespace HotelCore.Servicios.WebApi.Controllers
{
    public class HotelController : ApiController
    {
        private HotelDBEntities db = new HotelDBEntities();

        // GET: api/Hotel
        [Route("Hotel/obtenerHoteles")]
        [HttpGet]
        public IQueryable<Hotel> GetHotel()
        {
            db.Configuration.ProxyCreationEnabled = false;
            return db.Hotel.AsQueryable();
        }

        // GET: api/Hotel/5
        [ResponseType(typeof(Hotel))]
        [Route("Hotel/obtenerHotel")]
        [HttpGet]
        public IHttpActionResult obtenerHotel(string id)
        {
            db.Configuration.ProxyCreationEnabled = false;
            RepositorioHotel repositorio = new RepositorioHotel();
            Hotel hotel = repositorio.obtenerHotel(id);

            return Ok(hotel);
        }

        // PUT: api/Hotel/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutHotel(string id, Hotel hotel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != hotel.nombre_Hotel)
            {
                return BadRequest();
            }

            db.Entry(hotel).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HotelExists(id))
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

        // POST: api/Hotel
        [ResponseType(typeof(Hotel))]
        public IHttpActionResult PostHotel(Hotel hotel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Hotel.Add(hotel);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (HotelExists(hotel.nombre_Hotel))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = hotel.nombre_Hotel }, hotel);
        }

        // DELETE: api/Hotel/5
        [ResponseType(typeof(Hotel))]
        public IHttpActionResult DeleteHotel(string id)
        {
            Hotel hotel = db.Hotel.Find(id);
            if (hotel == null)
            {
                return NotFound();
            }

            db.Hotel.Remove(hotel);
            db.SaveChanges();

            return Ok(hotel);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool HotelExists(string id)
        {
            return db.Hotel.Count(e => e.nombre_Hotel == id) > 0;
        }
    }
}