using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProyISW.Startup))]
namespace ProyISW
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
