using HotelCore.dominio.entidades.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IReservacionLN
{
    HabitacionDisponible habitacionDisponible(System.DateTime fechaInicio, System.DateTime fechaFinal, string tipo);

    Reservacion insertarReservacion(Reservacion nuevaReservacion, Cliente cliente);
}

