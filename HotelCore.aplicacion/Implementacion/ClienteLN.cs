using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelCore.dominio.entidades.Objetos;

public class ClienteLN : IClienteLN
{
    private IRepositorioCliente dominio;

    public ClienteLN(IRepositorioCliente repositorio)
    {
        dominio = repositorio;
    }
    public bool actualizar(Cliente cliente)
    {
        bool retorno;
        retorno = dominio.actualizar(cliente);
        return retorno;
    }

    public bool eliminar(string cedula)
    {
        bool retorno;
        retorno = dominio.eliminar(cedula);
        return retorno;
    }

    public bool insertar(Cliente cliente)
    {
        bool retorno;
        retorno = dominio.insertar(cliente);
        return retorno;
    }

    public Cliente obtenerCliente(string cedula)
    {
        Cliente retornoCliente;
        retornoCliente = dominio.obtenerCliente(cedula);
        return retornoCliente;
    }

    public List<Cliente> obtenerClientes()
    {
        List<Cliente> retornoClientes;
        retornoClientes = dominio.obtenerClientes();
        return retornoClientes;
    }
}

