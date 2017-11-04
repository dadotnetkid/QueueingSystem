using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QueueingSystem.Startup))]
namespace QueueingSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
