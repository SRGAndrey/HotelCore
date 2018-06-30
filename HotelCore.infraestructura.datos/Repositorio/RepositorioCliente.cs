using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelCore.dominio.entidades.Objetos;
using HotelCore.infraestructura.datos.Modelo;

namespace HotelCore.infraestructura.datos.Repositorio
{
    public class RepositorioCliente : IRepositorioCliente
    {
        private HotelDBEntities db = new HotelDBEntities(); //base de datos
        public bool actualizar(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public bool eliminar(string cedula)
        {
            throw new NotImplementedException();
        }

        public bool insertar(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public Cliente obtenerCliente(string cedula) { 
        Cliente cliente = new Cliente();
            try {
                cliente = db.Cliente.Find(cedula);
                return cliente;
            }
            catch (Exception ex) {
                return cliente;
            }          
        }//obtenerCliente

        public List<Cliente> obtenerClientes()
        {
            throw new NotImplementedException();
        }
    }//fin de clase
}//namespace
