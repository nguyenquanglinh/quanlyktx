namespace QuanLyKyTucXa.entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HopDong")]
    public partial class HopDong
    {
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

        public virtual NhanVien NhanVien { get; set; }

        public virtual SinhVien SinhVien { get; set; }
    }
}
