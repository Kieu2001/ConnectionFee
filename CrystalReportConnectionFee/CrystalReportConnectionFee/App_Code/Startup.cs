using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CrystalReportConnectionFee.Startup))]
namespace CrystalReportConnectionFee
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
