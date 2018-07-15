using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ReviewSiteMVC.Startup))]
namespace ReviewSiteMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
