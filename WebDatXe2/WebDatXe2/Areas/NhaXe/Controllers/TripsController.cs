using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DATA;
using WebDatXe2.App_Start;

namespace WebDatXe2.Areas.NhaXe.Controllers
{
    public class TripsController : Controller
    {
        // GET: NhaXe/Trips
        public ActionResult Index()
        {
            var user = SessionConfig.GetBuserUser();
            if (user == null)
            {
                Redirect("/NhaXe/Users/Login");
            }
            int id = (int)user.id_buses;
            mapTrips map = new mapTrips();
            var danhsach = map.LayDanhSachTripTheoId(id);
            return View(danhsach);
        }
    }
}