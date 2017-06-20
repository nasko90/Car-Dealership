using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
            var carDealershipContext = new CarDealershipContext();
            var carModelsArray = new Collection<CarModel>
            {
                new CarModel {Name = "Golf", Manufacturer = "VW"},
                new CarModel {Name = "Fiesta", Manufacturer = "Ford"},
                new CarModel {Name = "Polo", Manufacturer = "VW"},
                new CarModel {Name = "Clio", Manufacturer = "Renault"},
                new CarModel {Name = "Corsa", Manufacturer = "Opel"},
                new CarModel {Name = "208", Manufacturer = "Peugeot"},
                new CarModel {Name = "Qashqai", Manufacturer = "Nissan"},
                new CarModel {Name = "Astra", Manufacturer = "Opel"},
                new CarModel {Name = "Ford", Manufacturer = "Focus"},
                new CarModel {Name = "Panda", Manufacturer = "Fiat"},
                new CarModel {Name = "Octavia", Manufacturer = "Skoda"},
                new CarModel {Name = "Captur", Manufacturer = "Renault"},
                new CarModel {Name = "A3", Manufacturer = "Audi"},
                new CarModel {Name = "Yaris", Manufacturer = "Toyota"},
                new CarModel {Name = "Passat", Manufacturer = "VW"},
                new CarModel {Name = "Mikka", Manufacturer = "Opel"}
            };

            foreach (var carModel in carModelsArray)
            {
                carDealershipContext.CarModels.Add(carModel);
                carDealershipContext.SaveChanges();
            }

            var randomModel = new Random();

            for (int i = 0; i < 500; i++)
            {
                var car = new Car
                {
                    VIN = RandomString(17),
                    Price = randomModel.Next(4000, 45000),
                    CarModel = carDealershipContext.CarModels.Find(randomModel.Next(1, 16)),
                    YearProduced = randomModel.Next(2002, 2017),                                       
                };

                car.SalesInfo = new SaleInfo
                {
                    Car = car,
                    SalesDate = RandomDay()
                };

                carDealershipContext.Cars.Add(car);
                carDealershipContext.SaveChanges();
            }

        }

        private static DateTime RandomDay()
        {
            DateTime start = new DateTime(2014, 1, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(random.Next(range));
        }

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
