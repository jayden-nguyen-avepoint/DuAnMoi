namespace QuanNet.LinQ
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoaiTPham")]
    public partial class LoaiTPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LoaiTPham()
        {
            TPhams = new HashSet<TPham>();
        }

        [Key]
        [StringLength(20)]
        public string IdLoaiTP { get; set; }

        [Required]
        public string TenLoaiTP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TPham> TPhams { get; set; }
    }
}
