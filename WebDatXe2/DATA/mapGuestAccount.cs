using DATA.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA
{
    public class mapGuestAccount
    {
        QuanLyBenXeEntities1 db = new QuanLyBenXeEntities1();

        public guest_account TimKiem(string username, string password)
        {
            var user = db.guest_account.Where(m => m.username == username & m.password == password).ToList();
            if (user.Count > 0)
            {
                return user[0];
            }
            else
            {
                return null;
            }
        }

        public bool ThemMoi(guest_account tk)
        {
            try
            {
                db.guest_account.Add(tk);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
