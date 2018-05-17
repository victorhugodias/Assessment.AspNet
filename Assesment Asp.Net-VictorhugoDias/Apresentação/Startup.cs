using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Apresentação.Startup))]
namespace Apresentação
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
