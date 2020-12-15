namespace QuanLyKyTucXa.entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SinhVien")]
    public partial class SinhVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SinhVien()
        {
            HopDongs = new HashSet<HopDong>();
        }

        public SinhVien(string text1, string text2, string text3, string text4, string text5,string text6)
        {
            this.maSinhVien = text1;
            this.hoTen = text2;
            this.ngaySinh =DateTime.Parse(text3);
            this.CMND = text4;
            this.SDT = text5;
            this.lopKhoa = text6;
        }

        [Key]
        [StringLength(10)]
        public string maSinhVien { get; set; }

        [StringLength(50)]
        public string hoTen { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngaySinh { get; set; }

        [StringLength(15)]
        public string CMND { get; set; }

        [StringLength(11)]
        public string SDT { get; set; }

        [StringLength(50)]
        public string lopKhoa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HopDong> HopDongs { get; set; }
    }
}
