using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelCore.dominio.entidades.Objetos;

public class HabitacionLN : IHabitacionLN
{
    private IRepositorioHabitacion dominio;

    public HabitacionLN(IRepositorioHabitacion repositorio)
    {
        dominio = repositorio;
    }
    public bool actualizar(Habitacion habitacion)
    {
        bool retorno;
        retorno = dominio.actualizar(habitacion);
        return retorno;
    }

    public bool eliminar(int numero)
    {
        bool retorno;
        retorno = dominio.eliminar(numero);
        return retorno;
    }

    public bool insertar(Habitacion habitacion)
    {
        bool retorno;
        retorno = dominio.insertar(habitacion);
        return retorno;
    }

    public Habitacion obtenerHabitacion(int numero)
    {
        Habitacion retornoHabitacion;
        retornoHabitacion = dominio.obtenerHabitacion(numero);
        return retornoHabitacion;
    }

    public List<Habitacion> obtenerHabitaciones()
    {
        List<Habitacion> retornoHabitaciones;
        retornoHabitaciones = dominio.obtenerHabitaciones();
        return retornoHabitaciones;
    }

    public List<AdministrarHabitacion> obtenerTodas()
    {
        List<AdministrarHabitacion> retornoHabitaciones;
        retornoHabitaciones = dominio.obtenerTodas();
        return retornoHabitaciones;
    }

    public Tipo_Habitacion obtenerTipoHabitacion(string tipo)
    {
        Tipo_Habitacion tipoHabitacion;
        tipoHabitacion = dominio.obtenerTipoHabitacion(tipo);
        return tipoHabitacion;
    }

    public Tipo_Habitacion actualizarTipo(string tipo, string descripcion, double tarifa)
    {
        Tipo_Habitacion tipoHabitacion;
        tipoHabitacion = dominio.actualizarTipo(tipo, descripcion, tarifa);
        return tipoHabitacion;
    }

    public List<HabitacionesDisponibles> obtenerHabitaciones(System.DateTime fechaInicio, System.DateTime fechaFinal, string tipos)
    {
        List<HabitacionesDisponibles> habitaciones = new List<HabitacionesDisponibles>();
        habitaciones = dominio.obtenerHabitaciones(fechaInicio, fechaFinal, tipos);
        return habitaciones;
    }
}

