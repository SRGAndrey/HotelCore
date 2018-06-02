using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelCore.dominio.entidades.Objetos
{
    public class Tarifa
    {
        public List<Tipo_Habitacion> tipoHabitacion { get; set; }
        public ImagenesJunior imagenJunior { get; set; }
        public ImagenesStandard imagenStandard { get; set; }
        public ImagenesSuite imagenSuite { get; set; }
    }
}
