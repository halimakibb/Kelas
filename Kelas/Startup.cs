using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Kelas.Startup))]
namespace Kelas
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
