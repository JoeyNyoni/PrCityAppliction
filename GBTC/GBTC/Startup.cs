using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GBTC.Startup))]
namespace GBTC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
