using System;
using System.CodeDom;
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
    public partial class frmTour : Form
    {
        //Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu
        bool Them, Sua, Xoa;
        //Chuỗi kết nối
        String strConnectionString = "Server=dell\\sqlexpress;uid=sa;pwd=sa2008;Database=QuanLyTour";
        //Đối tượng kết nối
        SqlConnection conn = null;

        SqlCommand cmd = null;
        //Đối tượng đưa dữ liệu vào DataTable dtTour = null;
        SqlDataAdapter daTour = null;
        //Đối tượng hiển thị dữ liệu lên Form
        DataTable dtTour = null;
        DataTable dtNhanVien = null, dtPhuongTien = null;

        //Đối tượng đưa dữ liệu vào DataTable dtKhachHang = null;
        SqlDataAdapter daKhachHang = null, daPhuongTien = null;
        SqlDataAdapter daNhanVien = null;
        //Đối tượng hiển thị dữ liệu lên Form
        DataTable dtKhachHang = null;
        String tenTour, sqlstr;
        int  mahdv;
        Decimal updMatour, updGiatour;
        

        

        public frmTour()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            try
            {
                //Khởi động kết nối
                conn = new SqlConnection(strConnectionString);
                conn.Open();
                //Vận chuyển dữ liệu lên DataTable dtHoaDon
                daTour = new SqlDataAdapter("SELECT * FROM Tour", conn);
                dtTour = new DataTable();
                dtTour.Clear();
                daTour.Fill(dtTour);
                //Đưa dữ liệu lên DataGridView
                this.dgvTour.DataSource = dtTour;

                // Vận chuyển dữ liệu lên DataTable dtThanhPho
                daNhanVien = new SqlDataAdapter("SELECT * FROM NhanVien where maquyen=3", conn);
                dtNhanVien = new DataTable();
                dtNhanVien.Clear();
                daNhanVien.Fill(dtNhanVien);

                //  Đưa dữ liệu lên ComboBox trong DataGridView   
                (dgvTour.Columns["manv"] as DataGridViewComboBoxColumn).DataSource = dtNhanVien;
                (dgvTour.Columns["manv"] as DataGridViewComboBoxColumn).DisplayMember = "tennv";
                (dgvTour.Columns["manv"] as DataGridViewComboBoxColumn).ValueMember = "manv";

                // Vận chuyển dữ liệu lên DataTable dtThanhPho
                daPhuongTien = new SqlDataAdapter("SELECT * FROM phuongtien", conn);
                dtPhuongTien = new DataTable();
                dtPhuongTien.Clear();
                daPhuongTien.Fill(dtPhuongTien);



                //  Đưa dữ liệu lên ComboBox trong DataGridView   
                (dgvTour.Columns["mapt"] as DataGridViewComboBoxColumn).DataSource = dtPhuongTien;
                (dgvTour.Columns["mapt"] as DataGridViewComboBoxColumn).DisplayMember = "tenpt";
                (dgvTour.Columns["mapt"] as DataGridViewComboBoxColumn).ValueMember = "mapt";


                //Đưa dữ liệu lên ComboBox
                this.cbHDV.DataSource = dtNhanVien;
                this.cbHDV.DisplayMember = "tennv";
                this.cbHDV.ValueMember = "manv";

                //Đưa dữ liệu lên ComboBox
                this.cboPhuongTien.DataSource = dtPhuongTien;
                this.cboPhuongTien.DisplayMember = "tenpt";
                this.cboPhuongTien.ValueMember = "mapt";

                ResetField();
                //Cho thao tác trên các nút Thêm / Sửa / Xóa / Trở về
                this.btnThem.Enabled = true;
                //this.btnSua.Enabled = true;
                this.btnTroVe.Enabled = true;
                //Không cho thao tác trên các nút Xóa/ Lưu / Hủy / Grb Thông tin
                this.btnXoa.Enabled = false;
                this.btnLuu.Enabled = false;
                this.btnHuy.Enabled = false;
                this.grBThongTin.Enabled = false;
                conn.Close();
              
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi! Không lấy được nội dung trong bảng csdl Tour.");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetField();
            //Cho thao tác trên các nút Thêm / Sửa / Trở về
            this.btnThem.Enabled = true;
            //this.btnSua.Enabled = true;
            this.btnTroVe.Enabled = true;
            //Không cho thao tác trên các nút Xoa/ Lưu / Hủy / Grb Thông tin
            this.btnXoa.Enabled = false;
            this.btnLuu.Enabled = false;
            this.btnHuy.Enabled = false;
            this.grBThongTin.Enabled = false;
        }

        private void ResetField()
        {
            //Xóa trống các đối tượng trong grb
            this.nudMaTour.Value = 0;
            this.txtTenTour.ResetText();
            this.dtpNgayBD.ResetText();
            this.dtpNgayKT.ResetText();
            this.txtDiemden.ResetText();
            this.txtDiemxp.ResetText();
            this.nudGiaTE.Value = 100000;
            this.nudGiaNL.Value = 100000;
            updMatour = 0;
            updGiatour = 100000;
        }

       

        private void frmTour_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void frmTour_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Giải phóng tài nguyên
            dtTour.Dispose();
            dtTour = null;
            dtNhanVien.Dispose();
            dtNhanVien = null;

            //hủy kết nối
            //conn.Close();
            conn = null;
        }

        private void btnTaiLaiDL_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Them = true;
            conn.Open();
            ResetField();
            int matour_moi;
            try
            {
                sqlstr = "Select max(matour) from tour";
                cmd = new SqlCommand(sqlstr, conn);
                matour_moi = Convert.ToInt32(cmd.ExecuteScalar()); 

                
            }
            catch (SqlException ex)
            {
                matour_moi = 0;
                MessageBox.Show("Lỗi! " + ex.StackTrace);
            }
            matour_moi++;
            nudMaTour.Value = matour_moi;

            //Đưa dữ liệu lên ComboBox
            this.cbHDV.DataSource = dtNhanVien;
            this.cbHDV.DisplayMember = "tennv";
            this.cbHDV.ValueMember = "manv";

            //Đưa dữ liệu lên ComboBox
            this.cboPhuongTien.DataSource = dtPhuongTien;
            this.cboPhuongTien.DisplayMember = "tenpt";
            this.cboPhuongTien.ValueMember = "mapt";

            //Không Cho thao tác trên các nút Thêm / Sửa / Xóa / Trở về
            this.btnThem.Enabled = false;
            //this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnTroVe.Enabled = false;
            //Cho thao tác trên các nút Lưu / Hủy / Grb Thông tin
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.grBThongTin.Enabled = true;
            conn.Close();

            
        }

        private void dgvTour_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbHDV_SelectedIndexChanged(object sender, EventArgs e)
        {
  
        }

       

        private void nudGia_ValueChanged(object sender, EventArgs e)
        {
            updGiatour = nudGiaNL.Value;
            if (nudGiaNL.Value != 0 )
                nudGiaTE.Value = nudGiaNL.Value / 2;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (Them == true)
            {
                
                try 
                {

                    /*sqlstr = "Insert into Tour values("
                        + nudMaTour.Value.ToString() + ", '"
                        + txtTenTour.Text.ToString() + "',"
                        + dtpNgayBD.Value.Date + ", "
                        + dtpNgayBD.Value.Date + ", "
                        + nudGia.Value.ToString() + ", "
                        + cbHDV.SelectedValue.ToString() + ");";*/
                    sqlstr = "Insert into Tour values( @matour, @tentour, @ngaykh, @ngayve, @manv, @diemxp, @diemden, @mapt);";
                    cmd = new SqlCommand(sqlstr, conn);
                    cmd.Parameters.AddWithValue("@matour", nudMaTour.Value);
                    cmd.Parameters.AddWithValue("@tentour", txtTenTour.Text);
                    cmd.Parameters.AddWithValue("@ngaykh", dtpNgayBD.Value);
                    cmd.Parameters.AddWithValue("@ngayve", dtpNgayKT.Value);
                   
                    //cmd.Parameters.AddWithValue("@gia", nudGiaNL.Value);
                    cmd.Parameters.AddWithValue("@manv", cbHDV.SelectedValue);
                    cmd.Parameters.AddWithValue("@diemxp", txtDiemxp.Text);
                    cmd.Parameters.AddWithValue("@diemden", txtDiemden.Text);
                    cmd.Parameters.AddWithValue("@mapt", cboPhuongTien.SelectedValue);
                    //MessageBox.Show(sqlstr);
                    cmd.ExecuteNonQuery();


                    sqlstr = "Insert into giave values( @malv, @matour, @gia);";
                    cmd = new SqlCommand(sqlstr, conn);
                    cmd.Parameters.AddWithValue("@matour", nudMaTour.Value);
                    cmd.Parameters.AddWithValue("@malv", '1');
                    cmd.Parameters.AddWithValue("@gia", nudGiaNL.Value);
                    cmd.ExecuteNonQuery();

                    sqlstr = "Insert into giave values( @malv, @matour, @gia);";
                    cmd = new SqlCommand(sqlstr, conn);
                    cmd.Parameters.AddWithValue("@matour", nudMaTour.Value);
                    cmd.Parameters.AddWithValue("@malv", '2');
                    cmd.Parameters.AddWithValue("@gia", nudGiaTE.Value);
                    cmd.ExecuteNonQuery();

                    LoadData();
                    ResetField();
                    MessageBox.Show("Thêm tour thành công!");
                    
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
                    sqlstr = "Update tour set tentour= @tentour, ngaykh= @ngaykh, ngayve= @ngayve, manv= @manv, diemxp= @diemxp, diemden= @diemden, mapt= @mapt where matour= @matour";
                    cmd = new SqlCommand(sqlstr, conn);
                    cmd.Parameters.AddWithValue("@matour", nudMaTour.Value);
                    cmd.Parameters.AddWithValue("@tentour", txtTenTour.Text);
                    cmd.Parameters.AddWithValue("@ngaykh", dtpNgayBD.Value);
                    cmd.Parameters.AddWithValue("@ngayve", dtpNgayKT.Value);

                    //cmd.Parameters.AddWithValue("@gia", nudGiaNL.Value);
                    cmd.Parameters.AddWithValue("@manv", cbHDV.SelectedValue);
                    cmd.Parameters.AddWithValue("@diemxp", txtDiemxp.Text);
                    cmd.Parameters.AddWithValue("@diemden", txtDiemden.Text);
                    cmd.Parameters.AddWithValue("@mapt", cboPhuongTien.SelectedValue);
                    cmd.ExecuteNonQuery();

                    sqlstr = "Update giave set gia= @gia where matour= @matour and malv= @malv ;";
                    cmd = new SqlCommand(sqlstr, conn);
                    cmd.Parameters.AddWithValue("@matour", nudMaTour.Value);
                    cmd.Parameters.AddWithValue("@malv", '1');
                    cmd.Parameters.AddWithValue("@gia", nudGiaNL.Value);
                    cmd.ExecuteNonQuery();

                    sqlstr = "Update giave set gia= @gia where matour= @matour and malv= @malv ;";
                    cmd = new SqlCommand(sqlstr, conn);
                    cmd.Parameters.AddWithValue("@matour", nudMaTour.Value);
                    cmd.Parameters.AddWithValue("@malv", '2');
                    cmd.Parameters.AddWithValue("@gia", nudGiaTE.Value);
                    cmd.ExecuteNonQuery();

                    LoadData();
                    ResetField();
                    MessageBox.Show("Đã cập nhật tour thành công!");
                    
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Lỗi! " + ex.Message + ex.StackTrace);
                }


            }
            conn.Close();
        }

        private void dgvTour_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            this.grBThongTin.Enabled = true;
            ResetField();
            //Không Cho thao tác trên các nút Thêm / Sửa / Trở về
            this.btnThem.Enabled = false;
            //this.btnSua.Enabled = false;

            this.btnTroVe.Enabled = false;
            //Cho thao tác trên các nút Xóa/ Lưu / Hủy / Grb Thông tin
            this.btnXoa.Enabled = true;
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;


            //Đưa dữ liệu lên ComboBox
            this.cbHDV.DataSource = dtNhanVien;
            this.cbHDV.DisplayMember = "tennv";
            this.cbHDV.ValueMember = "manv";
            //MessageBox.Show("CIndex: " + e.ColumnIndex);
            /*if (e.ColumnIndex >= 0)
            {

                //MessageBox.Show("Cell: " + dgvTour.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                if (dgvTour.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvTour.CurrentRow.Selected = true;  
                    nudMaTour.Value = Convert.ToInt32(dgvTour.Rows[e.RowIndex].Cells["matour"].Value.ToString());
                    txtTenTour.Text = dgvTour.Rows[e.RowIndex].Cells["tentour"].FormattedValue.ToString();
                    dtpNgayBD.Value = Convert.ToDateTime(dgvTour.Rows[e.RowIndex].Cells["ngaybd"].FormattedValue.ToString());
                    dtpNgayKT.Value = Convert.ToDateTime(dgvTour.Rows[e.RowIndex].Cells["ngaykt"].FormattedValue.ToString());
                    nudGia.Value = Convert.ToInt32(dgvTour.Rows[e.RowIndex].Cells["gia"].FormattedValue.ToString());
                    
                }
                
            } 
            else
            {*/
            //Chon Cell/Row
            dgvTour.CurrentCell.Selected = true;
            dgvTour.CurrentRow.Selected = true;
            foreach (DataGridViewRow row in dgvTour.SelectedRows)
            {
                if (row.Cells["matour1"].Value.ToString() != "")
                {
                    nudMaTour.Value = Convert.ToInt32(row.Cells["matour1"].Value.ToString());
                    txtTenTour.Text = row.Cells["tentour1"].Value.ToString();
                    dtpNgayBD.Value = Convert.ToDateTime(row.Cells["ngaykh"].Value.ToString());
                    dtpNgayKT.Value = Convert.ToDateTime(row.Cells["ngayve"].Value.ToString());
                    txtDiemden.Text = row.Cells["diemden"].Value.ToString();
                    txtDiemxp.Text = row.Cells["diemxp"].Value.ToString();
                    cbHDV.SelectedValue = Convert.ToInt32(row.Cells["manv"].Value.ToString());
                    cboPhuongTien.SelectedValue = Convert.ToInt32(row.Cells["mapt"].Value.ToString());
                    conn.Open();
                    try
                    {

                        sqlstr = "Select * from giave where matour=" + row.Cells["matour1"].Value.ToString() + ";";
                        cmd = new SqlCommand(sqlstr, conn);
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                if (dr.GetDecimal(0) == 1)
                                {
                                    nudGiaNL.Value = dr.GetDecimal(2);
                                }
                                else
                                {
                                    nudGiaTE.Value = dr.GetDecimal(2);
                                }
                            }
                        }
                        dr.Close();

                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Lỗi! " + ex.Message + ex.StackTrace);
                    }
                    conn.Close();
                }
                

            }

            nudMaTour.Enabled = false;
        }

        private void dtpNgayBD_ValueChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(dtpNgayBD.Value.Date.ToString());

        }

        private void dtpNgayKT_ValueChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(dtpNgayKT.Value.ToString());
        }

        private void nudGiaTE_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dgvTour_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            conn.Open();
            Xoa = true;
            try
            {
                DialogResult xacnhan_xoa = MessageBox.Show("Bạn có chắc chắn muốn xóa tour này?",
                    "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (xacnhan_xoa == DialogResult.Yes)
                {
                    int r = dgvTour.CurrentCell.RowIndex;
                    String matour_xoa = dgvTour.Rows[r].Cells["matour1"].Value.ToString();
                    sqlstr = "Delete from Tour where matour=" + matour_xoa;
                    cmd = new SqlCommand(sqlstr, conn);
                    cmd.ExecuteNonQuery();
                    sqlstr = "Delete from giave where matour=" + matour_xoa;
                    LoadData();
                    ResetField();
                    MessageBox.Show("Đã xóa tour thành công!");
                    
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi! " + ex.Message + ex.StackTrace);
            }
            Xoa = false;
            conn.Close();
        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void dgvTour_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.grBThongTin.Enabled = true;
            ResetField();
            //Không Cho thao tác trên các nút Thêm / Sửa / Trở về
            this.btnThem.Enabled = false;
            //this.btnSua.Enabled = false;
                
            this.btnTroVe.Enabled = false;
            //Cho thao tác trên các nút Xóa/ Lưu / Hủy / Grb Thông tin
            this.btnXoa.Enabled = true;
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            

            //Đưa dữ liệu lên ComboBox
            this.cbHDV.DataSource = dtNhanVien;
            this.cbHDV.DisplayMember = "tennv";
            this.cbHDV.ValueMember = "manv";
            //MessageBox.Show("CIndex: " + e.ColumnIndex);
            /*if (e.ColumnIndex >= 0)
            {

                //MessageBox.Show("Cell: " + dgvTour.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                if (dgvTour.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvTour.CurrentRow.Selected = true;  
                    nudMaTour.Value = Convert.ToInt32(dgvTour.Rows[e.RowIndex].Cells["matour"].Value.ToString());
                    txtTenTour.Text = dgvTour.Rows[e.RowIndex].Cells["tentour"].FormattedValue.ToString();
                    dtpNgayBD.Value = Convert.ToDateTime(dgvTour.Rows[e.RowIndex].Cells["ngaybd"].FormattedValue.ToString());
                    dtpNgayKT.Value = Convert.ToDateTime(dgvTour.Rows[e.RowIndex].Cells["ngaykt"].FormattedValue.ToString());
                    nudGia.Value = Convert.ToInt32(dgvTour.Rows[e.RowIndex].Cells["gia"].FormattedValue.ToString());
                    
                }
                
            } 
            else
            {*/
            //Chon Cell/Row
            dgvTour.CurrentCell.Selected = true;
            dgvTour.CurrentRow.Selected = true;
            foreach (DataGridViewRow row in dgvTour.SelectedRows)
            {
                nudMaTour.Value = Convert.ToInt32(row.Cells["matour"].Value.ToString());
                    txtTenTour.Text = row.Cells["tentour"].Value.ToString();
                    dtpNgayBD.Value = Convert.ToDateTime(row.Cells["ngaykh"].Value.ToString());
                    dtpNgayKT.Value = Convert.ToDateTime(row.Cells["ngayve"].Value.ToString());             
                    txtDiemden.Text = row.Cells["diemden"].Value.ToString();
                    txtDiemxp.Text = row.Cells["diemxp"].Value.ToString();
                    cbHDV.SelectedValue = Convert.ToInt32(row.Cells["manv"].Value.ToString());
                    cboPhuongTien.SelectedValue = Convert.ToInt32(row.Cells["mapt"].Value.ToString());
                try
                {
                    sqlstr = "Select * from giave where matour=" + row.Cells["matour"].Value.ToString() + ";";
                    cmd = new SqlCommand(sqlstr, conn);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        dr.Read();
                        if (dr.GetDecimal(1) == 1)
                        {
                            nudGiaNL.Value = dr.GetDecimal(3);
                        }
                        else
                        {
                            nudGiaTE.Value = dr.GetDecimal(3);
                        }
                    }
                    dr.Close();

                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Lỗi! " + ex.Message + ex.StackTrace);
                }

            }
            
            nudMaTour.Enabled = false;

        }

        private void dgvTour_SelectionChanged(object sender, EventArgs e)
        {
            //ResetField();
            ////Không Cho thao tác trên các nút Thêm / Sửa / Trở về
            //this.btnThem.Enabled = false;
            ////this.btnSua.Enabled = false;

            //this.btnTroVe.Enabled = false;
            ////Cho thao tác trên các nút Xóa/ Lưu / Hủy / Grb Thông tin
            //this.btnXoa.Enabled = false;
            //this.btnLuu.Enabled = true;
            //this.btnHuy.Enabled = true;
            //this.grBThongTin.Enabled = true;

            ////Đưa dữ liệu lên ComboBox
            //this.cbHDV.DataSource = dtNhanVien;
            //this.cbHDV.DisplayMember = "tennv";
            //this.cbHDV.ValueMember = "manv";

            //foreach (DataGridViewRow row in dgvTour.SelectedRows)
            //{
            //    nudMaTour.Value = Convert.ToInt32(row.Cells[0].Value.ToString());
            //    txtTenTour.Text = row.Cells[1].Value.ToString();
            //    dtpNgayBD.Value = Convert.ToDateTime(row.Cells[2].Value.ToString());
            //    dtpNgayKT.Value = Convert.ToDateTime(row.Cells[3].Value.ToString());
            //    nudGiaNL.Value = Convert.ToInt32(row.Cells[4].Value.ToString());
            //    cbHDV.SelectedValue = Convert.ToInt32(row.Cells[5].Value.ToString());
            //}
            //nudMaTour.Enabled = false;
        }

        private void nudMaTour_ValueChanged(object sender, EventArgs e)
        {
            updMatour = nudMaTour.Value;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }
    }
}
