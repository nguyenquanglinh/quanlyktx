using QuanLyKyTucXa.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKyTucXa.DAO
{
    public class DAODaiLy
    {
        private static model model = null;
        public DAODaiLy()
        {
            if (model == null)
                model = new model();
        }

        public List<DaiLy> GetListDaiLy()
        {
            return model.DaiLies.ToList();
        }
        public bool AddDaiLy(DaiLy dl)
        {
            try
            {
                model.DaiLies.Add(dl);
                model.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteDaiLy(DaiLy dl)
        {
            try
            {
                model.DaiLies.Remove(GetDaiLy(dl.maDaiLy));
                model.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public DaiLy GetDaiLy(string id)
        {
            return model.DaiLies.Single(i => i.maDaiLy == id);
        }

        public bool EditDaiLy(DaiLy dl_n)
        {
            try
            {
                var dl_c = GetDaiLy(dl_n.maDaiLy);
                dl_c.tenDaiLy = dl_n.tenDaiLy;
                dl_c.SDT = dl_n.SDT;
                dl_c.diaChi = dl_n.diaChi;
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
