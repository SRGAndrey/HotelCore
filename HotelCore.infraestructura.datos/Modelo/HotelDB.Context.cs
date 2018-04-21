﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HotelCore.infraestructura.datos.Modelo
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class HotelDBEntities : DbContext
    {
        public HotelDBEntities()
            : base("name=HotelDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Administrador> Administrador { get; set; }
        public virtual DbSet<Caracteristica> Caracteristica { get; set; }
        public virtual DbSet<Caracteristica_Tipo_Habitacion> Caracteristica_Tipo_Habitacion { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Entidad> Entidad { get; set; }
        public virtual DbSet<Entidad_SubEntidad_Imagen> Entidad_SubEntidad_Imagen { get; set; }
        public virtual DbSet<Facilidad> Facilidad { get; set; }
        public virtual DbSet<Habitacion> Habitacion { get; set; }
        public virtual DbSet<Hotel> Hotel { get; set; }
        public virtual DbSet<HotelAdministrador> HotelAdministrador { get; set; }
        public virtual DbSet<HotelPublicidad> HotelPublicidad { get; set; }
        public virtual DbSet<Imagen> Imagen { get; set; }
        public virtual DbSet<Promocion> Promocion { get; set; }
        public virtual DbSet<Publicidad> Publicidad { get; set; }
        public virtual DbSet<Reservacion> Reservacion { get; set; }
        public virtual DbSet<Rol> Rol { get; set; }
        public virtual DbSet<SubEntidad> SubEntidad { get; set; }
        public virtual DbSet<Tipo_Habitacion> Tipo_Habitacion { get; set; }
        public virtual DbSet<ImagenesBar> ImagenesBar { get; set; }
        public virtual DbSet<ImagenesCafeteria> ImagenesCafeteria { get; set; }
        public virtual DbSet<ImagenesDescripcion> ImagenesDescripcion { get; set; }
        public virtual DbSet<ImagenesFacilidades> ImagenesFacilidades { get; set; }
        public virtual DbSet<ImagenesHabitacion> ImagenesHabitacion { get; set; }
        public virtual DbSet<ImagenesHotel> ImagenesHotel { get; set; }
        public virtual DbSet<ImagenesInfantiles> ImagenesInfantiles { get; set; }
        public virtual DbSet<ImagenesJacuzzi> ImagenesJacuzzi { get; set; }
        public virtual DbSet<ImagenesJunior> ImagenesJunior { get; set; }
        public virtual DbSet<ImagenesPiscina> ImagenesPiscina { get; set; }
        public virtual DbSet<ImagenesRestaurante> ImagenesRestaurante { get; set; }
        public virtual DbSet<ImagenesSobreNosotros> ImagenesSobreNosotros { get; set; }
        public virtual DbSet<ImagenesStandard> ImagenesStandard { get; set; }
        public virtual DbSet<ImagenesSuite> ImagenesSuite { get; set; }
        public virtual DbSet<ImagenesTenis> ImagenesTenis { get; set; }
    
        public virtual int cancelar_Promocion(string nombre)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("cancelar_Promocion", nombreParameter);
        }
    
        public virtual int crear_Promocion(string nombre, Nullable<System.DateTime> inicio, Nullable<System.DateTime> fin, Nullable<int> descuento)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var inicioParameter = inicio.HasValue ?
                new ObjectParameter("inicio", inicio) :
                new ObjectParameter("inicio", typeof(System.DateTime));
    
            var finParameter = fin.HasValue ?
                new ObjectParameter("fin", fin) :
                new ObjectParameter("fin", typeof(System.DateTime));
    
            var descuentoParameter = descuento.HasValue ?
                new ObjectParameter("descuento", descuento) :
                new ObjectParameter("descuento", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("crear_Promocion", nombreParameter, inicioParameter, finParameter, descuentoParameter);
        }
    
        public virtual int Estado_Promocion(string nombre)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Estado_Promocion", nombreParameter);
        }
    
        public virtual int insertar_Tipo_Habitacion(string nombre, string descrip, Nullable<double> tarifa, string hotel)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var descripParameter = descrip != null ?
                new ObjectParameter("descrip", descrip) :
                new ObjectParameter("descrip", typeof(string));
    
            var tarifaParameter = tarifa.HasValue ?
                new ObjectParameter("tarifa", tarifa) :
                new ObjectParameter("tarifa", typeof(double));
    
            var hotelParameter = hotel != null ?
                new ObjectParameter("hotel", hotel) :
                new ObjectParameter("hotel", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("insertar_Tipo_Habitacion", nombreParameter, descripParameter, tarifaParameter, hotelParameter);
        }
    
        public virtual int obtener_tarifa_Tipo_Habitacion(string nombre, ObjectParameter tarifa)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("obtener_tarifa_Tipo_Habitacion", nombreParameter, tarifa);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual int insertar_Cliente(string cedula, string nombre, string apellido, Nullable<int> tarjeta_Cliente, string email)
        {
            var cedulaParameter = cedula != null ?
                new ObjectParameter("cedula", cedula) :
                new ObjectParameter("cedula", typeof(string));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var apellidoParameter = apellido != null ?
                new ObjectParameter("apellido", apellido) :
                new ObjectParameter("apellido", typeof(string));
    
            var tarjeta_ClienteParameter = tarjeta_Cliente.HasValue ?
                new ObjectParameter("tarjeta_Cliente", tarjeta_Cliente) :
                new ObjectParameter("tarjeta_Cliente", typeof(int));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("insertar_Cliente", cedulaParameter, nombreParameter, apellidoParameter, tarjeta_ClienteParameter, emailParameter);
        }
    
        public virtual int insertar_Reservacion(Nullable<System.DateTime> fechaLLegada, Nullable<System.DateTime> fechasalida, Nullable<int> idHabitacion, string idCliente, string nombre, string apellido, Nullable<int> tarjeta_Cliente, string email)
        {
            var fechaLLegadaParameter = fechaLLegada.HasValue ?
                new ObjectParameter("fechaLLegada", fechaLLegada) :
                new ObjectParameter("fechaLLegada", typeof(System.DateTime));
    
            var fechasalidaParameter = fechasalida.HasValue ?
                new ObjectParameter("fechasalida", fechasalida) :
                new ObjectParameter("fechasalida", typeof(System.DateTime));
    
            var idHabitacionParameter = idHabitacion.HasValue ?
                new ObjectParameter("idHabitacion", idHabitacion) :
                new ObjectParameter("idHabitacion", typeof(int));
    
            var idClienteParameter = idCliente != null ?
                new ObjectParameter("idCliente", idCliente) :
                new ObjectParameter("idCliente", typeof(string));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var apellidoParameter = apellido != null ?
                new ObjectParameter("apellido", apellido) :
                new ObjectParameter("apellido", typeof(string));
    
            var tarjeta_ClienteParameter = tarjeta_Cliente.HasValue ?
                new ObjectParameter("tarjeta_Cliente", tarjeta_Cliente) :
                new ObjectParameter("tarjeta_Cliente", typeof(int));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("insertar_Reservacion", fechaLLegadaParameter, fechasalidaParameter, idHabitacionParameter, idClienteParameter, nombreParameter, apellidoParameter, tarjeta_ClienteParameter, emailParameter);
        }
    }
}
