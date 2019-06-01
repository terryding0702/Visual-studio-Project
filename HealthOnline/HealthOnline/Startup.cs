using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HealthOnline.Startup))]
namespace HealthOnline
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
