using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Http;

namespace ContactManager.AcceptanceTests
{
    public class Bootstrapper
    {
        public void Configure(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "API Default",
                routeTemplate: "{controller}/{id}",
                defaults: new { 
                    controller = "Contact",
                    id = RouteParameter.Optional
                }
                );

            config.Formatters.JsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
        }        
    }
}
