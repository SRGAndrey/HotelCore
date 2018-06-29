using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelCore.dominio.entidades.Objetos;

public class AdministradorLN : IAdministradorLN
{
    private IRepositorioAdministrador dominio;

    public AdministradorLN(IRepositorioAdministrador repositorio)
    {
        dominio = repositorio;
    }
    public bool actualizar(Administrador admin)
    {
        bool retornoAdmin;
        retornoAdmin = dominio.actualizar(admin);
        return retornoAdmin;
    }

    public bool eliminar(int id)
    {
        bool retorno;
        retorno = dominio.eliminar(id);
        return retorno;
    }

    public bool insertar(Administrador admin)
    {
        bool retorno;
        retorno = dominio.insertar(admin);
        return retorno;
    }

    public Administrador obtenerAdmin(string usuario, string contraseña)
    {
        Administrador retornoAdmin;
        retornoAdmin = dominio.obtenerAdmin(usuario,contraseña);
        return retornoAdmin;
    }

    public List<Administrador> obtenerTodosAdmin()
    {
        List<Administrador> retornoAdmins;
        retornoAdmins = dominio.obtenerTodosAdmin();
        return retornoAdmins;
    }
}

