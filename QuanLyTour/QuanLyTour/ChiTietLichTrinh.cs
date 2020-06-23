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
    public partial class ChiTietLichTrinh : Form
    {
        public frmQLLichTrinh frmQLLT;
        //Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu
        bool Them, Sua, Xoa, ThemKs = false, SuaKs = false;
        //Chuỗi kết nối
        String strConnectionString = "Server=dell\\sqlexpress;uid=sa;pwd=sa2008;Database=QuanLyTour;MultipleActiveResultSets=True";
        //Đối tượng kết nối
        SqlConnection conn = null;

        SqlCommand cmd = null;
        //Đối tượng đưa dữ liệu vào DataTable dtLT = null;
        SqlDataAdapter daLT = null, daTour = null, daDiaDanh = null, daKhachHang = null, daPhuongTien = null, daKhachSan = null;
        String sqlstr;
        DateTime ngay;
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Them)
            {
                try
                {
                    sqlstr = "Insert into lichtrinh values( @matour, @ngayo, @madd, @mapt, @gio);";
                    cmd = new SqlCommand(sqlstr, conn);
                    cmd.Parameters.AddWithValue("@matour", this.matour);
                    cmd.Parameters.AddWithValue("@madd", cboDiaDanh.SelectedValue);
                    cmd.Parameters.AddWithValue("@mapt", cboPhuongTien.SelectedValue);
                    cmd.Parameters.AddWithValue("@gio", dtpGio.Value);
                    //String ngay = "" + (cboNgay.SelectedItem as dynamic).Value;
                    //DateTime oDate = DateTime.ParseExact(ngay, "dd/M/yyyy", null);
                    cmd.Parameters.AddWithValue("@ngayo", this.ngay.Date);
                    String sql = "matour: " + this.matour +
                        " madd " + cboDiaDanh.SelectedValue +
                        " mapt " + cboPhuongTien.SelectedValue +
                        " gio " + dtpGio.Value.ToShortTimeString() +
                        " ngayo " + this.ngay.Date;
                    MessageBox.Show(sql);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm lịch trình thành công!");
                   
                    Them = false;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Lỗi thêm lịch trình!"+ex.Message + ex.StackTrace);
                }
            }
        }

        //Đối tượng hiển thị dữ liệu lên Form
        DataTable dtLT = null, dtTour = null, dtKhachSan = null, dtPhuongTien = null, dtDiaDanh = null;

        String matour;
        public ChiTietLichTrinh()
        {
            InitializeComponent();
        }

        private void ChiTietLichTrinh_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(strConnectionString);
            conn.Open();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                //Vận chuyển dữ liệu lên DataTable dtHoaDon
                daDiaDanh = new SqlDataAdapter("SELECT * FROM diadanh", conn);
                dtDiaDanh = new DataTable();
                dtDiaDanh.Clear();
                daDiaDanh.Fill(dtDiaDanh);
                this.cboDiaDanh.DataSource = dtDiaDanh;
                this.cboDiaDanh.DisplayMember = "tendd";
                this.cboDiaDanh.ValueMember = "madd";

                // Vận chuyển dữ liệu lên DataTable dtThanhPho
                daPhuongTien = new SqlDataAdapter("SELECT * FROM phuongtien", conn);
                dtPhuongTien = new DataTable();
                dtPhuongTien.Clear();
                daPhuongTien.Fill(dtPhuongTien);
                this.cboPhuongTien.DataSource = dtPhuongTien;
                this.cboPhuongTien.DisplayMember = "tenpt";
                this.cboPhuongTien.ValueMember = "mapt";
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        public void setTextLabel(String txt)
        {
            lblLichTrinh.Text = txt;
            if (txt == "Thêm lịch trình")
            {
                Them = true;  
            }else
            {
                Sua = true;
            }
        }

        public void setThemChiTietLichTrinh(String matourlt, DateTime ngaylt)
        {
            this.matour = matourlt;
            txtMatour.Text = matourlt;
            txtNgay.Text = "" + ngaylt.Date;
            this.ngay = ngaylt;
            MessageBox.Show("matour: " + matourlt + " ngay: " + ngaylt.Date);
           
        }

        private void ChiTietLichTrinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            //e.Cancel = true;

            //this.Close();
            dtDiaDanh.Dispose();
            dtDiaDanh = null;
            dtPhuongTien.Dispose();
            dtPhuongTien = null;
            conn.Close();
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
