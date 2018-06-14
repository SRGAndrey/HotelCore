using HotelCore.dominio.entidades.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public interface IHotelLN
    {
        bool insertar(Hotel hotel);
        Hotel obtenerHotel(String nombre);
        Tipo_Habitacion obtenerHabitacion(String nombre);

        bool actualizar(Hotel hotel);
        bool eliminar(String nombre);

        List<Hotel> obtenerHoteles();
        List<Tipo_Habitacion> obtenerHabitacion();
    }

