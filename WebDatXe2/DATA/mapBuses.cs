using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATA.Entity;

namespace DATA
{
    public class mapBuses
    {
        QuanLyBenXeEntities1 db = new QuanLyBenXeEntities1();
        public List<bus> LoadDanhSach()
        {
            var danhSach = db.buses.ToList();
            return danhSach;
        }

        public bus ChiTiet(int id)
        {
            return db.buses.Find(id);
        }
        public int ThemMoi(bus model)
        {
            try
            {
                db.buses.Add(model);
                db.SaveChanges();

            }
            catch (Exception ex)
            {


              
            }
            return model.id;
        }

        public bool CapNhat(bus model)
        {
            try
            {
                var update = db.buses.Find(model.id);
                if (update == null)
                {
                    return false;
                }

                update.name = model.name;
                update.phone_number = model.phone_number;
                update.avatar = model.avatar;
                db.SaveChanges();
                return true;
            }catch (Exception ex)
            {

            }
            return false;
        }

        public bool Xoa(int id)
        {
            var update = db.buses.Find(id);
            if (update == null)
            {
                return false;
            }

            db.buses.Remove(update);
            db.SaveChanges();
            return true;
        }
    }
}
