using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Day4RestaurantApp.Startup))]
namespace Day4RestaurantApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
