using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Authors.Startup))]
namespace Authors
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
