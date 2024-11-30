using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Web.Http;

namespace Api_Tienda_Virtual
{
        public static class WebApiConfig
        {
                public static void Register( HttpConfiguration config ) {

                        // Configura el formato JSON para manejar referencias circulares
                        var jsonFormatter = config.Formatters.OfType<JsonMediaTypeFormatter>().First();
                        jsonFormatter.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;

                        // Otras configuraciones...

                        // Configuración y servicios de Web API

                        // Rutas de Web API
                        config.MapHttpAttributeRoutes();


                        config.Routes.MapHttpRoute(
                            name: "DefaultApi",
                            routeTemplate: "api/{controller}/{id}",
                            defaults: new { id = RouteParameter.Optional }
                        );
                }
        }
}
