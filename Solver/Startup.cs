using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Solver.Startup))]
namespace Solver
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}
