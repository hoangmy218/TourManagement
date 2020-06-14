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
    public partial class frmDaiLy : Form
    {
        bool Them;
        String sqltr;

        SqlConnection conn = new SqlConnection("Server=dell\\sqlexpress;uid=sa;pwd=sa2008;Database=QuanLyTour");
        SqlCommand cmd = null;
        SqlDataAdapter daDaily = null;
        DataTable dtDaily = null;
        

        public frmDaiLy()
        {
            InitializeComponent();
        }


        private void DaiLy_Load(object sender, EventArgs e)
        {
            conn.Open();
            LoadData();
            

        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void ResetFeild()
        {
            txtMaDL.ResetText();
            txtDiaChi.ResetText();
            txtSdt.ResetText();
            txtTenDL.ResetText();

        }

        private void LoadData()
        {
            sqltr = "Select * from daily";
            daDaily = new SqlDataAdapter(sqltr, conn);
            dtDaily = new DataTable();
            dtDaily.Clear();
            daDaily.Fill(dtDaily);
            this.dgvDaily.DataSource = dtDaily;
            

            pnlDaily.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;

            btnTaiLai.Enabled = true;
            btnThem.Enabled = true;
            btnTroVe.Enabled = true;

        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Them = true;
            pnlDaily.Enabled = true;

            ResetFeild();
            btnTaiLai.Enabled = true;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnTroVe.Enabled = true;

            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            int madl_moi;
            try
            {
                sqltr = "Select max(madl) from daily";
                cmd = new SqlCommand(sqltr, conn);
                madl_moi = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                madl_moi = 0;
                MessageBox.Show("Lỗi! " + ex.Message + ex.StackTrace);
            }
            madl_moi++;
            txtMaDL.Text = madl_moi.ToString();
            txtMaDL.Enabled = false;
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

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Them)
            {
                try
                {
                    sqltr = "Insert into daily values("
                        + txtMaDL.Text.ToString() + ", N'"
                        + txtTenDL.Text.ToString() + "', N'"
                        + txtDiaChi.Text.ToString() + "','"
                        + txtSdt.Text.ToString() + "');";
                        
                    cmd = new SqlCommand(sqltr, conn);
                    cmd.ExecuteNonQuery();
                    LoadData();
                    MessageBox.Show("Đã thêm đại lý thành công!");
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
                    sqltr = "Update daily set "
                        + "tendl = N'"+ txtTenDL.Text.ToString() 
                        + "', diachi = N'" + txtDiaChi.Text.ToString() 
                        + "', sdt = '" + txtSdt.Text.ToString() + "' "
                        + "where madl="+ txtMaDL.Text.ToString() + ";";
                    cmd = new SqlCommand(sqltr, conn);
                    cmd.ExecuteNonQuery();
                    LoadData();
                    MessageBox.Show("Đã cập nhật đại lý thành công!");
                    ResetFeild();

                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Lỗi! " + ex.Message + ex.StackTrace);
                }
            }
        }

        private void frmDaiLy_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Close();
            conn = null;
        }

        private void dgvDaily_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pnlDaily.Enabled = true;
            ResetFeild();
            //Cho phep TaiLai/ Xoa/ Luu /Huy / Tro Ve
            btnXoa.Enabled = true;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnTroVe.Enabled = true;

            //Không cho phep Them
            btnThem.Enabled = false;


            //Chon Cell/Row
            dgvDaily.CurrentCell.Selected = true;
            dgvDaily.CurrentRow.Selected = true;
            foreach (DataGridViewRow row in dgvDaily.SelectedRows)
            {
                txtMaDL.Text = row.Cells["madl"].Value.ToString();
                txtTenDL.Text = row.Cells["tendl"].Value.ToString();
                txtDiaChi.Text = row.Cells["diachi"].Value.ToString();
                txtSdt.Text = row.Cells["sdt"].Value.ToString();
                txtMaDL.Enabled = false;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult xacnhan_xoa = MessageBox.Show("Bạn có chắc chắn muốn xóa đại lý này?",
                    "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (xacnhan_xoa == DialogResult.Yes)
                {
                    int r = dgvDaily.CurrentCell.RowIndex;
                    int madl_xoa = Convert.ToInt32(dgvDaily.Rows[r].Cells["madl"].Value.ToString());
                    sqltr = "Delete from daily where madl=" + madl_xoa;
                    cmd = new SqlCommand(sqltr, conn);
                    cmd.ExecuteNonQuery();
                    LoadData();
                    MessageBox.Show("Đã xóa đại lý thành công!");
                    ResetFeild();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi! " + ex.Message + ex.StackTrace);
            }
        }
    }
}
