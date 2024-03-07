using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA.Entity.Metadata
{
    public class trip_detailMetadata
    {
        public int id { get; set; }
        [DisplayName("Ngày khởi hành")]
        public Nullable<System.DateTime> date_start { get; set; }
        [DisplayName("Giờ khởi hành")]
        public Nullable<System.TimeSpan> time_start { get; set; }
        [DisplayName("Ngày đến")]
        public Nullable<System.DateTime> date_end { get; set; }
        [DisplayName("Giờ đến")]
        public Nullable<System.TimeSpan> time_end { get; set; }
        [DisplayName("Tổng ghế đã đặt")]
        public Nullable<int> total { get; set; }
        public Nullable<int> trip_id { get; set; }

        public virtual trip trip { get; set; }
    }
}
