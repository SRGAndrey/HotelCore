using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelCore.dominio.entidades.Objetos;

public class ImagenLN : IImagenLN
{
    private IRepositorioImagen dominio;

    public ImagenLN(IRepositorioImagen repositorio)
    {
        dominio = repositorio;
    }
    public List<ImagenesBar> obtenerImagenesBar()
    {
        List<ImagenesBar> imagenesBar;
        imagenesBar = dominio.obtenerImagenesBar();
        return imagenesBar;
    }

    public List<ImagenesCafeteria> obtenerImagenesCafeteria()
    {
        List<ImagenesCafeteria> imagenesCafeteria;
        imagenesCafeteria = dominio.obtenerImagenesCafeteria();
        return imagenesCafeteria;
    }

    public List<ImagenesDescripcion> obtenerImagenesDescripcion()
    {
        List<ImagenesDescripcion> imagenesDescripcion;
        imagenesDescripcion = dominio.obtenerImagenesDescripcion();
        return imagenesDescripcion;
    }

    public List<ImagenesFacilidades> obtenerImagenesFacilidades()
    {
        List<ImagenesFacilidades> imagenesFacilidades;
        imagenesFacilidades = dominio.obtenerImagenesFacilidades();
        return imagenesFacilidades;
    }

    public List<ImagenesHotel> obtenerImagenesHotel()
    {
        List<ImagenesHotel> imagenesHotel;
        imagenesHotel = dominio.obtenerImagenesHotel();
        return imagenesHotel;
    }

    public List<ImagenesInfantiles> obtenerImagenesInfantiles()
    {
        List<ImagenesInfantiles> imagenesInfantiles;
        imagenesInfantiles = dominio.obtenerImagenesInfantiles();
        return imagenesInfantiles;
    }

    public List<ImagenesJacuzzi> obtenerImagenesJacuzzi()
    {
        List<ImagenesJacuzzi> imagenesJacuzzi;
        imagenesJacuzzi = dominio.obtenerImagenesJacuzzi();
        return imagenesJacuzzi;
    }

    public ImagenesJunior obtenerImagenesJunior()
    {
        ImagenesJunior imagenesJunior;
        imagenesJunior = dominio.obtenerImagenesJunior();
        return imagenesJunior;
    }

    public List<ImagenesPiscina> obtenerImagenesPiscina()
    {
        List<ImagenesPiscina> imagenesPiscina;
        imagenesPiscina = dominio.obtenerImagenesPiscina();
        return imagenesPiscina;
    }

    public List<ImagenesRestaurante> obtenerImagenesRestaurante()
    {
        List<ImagenesRestaurante> imagenesRestaurante;
        imagenesRestaurante = dominio.obtenerImagenesRestaurante();
        return imagenesRestaurante;
    }

    public List<ImagenesSobreNosotros> obtenerImagenesSobreNosotros()
    {
        List<ImagenesSobreNosotros> imagenesSobreNosotros;
        imagenesSobreNosotros = dominio.obtenerImagenesSobreNosotros();
        return imagenesSobreNosotros;
    }

    public ImagenesStandard obtenerImagenesStandard()
    {
        ImagenesStandard imagenesStandard;
        imagenesStandard = dominio.obtenerImagenesStandard();
        return imagenesStandard;
    }

    public ImagenesSuite obtenerImagenesSuite()
    {
        ImagenesSuite imagenesSuite;
        imagenesSuite = dominio.obtenerImagenesSuite();
        return imagenesSuite;
    }

    public List<ImagenesTenis> obtenerImagenesTenis()
    {
        List<ImagenesTenis> imagenesTenis;
        imagenesTenis = dominio.obtenerImagenesTenis();
        return imagenesTenis;
    }
}

