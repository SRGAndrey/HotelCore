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
    public class FacilidadController : ApiController
    {
        private HotelDBEntities db = new HotelDBEntities();

        // GET: api/Facilidad
        [Route("Facilidad/ObtenerFacilidades")]
        [HttpGet()]
        [HttpPost()]
        public IHttpActionResult obtenerFacilidades()
        {
            RepositorioFacilidad repositorio = new RepositorioFacilidad();
            RepositorioImagen repositorioImagenes = new RepositorioImagen();

            var facilidades = repositorio.obtenerFacilidades();
            var imagenesBar = repositorioImagenes.obtenerImagenesBar();
            var imagenesCafeteria = repositorioImagenes.obtenerImagenesCafeteria();
            var imagenesInfantiles = repositorioImagenes.obtenerImagenesInfantiles();
            var imagenesJacuzzi = repositorioImagenes.obtenerImagenesJacuzzi();
            var imagenesPiscina = repositorioImagenes.obtenerImagenesPiscina();
            var imagenesRestaurante = repositorioImagenes.obtenerImagenesRestaurante();
            var imagenesTenis = repositorioImagenes.obtenerImagenesTenis();

            FacilidadesConImagenes facilidadesConImagenes = new FacilidadesConImagenes();
            facilidadesConImagenes.facilidades = facilidades;
            facilidadesConImagenes.imagenesBar = imagenesBar;
            facilidadesConImagenes.imagenesCafeteria = imagenesCafeteria;
            facilidadesConImagenes.imagenesInfantil = imagenesInfantiles;
            facilidadesConImagenes.imagenesJacuzzi = imagenesJacuzzi;
            facilidadesConImagenes.imagenesPiscina = imagenesPiscina;
            facilidadesConImagenes.imagenesRestaurante = imagenesRestaurante;
            facilidadesConImagenes.imagenesTenis = imagenesTenis;

            return Ok(facilidadesConImagenes);
        }

        // GET: api/Facilidad/5
        [ResponseType(typeof(Facilidad))]
        public IHttpActionResult GetFacilidad(string id)
        {
            Facilidad facilidad = db.Facilidad.Find(id);
            if (facilidad == null)
            {
                return NotFound();
            }

            return Ok(facilidad);
        }

        // PUT: api/Facilidad/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutFacilidad(string id, Facilidad facilidad)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != facilidad.id_Facilidad)
            {
                return BadRequest();
            }

            db.Entry(facilidad).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FacilidadExists(id))
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

        // POST: api/Facilidad
        [ResponseType(typeof(Facilidad))]
        public IHttpActionResult PostFacilidad(Facilidad facilidad)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Facilidad.Add(facilidad);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (FacilidadExists(facilidad.id_Facilidad))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = facilidad.id_Facilidad }, facilidad);
        }

        // DELETE: api/Facilidad/5
        [ResponseType(typeof(Facilidad))]
        public IHttpActionResult DeleteFacilidad(string id)
        {
            Facilidad facilidad = db.Facilidad.Find(id);
            if (facilidad == null)
            {
                return NotFound();
            }

            db.Facilidad.Remove(facilidad);
            db.SaveChanges();

            return Ok(facilidad);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool FacilidadExists(string id)
        {
            return db.Facilidad.Count(e => e.id_Facilidad == id) > 0;
        }
    }
}