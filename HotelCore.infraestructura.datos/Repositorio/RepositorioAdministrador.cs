using System;
using System.Collections.Generic;
using HotelCore.dominio.entidades.Objetos;
using HotelCore.infraestructura.datos.Modelo;
using System.Linq;


public class RepositorioAdministrador : IRepositorioAdministrador
{
    private HotelDBEntities contexto = new HotelDBEntities();
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

    public Administrador obtenerAdmin(string usuario, string contrasenna)
    {
        Administrador administrador = new Administrador();
        try
        {
            var admins = (from Administrador adm in contexto.Administrador
                         where adm.usuario_Administrador == usuario
                         where adm.contrasenna_Administrador == contrasenna
                         select new
                         {
                             adm

                         });
            if (admins.Count()>0)
            {
                foreach (var admin in admins)
                {
                    administrador.contrasenna_Administrador = admin.adm.contrasenna_Administrador;
                    administrador.HotelAdministrador = admin.adm.HotelAdministrador;
                    administrador.id_Administrador = admin.adm.id_Administrador;
                    administrador.Rol = admin.adm.Rol;
                    administrador.rol_Administrador = admin.adm.rol_Administrador;
                    administrador.usuario_Administrador = admin.adm.usuario_Administrador;
                    return administrador;

                }
            }
            
            return null;
        }
        catch(Exception ex)
        {
            return null;
        }

    }

    public List<Administrador> obtenerTodosAdmin()
    {
        throw new NotImplementedException();
    }
}

