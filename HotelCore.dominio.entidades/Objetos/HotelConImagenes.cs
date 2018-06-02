using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HotelCore.dominio.entidades.Objetos
{
    public class HotelConImagenes
    {

        public Hotel hotel { get; set; }

        public List<ImagenesDescripcion> imagenesDescripcion { get; set; }

        public List<ImagenesSobreNosotros> galeria { get; set; }
    }
}