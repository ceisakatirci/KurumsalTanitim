using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KurumsalTanitim.MVC.Startup))]
namespace KurumsalTanitim.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
