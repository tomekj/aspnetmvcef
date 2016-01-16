using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SystemEwidencjonowaniaAR.Startup))]
namespace SystemEwidencjonowaniaAR
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
