using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA.Entity.Metadata
{
    public class newsMetadata
    {
        [DisplayName("Tiêu đề")]
        public string tieu_de { get; set; }

        [DisplayName("Tóm tắt")]
        public string tom_tat { get; set; }

        [DisplayName("Hình ảnh")]
        public string hinh_anh { get; set; }

        [DisplayName("Nội dung")]
        public string noi_dung { get; set; }

        [DisplayName("Thời gian viết")]
        public Nullable<System.DateTime> thoi_gian_viet { get; set; }

        [DisplayName("Tác giả")]
        public string tac_gia { get; set; }

        [DisplayName("Link SEO")]
        public string link_seo { get; set; }
    }
}
