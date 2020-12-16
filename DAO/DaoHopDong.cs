using QuanLyKyTucXa.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKyTucXa.DAO
{
    public class DaoHopDong
    {
        private static model model = null;
        public DaoHopDong()
        {
            if (model == null)
                model = new model();
        }

        public List<HopDong> GetListHopDong()
        {
            return model.HopDongs.ToList();
        }
        public bool AddHopDong(HopDong hd)
        {
            try
            {
                model.HopDongs.Add(hd);
                model.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteHopDong(HopDong hd)
        {
            try
            {
                model.HopDongs.Remove(GetHopDong(hd.maHopDong));
                model.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public HopDong GetHopDong(string id)
        {
            return model.HopDongs.Single(i => i.maHopDong == id);
        }

        public bool EditHopDong(HopDong hd_n)
        {
            try
            {
                var hd_c = GetHopDong(hd_n.maHopDong);
                hd_c.maSinhVien = hd_n.maSinhVien;
                hd_c.maNhanVien = hd_n.maNhanVien;
                hd_c.soPhong = hd_n.soPhong;
                hd_c.khuNha = hd_n.khuNha;
                hd_c.ngayLap = hd_n.ngayLap;
                hd_c.ngayBatDau = hd_n.ngayBatDau;
                hd_c.ngayKetThuc = hd_n.ngayKetThuc;
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
