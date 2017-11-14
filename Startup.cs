using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCDevOps.Startup))]
namespace MVCDevOps
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
