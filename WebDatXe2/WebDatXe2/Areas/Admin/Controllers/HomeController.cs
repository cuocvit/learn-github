using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebDatXe2.App_Start;

namespace WebDatXe2.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        // GET: Admin/Home
        public ActionResult Index()
        {
            var user = SessionConfig.GetUser();
            if(user == null)
            {
                return Redirect("/Admin/User/Login");
            }
            return View();
        }
    }
}