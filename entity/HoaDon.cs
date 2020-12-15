namespace QuanLyKyTucXa.entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoaDon")]
    public partial class HoaDon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HoaDon()
        {
            HoaDonDienChiTiets = new HashSet<HoaDonDienChiTiet>();
            HoaDonNuocChiTiets = new HashSet<HoaDonNuocChiTiet>();
        }

        [Key]
        [StringLength(10)]
        public string maHoaDon { get; set; }

        [StringLength(10)]
        public string maNhanVien { get; set; }

        [StringLength(10)]
        public string maPhong { get; set; }

        [StringLength(10)]
        public string makhu { get; set; }

        public virtual Khu Khu { get; set; }

        public virtual Phong Phong { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDonDienChiTiet> HoaDonDienChiTiets { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDonNuocChiTiet> HoaDonNuocChiTiets { get; set; }
    }
}
