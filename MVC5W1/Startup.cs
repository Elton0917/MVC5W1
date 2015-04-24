using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC5W1.Startup))]
namespace MVC5W1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
