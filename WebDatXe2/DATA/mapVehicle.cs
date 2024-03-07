using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATA.Entity;

namespace DATA
{
    public class mapVehicle
    {
        QuanLyBenXeEntities1 db = new QuanLyBenXeEntities1();
        public List<vehicle> LoadDanhSachXe()
        {
            var DanhSachXe = db.vehicles.ToList();
            return DanhSachXe;

        }

        public List<vehicle> LoadDanhSachXeTheoId(int id)
        {
            var DanhSachXe = db.vehicles.Where(m => m.id_buses == id).ToList();
            return DanhSachXe;
        }
        public List<bus> LoadNhaXe()
        {
            var DanhSachNhaXe = db.buses.ToList();
            return DanhSachNhaXe;
        }

        public int ThemMoi(vehicle model)
        {
            try
            {


                db.vehicles.Add(model);
                db.SaveChanges();
                return model.id;
            }
            catch
            {

            }
            return 0;
         
        }

        public bool Xoa(int id)
        {
            var update = db.vehicles.Find(id);
            if (update == null)
            {
                return false;
            }

            db.vehicles.Remove(update);
            db.SaveChanges();
            return true;
        }

        public vehicle ChiTiet(int id)
        {
            return db.vehicles.Find(id);
        }
        public bool CapNhat(vehicle model)
        {
            var update = db.vehicles.Find(model.id);
            if (update == null)
            {
                return false;
            }

            update.name = model.name;
            update.license_plate = model.license_plate;
            update.type = model.type;
            update.avatar = model.avatar;
            update.id_buses = model.id_buses;
            db.SaveChanges();
            return true;
        }
    }
}
