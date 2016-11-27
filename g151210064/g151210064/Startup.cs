using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(g151210051.Startup))]
namespace g151210051
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
