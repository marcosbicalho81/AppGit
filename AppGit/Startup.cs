using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AppGit.Startup))]
namespace AppGit
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
