using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DATA;
using DATA.Entity;

namespace WebDatXe2.Controllers
{
    public class DetailsController : Controller
    {
        // GET: Details
        [HttpPost]
        public ActionResult Index(int tripId, int tripDetailsId)
        {
            mapTrips map = new mapTrips();
            var danhsach = map.get_trip_details(tripId, tripDetailsId);
            return View(danhsach);
        }
    }
}