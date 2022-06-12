namespace QuanNet.LinQ
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
        [StringLength(20)]
        public string IdHoaDon { get; set; }
        [Required]
        [StringLength(20)]
        public string IdTK { get; set; }

        [Required]
        [StringLength(20)]
        public string IdChiTiet { get; set; }

        public virtual HoaDonChiTiet HoaDonChiTiet { get; set; }

        public virtual TaiKhoan TaiKhoan { get; set; }
    }
}
