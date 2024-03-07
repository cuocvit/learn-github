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
    public class UserController : Controller
    {
        // GET: Admin/User
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            mapAdminAccount map = new mapAdminAccount();
            var user = map.TimKiem(username, password);
            if(user != null)
            {
                SessionConfig.SetUser(user);
                return RedirectToAction("DanhSach", "Buses", new { area = "Admin"});
            }
            ViewBag.error = "Tên đăng nhập hoặc mật khẩu không đúng";
            return View();
        }

        public ActionResult Logout()
        {
            SessionConfig.SetUser(null);
            return RedirectToAction("Login", "User", new { area = "Admin" });
        }

        public ActionResult DangKy()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DangKy(admin_account model)
        {
            mapAdminAccount map = new mapAdminAccount();
            if (map.ThemMoi(model))
            {
                return RedirectToAction("Login");
            }
            else
            {
                return View();
            }
            
        }
    }
}