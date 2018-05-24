using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(APPGestionEMS.Startup))]
namespace APPGestionEMS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
