using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EatmMVC.Startup))]
namespace EatmMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
