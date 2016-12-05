using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Black15.Startup))]
namespace Black15
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
