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
    public partial class frmNhanVien : Form
    {
        SqlConnection conn = new SqlConnection("Server=DELL\\SQLEXPRESS;uid=sa;pwd=sa2008;Database=QuanLyTour");
        
        SqlCommand cmd = null;
        SqlDataAdapter daQuyen = null, daNhanvien = null;

        DataTable dtQuyen = null, dtNhanvien = null;
        bool Them = false, Xoa = false;
        String sqlstr;


        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvNhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pnlThongtinnv.Enabled = true;
            ResetFeild();
            //Cho phep TaiLai/ Xoa/ Luu /Huy / Tro Ve
            btnXoa.Enabled = true;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnTroVe.Enabled = true;

            //Không cho phep Them
            btnThem.Enabled = false;

            //Đưa dl lên cbox Quyen trong pnlThongtinNV
            this.cboQuyen.DataSource = dtQuyen;
            this.cboQuyen.DisplayMember = "tenquyen";
            this.cboQuyen.ValueMember = "maquyen";

            //Chon Cell/Row
            dgvNhanvien.CurrentCell.Selected = true;
            dgvNhanvien.CurrentRow.Selected = true;

            //Load du lieu tu DGV lên pnlThongTinNV
            foreach (DataGridViewRow row in dgvNhanvien.SelectedRows)
            {
                txtManv.Text = row.Cells["manv"].Value.ToString();
                txtTennv.Text = row.Cells["tennv"].Value.ToString();
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

                cboQuyen.SelectedValue = Convert.ToInt32(row.Cells["maquyen"].Value.ToString());
            }
            txtManv.Enabled = false;
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

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            dtNhanvien.Dispose();
            dtNhanvien = null;
            dtQuyen.Dispose();
            dtQuyen = null;
            conn = null;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //conn.Open();
            Them = true;
            ResetFeild();
            //Cho phep TaiLai/ Luu/ Huy/ TroVe / pnlThongtinNV
            btnTaiLai.Enabled = true;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnTroVe.Enabled = true;
            pnlThongtinnv.Enabled = true;

            //khong cho phep Them/ Xoa
            btnThem.Enabled = false;
            btnXoa.Enabled = false;

            cboQuyen.SelectedItem = cboQuyen.Items[0];

            int manv_moi;
            try
            {
                sqlstr = "Select max(manv) from nhanvien";
                cmd = new SqlCommand(sqlstr, conn);
                object result = cmd.ExecuteScalar();
                if (result.GetType() != typeof(DBNull))
                {
                    manv_moi = Convert.ToInt32(result);
                }
                else
                    manv_moi = 0;
                manv_moi++;
                txtManv.Text = manv_moi.ToString();
                txtManv.Enabled = false;
            }
            catch (SqlException ex)
            {
               
                MessageBox.Show("Lỗi! " + ex.Message + ex.StackTrace);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //conn.Open();
            String gtinh;
            if (radNam.Checked == true)
                gtinh = "Nam";
            else
                gtinh = "Nữ";
            if (Them)
            {
                try
                { 
                    sqlstr = "Insert into nhanvien values("
                            + txtManv.Text.ToString() + ",N'"
                            + txtTennv.Text.ToString() + "',N'"
                            + gtinh + "', N'"
                            + txtDiachi.Text.ToString() + "','"
                            + txtSdt.Text.ToString() + "',"
                            + cboQuyen.SelectedValue.ToString() + ");";
                    cmd = new SqlCommand(sqlstr, conn);
                    cmd.ExecuteNonQuery();
                    LoadData();
                    ResetFeild();
                    MessageBox.Show("Đã thêm nhân viên thành công!");
                    
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
                    sqlstr = "Update nhanvien set "
                        + "tennv=N'" + txtTennv.Text.ToString() + "', "
                        + "gioitinh =N'" + gtinh + "', "
                        + "diachi=N'" + txtDiachi.Text.ToString() + "', "
                        + "sdt='" + txtSdt.Text.ToString() + "', "
                        + "maquyen=" + cboQuyen.SelectedValue.ToString()
                        + " where manv=" + txtManv.Text.ToString();
                    cmd = new SqlCommand(sqlstr, conn);
                    cmd.ExecuteNonQuery();
                    LoadData();
                    ResetFeild();
                    MessageBox.Show("Đã cập nhật nhân viên thành công!");
                    
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Lỗi! " + ex.Message + ex.StackTrace);
                }
            }
            //conn.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int r = dgvNhanvien.CurrentCell.RowIndex;
                if (r >= 0)
                {
                    DialogResult xacnhan_xoa = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (xacnhan_xoa == DialogResult.Yes)
                    {
                        String manv_xoa = dgvNhanvien.Rows[r].Cells["manv"].Value.ToString();
                        sqlstr = "Delete from nhanvien where manv=" + manv_xoa;
                        cmd = new SqlCommand(sqlstr, conn);
                        cmd.ExecuteNonQuery();
                        LoadData();
                        ResetFeild();
                        MessageBox.Show("Đã xóa nhân viên thành công!");
                        
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi! " + ex.Message + ex.StackTrace);
            }

        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            conn.Open();
            LoadData();
        }

        private void LoadData() 
        {
            
            try
            {
                
                //Load dl lên dgvNhanvien
                sqlstr = "Select * from nhanvien";
                //cmd = new SqlCommand(sqlstr, conn);
                
                daNhanvien = new SqlDataAdapter(sqlstr, conn);
                //conn.Open();
                dtNhanvien = new DataTable();
                dtNhanvien.Clear();
                daNhanvien.Fill(dtNhanvien);
                this.dgvNhanvien.DataSource = dtNhanvien;

                //Load dl Quyen
                sqlstr = "Select * from quyen";
                daQuyen = new SqlDataAdapter(sqlstr, conn);
                dtQuyen = new DataTable();
                dtQuyen.Clear();
                daQuyen.Fill(dtQuyen);

                //Đua dl lên cbo trong pnl
                cboQuyen.DataSource = dtQuyen;
                cboQuyen.DisplayMember = "tenquyen";
                cboQuyen.ValueMember = "maquyen";

                //Đưa dl lên combobox trong dgv
                (dgvNhanvien.Columns["maquyen"] as DataGridViewComboBoxColumn).DataSource = dtQuyen;
                (dgvNhanvien.Columns["maquyen"] as DataGridViewComboBoxColumn).DisplayMember = "tenquyen";
                (dgvNhanvien.Columns["maquyen"] as DataGridViewComboBoxColumn).ValueMember = "maquyen";
                
                ResetFeild();
                //Cho phep tai lai/ them/ tro ve
                btnTaiLai.Enabled = true;
                btnThem.Enabled = true;
                btnTroVe.Enabled = true;

                //khong cho phep xoa/ luu/ huy
                btnXoa.Enabled = false;
                btnLuu.Enabled = false;
                btnHuy.Enabled = false;
                pnlThongtinnv.Enabled = false;
                //conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu! " + ex.Message + ex.StackTrace);
            }
            
            
                
        }

        private void ResetFeild()
        {
            txtManv.ResetText();
            txtDiachi.ResetText();
            txtSdt.ResetText();
            txtTennv.ResetText();
            radNam.Checked = true;
            radNu.Checked = false;

        }
    }
}
