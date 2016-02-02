using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ClubMall.Startup))]
namespace ClubMall
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
