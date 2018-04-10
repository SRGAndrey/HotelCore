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
    public class ImagenController : ApiController
    {
        private HotelDBEntities db = new HotelDBEntities();

        // GET: api/Imagen
        [Route("Imagen/obtenerImagenes")]
        [HttpGet]
        public List<Imagen> obtenerImagenes(int idEntidad)
        {
            db.Configuration.ProxyCreationEnabled = false;
            RepositorioImagen repositorio = new RepositorioImagen();
            var imagenes = repositorio.obtenerImagenes(idEntidad);
            return imagenes;
        }

        // GET: api/Imagen/5
        [ResponseType(typeof(Imagen))]
        public IHttpActionResult GetImagen(int id)
        {
            Imagen imagen = db.Imagen.Find(id);
            if (imagen == null)
            {
                return NotFound();
            }

            return Ok(imagen);
        }

        // PUT: api/Imagen/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutImagen(int id, Imagen imagen)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != imagen.id_Imagen)
            {
                return BadRequest();
            }

            db.Entry(imagen).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ImagenExists(id))
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

        // POST: api/Imagen
        [ResponseType(typeof(Imagen))]
        public IHttpActionResult PostImagen(Imagen imagen)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Imagen.Add(imagen);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = imagen.id_Imagen }, imagen);
        }

        // DELETE: api/Imagen/5
        [ResponseType(typeof(Imagen))]
        public IHttpActionResult DeleteImagen(int id)
        {
            Imagen imagen = db.Imagen.Find(id);
            if (imagen == null)
            {
                return NotFound();
            }

            db.Imagen.Remove(imagen);
            db.SaveChanges();

            return Ok(imagen);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ImagenExists(int id)
        {
            return db.Imagen.Count(e => e.id_Imagen == id) > 0;
        }
    }
}