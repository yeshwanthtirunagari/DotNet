using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestMVC823.Startup))]
namespace TestMVC823
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
