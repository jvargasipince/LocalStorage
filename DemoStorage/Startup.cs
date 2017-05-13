using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemoStorage.Startup))]
namespace DemoStorage
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
