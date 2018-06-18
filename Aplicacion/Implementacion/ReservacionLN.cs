using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelCore.dominio.entidades.Objetos;

public class ReservacionLN : IReservacionLN
{
    private IRespositorioReservacion dominio;

    public ReservacionLN(IRespositorioReservacion repositorio)
    {
        dominio = repositorio;
    }
    public HabitacionDisponible habitacionDisponible(DateTime fechaInicio, DateTime fechaFinal, string tipo)
    {
        HabitacionDisponible habitacionDisp;
        habitacionDisp = dominio.habitacionDisponible(fechaInicio, fechaFinal, tipo);
        return habitacionDisp;
    }

    public Reservacion insertarReservacion(Reservacion nuevaReservacion, Cliente cliente)
    {
        Reservacion reservacion;
        reservacion = dominio.insertarReservacion(nuevaReservacion, cliente);
        return reservacion;
    }
}

