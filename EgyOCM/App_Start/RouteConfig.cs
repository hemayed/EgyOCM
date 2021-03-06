﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace EgyOCM
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
               name: "_ClusterList",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Home", action = "_ClusterList", id = UrlParameter.Optional }
           );

            routes.MapRoute(
             name: "_ClusterMap",
             url: "{controller}/{action}/{id}",
             defaults: new { controller = "Home", action = "_ClusterMap", id = UrlParameter.Optional }
         );

            routes.MapRoute(
            name: "ClusterDetail",
            url: "{controller}/{action}/{id}",
            defaults: new { controller = "Home", action = "ClusterDetail", id = UrlParameter.Optional }
        );

            routes.MapRoute(
           name: "OtherGovtClusters",
           url: "{controller}/{action}/{id}",
           defaults: new { controller = "Home", action = "OtherGovtClusters", id = UrlParameter.Optional }
       );

            routes.MapRoute(
                      name: "SimilarClusters",
                      url: "{controller}/{action}/{id}",
                      defaults: new { controller = "Home", action = "SimilarClusters", id = UrlParameter.Optional }
                  );

        }

    }
}
