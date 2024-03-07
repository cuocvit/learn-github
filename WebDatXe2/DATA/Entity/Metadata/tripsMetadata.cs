using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA.Entity.Metadata
{
    public class tripsMetadata
    {
        [Required(ErrorMessage = "Bạn chưa nhập tên")]
        [StringLength(50)]
        [DisplayName("Điểm khởi đầu")]
        public string start_point { get; set; }
        [DisplayName("Điểm kết thúc")]
        public string end_point { get; set; }
        [DisplayName("Trạng thái duyệt")]
        public Nullable<bool> status_confirm { get; set; }
        [DisplayName("Trạng thái sửa")]
        public Nullable<bool> status_update { get; set; }
        [DisplayName("Trạng thái xoá")]
        public Nullable<bool> status_delete { get; set; }
        public Nullable<int> id_discount { get; set; }
        public Nullable<int> vehicle_id { get; set; }
        [DisplayName("Giá vé")]
        public Nullable<int> cost { get; set; }
        [DisplayName("Số ghế")]
        public Nullable<int> chair { get; set; }
    }
}
