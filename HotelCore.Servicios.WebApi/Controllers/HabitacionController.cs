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
        public IHttpActionResult obtenerHabitaciones()
        {
            List<Habitacion> habitaciones = new List<Habitacion>();
            //RepositorioHabitacion reposiorio = new RepositorioHabitacion();
            IHabitacionLN repositorio = FabricaIoC.Contenedor.Resolver<HabitacionLN>();
            habitaciones = repositorio.obtenerHabitaciones();
            return Ok(habitaciones);
        }
        public IHttpActionResult obtenerTodas()
        {
            List<AdministrarHabitacion> habitaciones = new List<AdministrarHabitacion>();
            //RepositorioHabitacion reposiorio = new RepositorioHabitacion();
            IHabitacionLN repositorio = FabricaIoC.Contenedor.Resolver<HabitacionLN>();
            habitaciones = repositorio.obtenerTodas();
            return Ok(habitaciones);
        }


    }
}