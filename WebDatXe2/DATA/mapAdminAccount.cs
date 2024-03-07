using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATA.Entity;


namespace DATA
{
    public class mapAdminAccount
    {
        QuanLyBenXeEntities1 db = new QuanLyBenXeEntities1();

        public admin_account TimKiem(string username, string password)
        {
            var user = db.admin_account.Where(m => m.email == username & m.password == password).ToList();
            if (user.Count > 0)
            {
                return user[0];
            }
            else
            {
                return null;
            }
        }

        public bool ThemMoi(admin_account tk)
        {
            try
            {
                db.admin_account.Add(tk);
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
