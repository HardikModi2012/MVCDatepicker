using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCDateRange.Startup))]
namespace MVCDateRange
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
