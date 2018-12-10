using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ConsortaMVC.Startup))]
namespace ConsortaMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
