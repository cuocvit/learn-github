using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA.Entity.Metadata
{
    public class vehicleMetadata
    {
        [Required(ErrorMessage = "Bạn chưa nhập tên xe")]
        [StringLength(30, ErrorMessage ="Bạn không được phép nhập quá 30 ký tự")]
        [DisplayName("Tên xe")]
        public string name { get; set; }
        [Required(ErrorMessage = "Bạn chưa nhập biển số xe")]
        [StringLength(15, ErrorMessage = "Bạn không được phép nhập quá 15 ký tự")]
        [DisplayName("Biển số xe")]
        public string license_plate { get; set; }
        [Required(ErrorMessage = "Bạn chưa nhập kiểu xe")]
        [StringLength(20, ErrorMessage = "Bạn không được phép nhập quá 20 ký tự")]
        [DisplayName("Kiểu xe")]
        public string type { get; set; }
        [Required(ErrorMessage = "Bạn chưa chọn hình ảnh")]
        [StringLength(310, ErrorMessage = "vui lòng chọn đúng kiểu ảnh")]
        [DisplayName("Avatar")]
        public string avatar {  get; set; }


    }
}
