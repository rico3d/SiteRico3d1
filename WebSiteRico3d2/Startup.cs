using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebSiteRico3d2.Startup))]
namespace WebSiteRico3d2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
