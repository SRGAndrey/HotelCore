//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HotelCore.dominio.entidades.Objetos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Caracteristica_Tipo_Habitacion
    {
        public int id_Caracteristica_Tipo_Habitacion { get; set; }
        public int idCaracteristica_Caracteristica_Tipo_Habitacion { get; set; }
        public string tipo_Habitacion_Caracteristica_Tipo_Habitacion { get; set; }
    
        public virtual Caracteristica Caracteristica { get; set; }
        public virtual Tipo_Habitacion Tipo_Habitacion { get; set; }
    }
}