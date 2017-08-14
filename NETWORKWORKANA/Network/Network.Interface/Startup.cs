using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Network.Interface.Startup))]
namespace Network.Interface
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
