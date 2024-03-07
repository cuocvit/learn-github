using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebDatXe2.App_Start;

namespace WebDatXe2.Areas.NhaXe.Controllers
{
    public class HomeController : Controller
    {
        // GET: NhaXe/Home
        public ActionResult Index()
        {
            var user = SessionConfig.GetBuserUser();
            if (user == null)
            {
                return Redirect("/NhaXe/Users/Login");
            }
            return View();
        }
    }
}