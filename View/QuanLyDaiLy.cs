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
    public partial class QuanLyDaiLy : Form
    {
        private Form1 form1;

        public DAODaiLy DaoDaiLy { get; }

        public QuanLyDaiLy()
        {
            InitializeComponent();
        }

        public QuanLyDaiLy(Form1 form1):this()
        {
            this.form1 = form1;
            this.DaoDaiLy = new DAODaiLy();
            InitDataView();
        }

        private void InitDataView()
        {
            var dshd = DaoDaiLy.GetListDaiLy();
            cbbMaDL.Items.Clear();
            cbbTenDL.Items.Clear();
            cbbSDT.Items.Clear();
            cbbDiaChi.Items.Clear();
            dataGridView1.DataSource = dshd;
            foreach (var item in dshd)
            {
                cbbMaDL.Items.Add(item.maDaiLy);
                cbbTenDL.Items.Add(item.tenDaiLy);
                cbbSDT.Items.Add(item.SDT);
                cbbDiaChi.Items.Add(item.diaChi);
            }
        }

        private void QuanLyDaiLy_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbbDiaChi.SelectedIndex = e.RowIndex;
            cbbMaDL.SelectedIndex = e.RowIndex;
            cbbSDT.SelectedIndex = e.RowIndex;
            cbbTenDL.SelectedIndex = e.RowIndex;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (DaoDaiLy.AddDaiLy(new entity.DaiLy(cbbMaDL.Text, cbbTenDL.Text, cbbSDT.Text, cbbDiaChi.Text)))
            {
                MessageBox.Show("Thêm đại lý thành công");
                InitDataView();
            }
            else MessageBox.Show("Thêm đại lý không thành công");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (DaoDaiLy.EditDaiLy(new entity.DaiLy(cbbMaDL.Text, cbbTenDL.Text, cbbSDT.Text, cbbDiaChi.Text)))
            {
                MessageBox.Show("Sửa đại lý thành công");
                InitDataView();
            }
            else MessageBox.Show("Sửa đại lý không thành công");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (DaoDaiLy.DeleteDaiLy(new entity.DaiLy(cbbMaDL.Text, cbbTenDL.Text, cbbSDT.Text, cbbDiaChi.Text)))
            {
                MessageBox.Show("Xóa đại lý thành công");
                InitDataView();
            }
            else MessageBox.Show("Xóa đại lý không thành công");
        }
    }
}
