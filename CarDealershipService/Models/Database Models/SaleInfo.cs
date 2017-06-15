using System;
using System.ComponentModel.DataAnnotations;

namespace CarDealership.Models
{
    public class SaleInfo
    {       
        public int Id { get; set; }

        [Required]
        public DateTime SalesDate { get; set; }

        [Required]
        public virtual Car Car { get; set; }
    }
}