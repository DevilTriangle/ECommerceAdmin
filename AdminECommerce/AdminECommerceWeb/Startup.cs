using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AdminECommerceWeb.Startup))]
namespace AdminECommerceWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
