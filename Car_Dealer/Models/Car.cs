using System.ComponentModel.DataAnnotations;

namespace CarDealership.Models
{
    public class Car
    {
        [Key]
        [MaxLength(17), MinLength(17)]       
        public string VIN { get; set; }

        [Required]
        public virtual CarModel CarModel { get; set; }

        [Required]
        public int YearProduced { get; set; }

        [Required]
        public decimal Price { get; set; }

        public virtual SaleInfo SalesInfo { get; set; }

    }
}