using HotelCore.dominio.entidades.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IRepositorioImagen
{
    bool insertarImagen(Imagen imagen);
    Imagen obtenerImagen(int idEntidad, String descripcion);
    bool actualizar(int id);
    bool eliminar(int id);

    List<Imagen> obtenerImagenes(int idEntidad);
}

