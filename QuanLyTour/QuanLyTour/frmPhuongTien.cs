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
    public partial class frmPhuongTien : Form
    {
        SqlConnection conn = new SqlConnection("Server=DELL\\SQLEXPRESS;uid=sa;pwd=sa2008;Database=QuanLyTour");

        SqlCommand cmd = null;
        SqlDataAdapter daPhuongTien = null;

        DataTable dtPhuongTien = null;
        bool Them = false, Xoa = false;
        String sqlstr;

        public frmPhuongTien()
        {
            InitializeComponent();
        }

        private void ResetFeild()
        {
            txtMapt.ResetText();
            txtTenpt.ResetText();
            nudSoCho.Value = 1;

        }

        private void frmPhuongTien_Load(object sender, EventArgs e)
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

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void frmPhuongTien_FormClosing(object sender, FormClosingEventArgs e)
        {
            dtPhuongTien.Dispose();
            dtPhuongTien = null;
            conn.Close();
            conn = null;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Them = true;
            pnlThongtinpt.Enabled = true;
            ResetFeild();
            btnTaiLai.Enabled = true;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnTroVe.Enabled = true;

            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            int mapt_moi;
            try
            {
                sqlstr = "Select max(mapt) from phuongtien";
                cmd = new SqlCommand(sqlstr, conn);
                object result = cmd.ExecuteScalar();
                if (result.GetType() != typeof(DBNull))
                {
                    mapt_moi = Convert.ToInt32(result);
                }
                else
                    mapt_moi = 0;
                mapt_moi++;
                txtMapt.Text = mapt_moi.ToString();
                txtMapt.Enabled = false;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi! " + ex.Message + ex.StackTrace);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int r = dgvPhuongTien.CurrentCell.RowIndex;
                if (r >= 0)
                {
                    DialogResult xacnhan_xoa = MessageBox.Show("Bạn có chắc chắn muốn xóa phương tiện này?",
                        "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (xacnhan_xoa == DialogResult.Yes)
                    {
                        String mapt_xoa = dgvPhuongTien.Rows[r].Cells["mapt"].Value.ToString();
                        sqlstr = "Delete from phuongtien where mapt=" + mapt_xoa;
                        cmd = new SqlCommand(sqlstr, conn);
                        cmd.ExecuteNonQuery();
                        LoadData();
                        ResetFeild();
                        MessageBox.Show("Đã xóa phương tiện thành công!");

                    }
                }
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
                    sqlstr = "Insert into phuongtien values("
                            + txtMapt.Text.ToString() + ",N'"
                            + txtTenpt.Text.ToString() + "',"
                            + nudSoCho.Value.ToString() + ")";

                    cmd = new SqlCommand(sqlstr, conn);
                    cmd.ExecuteNonQuery();
                    LoadData();
                    MessageBox.Show("Đã thêm phương tiện thành công!");
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
                    sqlstr = "Update phuongtien set "
                        + "tenpt=N'" + txtTenpt.Text.ToString() + "', "
                        + "socho =" + nudSoCho.Value.ToString() + " "
                        + "where mapt=" + txtMapt.Text.ToString();
                    cmd = new SqlCommand(sqlstr, conn);
                    cmd.ExecuteNonQuery();
                    LoadData();
                    ResetFeild();
                    MessageBox.Show("Đã cập nhật phương tiện thành công!");

                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Lỗi! " + ex.Message + ex.StackTrace);
                }
            }
        }

        private void dgvPhuongTien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pnlThongtinpt.Enabled = true;
            ResetFeild();
            //Cho phep TaiLai/ Xoa/ Luu /Huy / Tro Ve
            btnXoa.Enabled = true;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnTroVe.Enabled = true;

            //Không cho phep Them
            btnThem.Enabled = false;

            //Chon Cell/Row
            dgvPhuongTien.CurrentCell.Selected = true;
            dgvPhuongTien.CurrentRow.Selected = true;
            foreach (DataGridViewRow row in dgvPhuongTien.SelectedRows)
            {
                txtMapt.Text = row.Cells["mapt"].Value.ToString();
                txtTenpt.Text = row.Cells["tenpt"].Value.ToString();
                nudSoCho.Value = Convert.ToInt32(row.Cells["socho"].Value.ToString());              
                txtMapt.Enabled = false;
            }
        }

        private void LoadData()
        {

            try
            {
                //Load dl lên dgvNhanvien
                sqlstr = "Select * from phuongtien";
                //cmd = new SqlCommand(sqlstr, conn);

                daPhuongTien = new SqlDataAdapter(sqlstr, conn);
                //conn.Open();
                dtPhuongTien = new DataTable();
                dtPhuongTien.Clear();
                daPhuongTien.Fill(dtPhuongTien);
                this.dgvPhuongTien.DataSource = dtPhuongTien;

                ResetFeild();
                //Cho phep tai lai/ them/ tro ve
                btnTaiLai.Enabled = true;
                btnThem.Enabled = true;
                btnTroVe.Enabled = true;

                //khong cho phep xoa/ luu/ huy
                btnXoa.Enabled = false;
                btnLuu.Enabled = false;
                btnHuy.Enabled = false;
                pnlThongtinpt.Enabled = false;
                //conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu! " + ex.Message + ex.StackTrace);
            }



        }
    }

    
}
