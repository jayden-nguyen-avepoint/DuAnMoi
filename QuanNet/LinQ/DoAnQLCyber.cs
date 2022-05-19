using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QuanNet
{
    public partial class DoAnQLCyber : DbContext
    {
        public DoAnQLCyber()
            : base("name=DoAnQLCyberGame")
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
            modelBuilder.Entity<HoaDon>()
                .Property(e => e.IdHoaDon)
                .IsFixedLength();

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.IdTK)
                .IsFixedLength();

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.IdChiTiet)
                .IsFixedLength();

            modelBuilder.Entity<HoaDonChiTiet>()
                .Property(e => e.IdChiTiet)
                .IsFixedLength();

            modelBuilder.Entity<HoaDonChiTiet>()
                .Property(e => e.IdMay)
                .IsFixedLength();

            modelBuilder.Entity<ListTPham>()
                .Property(e => e.IdOrderList)
                .IsFixedLength();

            modelBuilder.Entity<ListTPham>()
                .Property(e => e.IdTP)
                .IsFixedLength();

            modelBuilder.Entity<ListTPham>()
                .Property(e => e.IdChiTiet)
                .IsFixedLength();

            modelBuilder.Entity<LoaiTPham>()
                .Property(e => e.IdLoaiTP)
                .IsFixedLength();

            modelBuilder.Entity<May>()
                .Property(e => e.IdMay)
                .IsFixedLength();

            modelBuilder.Entity<May>()
                .Property(e => e.IdTK)
                .IsFixedLength();

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.IdTK)
                .IsFixedLength();

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.LienHe)
                .IsFixedLength();

            modelBuilder.Entity<TPham>()
                .Property(e => e.IdTP)
                .IsFixedLength();

            modelBuilder.Entity<TPham>()
                .Property(e => e.IdLoaiTP)
                .IsFixedLength();
        }
    }
}
