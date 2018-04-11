using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OrderRestaurant.Startup))]
namespace OrderRestaurant
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
