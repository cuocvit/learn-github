using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA.Entity.Metadata
{
    public class busMetadata
    {
        [Required(ErrorMessage = "Bạn chưa nhập tên")]
        [StringLength(50)]
        public string name { get; set; }
        [Required(ErrorMessage = "Bạn chưa nhập số điện thoại")]
        [StringLength(20, ErrorMessage ="Bạn không được nhập quá 20 ký tự")]
        public string phone_number { get; set; }
    }
}
