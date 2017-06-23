using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CarDealershi.Context.Context;
using CarDealership.Models;
using CarDealershipService.Models;

namespace CarDealershipService.Controllers
{
    public class ReportController : ApiController
    {
        private CarDealershipContext db = new CarDealershipContext();

        // GET: api/Report?startDate={startDate}&endDate={endDate}
        public ICollection<ReportView> GetReport(string startDate, string endDate)
        {
            DateTime start = DateTime.Parse(startDate);
            DateTime end = DateTime.Parse(endDate);
            var report = ReportView.GetReportForPeriod(db, start, end);
            return report;
        }
     
    }
}
