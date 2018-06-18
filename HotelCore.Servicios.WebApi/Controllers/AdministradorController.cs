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
    public class AdministradorController : ApiController
    {
   

      

        // GET: api/Administrador/5
        [ResponseType(typeof(Administrador))]
        [Route("Admin/obtenerAdmin")]
        [HttpGet]
        public IHttpActionResult obtenerAdmin(string usuario, string contra)
        {
            try
            {
                //db.Configuration.ProxyCreationEnabled = false;
                IAdministradorLN repositorio = FabricaIoC.Contenedor.Resolver<AdministradorLN>();
                //RepositorioAdministrador repositorio = new RepositorioAdministrador();
                Administrador admin = repositorio.obtenerAdmin(usuario, contra);
                return Ok(admin);
            }
            catch(Exception ex)
            {
                return null;
            }
           
        }


      
    }
}