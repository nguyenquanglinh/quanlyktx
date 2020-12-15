namespace QuanLyKyTucXa.entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CongToDien")]
    public partial class CongToDien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CongToDien()
        {
            HoaDonDienChiTiets = new HashSet<HoaDonDienChiTiet>();
        }

        [Key]
        [StringLength(10)]
        public string maCongToDien { get; set; }

        [StringLength(10)]
        public string chiSoCu { get; set; }

        [StringLength(10)]
        public string chiSoMoi { get; set; }

        [StringLength(10)]
        public string maDaiLy { get; set; }

        public virtual DaiLy DaiLy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDonDienChiTiet> HoaDonDienChiTiets { get; set; }
    }
}
