using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelCore.dominio.entidades.Objetos;

    public interface IRepositorioAdministrador
    {
    bool insertar(Administrador admin);
    Administrador obtenerAdmin(int id);
    bool actualizar(Administrador admin);
    bool eliminar(int id);

    List<Administrador> obtenerTodosAdmin();

}
