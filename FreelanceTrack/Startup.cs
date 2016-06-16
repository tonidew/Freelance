using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FreelanceTrack.Startup))]
namespace FreelanceTrack
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
