using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Djikstra.Startup))]
namespace Djikstra
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
