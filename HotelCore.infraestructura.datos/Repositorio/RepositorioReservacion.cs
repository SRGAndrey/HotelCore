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
        habitDisponible = null;

        Habitacion habitacion = new Habitacion();
        Tipo_Habitacion tipoHabitacion = new Tipo_Habitacion();

        RepositorioImagen repoImagen = new RepositorioImagen();
        ImagenesJunior imagenJunior = repoImagen.obtenerImagenesJunior();
        ImagenesStandard imagenStandard = repoImagen.obtenerImagenesStandard();
        ImagenesSuite imagenSuite = repoImagen.obtenerImagenesSuite();

        contexto.actualiza_Estado_Habitacion();

        int cambioFecha = 0;

        while (habitDisponible == null)
        {
            var habitaciones = from Habitacion h in contexto.Habitacion
                               join Tipo_Habitacion th in contexto.Tipo_Habitacion
                               on h.tipo_Habitacion_Habitacion equals th.nombre_Tipo_Habitacion
                               where th.nombre_Tipo_Habitacion == tipo
                               select new
                               {
                                   h.estado_Habitacion,
                                   h.numero_Habitacion,
                                   h.tipo_Habitacion_Habitacion,
                                   th.descripcion_Tipo_Habitacion,
                                   th.nombre_Tipo_Habitacion,
                                   th.tarifa_Tipo_Habitacion,

                               };

            foreach (var miHabitacion in habitaciones)
            {
                var reservada = from Reservacion r in contexto.Reservacion
                                where r.idHabitacion_Reservacion == miHabitacion.numero_Habitacion

                                select new
                                {
                                    r.id_Reservacion,
                                    r.fechaLLegada_Reservacion,
                                    r.fechaSalida_Reservacion,
                                    r.idCliente_Reservacion,
                                    r.idHabitacion_Reservacion,
                                };
                if (reservada.Count() > 0)
                {
                    foreach (var reserv in reservada)
                    {
                        if (fechaInicio >= reserv.fechaLLegada_Reservacion && fechaInicio <= reserv.fechaSalida_Reservacion ||
                            fechaFinal >= reserv.fechaLLegada_Reservacion && fechaFinal <= reserv.fechaSalida_Reservacion ||
                            reserv.fechaLLegada_Reservacion >= fechaInicio && reserv.fechaLLegada_Reservacion <= fechaFinal ||
                            reserv.fechaSalida_Reservacion >= fechaInicio && reserv.fechaSalida_Reservacion <= fechaFinal))
                        {
                            break;
                        }
                        else
                        {
                            habitDisponible = getHabitDisponible(miHabitacion.estado_Habitacion, miHabitacion.numero_Habitacion,
                            miHabitacion.tipo_Habitacion_Habitacion, miHabitacion.descripcion_Tipo_Habitacion, miHabitacion.tarifa_Tipo_Habitacion,
                            fechaInicio, fechaFinal, imagenStandard, imagenSuite, imagenJunior);

                            if (cambioFecha == 1)
                            {
                                habitDisponible.mensaje = "No pudimos encontrar una habitacion en dentro de las fechas indicadas," +
                                                           " sin embargo," + "le ofrecemos una habitacion similar para estas fechas";
                            }
                            else
                            {
                                habitDisponible.mensaje = "Hemos encontrado esta habitacion para usted";
                            }

                            return habitDisponible;

                        }
                    }
                }
                else
                {
                    habitDisponible = getHabitDisponible(miHabitacion.estado_Habitacion, miHabitacion.numero_Habitacion, miHabitacion.tipo_Habitacion_Habitacion,
                                        miHabitacion.descripcion_Tipo_Habitacion, miHabitacion.tarifa_Tipo_Habitacion, fechaInicio, fechaFinal, imagenStandard,
                                        imagenSuite, imagenJunior);
                    if (cambioFecha == 1)
                    {
                        habitDisponible.mensaje = "No pudimos encontrar una habitacion dentro de las fechas indicadas," +
                                                   " sin embargo," + "le ofrecemos una habitacion similar para estas fechas";
                    }
                    else
                    {
                        habitDisponible.mensaje = "Hemos encontrado esta habitacion para usted";
                    }

                    return habitDisponible;
                }
            }
            cambioFecha = 1;
            fechaInicio = fechaInicio.AddDays(1);
            fechaFinal = fechaFinal.AddDays(1);
        }
        return habitDisponible;
        //while (disponible == false)
        //{
        //    var resultados = from Reservacion r in contexto.Reservacion
        //                     join Habitacion h in contexto.Habitacion
        //                     on r.idHabitacion_Reservacion equals h.numero_Habitacion
        //                     join Tipo_Habitacion th in contexto.Tipo_Habitacion
        //                     on h.tipo_Habitacion_Habitacion equals th.nombre_Tipo_Habitacion
        //                     where r.fechaLLegada_Reservacion == fechaInicio
        //                     where r.fechaSalida_Reservacion == fechaFinal
        //                     where h.estado_Habitacion == "Inactiva"
        //                     where th.nombre_Tipo_Habitacion == tipo
        //                     select new
        //                     {
        //                         h.numero_Habitacion,
        //                         h.estado_Habitacion,
        //                         th.nombre_Tipo_Habitacion,
        //                         th.descripcion_Tipo_Habitacion,
        //                         th.tarifa_Tipo_Habitacion
        //                     };

        //    if (resultados.Count() >= 1)
        //    {
        //        fechaInicio = fechaInicio.AddDays(1);
        //        fechaFinal = fechaFinal.AddDays(1);
        //        encontrado = 0;

        //    }
        //    else
        //    {

        //        var habitacionesDisponibles = from Habitacion h in contexto.Habitacion
        //                                      join Tipo_Habitacion th in contexto.Tipo_Habitacion
        //                                      on h.tipo_Habitacion_Habitacion equals th.nombre_Tipo_Habitacion
        //                                      where h.estado_Habitacion == "Activa"
        //                                      where th.nombre_Tipo_Habitacion == tipo
        //                                      select new
        //                                      {
        //                                          h.numero_Habitacion,
        //                                          h.estado_Habitacion,
        //                                          th.nombre_Tipo_Habitacion,
        //                                          th.descripcion_Tipo_Habitacion,
        //                                          th.tarifa_Tipo_Habitacion
        //                                      };

        //        foreach (var habitacionDisp in habitacionesDisponibles)
        //        {
        //            habitacion.numero_Habitacion = habitacionDisp.numero_Habitacion;
        //            habitacion.estado_Habitacion = habitacionDisp.estado_Habitacion;
        //            habitacion.tipo_Habitacion_Habitacion = habitacionDisp.nombre_Tipo_Habitacion;

        //            tipoHabitacion.nombre_Tipo_Habitacion = habitacionDisp.nombre_Tipo_Habitacion;
        //            tipoHabitacion.tarifa_Tipo_Habitacion = habitacionDisp.tarifa_Tipo_Habitacion;
        //            tipoHabitacion.descripcion_Tipo_Habitacion = habitacionDisp.descripcion_Tipo_Habitacion;

        //            habitDisponible.habitacion = habitacion;
        //            habitDisponible.tipoHabitacion = tipoHabitacion;
        //            habitDisponible.imagenJunior = imagenJunior;
        //            habitDisponible.imagenStandard = imagenStandard;
        //            habitDisponible.imagenSuite = imagenSuite;

        //            habitDisponible.fechaInic = fechaInicio;
        //            habitDisponible.fechaFin = fechaFinal;
        //            break;
        //        }
        //        disponible = true;
        //    }

        //}

    }

    public Reservacion insertarReservacion(Reservacion nuevaReservacion, Cliente cliente)
    {
        Reservacion reserv = new Reservacion();
        try
        {
            var proced = 0;
            proced = contexto.insertar_Reservacion(nuevaReservacion.fechaLLegada_Reservacion, nuevaReservacion.fechaSalida_Reservacion,
                nuevaReservacion.idHabitacion_Reservacion, cliente.cedula_Cliente, cliente.nombre_Cliente, cliente.apellidos_Cliente,
                cliente.tarjeta_Cliente, cliente.email_Cliente);

            contexto.SaveChanges();

            if (proced != 0)
            {
                var consulta = contexto.Reservacion
                    .Where(t => t.idHabitacion_Reservacion == nuevaReservacion.idHabitacion_Reservacion);

                foreach (var reserva in consulta)
                {
                    reserv = reserva;
                    break;
                }
                return reserv;
            }
            else
            {
                reserv = null;
                return reserv;
            }

        }
        catch (Exception ex)
        {
            reserv = null;
            return reserv;
        }
    }

    public HabitacionDisponible getHabitDisponible(string estadoHab, int numeroHab, string tipoHab, string descripHab, double tarifaHab,
        System.DateTime fechaInic, System.DateTime fechaFin, ImagenesStandard imgStandard, ImagenesSuite imgSuite, ImagenesJunior imgJunior)
    {
        HabitacionDisponible habitDisponible = new HabitacionDisponible();

        Habitacion habitacion = new Habitacion();
        Tipo_Habitacion tipoHabitacion = new Tipo_Habitacion();

        habitacion.estado_Habitacion = estadoHab;
        habitacion.numero_Habitacion = numeroHab;
        habitacion.tipo_Habitacion_Habitacion = tipoHab;

        tipoHabitacion.descripcion_Tipo_Habitacion = descripHab;
        tipoHabitacion.nombre_Tipo_Habitacion = tipoHab;
        tipoHabitacion.tarifa_Tipo_Habitacion = tarifaHab;

        habitDisponible.fechaFin = fechaFin;
        habitDisponible.fechaInic = fechaInic;
        habitDisponible.habitacion = habitacion;
        habitDisponible.tipoHabitacion = tipoHabitacion;
        habitDisponible.imagenJunior = imgJunior;
        habitDisponible.imagenStandard = imgStandard;
        habitDisponible.imagenSuite = imgSuite;

        return habitDisponible;
    }
}



