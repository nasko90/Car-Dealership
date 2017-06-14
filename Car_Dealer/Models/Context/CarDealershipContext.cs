using System.Data.Entity;
using CarDealership.Models;

namespace CarDealershi.Context.Context
{
    public class CarDealershipContext : DbContext
    {
            public CarDealershipContext()
                : base("CarDealership.Database")
            {
            }

            public virtual DbSet<Car> Cars { get; set; }

            public virtual DbSet<CarModel> CarModels { get; set; }

            public virtual DbSet<SaleInfo> SalesInfo { get; set; }          
        
    }
}