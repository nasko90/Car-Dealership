using System;
using System.Web.Http;
using CarDealershi.Context.Context;
using CarDealership.Models;

namespace CarDealership
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            //config.MapHttpAttributeRoutes();

            //config.Routes.MapHttpRoute(
            //    name: "DefaultApi",
            //    routeTemplate: "api/{controller}/{id}",
            //    defaults: new { id = RouteParameter.Optional }
            //);

            var context = new CarDealershipContext();
            var model = new CarModel {Name = "Civic", Manufacturer = "Honda"};
            var car = new Car
            {
                VIN = "12345678901234567111",
                Price = 15000,
                YearProduced = 2005
            };
            var saleInfo = new SaleInfo {Car = car, SalesDate = new DateTime(2016,06,06)};

            car.SalesInfo = saleInfo;
        }
    }
}
