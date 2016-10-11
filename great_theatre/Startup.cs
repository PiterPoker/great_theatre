using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(great_theatre.Startup))]
namespace great_theatre
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
