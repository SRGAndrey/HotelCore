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
    public class HabitacionController : ApiController
    {
        // GET: api/Habitacion
        [Route("Habitacion/obtenerHabitaciones")]
        [HttpGet()]
        [HttpPost()]
        public IHttpActionResult obtenerHabitaciones()
        {
            List<Habitacion> habitaciones = new List<Habitacion>();
            //RepositorioHabitacion reposiorio = new RepositorioHabitacion();
            IHabitacionLN repositorio = FabricaIoC.Contenedor.Resolver<HabitacionLN>();
            habitaciones = repositorio.obtenerHabitaciones();
            return Ok(habitaciones);
        }

        [Route("Habitacion/obtenerTodas")]
        [HttpGet()]
        [HttpPost()]
        public IHttpActionResult obtenerTodas()
        {
            List<AdministrarHabitacion> habitaciones = new List<AdministrarHabitacion>();
            //RepositorioHabitacion reposiorio = new RepositorioHabitacion();
            IHabitacionLN repositorio = FabricaIoC.Contenedor.Resolver<HabitacionLN>();
            habitaciones = repositorio.obtenerTodas();
            return Ok(habitaciones);
        }

        [Route("Habitacion/obtenerTipoHabitacion")]
        [HttpGet()]
        [HttpPost()]
        public IHttpActionResult obtenerTipoHabitacion(string tipo)
        {
            Tipo_Habitacion habitacion = new Tipo_Habitacion();
            //RepositorioHabitacion reposiorio = new RepositorioHabitacion();
            IHabitacionLN repositorio = FabricaIoC.Contenedor.Resolver<HabitacionLN>();
            habitacion = repositorio.obtenerTipoHabitacion(tipo);
            return Ok(habitacion);
        }

        [Route("Habitacion/actualizarTipo")]
        [HttpGet()]
        [HttpPost()]
        public IHttpActionResult actualizarTipo(string tipo, string descripcion, double tarifa)
        {
            Tipo_Habitacion habitacion = new Tipo_Habitacion();
            //RepositorioHabitacion reposiorio = new RepositorioHabitacion();
            IHabitacionLN repositorio = FabricaIoC.Contenedor.Resolver<HabitacionLN>();
            habitacion = repositorio.actualizarTipo(tipo, descripcion, tarifa);
            return Ok(habitacion);
        }

        //[ResponseType(typeof(HabitacionDisponible))]

        [Route("Habitacion/ObtenerDisponibilidad")]

        [HttpGet]

        [HttpPost]

        public IHttpActionResult ObtenerDisponibilidad(string fechaLlegada, string fechaSalida, string tipo)
        {

            System.DateTime fechaInicio = DateTime.Parse(fechaLlegada);

            System.DateTime fechaFinal = DateTime.Parse(fechaSalida);

            List<HabitacionesDisponibles> hds = new List<HabitacionesDisponibles>();
            //RepositorioHabitacion reposiorio = new RepositorioHabitacion();
            IHabitacionLN repositorio = FabricaIoC.Contenedor.Resolver<HabitacionLN>();
            hds = repositorio.obtenerHabitaciones(fechaInicio, fechaFinal, tipo);
            return Ok(hds);

        }//obtenerDisponibilidad

    }
}