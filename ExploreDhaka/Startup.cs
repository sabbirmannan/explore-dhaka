using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExploreDhaka.Startup))]
namespace ExploreDhaka
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
