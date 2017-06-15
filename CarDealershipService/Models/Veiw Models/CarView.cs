using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CarDealership.Models;

namespace CarDealershipService.Models.Veiw_Models
{
    public class CarView
    {
        public string VIN { get; set; }

        public CarModelsView CarModel { get; set; }

        public string YearProduced { get; set; }

        public string Price { get; set; }

        public string SaleInfo { get; set; }

        public static ICollection<CarView> ConvertCarsFromDatabase(IEnumerable<Car> cars)
        {
            var listOfCarView =
                from car in cars
                select new CarView()
                {
                    VIN = car.VIN,
                    CarModel = CarModelsView.ConvertCarModelFromDatabase(car.CarModel),
                    YearProduced = car.YearProduced.ToString(),
                    SaleInfo = car.SalesInfo.SalesDate.ToString("d"),
                    Price = car.Price.ToString("C0")
                };

            return listOfCarView.ToList();
        }

        public static CarView ConvertCarFromDatabase(Car car)
        {
            var carView = new CarView
            {
                VIN = car.VIN,
                CarModel = CarModelsView.ConvertCarModelFromDatabase(car.CarModel),
                YearProduced = car.YearProduced.ToString(),
                SaleInfo = car.SalesInfo.SalesDate.ToString("d"),
                Price = car.Price.ToString("C0")
            };               

            return carView ;
        }
    }
}