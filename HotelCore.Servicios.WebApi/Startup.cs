using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HotelCore.Servicios.WebApi.Startup))]
namespace HotelCore.Servicios.WebApi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
