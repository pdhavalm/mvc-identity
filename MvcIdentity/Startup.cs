using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcIdentity.Startup))]
namespace MvcIdentity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
