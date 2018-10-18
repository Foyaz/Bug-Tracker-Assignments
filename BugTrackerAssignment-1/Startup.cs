using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BugTrackerAssignment_1.Startup))]
namespace BugTrackerAssignment_1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
