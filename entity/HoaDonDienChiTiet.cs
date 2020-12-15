namespace QuanLyKyTucXa.entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoaDonDienChiTiet")]
    public partial class HoaDonDienChiTiet
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string maCongToDien { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngayThang { get; set; }

        [StringLength(10)]
        public string donGia { get; set; }

        [StringLength(20)]
        public string tongTien { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string maHoaDon { get; set; }

        public virtual CongToDien CongToDien { get; set; }

        public virtual HoaDon HoaDon { get; set; }
    }
}
