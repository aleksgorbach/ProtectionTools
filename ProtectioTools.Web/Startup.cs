using Microsoft.Owin;
using ProtectionTools.Web;

[assembly: OwinStartup(typeof(Startup))]
namespace ProtectionTools.Web
{
    using Owin;

    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
