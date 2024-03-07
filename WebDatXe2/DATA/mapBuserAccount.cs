using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATA.Entity;

namespace DATA
{
    public class mapBuserAccount
    {
        QuanLyBenXeEntities1 db = new QuanLyBenXeEntities1();
        public buser_account TimKiem(string account, string password)
        {
            var user = db.buser_account.Where(m => m.account == account & m.password == password).ToList();
            if(user.Count > 0)
            {
                return user[0];
            }
            else
            {
                return null;
            }
        }

        public void ThemMoi(string account, string password, string name)
        {
            buser_account tk = new buser_account();
            tk.account = account;
            tk.password = password;
            tk.name = name;

            db.buser_account.Add(tk);
            db.SaveChanges();
        }

        public bool ThemMoi(buser_account tk)
        {
            try
            {
                db.buser_account.Add(tk);
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
