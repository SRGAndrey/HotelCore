using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelCore.dominio.entidades.Objetos;
using HotelCore.infraestructura.datos.Modelo;
using System.Data.Entity;

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

    public List<AdministrarHabitacion> obtenerTodas()
    {
        var TipoYHabitaciones = new List<AdministrarHabitacion>();
        var obj = new AdministrarHabitacion();
        var tipo = db.Tipo_Habitacion.ToList();
        foreach (var tipoHabitacion in tipo)
        {
            var habitacion = db.Habitacion.Where(q => q.tipo_Habitacion_Habitacion == tipoHabitacion.nombre_Tipo_Habitacion).OrderBy(q => q.numero_Habitacion).ToList();
            obj.nombre_Tipo_Habitacion = tipoHabitacion.nombre_Tipo_Habitacion;
            obj.habitaciones = habitacion;
            TipoYHabitaciones.Add(obj);
            obj = new AdministrarHabitacion();
        }

        return TipoYHabitaciones;
    }

    public Tipo_Habitacion obtenerTipoHabitacion(string tipo)
    {
        Tipo_Habitacion tipoHabitacion = db.Tipo_Habitacion.Find(tipo);
        return tipoHabitacion;
    }

    public Tipo_Habitacion actualizarTipo(string tipo, string descripcion, double tarifa)
    {

        Tipo_Habitacion habitacion = new Tipo_Habitacion();
        habitacion.descripcion_Tipo_Habitacion = descripcion;
        habitacion.hotel_Tipo_Habitacion = "Patito";
        habitacion.tarifa_Tipo_Habitacion = tarifa;
        habitacion.nombre_Tipo_Habitacion = tipo;
        db.Entry(habitacion).State = EntityState.Modified;
        db.SaveChanges();
        return db.Tipo_Habitacion.Find(tipo); ;
    }
    public void actualizarImagenTH(Imagen nuevaImagen)
    {

        var imagen = db.Imagen.Single((u => u.id_Imagen == nuevaImagen.id_Imagen));
        imagen.imagen_Imagen = nuevaImagen.imagen_Imagen;
        try
        {
            db.SaveChanges();
        }
        catch (Exception ex)
        {
            //return null;
        }

        //TipoHabitacionConImagenes hotelConImagenes = new TipoHabitacionConImagenes();

        //return hotelConImagenes;
    }

    public List<HabitacionesDisponibles> obtenerHabitaciones(DateTime fechaInicio, DateTime fechaFinal, string tipo)
    {
        List<HabitacionesDisponibles> hds = new List<HabitacionesDisponibles>();//habitaciones disponibles        
        Habitacion habitacion = new Habitacion();//habitacion para obtener
        Tipo_Habitacion tipoHabitacion = new Tipo_Habitacion();//tipo de habitacion en la BD

        int cantidadDias = (int)(fechaFinal - fechaInicio).TotalDays;
        float costoTotal = 0;

        //recorrer todos los tipos que solicita el usuario

        //Obtener todas las habitaciones por el tipo actual
        var habitaciones = from Habitacion h in db.Habitacion
                           join Tipo_Habitacion th in db.Tipo_Habitacion
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

                           };//creación de la habitacion 

        foreach (var miHabitacion in habitaciones)
        {
            var reservada = from Reservacion r in db.Reservacion
                            where r.idHabitacion_Reservacion == miHabitacion.numero_Habitacion
                            select new
                            {
                                r.id_Reservacion,
                                r.fechaLLegada_Reservacion,
                                r.fechaSalida_Reservacion,
                                r.idCliente_Reservacion,
                                r.idHabitacion_Reservacion,
                            };
            var tam = reservada.Count();
            if (tam > 0)//si está en la tabla reservada
            {
                foreach (var reserv in reservada)
                {
                    if (fechaInicio >= reserv.fechaLLegada_Reservacion && fechaInicio <= reserv.fechaSalida_Reservacion ||
                        fechaFinal >= reserv.fechaLLegada_Reservacion && fechaFinal <= reserv.fechaSalida_Reservacion ||
                        reserv.fechaLLegada_Reservacion >= fechaInicio && reserv.fechaLLegada_Reservacion <= fechaFinal ||
                        reserv.fechaSalida_Reservacion >= fechaInicio && reserv.fechaSalida_Reservacion <= fechaFinal)
                    {
                        break;//si la habitación está reservada no se puede tomar en cuenta
                    }//if
                    else //si está en reservada pero no se reservó en el rango de fechas entra
                    {
                        //creación de la habitación temporal que se genera según los filtros empleados.
                        HabitacionesDisponibles habitacionTemp = new HabitacionesDisponibles();

                        costoTotal = (cantidadDias * (float)miHabitacion.tarifa_Tipo_Habitacion);

                        habitacionTemp.numero_Habitacion = miHabitacion.numero_Habitacion;
                        habitacionTemp.tipo_Habitacion = miHabitacion.tipo_Habitacion_Habitacion;
                        habitacionTemp.costo = costoTotal;

                        hds.Add(habitacionTemp);//se agrega la habitación a la lista que se retornará

                    }//else
                }//foreach de reservaciones
            }//if reservada.Count
            else // si no está en la tabla reservada está libre y se agraga
            {
                //creación de la habitación temporal que se genera según los filtros empleados.
                HabitacionesDisponibles habitacionTemp = new HabitacionesDisponibles();

                costoTotal = (cantidadDias * (float)miHabitacion.tarifa_Tipo_Habitacion);

                habitacionTemp.numero_Habitacion = miHabitacion.numero_Habitacion;
                habitacionTemp.tipo_Habitacion = miHabitacion.tipo_Habitacion_Habitacion;
                habitacionTemp.costo = costoTotal;

                hds.Add(habitacionTemp);//se agrega la habitación a la lista que se retornará

            }//else
        }//foreach de habitaciones

        return hds;

    }//obtenerHabitaciones
}
