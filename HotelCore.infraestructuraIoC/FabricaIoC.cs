using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using HotelCore.dominio;
using HotelCore.infraestructura.datos.Repositorio;

public class FabricaIoC
{
    private static FabricaIoC _contenedor = new FabricaIoC();
    private IUnityContainer _unityContainer;
    private FabricaIoC()
    {
        _unityContainer = new UnityContainer();

        //Inicializar las clases que van a base datos
        _unityContainer.RegisterType<IRepositorioAdministrador, RepositorioAdministrador>();
        _unityContainer.RegisterType<IRepositorioCliente, RepositorioCliente>();
        _unityContainer.RegisterType<IRepositorioFacilidad, RepositorioFacilidad>();
        _unityContainer.RegisterType<IRepositorioHabitacion, RepositorioHabitacion>();
        _unityContainer.RegisterType<IRepositorioHotel, RepositorioHotel>();
        _unityContainer.RegisterType<IRepositorioImagen, RepositorioImagen>();
        _unityContainer.RegisterType<IRespositorioReservacion, RepositorioReservacion>();
    }

    public static FabricaIoC Contenedor
    {
        get
        {
            return _contenedor;
        }
    }

    /// <summary>
    ///   Crear una instancia de un objeto que implemente un tipo TServicio.
    /// </summary>
    /// <typeparam name = "TServicio">Tipo de servicio que deseamos resolver</typeparam>
    /// <returns></returns>
    public TServicio Resolver<TServicio>() where TServicio : class
    {
        return _unityContainer.Resolve<TServicio>();
    }

}

