namespace QuanLyKyTucXa.entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DichVu")]
    public partial class DichVu
    {
        [Key]
        [StringLength(10)]
        public string maDichVu { get; set; }

        [StringLength(50)]
        public string tenDichVu { get; set; }

        [StringLength(10)]
        public string maDaiLy { get; set; }

        public virtual DaiLy DaiLy { get; set; }
    }
}
