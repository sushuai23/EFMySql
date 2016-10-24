using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EFMySql.Startup))]
namespace EFMySql
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            
        }
    }
}
