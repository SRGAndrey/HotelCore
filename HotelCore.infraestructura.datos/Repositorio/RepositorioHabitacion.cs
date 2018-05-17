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
        habitaciones = db.Habitacion.ToList();
        return habitaciones;
    }
}
