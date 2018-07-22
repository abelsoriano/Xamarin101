using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ListXampleFromApiRest.Backend.Startup))]
namespace ListXampleFromApiRest.Backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
