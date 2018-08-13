using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Proyecto.UI.Startup))]
namespace Proyecto.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
