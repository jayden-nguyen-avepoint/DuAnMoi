namespace QuanNet.LinQ
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TPham")]
    public partial class TPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TPham()
        {
            ListTPhams = new HashSet<ListTPham>();
        }

        [Key]
        [StringLength(20)]
        public string IdTP { get; set; }

        [Required]
        public string TenTP { get; set; }

        public int Gia { get; set; }

        [Required]
        [StringLength(20)]
        public string IdLoaiTP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ListTPham> ListTPhams { get; set; }

        public virtual LoaiTPham LoaiTPham { get; set; }
    }
}
