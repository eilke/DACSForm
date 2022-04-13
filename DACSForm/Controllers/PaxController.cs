using DACSForm.Context;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DACSForm.Controllers
{
    public class PaxController : ApiController
    {
        DOCONAVContext _context = new DOCONAVContext();
        [HttpGet]
        public HttpResponseMessage Get(string startDate, string endDate, DataSourceLoadOptions loadOptions)
        {
            
                
            DateTime sD = DateTime.ParseExact(startDate.Substring(0, 24),
                              "ddd MMM d yyyy HH:mm:ss",
                              CultureInfo.InvariantCulture);
            DateTime eD = DateTime.ParseExact(endDate.Substring(0, 24),
                              "ddd MMM d yyyy HH:mm:ss",
                              CultureInfo.InvariantCulture);


            var paxs = from i in _context.DacsTransaction
                       join j in _context.DacshHeader on new
                       {
                          i.OrderDate,
                          i.FlightNo
                       } equals new
                       {
                           j.OrderDate,
                           j.FlightNo
                       }
                       where i.OrderDate>=sD && i.OrderDate<=eD 
                       select new
                       {
                i.OrderDate,
                j.DepTime,
                i.FlightNo,
                i.CustomerNo,
                i.CustomerDetail,
                i.ShortcutDimension1Code,
                i.Leg,
                i.Class,
                i.Status,
                i.MaxCapacity,
                i.InitialPax,
                i.ActualPax,
                j.RangeType,
                i.ArrFrom,
                i.LoadPax,
                j.Cancelled
            };
            return Request.CreateResponse(DataSourceLoader.Load(paxs, loadOptions));
        }
    }
}
