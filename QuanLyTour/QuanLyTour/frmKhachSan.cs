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
    public partial class frmKhachSan : Form
    {
        SqlConnection conn = new SqlConnection("Server=dell\\sqlexpress;uid=sa;pwd=sa2008;Database=QuanLyTour");
        SqlCommand cmd = null;
        SqlDataAdapter daKhachSan = null;
        DataTable dtKhachSan = null;
        bool Them;
        String sqlstr;

        public frmKhachSan()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            try
            {
                sqlstr = "Select * from khachsan";
                daKhachSan = new SqlDataAdapter(sqlstr, conn);
                dtKhachSan = new DataTable();
                dtKhachSan.Clear();
                daKhachSan.Fill(dtKhachSan);
                dgvKhachSan.DataSource = dtKhachSan;

                pnlThongtinks.Enabled = false;
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
            txtMaks.ResetText();
            txtTenks.ResetText();
            txtDiachi.ResetText();
            txtSdt.ResetText();

        }

        private void frmKhachSan_Load(object sender, EventArgs e)
        {
            conn.Open();
            LoadData();
        }

        private void frmKhachSan_FormClosing(object sender, FormClosingEventArgs e)
        {
            dtKhachSan.Dispose();
            conn.Close();
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
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
            pnlThongtinks.Enabled = true;
            ResetFeild();
            btnTaiLai.Enabled = true;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnTroVe.Enabled = true;

            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            int maks_moi;
            try
            {
                sqlstr = "Select max(maks) from khachsan";
                cmd = new SqlCommand(sqlstr, conn);
                object result = cmd.ExecuteScalar();
                if (result.GetType() != typeof(DBNull))
                {
                    maks_moi = Convert.ToInt32(result);
                }
                else
                    maks_moi = 0;
                maks_moi++;
                txtMaks.Text = maks_moi.ToString();
                txtMaks.Enabled = false;
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
                    sqlstr = "Insert into khachsan values("
                        + txtMaks.Text.ToString() + ", N'"
                        + txtTenks.Text.ToString() + "', N'"
                        + txtDiachi.Text.ToString() + "','"
                        + txtSdt.Text.ToString() + "')";
                    cmd = new SqlCommand(sqlstr, conn);
                    cmd.ExecuteNonQuery();
                    LoadData();
                    MessageBox.Show("Đã thêm khách sạn thành công!");
                    ResetFeild();

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
                    sqlstr = "Update khachsan set "
                        + "tenks = N'" + txtTenks.Text.ToString()
                        + "', diachi = N'" + txtDiachi.Text.ToString()
                        +"', sdt='" + txtSdt.Text.ToString() 
                        + "' where maks=" + txtMaks.Text.ToString() + ";";
                    cmd = new SqlCommand(sqlstr, conn);
                    cmd.ExecuteNonQuery();
                    LoadData();
                    MessageBox.Show("Đã cập nhật khách sạn thành công!");
                    ResetFeild();

                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Lỗi! " + ex.Message + ex.StackTrace);
                }
            }
        }

        private void dgvKhachSan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pnlThongtinks.Enabled = true;
            ResetFeild();
            //Cho phep TaiLai/ Xoa/ Luu /Huy / Tro Ve
            btnXoa.Enabled = true;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnTroVe.Enabled = true;

            //Không cho phep Them
            btnThem.Enabled = false;


            //Chon Cell/Row
            dgvKhachSan.CurrentCell.Selected = true;
            dgvKhachSan.CurrentRow.Selected = true;
            foreach (DataGridViewRow row in dgvKhachSan.SelectedRows)
            {
                txtMaks.Text = row.Cells["maks"].Value.ToString();
                txtTenks.Text = row.Cells["tenks"].Value.ToString();
                txtDiachi.Text = row.Cells["diachi"].Value.ToString();
                txtSdt.Text = row.Cells["sdt"].Value.ToString();
                txtMaks.Enabled = false;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult xacnhan_xoa = MessageBox.Show("Bạn có chắc chắn muốn xóa khách sạn này?",
                    "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (xacnhan_xoa == DialogResult.Yes)
                {
                    int r = dgvKhachSan.CurrentCell.RowIndex;
                    int maks_xoa = Convert.ToInt32(dgvKhachSan.Rows[r].Cells["maks"].Value.ToString());
                    sqlstr = "Delete from khachsan where maks=" + maks_xoa;
                    cmd = new SqlCommand(sqlstr, conn);
                    cmd.ExecuteNonQuery();
                    LoadData();
                    ResetFeild();
                    MessageBox.Show("Đã xóa khách sạn thành công!");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi! " + ex.Message + ex.StackTrace);
            }
        }
    }
}
