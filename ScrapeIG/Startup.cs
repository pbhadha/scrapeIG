using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ScrapeIG.Startup))]
namespace ScrapeIG
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
