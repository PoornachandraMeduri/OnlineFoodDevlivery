﻿using Autofac;
using Autofac.Integration.Mvc;
using OnlineFoodDelivery.Data.Services;
using System.Web.Mvc;

namespace OnlineFoodDelivery.Web
{
    public class ContainerConfig
    {
        internal static void RegisterContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterType<InMemoryRestaurantData>().As<IRestaurantService>().SingleInstance();

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container)); 
        }
    }
}