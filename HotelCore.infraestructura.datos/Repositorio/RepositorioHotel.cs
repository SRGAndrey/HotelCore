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

    public List<Hotel> obtenerHoteles()
    {
        List<Hotel> hoteles = db.Hotel.ToList();
        return hoteles;
    }
}

