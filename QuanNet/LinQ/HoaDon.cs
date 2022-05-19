namespace QuanNet
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoaDon")]
    public partial class HoaDon
    {
        [Key]
        [StringLength(10)]
        public string IdHoaDon { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayXuatHD { get; set; }

        [Required]
        [StringLength(10)]
        public string IdTK { get; set; }

        [Required]
        [StringLength(10)]
        public string IdChiTiet { get; set; }

        public virtual HoaDonChiTiet HoaDonChiTiet { get; set; }

        public virtual TaiKhoan TaiKhoan { get; set; }
    }
}
