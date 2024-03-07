using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DATA;
using DATA.Entity;
using WebDatXe2.App_Start;

namespace WebDatXe2.Areas.NhaXe.Controllers
{
    public class UsersController : Controller
    {
        // GET: NhaXe/Users
        public ActionResult Login()
        {
            var user = SessionConfig.GetBuserUser();
            if (user != null)
            {
                return Redirect("/NhaXe/Home/Index");
            }
            return View();
        }

        [HttpPost]
        public ActionResult Login(string account, string password)
        {
            mapBuserAccount map = new mapBuserAccount();
            var user = map.TimKiem(account, password);
            if (user != null)
            {
                SessionConfig.SetBuserUser(user);
                return RedirectToAction("Index", "Home", new { area = "NhaXe" });
            }
            ViewBag.error = "Tên đăng nhập hoặc mật khẩu không đúng";
            return View();
        }

        public ActionResult Logout()
        {
            SessionConfig.SetBuserUser(null);
            return RedirectToAction("Login", "Users", new { area = "NhaXe" });
        }
    }
}