using HotelCore.dominio.entidades.Objetos;
using HotelCore.infraestructura.datos.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class RepositorioReservacion : IRespositorioReservacion
{
    private HotelDBEntities contexto = new HotelDBEntities();
    public HabitacionDisponible habitacionDisponible(System.DateTime fechaInicio, System.DateTime fechaFinal, string tipo)
    {
        HabitacionDisponible habitDisponible = new HabitacionDisponible();
        Habitacion habitacion = new Habitacion();
        Tipo_Habitacion tipoHabitacion = new Tipo_Habitacion();

        RepositorioImagen repoImagen = new RepositorioImagen();
        ImagenesJunior imagenJunior = repoImagen.obtenerImagenesJunior();
        ImagenesStandard imagenStandard = repoImagen.obtenerImagenesStandard();
        ImagenesSuite imagenSuite = repoImagen.obtenerImagenesSuite();

        bool disponible = false;
        int encontrado = 1;
        while (disponible == false)
        {
            var resultados = from Reservacion r in contexto.Reservacion
                             join Habitacion h in contexto.Habitacion
                             on r.idHabitacion_Reservacion equals h.numero_Habitacion
                             join Tipo_Habitacion th in contexto.Tipo_Habitacion
                             on h.tipo_Habitacion_Habitacion equals th.nombre_Tipo_Habitacion
                             where r.fechaLLegada_Reservacion == fechaInicio
                             where r.fechaSalida_Reservacion == fechaFinal
                             where h.estado_Habitacion == "Inactiva"
                             where th.nombre_Tipo_Habitacion == tipo
                             select new
                             {
                                 h.numero_Habitacion,
                                 h.estado_Habitacion,
                                 th.nombre_Tipo_Habitacion,
                                 th.descripcion_Tipo_Habitacion,
                                 th.tarifa_Tipo_Habitacion
                             };

            if (resultados.Count() >= 1)
            {
                fechaInicio= fechaInicio.AddDays(1);
                fechaFinal= fechaFinal.AddDays(1);
                encontrado = 0;

            }
            else
            {
                
                    var habitacionesDisponibles = from Habitacion h in contexto.Habitacion
                                                  join Tipo_Habitacion th in contexto.Tipo_Habitacion
                                                  on h.tipo_Habitacion_Habitacion equals th.nombre_Tipo_Habitacion
                                                  where h.estado_Habitacion == "Activa"
                                                  where th.nombre_Tipo_Habitacion == tipo
                                                  select new
                                                  {
                                                      h.numero_Habitacion,
                                                      h.estado_Habitacion,
                                                      th.nombre_Tipo_Habitacion,
                                                      th.descripcion_Tipo_Habitacion,
                                                      th.tarifa_Tipo_Habitacion
                                                  };

                foreach (var habitacionDisp in habitacionesDisponibles)
                {
                    habitacion.numero_Habitacion = habitacionDisp.numero_Habitacion;
                    habitacion.estado_Habitacion = habitacionDisp.estado_Habitacion;
                    habitacion.tipo_Habitacion_Habitacion = habitacionDisp.nombre_Tipo_Habitacion;

                    tipoHabitacion.nombre_Tipo_Habitacion = habitacionDisp.nombre_Tipo_Habitacion;
                    tipoHabitacion.tarifa_Tipo_Habitacion = habitacionDisp.tarifa_Tipo_Habitacion;
                    tipoHabitacion.descripcion_Tipo_Habitacion = habitacionDisp.descripcion_Tipo_Habitacion;

                    habitDisponible.habitacion = habitacion;
                    habitDisponible.tipoHabitacion = tipoHabitacion;
                    habitDisponible.imagenJunior = imagenJunior;
                    habitDisponible.imagenStandard = imagenStandard;
                    habitDisponible.imagenSuite = imagenSuite;

                    habitDisponible.fechaInic = fechaInicio;
                    habitDisponible.fechaFin = fechaFinal;
                    break;
                }
                disponible = true;
            }
            
        }
        if(encontrado == 0)
        {
            habitDisponible.mensaje = "No pudimos encontrar una habitacion en dentro de las fechas indicadas," + 
                                       " sin embargo," + "le ofrecemos una habitacion similar para estas fechas";
        }else
        {
            habitDisponible.mensaje = "Hemos encontrado esta habitacion para usted";
        }
        return habitDisponible;
    }
}

