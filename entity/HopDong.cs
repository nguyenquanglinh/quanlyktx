namespace QuanLyKyTucXa.entity
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("HopDong")]
    public partial class HopDong
    {
        public HopDong() { }

        public HopDong(string text1, string text2, string text3, string text4, string text5, string text6, string text7, string text8)
        {
            this.maHopDong = text1;
            this.maSinhVien = text2;
            this.maNhanVien = text3;
            this.soPhong = text4;
            this.khuNha = text5;
            this.ngayLap = DateTime.Parse(text6);
            this.ngayBatDau = DateTime.Parse(text7);
            this.ngayKetThuc = DateTime.Parse(text8);
        }

        [Key]
        [StringLength(10)]
        public string maHopDong { get; set; }

        [StringLength(10)]
        public string maSinhVien { get; set; }

        [StringLength(10)]
        public string maNhanVien { get; set; }

        [StringLength(10)]
        public string soPhong { get; set; }

        [StringLength(10)]
        public string khuNha { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngayLap { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngayBatDau { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngayKetThuc { get; set; }

        protected virtual NhanVien NhanVien { get; set; }

        protected virtual SinhVien SinhVien { get; set; }
    }
}
