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
    public partial class frmKhachHang : Form
    {
        SqlConnection conn = new SqlConnection("Server=DELL\\SQLEXPRESS;uid=sa;pwd=sa2008;Database=QuanLyTour");

        SqlCommand cmd = null;
        SqlDataAdapter  daKhachHang = null;

        DataTable dtKhachHang = null;
        bool Them = false, Xoa = false;
        String sqlstr;

        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void pnlThongtinnv_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ResetFeild()
        {
            txtMakh.ResetText();
            txtDiachi.ResetText();
            txtSdt.ResetText();
            txtTenkh.ResetText();
            radNam.Checked = true;
            radNu.Checked = false;

        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            conn.Open();
            LoadData();
        }

        private void frmKhachHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            dtKhachHang.Dispose();
            conn.Close();
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            
            ResetFeild();
            //Cho phep Them / TroVe / TaiLai
            btnThem.Enabled = true;
            btnTroVe.Enabled = true;
            btnHuy.Enabled = true;

            //khong cho phep xoa / luu / huy/ 
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Them = true;
            pnlThongtinkh.Enabled = true;
            ResetFeild();
            btnTaiLai.Enabled = true;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnTroVe.Enabled = true;

            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            int makh_moi;
            try
            {
                sqlstr = "Select max(makh) from khachhang";
                cmd = new SqlCommand(sqlstr, conn);
                object result = cmd.ExecuteScalar();
                if (result.GetType() != typeof(DBNull))
                {
                    makh_moi = Convert.ToInt32(result);
                }
                else
                    makh_moi = 0;
                makh_moi++;
                txtMakh.Text = makh_moi.ToString();
                txtMakh.Enabled = false;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi! " + ex.Message + ex.StackTrace);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            String gtinh;
            if (radNam.Checked == true)
                gtinh = "Nam";
            else
                gtinh = "Nữ";
            if (Them)
            {
                try
                {
                    sqlstr = "Insert into khachhang values("
                            + txtMakh.Text.ToString() + ",N'"
                            + txtTenkh.Text.ToString() + "',N'"
                            + gtinh + "', N'"
                            + txtDiachi.Text.ToString() + "','"
                            + txtSdt.Text.ToString() + "')";
                            
                    cmd = new SqlCommand(sqlstr, conn);
                    cmd.ExecuteNonQuery();
                    LoadData();
                    MessageBox.Show("Đã thêm khách hàng thành công!");
                    ResetFeild();
                    Them = false;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Lỗi! " + ex.Message + ex.StackTrace);
                }
            }
            else
            {
                try
                {
                    sqlstr = "Update khachhang set "
                        + "tenkh=N'" + txtTenkh.Text.ToString() + "', "
                        + "gioitinh =N'" + gtinh + "', "
                        + "diachi=N'" + txtDiachi.Text.ToString() + "', "
                        + "sdt='" + txtSdt.Text.ToString() + "' "
                        + " where makh=" + txtMakh.Text.ToString();
                    cmd = new SqlCommand(sqlstr, conn);
                    cmd.ExecuteNonQuery();
                    LoadData();
                    ResetFeild();
                    MessageBox.Show("Đã cập nhật khách hàng thành công!");

                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Lỗi! " + ex.Message + ex.StackTrace);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int r = dgvKhachHang.CurrentCell.RowIndex;
                if (r >= 0)
                {
                    DialogResult xacnhan_xoa = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?",
                        "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (xacnhan_xoa == DialogResult.Yes)
                    {
                        String makh_xoa = dgvKhachHang.Rows[r].Cells["makh"].Value.ToString();
                        sqlstr = "Delete from khachhang where makh=" + makh_xoa;
                        cmd = new SqlCommand(sqlstr, conn);
                        cmd.ExecuteNonQuery();
                        LoadData();
                        ResetFeild();
                        MessageBox.Show("Đã xóa khách hàng thành công!");

                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi! " + ex.Message + ex.StackTrace);
            }
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pnlThongtinkh.Enabled = true;
            ResetFeild();
            //Cho phep TaiLai/ Xoa/ Luu /Huy / Tro Ve
            btnXoa.Enabled = true;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnTroVe.Enabled = true;

            //Không cho phep Them
            btnThem.Enabled = false;

            //Chon Cell/Row
            dgvKhachHang.CurrentCell.Selected = true;
            dgvKhachHang.CurrentRow.Selected = true;
            foreach (DataGridViewRow row in dgvKhachHang.SelectedRows)
            {
                txtMakh.Text = row.Cells["makh"].Value.ToString();
                txtTenkh.Text = row.Cells["tenkh"].Value.ToString();
                txtDiachi.Text = row.Cells["diachi"].Value.ToString();
                txtSdt.Text = row.Cells["sdt"].Value.ToString();
                if (row.Cells["gioitinh"].Value.ToString() == "Nam")
                {
                    this.radNam.Checked = true;
                    this.radNu.Checked = false;

                }
                else
                {
                    this.radNam.Checked = false;
                    this.radNu.Checked = true;
                }
                txtMakh.Enabled = false;
            }
        }

        private void LoadData()
        {

            try
            {

                //Load dl lên dgvNhanvien
                sqlstr = "Select * from khachhang";
                //cmd = new SqlCommand(sqlstr, conn);

                daKhachHang = new SqlDataAdapter(sqlstr, conn);
                //conn.Open();
                dtKhachHang = new DataTable();
                dtKhachHang.Clear();
                daKhachHang.Fill(dtKhachHang);
                this.dgvKhachHang.DataSource = dtKhachHang;

                ResetFeild();
                //Cho phep tai lai/ them/ tro ve
                btnTaiLai.Enabled = true;
                btnThem.Enabled = true;
                btnTroVe.Enabled = true;

                //khong cho phep xoa/ luu/ huy
                btnXoa.Enabled = false;
                btnLuu.Enabled = false;
                btnHuy.Enabled = false;
                pnlThongtinkh.Enabled = false;
                //conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu! " + ex.Message + ex.StackTrace);
            }



        }
    }
}
