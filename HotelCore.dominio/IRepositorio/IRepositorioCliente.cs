using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelCore.dominio.entidades.Objetos;
    interface IRepositorioCliente
    {
    bool create(Cliente cliente);
    Cliente retrieve(int id);
    bool update(Cliente distrito);
    bool delete(int id);
}

