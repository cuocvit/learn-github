using DATA.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA
{
    public class mapDiscount
    {

        QuanLyBenXeEntities1 db = new QuanLyBenXeEntities1();
        public List<discount> LoadDanhSachKM()
        {
            var DanhSachKM = db.discounts.ToList();
            return DanhSachKM;

        }
    }
}
