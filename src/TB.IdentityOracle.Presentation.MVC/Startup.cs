using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TB.IdentityOracle.Presentation.MVC.Startup))]
namespace TB.IdentityOracle.Presentation.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
