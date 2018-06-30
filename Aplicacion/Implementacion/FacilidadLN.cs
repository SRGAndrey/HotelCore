using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelCore.dominio.entidades.Objetos;

public class FacilidadLN : IFacilidadLN
{
    private IRepositorioFacilidad dominio;

    public FacilidadLN(IRepositorioFacilidad repositorio)
    {
        dominio = repositorio;
    }
    public bool actualizar(Facilidad facilidad)
    {
        bool retorno;
        retorno = dominio.actualizar(facilidad);
        return retorno;
    }

    public Facilidad actualizarFacilidad(string id, string descripcion, string nombre)
    {
        Facilidad facilidad;
        facilidad = dominio.actualizarFacilidad(id, descripcion, nombre);
        return facilidad;
    }

    public bool eliminar(int id)
    {
        bool retorno;
        retorno = dominio.eliminar(id);
        return retorno;
    }

    public bool insertar(Facilidad facilidad)
    {
        bool retorno;
        retorno = dominio.insertar(facilidad);
        return retorno;
    }

    public Facilidad obtenerFacilidad(string nombre)
    {
        Facilidad retornoFacilidad;
        retornoFacilidad = dominio.obtenerFacilidad(nombre);
        return retornoFacilidad;
    }

    public List<Facilidad> obtenerFacilidades()
    {
        List<Facilidad> retornoFacilidades;
        retornoFacilidades = dominio.obtenerFacilidades();
        return retornoFacilidades;
    }
    public Facilidad obtenerTipoFacilidad(string id)
    {
        Facilidad facilidad;
        facilidad = dominio.obtenerTipoFacilidad(id);
        return facilidad;
    }
}

