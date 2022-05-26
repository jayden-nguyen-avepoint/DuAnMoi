namespace QuanNet.LinQ
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaiKhoan")]
    public partial class TaiKhoan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TaiKhoan()
        {
            HoaDons = new HashSet<HoaDon>();
            Mays = new HashSet<May>();
        }

        [Key]
        [StringLength(20)]
        public string IdTK { get; set; }

        [Required]
        [StringLength(200)]
        public string TenDN { get; set; }

        [Required]
        [StringLength(200)]
        public string MatKhau { get; set; }

        public int Sodu { get; set; }

        [Required]
        public string TenKH { get; set; }

        [StringLength(10)]
        public string LienHe { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDon> HoaDons { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<May> Mays { get; set; }
    }
}
