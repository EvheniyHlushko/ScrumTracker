using Microsoft.Owin;
using Owin;
using StickersWeb;
using StickersWeb.Util;

[assembly: OwinStartup(typeof(Startup))]
namespace StickersWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            AutofacConfig.ConfigureContainer();
            ConfigureAuth(app);
        }
    }
}