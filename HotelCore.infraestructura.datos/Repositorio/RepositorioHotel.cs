using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelCore.dominio.entidades.Objetos;
using HotelCore.infraestructura.datos.Modelo;

public class RepositorioHotel : IRepositorioHotel
{
    private HotelDBEntities db = new HotelDBEntities();

   
    public bool actualizar(Hotel hotel)
    {
        throw new NotImplementedException();
    }

    public bool eliminar(string nombre)
    {
        Hotel hotel = db.Hotel.Find(nombre);
        db.Hotel.Remove(hotel);
        return true;
    }

    public bool insertar(Hotel hotel)
    {
        throw new NotImplementedException();
    }

      public Hotel obtenerHotel(string nombre)
    {
        Hotel hotel = db.Hotel.Find(nombre);
        return hotel;
    }
    public Tipo_Habitacion obtenerHabitacion(string nombre)
    {
        Tipo_Habitacion hotel = db.Tipo_Habitacion.Find(nombre);
        return hotel;
    }

    public List<Hotel> obtenerHoteles()
    {
        List<Hotel> hoteles = db.Hotel.ToList();
        return hoteles;
    }

    public List<Tipo_Habitacion> obtenerHabitacion()
    {
        List<Tipo_Habitacion> habitacion = new List<Tipo_Habitacion>();
        habitacion = db.Tipo_Habitacion.ToList();
        return habitacion;
    }
}

