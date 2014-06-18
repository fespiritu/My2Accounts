using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(My2AccountsInAGlance.Web.Startup))]
namespace My2AccountsInAGlance.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
