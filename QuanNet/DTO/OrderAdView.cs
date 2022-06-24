using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanNet.DTO
{
     public class OrderAdView
    {
        public string IdChiTiet { get; set; }
        public string IdMay { get; set; }
        public DateTime NgayOrder { get; set; }
        public int? TongTien { get; set; }
        public bool Trang_thai { get; set; }

    }
}
