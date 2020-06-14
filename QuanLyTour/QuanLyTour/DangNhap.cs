using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTour
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult thongbao = MessageBox.Show("Bạn chắc chắn muốn thoát khỏi ứng dụng?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (thongbao == DialogResult.OK)
                Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (this.txtTentk.Text == "admin" && this.txtMk.Text == "admin")
                this.Close();
            else
            {
                MessageBox.Show("Tên tài khoản hoặc mật khẩu không đúng!", "Thông báo");
                this.txtTentk.Focus();
            }
        }
    }
}
