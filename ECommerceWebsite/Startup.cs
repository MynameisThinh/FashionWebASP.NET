using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ECommerceWebsite.Startup))]
namespace ECommerceWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
