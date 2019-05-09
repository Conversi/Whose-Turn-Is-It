using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Whose_Turn_Is_It.Startup))]
namespace Whose_Turn_Is_It
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
