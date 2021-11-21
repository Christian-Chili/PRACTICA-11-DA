using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EjemploLoginASP5.Startup))]
namespace EjemploLoginASP5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
