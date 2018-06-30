using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelCore.dominio.entidades.Objetos;

public class HotelLN : IHotelLN
{
    private IRepositorioHotel dominio;

    public HotelLN(IRepositorioHotel repositorio)
    {
        dominio = repositorio;
    }
    public bool actualizar(Hotel hotel)
    {
        bool retorno;
        retorno = dominio.actualizar(hotel);
        return retorno;
    }

    public bool eliminar(string nombre)
    {
        bool retorno;
        retorno = dominio.eliminar(nombre);
        return retorno;
    }

    public bool insertar(Hotel hotel)
    {
        bool retorno;
        retorno = dominio.insertar(hotel);
        return retorno;
    }

    public List<Tipo_Habitacion> obtenerHabitacion()
    {
        List<Tipo_Habitacion> retornoHabitacion;
        retornoHabitacion = dominio.obtenerHabitacion();
        return retornoHabitacion;
    }

    public Tipo_Habitacion obtenerHabitacion(string nombre)
    {
        Tipo_Habitacion retornoHabitacion;
        retornoHabitacion = dominio.obtenerHabitacion(nombre);
        return retornoHabitacion;
    }

    public Hotel obtenerHotel(string nombre)
    {
        Hotel retornoHotel;
        retornoHotel = dominio.obtenerHotel(nombre);
        return retornoHotel;
    }

    public List<Hotel> obtenerHoteles()
    {
        List<Hotel> retornoHoteles;
        retornoHoteles = dominio.obtenerHoteles();
        return retornoHoteles;
    }


    public HotelConImagenes actualizarImagenHome(Imagen nuevaImagen)
    {
        HotelConImagenes retornoHoteles;
        retornoHoteles = dominio.actualizarImagenHome(nuevaImagen);
        return retornoHoteles;
    }

    public HotelConImagenes actualizarDescripcionHome(Hotel hotel)
    {
        HotelConImagenes retornoHoteles;
        retornoHoteles = dominio.actualizarDescripcionHome(hotel);
        return retornoHoteles;

    }

    public bool actualizarsobreNosotros_Hotel(string nombre, string descripcion)
    {
        bool resultado;
        resultado = dominio.actualizarsobreNosotros_Hotel(nombre, descripcion);
        return resultado;
    }//actualizarsobreNosotros_Hotel

    public bool actualizarcomoLlegar(string nombre, string descripcion)
    {
        bool resultado;
        resultado = dominio.actualizarcomoLlegar(nombre, descripcion);
        return resultado;
    }//actualizarcomoLlegar
}

