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
    public partial class mainForm : Form
    {
        public DangNhap frmdn;
        public mainForm()
        {
            InitializeComponent();
        }
        

        private void frmDangNhap()
        {
            frmdn = new DangNhap();
            
            frmdn.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void setTextTenDN(String txt)
        {
            
            txtTenDN.Text = txt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            frmDangNhap();
            txtTenDN.Text = frmdn.gettenDN();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult thongbao = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (thongbao == DialogResult.OK)
                frmDangNhap();
            
        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult thongbao = MessageBox.Show("Bạn chắc chắn muốn thoát khỏi ứng dụng?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (thongbao == DialogResult.OK)
                Application.Exit();
        }

        private void quảnLýTourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmtour = new frmTour();
            frmtour.ShowDialog();
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmnv = new frmNhanVien();
            frmnv.ShowDialog();
        }

        private void quảnLýĐạiLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmdl = new frmDaiLy();
            frmdl.ShowDialog();
        }

        private void quảnLýĐịaDanhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmDiaDanh = new frmdiadanh();
            frmDiaDanh.ShowDialog();
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmKhachhang = new frmKhachHang();
            frmKhachhang.ShowDialog();
        }

        private void quảnLýPhươngTiệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmPhuongtien = new frmPhuongTien();
            frmPhuongtien.ShowDialog();
        }

        private void quảnLýKháchSạnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmKhachSan = new frmKhachSan();
            frmKhachSan.ShowDialog();
        }

        private void quảnLýLịchTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form frm_LichTrinh = new frmLichTrinh();
            Form frm_LichTrinh = new frmQLLichTrinh();
            frm_LichTrinh.ShowDialog();
        }
    }
}
