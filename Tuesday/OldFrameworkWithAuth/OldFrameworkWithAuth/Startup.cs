using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OldFrameworkWithAuth.Startup))]
namespace OldFrameworkWithAuth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
