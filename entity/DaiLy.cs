namespace QuanLyKyTucXa.entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DaiLy")]
    public partial class DaiLy
    {

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DaiLy()
        {
            CongToDiens = new HashSet<CongToDien>();
            CongToNuocs = new HashSet<CongToNuoc>();
            DichVus = new HashSet<DichVu>();
        }

        public DaiLy(string text1, string text2, string text3, string text4)
        {
            this.maDaiLy = text1;
            this.tenDaiLy = text2;
            this.SDT = text3;
            this.diaChi = text4;
        }

        [Key]
        [StringLength(10)]
        public string maDaiLy { get; set; }

        [StringLength(10)]
        public string tenDaiLy { get; set; }

        [StringLength(11)]
        public string SDT { get; set; }

        [StringLength(50)]
        public string diaChi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        protected virtual ICollection<CongToDien> CongToDiens { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        protected virtual ICollection<CongToNuoc> CongToNuocs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        protected virtual ICollection<DichVu> DichVus { get; set; }
    }
}
