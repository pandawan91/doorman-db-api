namespace doorman_db_api
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http.Formatting;
    using System.Web.Http;

    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web-API-Konfiguration und -Dienste
            GlobalConfiguration.Configuration.Formatters.JsonFormatter.MediaTypeMappings
                .Add(new RequestHeaderMapping("Accept",
                    "text/html",
                    StringComparison.InvariantCultureIgnoreCase,
                    true,
                    "application/json"));

            // Web-API-Routen
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "AddCard",
                routeTemplate: "api/card/add",
                defaults: new { controller = "Card", action = "Add" }
            );

            config.Routes.MapHttpRoute(
                name: "ValidateCard",
                routeTemplate: "api/card/validate/{cardId}",
                defaults: new { controller = "Card", action = "Validate" }
            );

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
