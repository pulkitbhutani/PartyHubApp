using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PartyHub.Startup))]
namespace PartyHub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
