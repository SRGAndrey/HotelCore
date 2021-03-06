﻿using System;
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
            IImagenLN repositorioImagenes = FabricaIoC.Contenedor.Resolver<ImagenLN>();
            IHabitacionLN repositorio = FabricaIoC.Contenedor.Resolver<HabitacionLN>();

            Tipo_Habitacion habitacion = new Tipo_Habitacion();
            habitacion = repositorio.obtenerTipoHabitacion(tipo);

            var imagenJunior = repositorioImagenes.obtenerImagenesJunior();
            var imagenStandard = repositorioImagenes.obtenerImagenesStandard();
            var imagenSuite = repositorioImagenes.obtenerImagenesSuite();

            TipoHabitacionConImagenes tipoHabitacion = new TipoHabitacionConImagenes();
            tipoHabitacion.tipoHabitacionX = habitacion;
            tipoHabitacion.imagenJunior = imagenJunior;
            tipoHabitacion.imagenStandard = imagenStandard;
            tipoHabitacion.imagenSuite = imagenSuite;

            return Ok(tipoHabitacion);
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

        [Route("Habitacion/actualizarImagenTH")]
        [HttpGet]
        [HttpPost]
        public void actualizarImagenTH(Imagen imagenNueva)
        {

            //RepositorioHotel repositorioHotel = new RepositorioHotel();
            IHabitacionLN repo = FabricaIoC.Contenedor.Resolver<HabitacionLN>();

            //TipoHabitacionConImagenes hotel = 
            repo.actualizarImagenTH(imagenNueva);

            //return Ok(hotel);
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