using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SISv3.Startup))]
namespace SISv3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
