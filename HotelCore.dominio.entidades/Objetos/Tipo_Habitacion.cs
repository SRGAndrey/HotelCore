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
    
    public partial class Tipo_Habitacion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tipo_Habitacion()
        {
            this.Caracteristica_Tipo_Habitacion = new HashSet<Caracteristica_Tipo_Habitacion>();
            this.Habitacion = new HashSet<Habitacion>();
            this.Promocion = new HashSet<Promocion>();
        }
    
        public string nombre_Tipo_Habitacion { get; set; }
        public string descripcion_Tipo_Habitacion { get; set; }
        public double tarifa_Tipo_Habitacion { get; set; }
        public string hotel_Tipo_Habitacion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Caracteristica_Tipo_Habitacion> Caracteristica_Tipo_Habitacion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Habitacion> Habitacion { get; set; }
        public virtual Hotel Hotel { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Promocion> Promocion { get; set; }
    }
}