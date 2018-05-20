using HotelCore.dominio.entidades.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public interface IClienteLN
    {
        bool insertar(Cliente cliente);

        Cliente obtenerCliente(string cedula);

        bool actualizar(Cliente cliente);

        bool eliminar(string cedula);

        List<Cliente> obtenerClientes();
    }

