using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelCore.dominio.entidades.Objetos;
using HotelCore.infraestructura.datos.Modelo;
using System.Data.Entity;

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
    public Facilidad actualizarFacilidad(string id, string descripcion, string nombre)
    {

        Facilidad facilidad = new Facilidad();

        facilidad.hotel_Facilidad = "Patito";
        facilidad.descripcion_Facilidad = descripcion;
        facilidad.nombre_Facilidad = nombre;
        facilidad.id_Facilidad = id;
        
        db.Entry(facilidad).State = EntityState.Modified;
        db.SaveChanges();
        return db.Facilidad.Find(id); ;
    }
    public Facilidad obtenerTipoFacilidad(string id)
    {
        Facilidad facilidad = db.Facilidad.Find(id);
        return facilidad;
    }
}

