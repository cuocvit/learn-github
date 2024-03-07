using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA.Entity.Metadata
{
    public class buser_accountMetadata
    {
        [DisplayName("Tài khoản")]
        [Required(ErrorMessage = "Bạn chưa nhập tài khoản")]
        [StringLength(20, ErrorMessage = "Nhập tối đa 20 ký tự!")]
        public string account { get; set; }
        
        [DisplayName("Mật khẩu")]
        [Required(ErrorMessage = "Bạn chưa nhập mật khẩu")]
        [StringLength(18, ErrorMessage = "Nhập tối đa 18 ký tự!")]
        public string password { get; set; }
        
        [DisplayName("Tên nhà xe")]
        [Required(ErrorMessage = "Bạn chưa nhập tên nhà xe")]
        public string name { get; set; }
        
        [DisplayName("Số điện thoại")]
        [Required(ErrorMessage = "Bạn chưa nhập số điện thoại")]
        [StringLength(20, ErrorMessage = "Nhập tối đa 20 ký tự!")]
        public string phone { get; set; }

        [DisplayName("Email")]
        [Required(ErrorMessage = "Bạn chưa nhập emai")]
        [StringLength(20, ErrorMessage = "Nhập tối đa 20 ký tự!")]
        public string email { get; set; }

        [DisplayName("Địa chỉ")]
        [Required(ErrorMessage = "Bạn chưa nhập địa chỉ")]
        public string address { get; set; }
    }
}
