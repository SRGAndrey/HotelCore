using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelCore.dominio.entidades.Objetos;
using HotelCore.infraestructura.datos.Modelo;

public class RepositorioFacilidad : IRepositorioFacilidad
{
    private HotelDBEntities db = new HotelDBEntities();
    public bool actualizar(Facilidad facilidad)
    {
        throw new NotImplementedException();
    }

    public bool eliminar(int id)
    {
        throw new NotImplementedException();
    }

    public bool insertar(Facilidad facilidad)
    {
        throw new NotImplementedException();
    }

    public Facilidad obtenerFacilidad(string nombre)
    {
        throw new NotImplementedException();
    }

    public List<Facilidad> obtenerFacilidades()
    {
        List<Facilidad> facilidades = new List<Facilidad>();
        facilidades = db.Facilidad.ToList();
        return facilidades;
    }
}

