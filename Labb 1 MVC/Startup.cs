using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Labb_1_MVC.Startup))]
namespace Labb_1_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
