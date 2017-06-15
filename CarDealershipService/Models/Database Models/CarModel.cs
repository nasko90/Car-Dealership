using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CarDealership.Models
{
    public class CarModel
    {
        public CarModel()
        {
            this.Cars = new HashSet<Car>();
        }
       
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Manufacturer { get; set; }

        public virtual ICollection<Car> Cars { get; set; }
    }
}