using System;
using System.Collections.Generic;
using HotelCore.dominio.entidades.Objetos;
using HotelCore.infraestructura.datos.Modelo;


public class RepositorioAdministrador : IRepositorioAdministrador
{
    private ISD_HotelEntities db = new ISD_HotelEntities();

    public bool actualizar(Administrador admin)
    {
        throw new NotImplementedException();
    }

    public bool eliminar(int id)
    {
        throw new NotImplementedException();
    }

    public bool insertar(Administrador admin)
    {
        throw new NotImplementedException();
    }

    public Administrador obtenerAdmin(int id)
    {
        throw new NotImplementedException();
    }

    public List<Administrador> obtenerTodosAdmin()
    {
        throw new NotImplementedException();
    }
}

