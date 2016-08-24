using System.Net.Http.Headers;
using System.Web.Http;
using Owin;

namespace Itm_lunchWebAPI
{
    public class WebApiConfig
    {
        public static void Configure(IAppBuilder App)
        {
            HttpConfiguration config = new HttpConfiguration();

            //Web API routes
            config.MapHttpAttributeRoutes();
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new {id = RouteParameter.Optional});

            //Json formatter
            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));

            App.UseWebApi(config);
        }
    }
}