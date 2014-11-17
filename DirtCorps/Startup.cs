using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DirtCorps.Startup))]
namespace DirtCorps
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
