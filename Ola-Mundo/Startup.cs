using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ola_Mundo.Startup))]
namespace Ola_Mundo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
