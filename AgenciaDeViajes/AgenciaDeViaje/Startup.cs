using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AgenciaDeViaje.Startup))]
namespace AgenciaDeViaje
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
