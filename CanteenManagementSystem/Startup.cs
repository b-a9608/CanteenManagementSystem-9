using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CanteenManagementSystem.Startup))]
namespace CanteenManagementSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
