//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HotelCore.dominio.entidades.Objetos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Entidad_SubEntidad_Imagen
    {
        public int id_Entidad_SubEntidad_Imagen { get; set; }
        public int idEntidad_Entidad_SubEntidad_Imagen { get; set; }
        public int idSubEntidad_Entidad_SubEntidad_Imagen { get; set; }
        public int idImagen_Entidad_SubEntidad_Imagen { get; set; }
    
        public virtual Entidad Entidad { get; set; }
        public virtual Imagen Imagen { get; set; }
        public virtual SubEntidad SubEntidad { get; set; }
    }
}
