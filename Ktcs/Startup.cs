using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ktcs.Startup))]
namespace Ktcs
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
