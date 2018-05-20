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

namespace HotelCore.Servicios.WebApi.Controllers
{
    public class FacilidadController : ApiController
    {

        // GET: api/Facilidad
        [Route("Facilidad/ObtenerFacilidades")]
        [HttpGet()]
        [HttpPost()]
        public IHttpActionResult obtenerFacilidades()
        {
            IImagenLN repositorioImagenes = FabricaIoC.Contenedor.Resolver<ImagenLN>();
            IFacilidadLN repositorio = FabricaIoC.Contenedor.Resolver<FacilidadLN>();
            //RepositorioFacilidad repositorio = new RepositorioFacilidad();
            //RepositorioImagen repositorioImagenes = new RepositorioImagen();

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


    }
    
}