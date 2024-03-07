using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DATA;
using DATA.Entity;
using WebDatXe2.App_Start;

namespace WebDatXe2.Areas.Admin.Controllers
{
    public class VehiclesController : Controller
    {
        // GET: Admin/Vehicles
        public ActionResult Index()
        {
            var user = SessionConfig.GetUser();
            if (user == null)
            {
                return Redirect("/Admin/User/Login");
            }
            mapVehicle map = new mapVehicle();
            var ds =  map.LoadDanhSachXe();
            return View(ds);
        }
        
        public ActionResult Create()
        {
            var user = SessionConfig.GetUser();
            if (user == null)
            {
                return Redirect("/Admin/User/Login");
            }
            mapVehicle map = new mapVehicle();
            var buses = map.LoadNhaXe();
            SelectList busList = new SelectList(buses, "Id", "Name");
            ViewData["id_buses"] = busList;
            return View();
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Create(vehicle model)
        {
            mapVehicle map = new mapVehicle();
            var check = map.ThemMoi(model);
            if(check > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError("","Lỗi thêm dữ liệu, vui lòng thử lại");
                return View(model);
            }
        }

     
        public ActionResult DanhSachXe()
        {
            mapVehicle map = new mapVehicle();
            var danhsach = map.LoadDanhSachXe();
            return View(danhsach);
        }

        public ActionResult Delete(int id)
        {
            var map = new mapVehicle();
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

            mapVehicle map = new mapVehicle();
            var buses = map.LoadNhaXe();
            SelectList busList = new SelectList(buses, "Id", "Name");
            ViewData["id_buses"] = busList;
            var details = new mapVehicle().ChiTiet(id);
            return View(details);
        }

        [HttpPost]
        public ActionResult Edit(vehicle model)
        {
            mapVehicle map = new mapVehicle();
            if (map.CapNhat(model) == true)
            {
                return Redirect("/Admin/Vehicles/DanhSachXe");
            }
            else
            {
                return View(model);
            }
        }
    }
}