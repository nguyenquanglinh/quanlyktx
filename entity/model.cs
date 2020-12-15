namespace QuanLyKyTucXa.entity
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class model : DbContext
    {
        private static model model_ = null;
        public model()
            : base("name=model_KTX")
        {
            if (model_ == null)
                model_ = this;
        }

        public virtual DbSet<CongToDien> CongToDiens { get; set; }
        public virtual DbSet<CongToNuoc> CongToNuocs { get; set; }
        public virtual DbSet<DaiLy> DaiLies { get; set; }
        public virtual DbSet<DichVu> DichVus { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<HoaDonDienChiTiet> HoaDonDienChiTiets { get; set; }
        public virtual DbSet<HoaDonNuocChiTiet> HoaDonNuocChiTiets { get; set; }
        public virtual DbSet<HopDong> HopDongs { get; set; }
        public virtual DbSet<Khu> Khus { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<Phong> Phongs { get; set; }
        public virtual DbSet<SinhVien> SinhViens { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<ThongBao> ThongBaos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CongToDien>()
                .Property(e => e.maCongToDien)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CongToDien>()
                .Property(e => e.chiSoCu)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CongToDien>()
                .Property(e => e.chiSoMoi)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CongToDien>()
                .Property(e => e.maDaiLy)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CongToDien>()
                .HasMany(e => e.HoaDonDienChiTiets)
                .WithRequired(e => e.CongToDien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CongToNuoc>()
                .Property(e => e.maCongToNuoc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CongToNuoc>()
                .Property(e => e.chiSoCu)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CongToNuoc>()
                .Property(e => e.chiSoMoi)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CongToNuoc>()
                .Property(e => e.maDaiLy)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CongToNuoc>()
                .HasMany(e => e.HoaDonNuocChiTiets)
                .WithRequired(e => e.CongToNuoc)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DaiLy>()
                .Property(e => e.maDaiLy)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DaiLy>()
                .Property(e => e.tenDaiLy)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DaiLy>()
                .Property(e => e.SDT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DichVu>()
                .Property(e => e.maDichVu)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DichVu>()
                .Property(e => e.maDaiLy)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.maHoaDon)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.maNhanVien)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.maPhong)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.makhu)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .HasMany(e => e.HoaDonDienChiTiets)
                .WithRequired(e => e.HoaDon)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HoaDon>()
                .HasMany(e => e.HoaDonNuocChiTiets)
                .WithRequired(e => e.HoaDon)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HoaDonDienChiTiet>()
                .Property(e => e.maCongToDien)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HoaDonDienChiTiet>()
                .Property(e => e.donGia)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HoaDonDienChiTiet>()
                .Property(e => e.tongTien)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HoaDonDienChiTiet>()
                .Property(e => e.maHoaDon)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HoaDonNuocChiTiet>()
                .Property(e => e.maCongToNuoc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HoaDonNuocChiTiet>()
                .Property(e => e.donGia)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HoaDonNuocChiTiet>()
                .Property(e => e.tongTien)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HoaDonNuocChiTiet>()
                .Property(e => e.maHoaDon)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HopDong>()
                .Property(e => e.maHopDong)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HopDong>()
                .Property(e => e.maSinhVien)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HopDong>()
                .Property(e => e.maNhanVien)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HopDong>()
                .Property(e => e.soPhong)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HopDong>()
                .Property(e => e.khuNha)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Khu>()
                .Property(e => e.maKhu)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.maNhanVien)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.SDT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Phong>()
                .Property(e => e.maPhong)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Phong>()
                .Property(e => e.maKhu)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SinhVien>()
                .Property(e => e.maSinhVien)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SinhVien>()
                .Property(e => e.CMND)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SinhVien>()
                .Property(e => e.SDT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ThongBao>()
                .Property(e => e.maThongBao)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ThongBao>()
                .Property(e => e.maNhanVien)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
