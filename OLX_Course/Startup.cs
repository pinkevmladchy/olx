using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OLX_Course.Startup))]
namespace OLX_Course
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
