using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LetUsPlay.Startup))]
namespace LetUsPlay
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
