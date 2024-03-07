using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DATA;
using DATA.Entity;

namespace WebDatXe2.Areas.Admin.Controllers
{
    public class TripDetailController : Controller
    {
        // GET: Admin/TripDetail
        public ActionResult Index()
        {
            mapTrip_details map = new mapTrip_details();
            var danhsach = map.DanhSachChuyen();
            return View(danhsach);
        }

        public ActionResult Create()
        {
            mapTrips map = new mapTrips();
            var tripName = map.DanhSachHanhTrinh();
            SelectList tripList = new SelectList(tripName, "Id", "Name");
            ViewData["trip_id"] = tripList;
            return View();
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Create(trip_details model)
        {
            var map = new mapTrip_details();
            if (map.ThemMoi(model) > 0)
            {
                return RedirectToAction("Index");
            }
            else return View(model);
        }

        public ActionResult Delete(int id)
        {
            var map = new mapTrip_details();
            if (map.Xoa(id) != true)
            {
                ViewBag.DeleteMessage = "Xoá thất bại!";
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.DeleteMessage = "Xoá thành công!";
                return RedirectToAction("Index");
            }
        }

        public ActionResult Edit(int id)
        {
            mapTrips map = new mapTrips();
            var tripName = map.DanhSachHanhTrinh();
            SelectList tripList = new SelectList(tripName, "Id", "Name");
            ViewData["trip_id"] = tripList;
            var details = new mapTrip_details().ChiTiet(id);
            return View(details);
        }

        [HttpPost]
        public ActionResult Edit(trip_details model)
        {
            mapTrip_details map = new mapTrip_details();
            if (map.CapNhat(model) == true)
            {
                return Redirect("/Admin/TripDetail/Index");
            }
            else
            {
                return View(model);
            }
        }
    }
}