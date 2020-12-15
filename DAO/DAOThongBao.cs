using QuanLyKyTucXa.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKyTucXa.DAO
{
    class DAOThongBao
    {
        private static model model = null;
        public DAOThongBao()
        {
            if (model == null)
                model = new model();
        }

        public List<ThongBao> GetListThongBao()
        {
            return model.ThongBaos.ToList();
        }
        public bool AddThongBao(ThongBao tb)
        {
            try
            {
                model.ThongBaos.Add(tb);
                model.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteThongBao(ThongBao tb)
        {
            try
            {
                model.ThongBaos.Remove(tb);
                model.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public ThongBao GetThongBao(string id)
        {
            return model.ThongBaos.Single(i => i.maThongBao == id);
        }

        public bool EditSinhVien(string id, ThongBao tb_n)
        {
            try
            {
                var tb_c = GetThongBao(id);
                tb_c.ngayLap = tb_n.ngayLap;
                tb_c.noiDung = tb_n.noiDung;
                tb_c.maNhanVien = tb_n.maNhanVien;
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
