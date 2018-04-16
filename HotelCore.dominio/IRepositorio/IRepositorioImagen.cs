using HotelCore.dominio.entidades.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IRepositorioImagen
{
    List<ImagenesHotel> obtenerImagenesHotel();
    List<ImagenesBar> obtenerImagenesBar();
    List<ImagenesCafeteria> obtenerImagenesCafeteria();
    List<ImagenesDescripcion> obtenerImagenesDescripcion();
    List<ImagenesFacilidades> obtenerImagenesFacilidades();
    List<ImagenesInfantiles> obtenerImagenesInfantiles();
    List<ImagenesJacuzzi> obtenerImagenesJacuzzi();
    List<ImagenesPiscina> obtenerImagenesPiscina();
    List<ImagenesRestaurante> obtenerImagenesRestaurante();
    List<ImagenesSobreNosotros> obtenerImagenesSobreNosotros();
    List<ImagenesTenis> obtenerImagenesTenis();
}

