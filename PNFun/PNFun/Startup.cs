using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PNFun.Startup))]
namespace PNFun
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
