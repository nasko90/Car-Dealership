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

        // GET: api/Report
        public IQueryable GetReport()
        {
            var report = ReportView.GetReportForPeriod(db, new DateTime(2017,05,01), new DateTime(2017, 06, 06));
            return report;
        }
    }
}
