using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Dive.Pad.Web.Forms.Startup))]
namespace Dive.Pad.Web.Forms
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
