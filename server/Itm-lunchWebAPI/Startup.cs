using Itm_lunchWebAPI;
using Microsoft.Owin;
using Owin;
[assembly: OwinStartup(typeof(Startup))]
namespace Itm_lunchWebAPI
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseCors(Microsoft.Owin.Cors.CorsOptions.AllowAll);
            WebApiConfig.Configure(app);
        }

    }
}