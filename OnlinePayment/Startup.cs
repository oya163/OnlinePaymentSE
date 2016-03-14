using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OnlinePayment.Startup))]
namespace OnlinePayment
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
