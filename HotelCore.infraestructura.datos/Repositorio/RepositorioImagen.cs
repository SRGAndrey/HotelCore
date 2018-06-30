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

    

    public ImagenesJunior obtenerImagenesJunior()
    {
        ImagenesJunior imgJunior = new ImagenesJunior();
        try
        {
            return db.ImagenesJunior.First();
        }
        catch (Exception ex) {
            return imgJunior;
        }
    }


    public List<ImagenesCafeteria> obtenerImagenesCafeteria()
    {
        List<ImagenesCafeteria> imgCafeteria = new List<ImagenesCafeteria>();
        try
        {
            return db.ImagenesCafeteria.ToList();

        }
        catch (Exception ex) {
            return imgCafeteria;
        }
        
    }

    public List<ImagenesDescripcion> obtenerImagenesDescripcion()
    {
        List<ImagenesDescripcion> imgDescripcion = new List<ImagenesDescripcion>();
        try
        {
            imgDescripcion = db.ImagenesDescripcion.ToList();
            return imgDescripcion;
        }
        catch (Exception ex) {
            return imgDescripcion;
        }
    }

    public List<ImagenesFacilidades> obtenerImagenesFacilidades()
    {
        List<ImagenesFacilidades> imgFacilidades = new List<ImagenesFacilidades>();
        try
        {
            return db.ImagenesFacilidades.ToList();
        }
        catch (Exception ex)
        {
            return imgFacilidades;
        }
    }

    public List<ImagenesHotel> obtenerImagenesHotel()
    {
        List<ImagenesHotel> imgHotel = new List<ImagenesHotel>();
        try
        {
            return db.ImagenesHotel.ToList();
        }
        catch (Exception ex)
        {
            return imgHotel;
        }
    }

    public List<ImagenesInfantiles> obtenerImagenesInfantiles()
    {
        List<ImagenesInfantiles> imgInfantiles = new List<ImagenesInfantiles>();
        try
        {
            return db.ImagenesInfantiles.ToList();
        }
        catch (Exception ex)
        {
            return imgInfantiles;
        }
    }

    public List<ImagenesJacuzzi> obtenerImagenesJacuzzi()
    {
        List<ImagenesJacuzzi> imgJacuzzi = new List<ImagenesJacuzzi>();
        try
        {
            return db.ImagenesJacuzzi.ToList();
        }
        catch (Exception ex)
        {
            return imgJacuzzi;
        }
    }

    public List<ImagenesPiscina> obtenerImagenesPiscina()
    {
        List<ImagenesPiscina> imgPiscina = new List<ImagenesPiscina>();
        try
        {
            return db.ImagenesPiscina.ToList();
        }
        catch (Exception ex)
        {
            return imgPiscina;
        }
    }

    public List<ImagenesRestaurante> obtenerImagenesRestaurante()
    {
        List<ImagenesRestaurante> imgRestaurante = new List<ImagenesRestaurante>();
        try
        {
            return db.ImagenesRestaurante.ToList();
        }
        catch (Exception ex)
        {
            return imgRestaurante;
        }
    }

    public List<ImagenesSobreNosotros> obtenerImagenesSobreNosotros()
    {
        List<ImagenesSobreNosotros> imgSobreNosotros = new List<ImagenesSobreNosotros>();
        try
        {
            return db.ImagenesSobreNosotros.ToList();
        }
        catch (Exception ex)
        {
            return imgSobreNosotros;
        }
    }

    public List<ImagenesTenis> obtenerImagenesTenis()
    {
        List<ImagenesTenis> imgTenis = new List<ImagenesTenis>();
        try
        {
            return db.ImagenesTenis.ToList();
        }
        catch (Exception ex)
        {
            return imgTenis;
        }
    }

    public List<ImagenesBar> obtenerImagenesBar()
    {
        List<ImagenesBar> imgBar = new List<ImagenesBar>();
        try
        {
            return db.ImagenesBar.ToList();
        }
        catch (Exception ex)
        {
            return imgBar;
        }
    }

    public ImagenesStandard obtenerImagenesStandard()
    {
        ImagenesStandard imgStandard = new ImagenesStandard();
        try
        {
            return db.ImagenesStandard.First();
        }
        catch (Exception ex)
        {
            return imgStandard;
        }
    }
    public ImagenesSuite obtenerImagenesSuite()
    {
        ImagenesSuite imgSuite = new ImagenesSuite();
        try
        {
            return db.ImagenesSuite.First();
        }
        catch (Exception ex)
        {
            return imgSuite;
        }
    }
}

