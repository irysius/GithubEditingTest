using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GithubEditingTest.Startup))]
namespace GithubEditingTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
