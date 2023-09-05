﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace ASPSec9_UPI_customization
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {

            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            // school route
            config.Routes.MapHttpRoute(
                name: "Custom",
                routeTemplate: "testapi/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

        }
    }
}
