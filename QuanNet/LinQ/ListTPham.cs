namespace QuanNet
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ListTPham")]
    public partial class ListTPham
    {
        [Key]
        [StringLength(10)]
        public string IdOrderList { get; set; }

        [Required]
        [StringLength(10)]
        public string IdTP { get; set; }

        public int SoluongTP { get; set; }

        public int ThanhTien { get; set; }

        [Required]
        [StringLength(10)]
        public string IdChiTiet { get; set; }

        public virtual HoaDonChiTiet HoaDonChiTiet { get; set; }

        public virtual TPham TPham { get; set; }
    }
}
