using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelCore.dominio.entidades.Objetos;
using HotelCore.infraestructura.datos.Modelo;

public class RepositorioImagen : IRepositorioImagen
{
    private HotelDBEntities db = new HotelDBEntities();
    public bool actualizar(int id)
    {
        throw new NotImplementedException();
    }

    public bool eliminar(int id)
    {
        throw new NotImplementedException();
    }

    public bool insertarImagen(Imagen imagen)
    {
        throw new NotImplementedException();
    }

    public Imagen obtenerImagen(int idEntidad, string descripcion)
    {
        throw new NotImplementedException();
    }

    public List<Imagen> obtenerImagenes(int idEntidad)
    {
        var imagenes = db.Imagen.Where(x => x.idEntidad_Imagen == idEntidad).ToList();
        return imagenes;
    }
}

