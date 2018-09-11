using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DayThree_Blog.Startup))]
namespace DayThree_Blog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
