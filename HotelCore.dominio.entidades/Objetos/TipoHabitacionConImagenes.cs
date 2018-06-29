using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HotelCore.dominio.entidades.Objetos
{
    public class TipoHabitacionConImagenes
    {

        public List<Tipo_Habitacion> tipoHabitacion { get; set; }
        public ImagenesJunior imagenJunior { get; set; }
        public ImagenesStandard imagenStandard { get; set; }
        public ImagenesSuite imagenSuite { get; set; }

        public Tipo_Habitacion tipoHabitacionX { get; set; }
    }
}