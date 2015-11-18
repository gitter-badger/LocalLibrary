using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(profesor79.LocalLibraby.Web.Startup))]
namespace profesor79.LocalLibraby.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
