using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DATA.Entity;
using DATA;
using WebDatXe2.App_Start;

namespace WebDatXe2.Areas.Admin.Controllers
{
    public class TripsController : Controller
    {
        // GET: Admin/Trips
        public ActionResult Index()
        {
            mapTrips map = new mapTrips();
            var danhsach = map.DanhSachHanhTrinh();
            return View(danhsach);
        }

        public ActionResult Create()
        {
            var user = SessionConfig.GetUser();
            if (user == null)
            {
                return Redirect("/Admin/User/Login");
            }
            mapVehicle map = new mapVehicle();
            var vehicle = map.LoadDanhSachXe();
            SelectList vehicleList = new SelectList(vehicle, "Id", "Name");
            ViewData["vehicle_id"] = vehicleList;
            mapDiscount mapDis = new mapDiscount();
            var discount = mapDis.LoadDanhSachKM();
            SelectList discountList = new SelectList(discount, "Id", "Name");
            ViewData["id_discount"] = discountList;
            return View();
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Create(trip model)
        {
            mapTrips map = new mapTrips();
            var check = map.ThemMoi(model);
            if (check > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError("", "Lỗi thêm dữ liệu, vui lòng thử lại");
                return View(model);
            }
        }

        public ActionResult Delete(int id)
        {
            var map = new mapTrips();
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
            mapTrips mapTrips = new mapTrips();
            mapVehicle map = new mapVehicle();
            var vehicle = map.LoadDanhSachXe();
            SelectList vehicleList = new SelectList(vehicle, "Id", "Name");
            ViewData["vehicle_id"] = vehicleList;
            mapDiscount mapDis = new mapDiscount();
            var discount = mapDis.LoadDanhSachKM();
            SelectList discountList = new SelectList(discount, "Id", "Name");
            ViewData["id_discount"] = discountList;
            var details = new mapTrips().ChiTiet(id);
            return View(details);
        }

        [HttpPost]
        public ActionResult Edit(trip model)
        {
            mapTrips map = new mapTrips();
            if (map.CapNhat(model) == true)
            {
                return Redirect("/Admin/Trips/Index");
            }
            else
            {
                return View(model);
            }
        }
    }
}