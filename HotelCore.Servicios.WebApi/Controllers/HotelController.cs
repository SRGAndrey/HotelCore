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
    public class HotelController : ApiController
    {

        // GET: api/Hotel/5
        [ResponseType(typeof(Hotel))]
        [Route("Hotel/obtenerHotel")]
        [HttpGet]
        public IHttpActionResult obtenerHotel(string id)
        {
                     
            //RepositorioHotel repositorioHotel = new RepositorioHotel();
            IImagenLN repositorioImagenes = FabricaIoC.Contenedor.Resolver<ImagenLN>();
            IHotelLN repo = FabricaIoC.Contenedor.Resolver<HotelLN>();
            Hotel hotel = repo.obtenerHotel(id);
           // RepositorioImagen repositorioImagenes = new RepositorioImagen();
            var imagenesDescrip = repositorioImagenes.obtenerImagenesDescripcion();
            var imagenesSobreNosotros = repositorioImagenes.obtenerImagenesSobreNosotros();

            HotelConImagenes hotelConImagenes = new HotelConImagenes();
            hotelConImagenes.hotel = hotel;
            hotelConImagenes.imagenesDescripcion = imagenesDescrip;
            hotelConImagenes.galeria = imagenesSobreNosotros;
           

            return Ok(hotelConImagenes);
        }


        // GET: api/Hotel/5
        [ResponseType(typeof(Tipo_Habitacion))]
        [Route("Hotel/obtenerHabitacion")]
        [HttpGet]
        public IHttpActionResult obtenerHabitacion()
        {
            IImagenLN repositorioImagenes = FabricaIoC.Contenedor.Resolver<ImagenLN>();
            IHotelLN repo = FabricaIoC.Contenedor.Resolver<HotelLN>();

            //RepositorioHotel repositorioHotel = new RepositorioHotel();
            List<Tipo_Habitacion> hotel = repo.obtenerHabitacion();
            //RepositorioImagen repositorioImagenes = new RepositorioImagen();
            var imagenesJunior = repositorioImagenes.obtenerImagenesJunior();
            var imagenSuite = repositorioImagenes.obtenerImagenesSuite();
            var imagenStandard = repositorioImagenes.obtenerImagenesStandard();

            Tarifa tipo = new Tarifa();
            tipo.tipoHabitacion = hotel;
            tipo.imagenJunior = imagenesJunior;
            tipo.imagenSuite = imagenSuite;
            tipo.imagenStandard = imagenStandard;

            return Ok(tipo);
        }

       


    }
}