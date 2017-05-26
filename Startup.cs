using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(sample01.Startup))]
namespace sample01
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
