using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LolArgentina.Startup))]
namespace LolArgentina
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
