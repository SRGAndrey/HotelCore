using HotelCore.dominio.entidades.Objetos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class AdministrarHabitacion
    {
        [StringLength(20)]
        public string nombre_Tipo_Habitacion { get; set; }

        public List<Habitacion> habitaciones { get; set; }
    }

