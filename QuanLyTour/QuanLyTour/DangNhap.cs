using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTour
{
    public partial class DangNhap : Form
    {
        //Chuỗi kết nối
        String strConnectionString = "Server=dell\\sqlexpress;uid=sa;pwd=sa2008;Database=QuanLyTour";
        //Đối tượng kết nối
        SqlConnection conn = null;

        SqlCommand cmd = null;
        //Đối tượng đưa dữ liệu vào DataTable dtTour = null;
        SqlDataAdapter daTour = null;
        //Đối tượng hiển thị dữ liệu lên Form
        DataTable dtTour = null;
        mainForm frmGDC;
        String  sqlstr;
        string tennd ="";
        
        
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
        private String GetMD5(string txt)
        {
            String str = "";
            Byte[] buffer = System.Text.Encoding.UTF8.GetBytes(txt);
            System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            buffer = md5.ComputeHash(buffer);
            foreach (Byte b in buffer)
            {
                str += b.ToString("X2");
            }
            return str;
        }

        public string gettenDN()
        {            
            return tennd;
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            
            if (this.txtTentk.Text != "" && this.txtMk.Text != "")
                try
                {
                    sqlstr = "Select * from nhanvien where tentk='" + txtTentk.Text +
                        "' and matkhau='" + GetMD5(txtMk.Text.ToString()) + "' and maquyen=1;";
                    cmd = new SqlCommand(sqlstr, conn);
                    SqlDataReader drnv = cmd.ExecuteReader();

                    if (drnv.HasRows)
                    {
                        while (drnv.Read())
                        {
                            tennd = drnv["tennv"].ToString();
                        }
                        drnv.Close();
                        conn.Close();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Tên tài khoản hoặc mật khẩu không đúng!", "Thông báo");
                        this.txtTentk.Focus();
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Tên tài khoản hoặc mật khẩu không đúng!", "Thông báo");
                }
                
            else
            {
                MessageBox.Show("Nhập tên và mật khẩu!", "Thông báo");
                this.txtTentk.Focus();
            }
           
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(strConnectionString);
            conn.Open();
        }

        private void DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Close();
        }
    }
}
