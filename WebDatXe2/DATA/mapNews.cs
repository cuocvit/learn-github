using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATA.Entity;

namespace DATA.Entity
{
    public class mapNews
    {
        QuanLyBenXeEntities1 db = new QuanLyBenXeEntities1();
        public List<news> DanhSach()
        {
            return db.news.ToList();
        }

        public news ChiTiet(int id)
        {
            var update = db.news.Find(id);
            return update;
        }

        public int ThemMoi(news model)
        {
            db.news.Add(model);
            db.SaveChanges();
            return model.id;
        }

        public bool CapNhat(news model)
        {
            var update = db.news.Find(model.id);
            if(update == null)
            {
                return false;
            }

            update.hinh_anh = model.hinh_anh;
            update.link_seo = model.link_seo;
            update.noi_dung = model.noi_dung;
            update.tac_gia = model.tac_gia;
            update.thoi_gian_viet = model.thoi_gian_viet;
            update.tieu_de = model.tieu_de;
            update.tom_tat = model.tom_tat;

            db.SaveChanges();
            return true;
        }

        public bool Xoa(int id)
        {
            var update = db.news.Find(id);
            if (update == null)
            {
                return false;
            }

            db.news.Remove(update);
            db.SaveChanges();
            return true;
        }
    }
}
