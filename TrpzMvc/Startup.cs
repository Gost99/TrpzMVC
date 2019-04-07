using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TrpzMvc.Startup))]
namespace TrpzMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
