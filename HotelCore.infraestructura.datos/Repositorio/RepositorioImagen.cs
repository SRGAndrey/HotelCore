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

    
    public List<ImagenesBar> obtenerImagenesBar()
    {
        return db.ImagenesBar.ToList();
    }

    public List<ImagenesCafeteria> obtenerImagenesCafeteria()
    {
        return db.ImagenesCafeteria.ToList();
    }

    public List<ImagenesDescripcion> obtenerImagenesDescripcion()
    {
        var imgDescripcion = db.ImagenesDescripcion.ToList();
        return imgDescripcion;
    }

    public List<ImagenesFacilidades> obtenerImagenesFacilidades()
    {
        return db.ImagenesFacilidades.ToList();
    }

    public List<ImagenesHotel> obtenerImagenesHotel()
    {
        return db.ImagenesHotel.ToList();
    }

    public List<ImagenesInfantiles> obtenerImagenesInfantiles()
    {
        return db.ImagenesInfantiles.ToList();
    }

    public List<ImagenesJacuzzi> obtenerImagenesJacuzzi()
    {
        return db.ImagenesJacuzzi.ToList();
    }

    public List<ImagenesPiscina> obtenerImagenesPiscina()
    {
        return db.ImagenesPiscina.ToList();
    }

    public List<ImagenesRestaurante> obtenerImagenesRestaurante()
    {
        return db.ImagenesRestaurante.ToList();
    }

    public List<ImagenesSobreNosotros> obtenerImagenesSobreNosotros()
    {
        return db.ImagenesSobreNosotros.ToList();
    }

    public List<ImagenesTenis> obtenerImagenesTenis()
    {
        return db.ImagenesTenis.ToList();
    }
}

