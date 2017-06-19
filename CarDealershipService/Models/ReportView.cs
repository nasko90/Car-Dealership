using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CarDealershi.Context.Context;

namespace CarDealershipService.Models
{
    public class ReportView
    {
        public string CarModel { get; set; }

        public int NumberOfSoldCars { get; set; }

        public decimal TotalAmountOfSalesForModel { get; set; }

        public static ICollection<ReportView> GetReportForPeriod(CarDealershipContext db, DateTime startDate, DateTime enDate)
        {
            var reportList =
                from car in db.Cars
                where car.SalesInfo.SalesDate >= startDate && car.SalesInfo.SalesDate <= enDate
                group car by car.CarModel.Name into grouped       
                select new ReportView()
                {
                    NumberOfSoldCars = grouped.Count(),
                    CarModel = grouped.Key,  
                    TotalAmountOfSalesForModel = grouped.Sum(x => x.Price) 
                };

            return reportList.ToList();
        }
    }
}