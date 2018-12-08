﻿using MyStudentsAPI.Models;
using System.Data.Entity;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace MyStudentsAPI
{
  public class WebApiApplication : System.Web.HttpApplication
  {
    protected void Application_Start()
    {
      //Database.SetInitializer(new StudentDbInitializer());
      Database.SetInitializer(new BookDbInitializer());

      AreaRegistration.RegisterAllAreas();
      GlobalConfiguration.Configure(WebApiConfig.Register);
      FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
      RouteConfig.RegisterRoutes(RouteTable.Routes);
      BundleConfig.RegisterBundles(BundleTable.Bundles);
    }
  }
}