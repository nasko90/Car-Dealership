using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarDealershi.Context.Context;
using CarDealership.Models;

namespace Testing
{
    public class Class1
    {
        public static void Main()
        {
            var context = new CarDealershipContext();
            var model = new CarModel { Name = "Civic", Manufacturer = "Honda" };
            var car = new Car
            {
                VIN = "12345678901234567111",
                Price = 15000,
                YearProduced = 2005
            };
            var saleInfo = new SaleInfo { Car = car, SalesDate = new DateTime(2016, 06, 06) };

            car.SalesInfo = saleInfo;
        }
    }
}
