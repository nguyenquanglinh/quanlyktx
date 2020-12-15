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
using QuanLyKyTucXa.entity;

namespace QuanLyKyTucXa
{
    public partial class QuanLySinhVien : Form
    {
        private Form1 form1;

        public QuanLySinhVien()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.AutoSize = false;
        }

        public QuanLySinhVien(Form1 form1):this()
        {
            this.form1 = form1;
            this.DaoSinhVien = new DAOSinhVien();
            InitDataView();
        }

        private void InitDataView()
        {
            var dsSV = DaoSinhVien.GetListSinhVien();
            cbbMaSV.Items.Clear();
            cbbHoTen.Items.Clear();

            cbbNgaySinh.Items.Clear();
            cbbCMND.Items.Clear();

            cbbSDT.Items.Clear();
            cbbLopKhoa.Items.Clear();
            dataGridView1.DataSource = dsSV;
            foreach (var item in dsSV)
            {
                cbbMaSV.Items.Add(item.maSinhVien);
                cbbHoTen.Items.Add(item.hoTen);

                cbbNgaySinh.Items.Add(item.ngaySinh);
                cbbCMND.Items.Add(item.CMND);

                cbbSDT.Items.Add(item.SDT);
                cbbLopKhoa.Items.Add(item.lopKhoa);
            }
        }
        public DAOSinhVien DaoSinhVien { get; private set; }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (DaoSinhVien.AddSinhVien(new entity.SinhVien(cbbMaSV.Text, cbbHoTen.Text, cbbNgaySinh.Text, cbbCMND.Text, cbbSDT.Text, cbbLopKhoa.Text)))
                MessageBox.Show("Thêm sinh viên thành công");
            else MessageBox.Show("Thêm sinh viên không thành công");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbbMaSV.SelectedIndex=e.RowIndex;
            cbbHoTen.SelectedIndex = e.RowIndex;
            cbbNgaySinh.SelectedIndex = e.RowIndex;
            cbbCMND.SelectedIndex = e.RowIndex;
            cbbSDT.SelectedIndex = e.RowIndex;
            cbbLopKhoa.SelectedIndex = e.RowIndex;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void QuanLySinhVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.Show();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (DaoSinhVien.EditSinhVien(new entity.SinhVien(cbbMaSV.Text, cbbHoTen.Text, cbbNgaySinh.Text, cbbCMND.Text, cbbSDT.Text, cbbLopKhoa.Text)))
                MessageBox.Show("Sửa sinh viên thành công");
            else MessageBox.Show("Sửa sinh viên không thành công");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (DaoSinhVien.DeleteSinhVien(new entity.SinhVien(cbbMaSV.Text, cbbHoTen.Text, cbbNgaySinh.Text, cbbCMND.Text, cbbSDT.Text, cbbLopKhoa.Text)))
                MessageBox.Show("Xoa sinh viên thành công");
            else MessageBox.Show("Xóa sinh viên không thành công");
        }
    }
}
