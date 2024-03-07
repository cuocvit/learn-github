using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DATA.Entity;

namespace WebDatXe2.App_Start
{
    public static class SessionConfig
    {
        //1.Lưu session user
        public static void SetUser(admin_account user)
        {
            //Lưu vào session
            HttpContext.Current.Session["user"] = user;
        }

        //2.Lấy session
        public static admin_account GetUser()
        {
            return (admin_account)HttpContext.Current.Session["user"];
        }

        public static void SetBuserUser(buser_account user)
        {
            HttpContext.Current.Session["buser_user"] = user;
        }

        public static buser_account GetBuserUser()
        {
            return (buser_account)HttpContext.Current.Session["buser_user"];
        }

        public static void SetGuestUser(guest_account user)
        {
            //Lưu vào session
            HttpContext.Current.Session["guest_user"] = user;
        }

        //2.Lấy session
        public static guest_account GetGuestUser()
        {
            return (guest_account)HttpContext.Current.Session["guest_user"];
        }
    }
}