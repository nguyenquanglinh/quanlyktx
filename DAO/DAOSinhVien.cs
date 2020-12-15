using QuanLyKyTucXa.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKyTucXa.DAO
{
   public class DAOSinhVien
    {
        private static model model=null;
        public DAOSinhVien()
        {
            if (model == null)
                model = new model();
        }

        public List<SinhVien> GetListSinhVien()
        {
            return model.SinhViens.ToList();
        }
        public bool AddSinhVien(SinhVien sv)
        {
            try
            {
                model.SinhViens.Add(sv);
                model.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteSinhVien(SinhVien sv)
        {
            try
            {
                var sv_n = GetSinhVien(sv.maSinhVien);
                model.SinhViens.Remove(sv_n);
                model.SaveChanges();
                return true;
            }catch
            {
                return false;
            }
        }

        public SinhVien GetSinhVien(string id)
        {
            return model.SinhViens.Single(i => i.maSinhVien == id);
        }
        
        public bool EditSinhVien(SinhVien sv_n)
        {
            try
            {
                var sv_c = GetSinhVien(sv_n.maSinhVien);
                sv_c.hoTen = sv_n.hoTen;
                sv_c.ngaySinh = sv_n.ngaySinh;
                sv_c.CMND = sv_n.CMND;
                sv_c.SDT = sv_n.SDT;
                sv_c.lopKhoa = sv_n.lopKhoa;
                model.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
           
        }
    }
}
