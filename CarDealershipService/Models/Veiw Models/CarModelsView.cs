using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CarDealership.Models;

namespace CarDealershipService.Models.Veiw_Models
{
    public class CarModelsView
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Manfucaturer { get; set; }

        public static ICollection<CarModelsView> ConvertCarModelsFromDatabase(IEnumerable<CarModel> carModels)
        {
            var listOfCarModelsView = 
                from carModel in carModels
                select new CarModelsView
                {
                    Id = carModel.Id.ToString(),
                    Name = carModel.Name,
                    Manfucaturer = carModel.Manufacturer
                };

            return listOfCarModelsView.ToList();
        }

        public static CarModelsView ConvertCarModelFromDatabase(CarModel carModel)
        {
            var carModelsView = new CarModelsView
            {
                Id = carModel.Id.ToString(),
                Name = carModel.Name,
                Manfucaturer = carModel.Manufacturer
            };
               
            return carModelsView;
        }
    }
}