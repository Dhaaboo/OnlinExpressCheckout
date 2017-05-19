using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OnlinExpressCheckout.Startup))]
namespace OnlinExpressCheckout
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
