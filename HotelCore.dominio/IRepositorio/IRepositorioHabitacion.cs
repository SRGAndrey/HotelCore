﻿using HotelCore.dominio.entidades.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IRepositorioHabitacion
{
    bool insertar(Habitacion habitacion);

    Habitacion obtenerHabitacion(int numero);

    bool actualizar(Habitacion habitacion);

    bool eliminar(int numero);

    List<Habitacion> obtenerHabitaciones();

    List<AdministrarHabitacion> obtenerTodas();
}

