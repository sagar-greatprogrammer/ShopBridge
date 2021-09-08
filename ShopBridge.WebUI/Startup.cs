using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShopBridge.WebUI.Startup))]
namespace ShopBridge.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
