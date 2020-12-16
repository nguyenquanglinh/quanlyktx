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
    public partial class QuanLyThongBao : Form
    {
        private Form1 form1;

        internal DAOThongBao DaoThongBao { get; }

        public QuanLyThongBao()
        {
            InitializeComponent();
        }

        public QuanLyThongBao(Form1 form1):this()
        {
            this.form1 = form1;
            this.DaoThongBao = new DAOThongBao();
            InitDataView();
        }

        private void InitDataView()
        {
            var dshd = DaoThongBao.GetListThongBao();
            cbbMaNV.Items.Clear();
            cbbMaTB.Items.Clear();
            cbbND.Items.Clear();
            cbbNgayLap.Items.Clear();
            dataGridView1.DataSource = dshd;
            foreach (var item in dshd)
            {
                cbbMaNV.Items.Add(item.maNhanVien);
                cbbMaTB.Items.Add(item.maThongBao);
                cbbND.Items.Add(item.noiDung);
                cbbNgayLap.Items.Add(item.ngayLap);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (DaoThongBao.AddThongBao(new entity.ThongBao(cbbMaTB.Text, cbbMaNV.Text, cbbND.Text, cbbNgayLap.Text)))
            {
                MessageBox.Show("Thêm thông báo thành công");
                InitDataView();
            }
            else MessageBox.Show("Thêm thông báo không thành công");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (DaoThongBao.EditThongBao(new entity.ThongBao(cbbMaTB.Text, cbbMaNV.Text, cbbND.Text, cbbNgayLap.Text)))
            {
                MessageBox.Show("Sửa thông báo thành công");
                InitDataView();
            }
            else MessageBox.Show("Sửa thông báo không thành công");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (DaoThongBao.DeleteThongBao(new entity.ThongBao(cbbMaTB.Text, cbbMaNV.Text, cbbND.Text, cbbNgayLap.Text)))
            {
                MessageBox.Show("Xóa thông báo thành công");
                InitDataView();
            }
            else MessageBox.Show("Xóa thông báo không thành công");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbbMaNV.SelectedIndex = e.RowIndex;
            cbbMaTB.SelectedIndex = e.RowIndex;
            cbbND.SelectedIndex = e.RowIndex;
            cbbNgayLap.SelectedIndex = e.RowIndex;
        }

        private void QuanLyThongBao_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.Show();
        }
    }
}
