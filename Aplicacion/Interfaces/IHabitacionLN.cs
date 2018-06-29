using HotelCore.dominio.entidades.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public interface IHabitacionLN
    {
        bool insertar(Habitacion habitacion);

        Habitacion obtenerHabitacion(int numero);

        bool actualizar(Habitacion habitacion);

        bool eliminar(int numero);

        List<Habitacion> obtenerHabitaciones();

        List<AdministrarHabitacion> obtenerTodas();

        Tipo_Habitacion obtenerTipoHabitacion(string tipo);

        Tipo_Habitacion actualizarTipo(string tipo, string descripcion, double tarifa);
        void actualizarImagenTH(Imagen nuevaImagen);

        List<HabitacionesDisponibles> obtenerHabitaciones(System.DateTime fechaInicio, System.DateTime fechaFinal, string tipos);
}

