using DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebDatXe2.App_Start;

namespace WebDatXe2.Areas.NhaXe.Controllers
{
    public class VehiclesController : Controller
    {
        
        // GET: NhaXe/Vehicles
        public ActionResult Index()
        {
            var user = SessionConfig.GetBuserUser();
            if(user == null)
            {
                Redirect("/NhaXe/Users/Login");
            }      
            int id_bus = (int)user.id_buses;
            mapVehicle map = new mapVehicle();
            var danhsach = map.LoadDanhSachXeTheoId(id_bus);
            return View(danhsach);
        }
    }
}