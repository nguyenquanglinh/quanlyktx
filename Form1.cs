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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSV_Click(object sender, EventArgs e)
        {
            new QuanLySinhVien(this).Show();
            this.Hide();
        }

        private void btnHD_Click(object sender, EventArgs e)
        {
            new QuanLyHopDong(this).Show();
            this.Hide();
        }

        private void btnThongBao_Click(object sender, EventArgs e)
        {
            new QuanLyThongBao(this).Show();
            Hide();
        }

        private void btnDaiLy_Click(object sender, EventArgs e)
        {
            new QuanLyDaiLy(this).Show();
            Hide();
        }
    }
}
