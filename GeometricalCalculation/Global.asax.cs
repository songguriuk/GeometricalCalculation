﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace GeometricalCalculation
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(config =>
            {
                config.MapHttpAttributeRoutes();

                config.Routes.MapHttpRoute(
                    name: "DefaultApi",
                    routeTemplate: "api/{controller}/{baseWidth}/{height}",
                    defaults: new
                    {
                        baseWidth  = RouteParameter.Optional,
                        height = RouteParameter.Optional
                    }
                    );
            });
        }
    }
}