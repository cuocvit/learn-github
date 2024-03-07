using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DATA.Entity;
using DATA;

namespace WebDatXe2.Controllers
{
    public class SearchTripController : Controller
    {
        // GET: SearchTrip
        [HttpPost]
        public ActionResult DanhSach(string SelectedStartPoint, string SelectedEndPoint, DateTime date)
        {
            mapTrips map = new mapTrips();
            var danhsach = map.search_trip(SelectedStartPoint, SelectedEndPoint, date);
            return View(danhsach);
        }
    }
}