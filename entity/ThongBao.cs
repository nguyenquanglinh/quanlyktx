namespace QuanLyKyTucXa.entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThongBao")]
    public partial class ThongBao
    {
        [Key]
        [StringLength(10)]
        public string maThongBao { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngayLap { get; set; }

        [StringLength(4000)]
        public string noiDung { get; set; }

        [StringLength(10)]
        public string maNhanVien { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}
