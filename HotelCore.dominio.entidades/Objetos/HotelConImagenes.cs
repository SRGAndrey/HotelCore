using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HotelCore.dominio.entidades.Objetos
{
    public class HotelConImagenes
    {

        [Key]
        [StringLength(25)]
        public string nombre_Hotel { get; set; }

        [Required]
        [StringLength(500)]
        public string descripcion_Hotel { get; set; }
        public string sobreNosotros_Hotel { get; set; }
        public string latitud_Hotel { get; set; }
        public string longitud_Hotel { get; set; }
        public string comoLlegar_Hotel { get; set; }
        public string telefono_Hotel { get; set; }
        public Nullable<int> aptoPostal_Hotel { get; set; }
        public string email_Hotel { get; set; }

        public List<Imagen> imagenes { get; set; }
    }
}