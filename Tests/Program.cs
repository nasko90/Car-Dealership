using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarDealershi.Context.Context;
using CarDealership.Models;

namespace Tests
{
    class Program
    {
        private static Random random = new Random();

        static void Main(string[] args)
        {
            var context = new CarDealershipContext();
            var randomModel = new Random();

            for (int i = 0; i < 500; i++)
            {
                var car = new Car
                {
                    VIN = RandomString(17),
                    Price = randomModel.Next(4000, 65000),
                    CarModel = context.CarModels.Find(randomModel.Next(1, 11)),
                    YearProduced = randomModel.Next(2002, 2017),                                       
                };

                car.SalesInfo = new SaleInfo
                {
                    Car = car,
                    SalesDate = RandomDay()
                };

                context.Cars.Add(car);
                context.SaveChanges();
            }

        }

        private static Random gen = new Random();
        private static DateTime RandomDay()
        {
            DateTime start = new DateTime(2014, 1, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(gen.Next(range));
        }

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
