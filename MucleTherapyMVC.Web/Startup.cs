using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MucleTherapyMVC.Web.Startup))]
namespace MucleTherapyMVC.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
