using DATA;
using DATA.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebDatXe2.Controllers
{
    public class NewsController : Controller
    {
        // GET: News
        public ActionResult Index()
        {
            mapNews map = new mapNews();
            var danhsach = map.DanhSach();
            return View(danhsach);
        }

        [HttpGet]
        public ActionResult Detail(int id)
        {
            mapNews map = new mapNews();
            var danhsach = map.ChiTiet(id);
            return View(danhsach);
        }
    }
}