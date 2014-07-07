using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RecipeApp.Web.Startup))]
namespace RecipeApp.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
