using HotelCore.dominio.entidades.Objetos;
using HotelCore.infraestructura.datos.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace HotelCore.Servicios.WebApi.Controllers
{
    public class ReservacionController : ApiController
    {
        private HotelDBEntities db = new HotelDBEntities();
        // GET: api/Reservacion
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Hotel/5
        //[ResponseType(typeof(HabitacionDisponible))]
        [Route("Reservacion/HabitacionDisponible")]
        [HttpGet]
        [HttpPost]
        public IHttpActionResult HabitacionDisponible(string fechaLlegada, string fechaSalida, string tipo)
        {

            System.DateTime fechaInicio = DateTime.Parse(fechaLlegada);
            System.DateTime fechaFinal = DateTime.Parse(fechaSalida);
            db.Configuration.ProxyCreationEnabled = false;
            RepositorioReservacion repositorio = new RepositorioReservacion();

            HabitacionDisponible habitacionDisponible = repositorio.habitacionDisponible(fechaInicio, fechaFinal,tipo);
            
            return Ok(habitacionDisponible);
        }

        // GET: api/Reservacion/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Reservacion
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Reservacion/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Rese
          
        public void Delete(int id)
        {
        }
    }
}
