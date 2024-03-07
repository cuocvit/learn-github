using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DATA;
using DATA.Entity;

namespace WebDatXe2.Areas.Admin.Controllers
{
    public class NewsController : Controller
    {
        // GET: Admin/News
        public ActionResult Index()
        {
            return View(new mapNews().DanhSach());
        }

        public ActionResult ThemMoi()
        {
            return View(new news() { thoi_gian_viet = DateTime.Now, tac_gia = "admin" });
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult ThemMoi(news model)
        {
            var map = new mapNews();
            if(map.ThemMoi(model) > 0)
            {
                return RedirectToAction("Index");
            }
            else return View(model);
        }

        public ActionResult Details(int id)
        {
            return View(new mapNews().ChiTiet(id));
        }

        public ActionResult Delete(int id)
        {
            var map = new mapNews();
            if(map.Xoa(id) != true)
            {
                ViewBag.DeleteMessage = "Xoá thất bại!";
                RedirectToAction("Index");
            }
            else
            {
                ViewBag.DeleteMessage = "Xoá thành công!";
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Edit(int id)
        {
            var map = new mapNews();
            return View(map.ChiTiet(id));
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Edit(news model)
        {
            mapNews map = new mapNews();
            if (map.CapNhat(model) == true)
            {
                return Redirect("/Admin/News/Index");
            }
            else
            {
                return View(model);
            }
        }
    }
}