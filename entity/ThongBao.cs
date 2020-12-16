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
        public ThongBao() { }

        public ThongBao(string text1, string text2, string text3, string text4)
        {
            this.maThongBao = text1;
            this.maNhanVien = text2;
            this.noiDung = text3;
            this.ngayLap = DateTime.Parse(text4);
        }

        [Key]
        [StringLength(10)]
        public string maThongBao { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngayLap { get; set; }

        [StringLength(4000)]
        public string noiDung { get; set; }

        [StringLength(10)]
        public string maNhanVien { get; set; }

        protected virtual NhanVien NhanVien { get; set; }
    }
}
