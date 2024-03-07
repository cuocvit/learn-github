using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA.Entity
{
    public class mapTrip_details
    {
        QuanLyBenXeEntities1 db = new QuanLyBenXeEntities1();
        
        public List<trip_details> DanhSachChuyen()
        {
            var danhsach = db.trip_details.ToList();
            return danhsach;
        }

        public int ThemMoi(trip_details model)
        {
            db.trip_details.Add(model);
            db.SaveChanges();
            return model.id;
        }

        public bool Xoa(int id)
        {
            var update = db.trip_details.Find(id);
            if (update == null)
            {
                return false;
            }

            db.trip_details.Remove(update);
            db.SaveChanges();
            return true;
        }

        public trip_details ChiTiet(int id)
        {
            return db.trip_details.Find(id);
        }
        public bool CapNhat(trip_details model)
        {
            var update = db.trip_details.Find(model.id);
            if (update == null)
            {
                return false;
            }

            update.date_start = model.date_start;
            update.time_start = model.time_start;
            update.date_end = model.date_end;
            update.time_end = model.time_end;
            update.total = model.total;
            update.trip_id = model.trip_id;
            db.SaveChanges();
            return true;
        }
    }
}
