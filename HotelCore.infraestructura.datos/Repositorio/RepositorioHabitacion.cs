using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelCore.dominio.entidades.Objetos;
using HotelCore.infraestructura.datos.Modelo;

public class RepositorioHabitacion : IRepositorioHabitacion
{
    private HotelDBEntities db = new HotelDBEntities();
    public bool actualizar(Habitacion habitacion)
    {
        throw new NotImplementedException();
    }

    public bool eliminar(int numero)
    {
        throw new NotImplementedException();
    }

    public bool insertar(Habitacion habitacion)
    {
        throw new NotImplementedException();
    }

    public Habitacion obtenerHabitacion(int numero)
    {
        throw new NotImplementedException();
    }

    public List<Habitacion> obtenerHabitaciones()
    {
        List<Habitacion> habitaciones = new List<Habitacion>();
        DateTime fechaDeHoy = DateTime.Today;

        var habitacionReservadas = from Habitacion h in db.Habitacion
                                   join Reservacion r in db.Reservacion
                                   on h.numero_Habitacion equals r.idHabitacion_Reservacion
                                   where fechaDeHoy >= r.fechaLLegada_Reservacion && fechaDeHoy <= r.fechaSalida_Reservacion
                                   select new
                                   {
                                       h
                                   };
        var habitacionesDisponibles = from Habitacion h in db.Habitacion
                                      where h.estado_Habitacion == "Disponible"
                                      select new
                                      {
                                          h
                                      };

        foreach (var habitacion in habitacionReservadas)
        {
            habitaciones.Add(habitacion.h);
        }

        foreach (var habitacion in habitacionesDisponibles)
        {
            habitaciones.Add(habitacion.h);
        }

        return habitaciones;
    }
}
