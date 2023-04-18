using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ConsumirArqui.Startup))]
namespace ConsumirArqui
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
