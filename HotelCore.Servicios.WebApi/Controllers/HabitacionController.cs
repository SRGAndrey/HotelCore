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
using HotelCore.dominio.entidades.Objetos;
using HotelCore.infraestructura.datos.Modelo;
using PagedList;

namespace HotelCore.Servicios.WebApi.Controllers
{
    public class HabitacionController : ApiController
    {
        private HotelDBEntities db = new HotelDBEntities();

        // GET: api/Habitacion
        // GET: api/Hotel/5
        [ResponseType(typeof(Habitacion))]
        [Route("Habitacion/obtenerHabitaciones")]
        [HttpGet]
        public IHttpActionResult obtenerHabitaciones()
        {
            List<Habitacion> habitaciones = new List<Habitacion>();
            RepositorioHabitacion reposiorio = new RepositorioHabitacion();
            habitaciones = reposiorio.obtenerHabitaciones();

            return Ok(habitaciones);
        }

        // GET: api/Habitacion/5
        [ResponseType(typeof(Habitacion))]
        public IHttpActionResult GetHabitacion(int id)
        {
            Habitacion habitacion = db.Habitacion.Find(id);
            if (habitacion == null)
            {
                return NotFound();
            }

            return Ok(habitacion);
        }

        // PUT: api/Habitacion/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutHabitacion(int id, Habitacion habitacion)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != habitacion.numero_Habitacion)
            {
                return BadRequest();
            }

            db.Entry(habitacion).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HabitacionExists(id))
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

        // POST: api/Habitacion
        [ResponseType(typeof(Habitacion))]
        public IHttpActionResult PostHabitacion(Habitacion habitacion)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Habitacion.Add(habitacion);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (HabitacionExists(habitacion.numero_Habitacion))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = habitacion.numero_Habitacion }, habitacion);
        }

        // DELETE: api/Habitacion/5
        [ResponseType(typeof(Habitacion))]
        public IHttpActionResult DeleteHabitacion(int id)
        {
            Habitacion habitacion = db.Habitacion.Find(id);
            if (habitacion == null)
            {
                return NotFound();
            }

            db.Habitacion.Remove(habitacion);
            db.SaveChanges();

            return Ok(habitacion);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool HabitacionExists(int id)
        {
            return db.Habitacion.Count(e => e.numero_Habitacion == id) > 0;
        }
    }
}