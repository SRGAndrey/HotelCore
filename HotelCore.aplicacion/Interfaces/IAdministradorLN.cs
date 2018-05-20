using HotelCore.dominio.entidades.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public interface IAdministradorLN
{
    bool insertar(Administrador admin);
    Administrador obtenerAdmin(string usuario, string contraseña);
    bool actualizar(Administrador admin);
    bool eliminar(int id);

    List<Administrador> obtenerTodosAdmin();
}

