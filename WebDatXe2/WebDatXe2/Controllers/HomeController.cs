using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DATA;
using DATA.Entity;

namespace WebDatXe2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            mapTrips map = new mapTrips();
            var StartPoints = map.DanhSachStartPoint();
            var EndPoints = map.DanhSachEndPoint();

            mapNews mapNews = new mapNews();
            var danhsach = mapNews.DanhSach();
            ViewBag.EndPoints = new SelectList(EndPoints);

            ViewBag.StartPoints = new SelectList(StartPoints);
            return View(danhsach);
        }
    }
}