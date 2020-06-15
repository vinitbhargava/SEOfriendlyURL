using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SEOfriendlyURL.Startup))]
namespace SEOfriendlyURL
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
