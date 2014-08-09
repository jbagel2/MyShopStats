using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyShopStatistics.Startup))]
namespace MyShopStatistics
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
