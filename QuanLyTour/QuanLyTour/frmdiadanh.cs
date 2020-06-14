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
    public partial class frmdiadanh : Form
    {
        SqlConnection conn = new SqlConnection("Server=dell\\sqlexpress;uid=sa;pwd=sa2008;Database=QuanLyTour");
        SqlCommand cmd = null;
        SqlDataAdapter daDiaDanh = null;
        DataTable dtDiaDanh = null;
        bool Them;
        String sqlstr;

        public frmdiadanh()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            try
            {
                sqlstr = "Select * from diadanh";
                daDiaDanh = new SqlDataAdapter(sqlstr, conn);
                dtDiaDanh = new DataTable();
                dtDiaDanh.Clear();
                daDiaDanh.Fill(dtDiaDanh);
                dgvDiaDanh.DataSource = dtDiaDanh;

                pnlThongTinDD.Enabled = false;
                btnXoa.Enabled = false;
                btnHuy.Enabled = false;
                btnLuu.Enabled = false;

                btnTaiLai.Enabled = true;
                btnThem.Enabled = true;
                btnTroVe.Enabled = true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi! " + ex.Message + ex.StackTrace);
            }
            
        }

        private void ResetFeild()
        {
            txtMadd.ResetText();
            txtTendd.ResetText();
            txtDiaChi.ResetText();
            
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            
            LoadData();
        }

        private void frmdiadanh_Load(object sender, EventArgs e)
        {
            conn.Open();
            LoadData();
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            Them = true;
            pnlThongTinDD.Enabled = true;
            ResetFeild();
            btnTaiLai.Enabled = true;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnTroVe.Enabled = true;

            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            int madd_moi;
            try
            {
                sqlstr = "Select max(madd) from diadanh";
                cmd = new SqlCommand(sqlstr, conn);
                object result = cmd.ExecuteScalar();
                if (result.GetType() != typeof(DBNull))
                {
                    madd_moi = Convert.ToInt32(result);
                }
                else
                    madd_moi = 0;
                madd_moi++;
                txtMadd.Text = madd_moi.ToString();
                txtMadd.Enabled = false;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi! " + ex.Message + ex.StackTrace);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Them)
            {
                try
                {
                    sqlstr = "Insert into diadanh values("
                        + txtMadd.Text.ToString() + ", N'"
                        + txtTendd.Text.ToString() + "', N'"
                        + txtDiaChi.Text.ToString() + "')";
                    cmd = new SqlCommand(sqlstr, conn);
                    cmd.ExecuteNonQuery();
                    LoadData();
                    ResetFeild();
                    MessageBox.Show("Đã thêm địa danh thành công!");

                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Lỗi! " + ex.Message + ex.StackTrace);
                }
                Them = false;
            }
            else
            {
                try
                {
                    sqlstr = "Update diadanh set "
                        + "tendd = N'" + txtTendd.Text.ToString()
                        + "', diachi = N'" + txtDiaChi.Text.ToString()
                        + "' where madd=" + txtMadd.Text.ToString() + ";";
                    cmd = new SqlCommand(sqlstr, conn);
                    cmd.ExecuteNonQuery();
                    LoadData();
                    MessageBox.Show("Đã cập nhật địa danh thành công!");
                    ResetFeild();

                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Lỗi! " + ex.Message + ex.StackTrace);
                }
            }
        }

        private void frmdiadanh_FormClosing(object sender, FormClosingEventArgs e)
        {
            dtDiaDanh.Dispose();
            conn.Close();
            conn = null;
        }

        private void dgvDiaDanh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pnlThongTinDD.Enabled = true;
            ResetFeild();
            //Cho phep TaiLai/ Xoa/ Luu /Huy / Tro Ve
            btnXoa.Enabled = true;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnTroVe.Enabled = true;

            //Không cho phep Them
            btnThem.Enabled = false;


            //Chon Cell/Row
            dgvDiaDanh.CurrentCell.Selected = true;
            dgvDiaDanh.CurrentRow.Selected = true;
            foreach (DataGridViewRow row in dgvDiaDanh.SelectedRows)
            {
                txtMadd.Text = row.Cells["madd"].Value.ToString();
                txtTendd.Text = row.Cells["tendd"].Value.ToString();
                txtDiaChi.Text = row.Cells["diachi"].Value.ToString();
                txtMadd.Enabled = false;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult xacnhan_xoa = MessageBox.Show("Bạn có chắc chắn muốn xóa địa danh này?",
                    "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (xacnhan_xoa == DialogResult.Yes)
                {
                    int r = dgvDiaDanh.CurrentCell.RowIndex;
                    int madd_xoa = Convert.ToInt32(dgvDiaDanh.Rows[r].Cells["madd"].Value.ToString());
                    sqlstr = "Delete from diadanh where madd=" + madd_xoa;
                    cmd = new SqlCommand(sqlstr, conn);
                    cmd.ExecuteNonQuery();
                    LoadData();
                    ResetFeild();
                    MessageBox.Show("Đã xóa địa danh thành công!");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi! " + ex.Message + ex.StackTrace);
            }
        }
    }
}
