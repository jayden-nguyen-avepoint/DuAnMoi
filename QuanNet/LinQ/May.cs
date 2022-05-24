namespace QuanNet.LinQ
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("May")]
    public partial class May
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public May()
        {
            HoaDonChiTiets = new HashSet<HoaDonChiTiet>();
        }

        [Key]
        [StringLength(20)]
        public string IdMay { get; set; }

        [Required]
        public string CauHinh { get; set; }

        public bool TrangThai { get; set; }

        public string HoatDong { get; set; }

        [StringLength(20)]
        public string IdTK { get; set; }

        public int TienGio { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; }

        public virtual TaiKhoan TaiKhoan { get; set; }
    }
}
