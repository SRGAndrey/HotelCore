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

namespace HotelCore.Servicios.WebApi.Controllers
{
    public class AdministradorController : ApiController
    {
        private HotelDBEntities db = new HotelDBEntities();

        // GET: api/Administrador
        [Route("Admin/obtenerAdmins")]
        [HttpGet]
        public IQueryable<Administrador> obtenerAdmins()
        {
            db.Configuration.ProxyCreationEnabled = false;
            return db.Administrador.AsQueryable();
        }

        // GET: api/Administrador/5
        [ResponseType(typeof(Administrador))]
        [Route("Admin/obtenerAdmin")]
        [HttpGet]
        public IHttpActionResult obtenerAdmin(string usuario, string contra)
        {
            try
            {
                db.Configuration.ProxyCreationEnabled = false;
                RepositorioAdministrador repositorio = new RepositorioAdministrador();
                Administrador admin = repositorio.obtenerAdmin(usuario, contra);
                return Ok(admin);
            }
            catch(Exception ex)
            {
                return null;
            }
           
        }

        // PUT: api/Administrador/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutAdministrador(int id, Administrador administrador)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != administrador.id_Administrador)
            {
                return BadRequest();
            }

            db.Entry(administrador).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AdministradorExists(id))
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

        // POST: api/Administrador
        [ResponseType(typeof(Administrador))]
        public IHttpActionResult PostAdministrador(Administrador administrador)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Administrador.Add(administrador);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = administrador.id_Administrador }, administrador);
        }

        // DELETE: api/Administrador/5
        [ResponseType(typeof(Administrador))]
        public IHttpActionResult DeleteAdministrador(int id)
        {
            Administrador administrador = db.Administrador.Find(id);
            if (administrador == null)
            {
                return NotFound();
            }

            db.Administrador.Remove(administrador);
            db.SaveChanges();

            return Ok(administrador);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AdministradorExists(int id)
        {
            return db.Administrador.Count(e => e.id_Administrador == id) > 0;
        }
    }
}