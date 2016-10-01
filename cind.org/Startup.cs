using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(cind.org.Startup))]
namespace cind.org
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
