using DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DATA.Entity;
using WebDatXe2.App_Start;

namespace WebDatXe2.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string username, string password)
        {
                mapGuestAccount map = new mapGuestAccount();
                var user = map.TimKiem(username, password);
                if (user != null)
                {
                    SessionConfig.SetGuestUser(user);
                    return Redirect("/Home/Index");
                }
                ViewBag.error = "Tên đăng nhập hoặc mật khẩu không đúng";
                return View();
        }

        public ActionResult Logout()
        {
            SessionConfig.SetGuestUser(null);
            return RedirectToAction("Index", "Home");
        }
    }
}