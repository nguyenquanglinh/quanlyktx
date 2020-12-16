using QuanLyKyTucXa.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKyTucXa
{
    public partial class QuanLyHopDong : Form
    {
        private Form1 form1;

        public DaoHopDong DaoHopDong { get; set; }

        public QuanLyHopDong()
        {
            InitializeComponent();
        }

        public QuanLyHopDong(Form1 form1):this()
        {
            this.form1 = form1;
            this.DaoHopDong = new DaoHopDong();
            InitDataView();
        }

        private void InitDataView()
        {
            var dshd = DaoHopDong.GetListHopDong();
            cbbMaSV.Items.Clear();
            cbbMaHD.Items.Clear();
            cbbMaNV.Items.Clear();
            cbbSP.Items.Clear();
            cbbKhuNha.Items.Clear();
            cbbNgayLap.Items.Clear();
            cbbBD.Items.Clear();
            cbbKT.Items.Clear();
            dataGridView1.DataSource = dshd;
            foreach (var item in dshd)
            {
                cbbMaSV.Items.Add(item.maSinhVien);
                cbbMaNV.Items.Add(item.maNhanVien);
                cbbMaHD.Items.Add(item.maHopDong);
                cbbSP.Items.Add(item.soPhong);
                cbbKhuNha.Items.Add(item.khuNha);
                cbbNgayLap.Items.Add(item.ngayLap);
                cbbBD.Items.Add(item.ngayBatDau);
                cbbKT.Items.Add(item.ngayKetThuc);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (DaoHopDong.AddHopDong(new entity.HopDong(cbbMaHD.Text, cbbMaSV.Text, cbbMaNV.Text, cbbSP.Text, cbbKhuNha.Text, cbbNgayLap.Text, cbbBD.Text, cbbKT.Text)))
            {
                MessageBox.Show("Thêm hợp đồng thành công");
                InitDataView();
            }
            else MessageBox.Show("Thêm hợp đồng không thành công");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (DaoHopDong.EditHopDong(new entity.HopDong(cbbMaHD.Text, cbbMaSV.Text, cbbMaNV.Text, cbbSP.Text, cbbKhuNha.Text, cbbNgayLap.Text, cbbBD.Text, cbbKT.Text)))
            {
                MessageBox.Show("Sửa hợp đồng thành công");
                InitDataView();
            }
            else MessageBox.Show("Sửa hợp đồng không thành công");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (DaoHopDong.DeleteHopDong(new entity.HopDong(cbbMaHD.Text, cbbMaSV.Text, cbbMaNV.Text, cbbSP.Text, cbbKhuNha.Text, cbbNgayLap.Text, cbbBD.Text, cbbKT.Text)))
            {
                MessageBox.Show("Xóa hợp đồng thành công");
                InitDataView();
            }
            else MessageBox.Show("Xóa hợp đồng không thành công");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbbMaSV.SelectedIndex = e.RowIndex;
            cbbMaHD.SelectedIndex = e.RowIndex;
            cbbMaNV.SelectedIndex = e.RowIndex;
            cbbSP.SelectedIndex = e.RowIndex;
            cbbKhuNha.SelectedIndex = e.RowIndex;
            cbbNgayLap.SelectedIndex = e.RowIndex;
            cbbBD.SelectedIndex = e.RowIndex;
            cbbKT.SelectedIndex = e.RowIndex;
        }

        private void QuanLyHopDong_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.Show();
        }
    }
}
