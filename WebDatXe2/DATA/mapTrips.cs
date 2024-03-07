using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATA;
using DATA.Entity;

namespace DATA
{
    public class mapTrips
    {
        QuanLyBenXeEntities1 db = new QuanLyBenXeEntities1();

        public List<string> DanhSachStartPoint()
        {
            // Lấy danh sách các start_point không trùng nhau
            var StartPoints = db.trips.Select(x => x.start_point).Distinct().OrderBy(x => x).ToList();

            return StartPoints;
        }

        public List<string> DanhSachEndPoint()
        {
            // Lấy danh sách các start_point không trùng nhau
            var EndPoints = db.trips.Select(x => x.end_point).Distinct().OrderBy(x => x).ToList();

            return EndPoints;
        }

      /* public List<SearchTrips_Result> SearchTrips(string start_point, string end_point, DateTime date_start, TimeSpan? time_start, TimeSpan? time_end, string vehicle_type, string sort_order)
        {
            var danhsach = db.SearchTrips(start_point, end_point, date_start, time_start, time_end, vehicle_type, sort_order).ToList();
            return danhsach;
        }*/

        public List<SearchTrips1_Result1> search_trip(string start_point, string end_point, DateTime date_start)
        {
            var danhsach = db.SearchTrips1(start_point, end_point, date_start).ToList();
            return danhsach;
        }

       public List<GetTripDetails_Result2> get_trip_details(int trip_id, int trip_details_id)
        {
            var danhsach = db.GetTripDetails(trip_id, trip_details_id).ToList();
            return danhsach;
        }

        public List<trip> DanhSachHanhTrinh()
        {
            var DanhSach = db.trips.ToList();
            return DanhSach;
        }

        public List<trip> LayDanhSachTripTheoId(int id)
        {
            var danhsach = db.trips.Where(m => m.vehicle_id == id).ToList();
            return danhsach;
        }

        public int ThemMoi(trip model)
        {
            db.trips.Add(model);
            db.SaveChanges();
            return model.id;
        }

        public bool Xoa(int id)
        {
            var update = db.trips.Find(id);
            if (update == null)
            {
                return false;
            }

            db.trips.Remove(update);
            db.SaveChanges();
            return true;
        }

        public trip ChiTiet(int id)
        {
            return db.trips.Find(id);
        }
        public bool CapNhat(trip model)
        {
            var update = db.trips.Find(model.id);
            if (update == null)
            {
                return false;
            }

            update.start_point = model.start_point;
            update.end_point = model.end_point;
            update.cost = model.cost;  
            update.chair = model.chair;
            update.id_discount = model.id_discount;
            update.vehicle_id = model.vehicle_id;
            db.SaveChanges();
            return true;
        }
    }
}
