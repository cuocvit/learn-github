using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA.Entity.Metadata
{
    public class admin_accountMetadata
    {
        public int id { get; set; }
        [Required(ErrorMessage = "Bạn chưa nhập password")]
        [StringLength(20, ErrorMessage = "Nhập tối đa 20 ký tự!")]
        public string password { get; set; }
        [Required(ErrorMessage = "Bạn chưa nhập tên")]
        [StringLength(20, ErrorMessage = "Nhập tối đa 20 ký tự!")]
        public string name { get; set; }
        [Required(ErrorMessage = "Bạn chưa nhập email")]
        [StringLength(20, ErrorMessage = "Nhập tối đa 20 ký tự!")]
        public string email { get; set; }
        [Required(ErrorMessage = "Bạn chưa nhập số điện thoại")]
        [StringLength(20, ErrorMessage = "Nhập tối đa 20 ký tự!")]
        public string phone { get; set; }
        [Required(ErrorMessage = "Bạn chưa nhập địa chỉ")]
        [StringLength(20, ErrorMessage = "Nhập tối đa 20 ký tự!")]
        public string address { get; set; }
        [Required(ErrorMessage ="Bạn chưa nhập tài khoản")]
        [StringLength(20, ErrorMessage ="Nhập tối đa 20 ký tự!")]
        public string username { get; set; }
    }
}
