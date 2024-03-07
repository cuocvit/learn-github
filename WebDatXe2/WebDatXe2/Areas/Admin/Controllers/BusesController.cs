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
    public class BusesController : Controller
    {
        // GET: Admin/Buses
        public ActionResult DanhSach()
        {
            var user = SessionConfig.GetUser();
            if (user == null)
            {
                return Redirect("/Admin/User/Login");
            }
            mapBuses map = new mapBuses();
            var ds = map.LoadDanhSach();
            return View(ds);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Create(bus model)
        {
            var map = new mapBuses();
            if (map.ThemMoi(model) > 0)
            {
                return RedirectToAction("DanhSach");
            }
            else return View(model);
        }

        public ActionResult Delete(int id)
        {
            var map = new mapBuses();
            if (map.Xoa(id) != true)
            {
                ViewBag.DeleteMessage = "Xoá thất bại!";
                RedirectToAction("DanhSach");
            }
            else
            {
                ViewBag.DeleteMessage = "Xoá thành công!";
                return RedirectToAction("DanhSach");
            }
            return View();
        }

        public ActionResult Edit(int id)
        {
            var details = new mapBuses().ChiTiet(id);
            return View(details);
        }

        [HttpPost]
        public ActionResult Edit(bus model)
        {
            mapBuses map = new mapBuses();
            if(map.CapNhat(model) == true)
            {
                return Redirect("/Admin/Buses/DanhSach");
            }
            else
            {
                return View(model);
            }
        }
    }
}