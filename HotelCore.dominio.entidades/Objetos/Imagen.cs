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
    
    public partial class Imagen
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Imagen()
        {
            this.Entidad_SubEntidad_Imagen = new HashSet<Entidad_SubEntidad_Imagen>();
        }
    
        public int id_Imagen { get; set; }
        public byte[] imagen_Imagen { get; set; }
        public string descripcion_Imagen { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Entidad_SubEntidad_Imagen> Entidad_SubEntidad_Imagen { get; set; }
    }
}
