using HotelCore.dominio.entidades.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public interface IRepositorioFacilidad
{
    bool insertar(Facilidad facilidad);
    Facilidad obtenerFacilidad(String nombre);
    bool actualizar(Facilidad facilidad);
    bool eliminar(int id);
    List<Facilidad> obtenerFacilidades();
    Facilidad actualizarFacilidad(string id, string descripcion, string nombre);

    Facilidad obtenerTipoFacilidad(string id);

}

