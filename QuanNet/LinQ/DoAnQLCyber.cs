using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QuanNet.LinQ
{
    public partial class DoAnQLCyber : DbContext
    {
        public DoAnQLCyber()
            : base("name=DoAnQLCyber")
        {
        }

        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<HoaDonChiTiet> HoaDonChiTiets { get; set; }
        public virtual DbSet<ListTPham> ListTPhams { get; set; }
        public virtual DbSet<LoaiTPham> LoaiTPhams { get; set; }
        public virtual DbSet<May> Mays { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }
        public virtual DbSet<TPham> TPhams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
