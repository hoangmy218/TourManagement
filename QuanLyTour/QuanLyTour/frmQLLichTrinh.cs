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
    public partial class frmQLLichTrinh : Form
    {

        //Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu
        bool Them, Sua, Xoa, ThemKs = false, SuaKs=false;
        //Chuỗi kết nối
        String strConnectionString = "Server=dell\\sqlexpress;uid=sa;pwd=sa2008;Database=QuanLyTour;MultipleActiveResultSets=True"; 
        //Đối tượng kết nối
        SqlConnection conn = null;

        SqlCommand cmd = null;
        //Đối tượng đưa dữ liệu vào DataTable dtLT = null;
        SqlDataAdapter daLT = null, daTour = null, daDiaDanh = null, daKhachHang = null, daPhuongTien = null, daKhachSan = null;
            
        //Đối tượng hiển thị dữ liệu lên Form
        DataTable dtLT = null, dtTour = null, dtKhachSan = null, dtPhuongTien = null, dtDiaDanh = null;
        ChiTietLichTrinh frmCTLT;
        private void btnHuy_Click(object sender, EventArgs e)
        {
            cboTenTour.SelectedIndex = 0;
            //cboKhachSan.SelectedIndex = 0;
            ResetField_TTTour();
            //ResetField_TTKhachSan();
        }
        


        private void cboTenTour_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (conn != null && conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            // Vận chuyển dữ liệu lên DataTable dtThanhPho
            daKhachSan = new SqlDataAdapter("SELECT * FROM khachsan", conn);
            dtKhachSan = new DataTable();
            dtKhachSan.Clear();
            daKhachSan.Fill(dtKhachSan);
            this.cboKhachSan.DataSource = dtKhachSan;
            this.cboKhachSan.DisplayMember = "tenks";
            this.cboKhachSan.ValueMember = "maks";

            if (cboTenTour.SelectedIndex >= 0)
            {
                if (cboTenTour.SelectedItem != null)
                {
                    
                    int matour;
                    bool result = Int32.TryParse(cboTenTour.SelectedValue.ToString(), out matour);
                    if (result)
                    {
                        //MessageBox.Show("matour: " + matour.ToString());
                        try
                        {
                            sqlstr = "Select matour, ngaykh, ngayve, diemxp, diemden, nhanvien.tennv, phuongtien.tenpt, tentour " +
                                            " from QuanLyTour.dbo.tour " +
                                            " join QuanLyTour.dbo.nhanvien" +
                                            " on QuanLyTour.dbo.tour.manv = QuanLyTour.dbo.nhanvien.manv" +
                                            " join QuanLyTour.dbo.phuongtien" +
                                            " on QuanLyTour.dbo.tour.mapt = QuanLyTour.dbo.phuongtien.mapt " +
                                            "WHERE matour= @matour ;";


                            cmd = new SqlCommand(sqlstr, conn);
                            cmd.Parameters.AddWithValue("@matour", matour);
                            SqlDataReader drtour = cmd.ExecuteReader();
                            if (drtour.HasRows)
                            {
                                while (drtour.Read())
                                {
                                    Double soNgay = (drtour.GetDateTime(2).Date - drtour.GetDateTime(1).Date).TotalDays + 1;

                                    DateTime ngaykh = drtour.GetDateTime(1).Date;
                                    DateTime ngayve = drtour.GetDateTime(2).Date;
                                    //MessageBox.Show(" SelectedChange Ngay kh" + drtour.GetDateTime(1).Date + " Ngày về " + drtour.GetDateTime(2).Date + " So ngay " + soNgay);
                                    // Add items in the ComboBox
                                    //mybox.Items.Add("C#");
                                    //ComboBox cboNgayDL = new ComboBox();

                                    cboNgay.Items.Clear();
                                    cboNgay.DisplayMember = "Text";
                                    cboNgay.ValueMember = "Value";


                                    for (int i = 1; i <= (int)soNgay; i++)
                                    {
                                        String ngaythu = "Ngày thứ " + i.ToString();
                                        //cboNgayDL.Items.Add(item_ngay);
                                        //this.cboNgay.Items.Add(item_ngay);
                                        DateTime ngay = ngaykh.AddDays(i - 1);
                                        String ngaystr = ngay.ToString("dd/M/yyyy", System.Globalization.CultureInfo.InvariantCulture);


                                        //items_ngay.Add(new KeyValuePair<string, string>(key_ngay, item_ngay));


                                        Ngay ngay_item = new Ngay();
                                        ngay_item.Value = ngaystr;
                                        ngay_item.Text = ngaystr;
                                        //cboNgay.Items.Add(ngay_item);
                                        cboNgay.Items.Add(new { Text = ngaythu, Value = ngaystr });
                                    }
                                    cboNgay.SelectedIndex = 0;
                                    //cboNgay.DataSource = items_ngay;
                                    //cboNgay.ValueMember = "Key";
                                    //cboNgay.DisplayMember = "Value";
                                    //cboNgay.SelectedIndex = 0;
                                    //cboNgay = cboNgayDL;
                                    //cboNgay.SelectedValue = 1;
                                    ResetField_TTTour();

                                    this.txtMaTour.Text = "" + drtour.GetDecimal(0);
                                    this.txtNgayKH.Text = "" + drtour.GetDateTime(1);
                                    this.txtNgayVe.Text = "" + drtour.GetDateTime(2);
                                    this.txtHDV.Text = "" + drtour.GetString(5); //join lay ten
                                    this.txtPhuongTien.Text = drtour.GetString(6);
                                    this.txtDiemXP.Text = drtour.GetString(3);
                                    this.txtDiemDen.Text = drtour.GetString(4);
                                    this.txtTenTour.Text = drtour.GetString(7);
                                    String Mess_tour = " this.txtMaTour.Text:  " + drtour.GetDecimal(0) + "\r \n"
                                         + " NgayKH.Text = " + drtour.GetDateTime(1) + "\r \n"
                                         + " NgayVe.Text = " + drtour.GetDateTime(2) + "\r \n"
                                         + " HDV.Text = " + drtour.GetString(5) + "\r \n"
                                         + " PhuongTien.Text =" + drtour.GetString(6) + "\r \n"
                                         + " DiemXP.Text =" + drtour.GetString(3) + "\r \n"
                                         + " DiemDen.Text =" + drtour.GetString(4) + "\r \n"
                                         + " TenTour.Text =" + drtour.GetString(7);

                                    //MessageBox.Show(Mess_tour);
                                }


                            }
                            else
                            {
                                MessageBox.Show("Không có kết quả!");
                            }
                            drtour.Close();
                        }
                        catch (SqlException ex)
                        {
                            //MessageBox.Show("Lỗi Selected Changed! " + ex.Message + ex.StackTrace);
                        }
                        if (cboNgay.SelectedIndex >= 0)
                        {
                            if (cboNgay.SelectedItem != null)
                            {
                                //TaiLenKhachSan();
                            }
                        }
                    }


                    

                    //  Đưa dữ liệu lên ComboBox trong DataGridView   
                    //(dgvTour.Columns["manv"] as DataGridViewComboBoxColumn).DataSource = dtNhanVien;
                    //(dgvTour.Columns["manv"] as DataGridViewComboBoxColumn).DisplayMember = "tennv";
                    //(dgvTour.Columns["manv"] as DataGridViewComboBoxColumn).ValueMember = "manv";

                   

                    
                }
            }
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();

        }


        //Đối tượng hiển thị dữ liệu lên Form
        DataTable dtKhachHang = null;

        private void cboNgay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboNgay.SelectedIndex >= 0)
            {
                if (cboNgay.SelectedItem != null)
                {

                    //MessageBox.Show("Index: " + cboNgay.SelectedIndex + "Value: " + (cboNgay.SelectedItem as dynamic).Value);
                    txtNgay.Text = "Tức ngày:  "+(cboNgay.SelectedItem as dynamic).Value;
                    TaiLenKhachSan();
                    TaiLenLichTrinh();


                }
            }
        }

        private void TaiLenKhachSan()
        {
            try
            {
                String ngay = "" + (cboNgay.SelectedItem as dynamic).Value;
                DateTime oDate = DateTime.ParseExact(ngay, "dd/M/yyyy", null);
                sqlstr = "Select * from QuanLyTour.dbo.o " +
                    "join QuanLyTour.dbo.khachsan " +
                    "on  QuanLyTour.dbo.o.maks = QuanLyTour.dbo.khachsan.maks " +
                    "where matour= @matour and ngayo= @ngayo;";

                cmd = new SqlCommand(sqlstr, conn);
                cmd.Parameters.AddWithValue("@matour", cboTenTour.SelectedValue);
                cmd.Parameters.AddWithValue("@ngayo", oDate.Date);


                SqlDataReader drks = cmd.ExecuteReader();

                if (drks.HasRows)
                {
                    while (drks.Read())
                    {
                        cboKhachSan.SelectedValue = Convert.ToDecimal(drks["maks"].ToString());
                        txtMaKS.Text = drks["maks"].ToString();
                        txtDiaChi.Text = drks["diachi"].ToString();
                        txtSdt.Text = drks["sdt"].ToString();
                        this.btnThemKS.Enabled = false;
                        this.btnSuaKS.Enabled = true;
                        // Không cho thao tác trên các nút Xóa / Lưu / Hủy / Grb Thông tin
                        this.btnLuuKS.Enabled = false;
                        this.btnHuyKS.Enabled = false;
                        //this.grbKhachSan.Enabled = false;
                        this.cboKhachSan.Enabled = false;
                    }
                }
                else
                {
                    this.btnSuaKS.Enabled = false;
                    this.btnThemKS.Enabled = true;
                    MessageBox.Show("Chưa thêm khách sạn!");
                    cboKhachSan.SelectedIndex = 0;
                    ResetField_TTKhachSan();
                }
                drks.Close();
            }
            catch (SqlException)
            {

            }
        }

        private void TaiLenLichTrinh()
        {
            try
            {
                String ngay = "" + (cboNgay.SelectedItem as dynamic).Value;
                DateTime oDate = DateTime.ParseExact(ngay, "dd/M/yyyy", null);
                sqlstr = "Select gio, madd, mapt from lichtrinh where matour= @matour and ngayo= @ngayo order by gio asc";
                SqlDataAdapter daLichTrinh = new SqlDataAdapter(sqlstr, conn);
                daLichTrinh.SelectCommand.Parameters.AddWithValue("@matour", cboTenTour.SelectedValue);
                daLichTrinh.SelectCommand.Parameters.AddWithValue("@ngayo", oDate.Date);
                DataTable dtLichTrinh = new DataTable();
                dtLichTrinh.Clear();
                daLichTrinh.Fill(dtLichTrinh);
                this.dgvLT.DataSource = dtLichTrinh;

                this.btnThem.Enabled = true;
                        this.btnSua.Enabled = true;
                        // Không cho thao tác trên các nút Xóa / Lưu / Hủy / Grb Thông tin
                        //this.btnLuu.Enabled = false;
                        //this.btnHuy.Enabled = false;
                this.btnXoa.Enabled = true;
                        //this.grbKhachSan.Enabled = false;

            }
            catch (SqlException)
            {
                this.btnSua.Enabled = false;
                this.btnThem.Enabled = true;
                this.btnXoa.Enabled = false;
                MessageBox.Show("Chưa thêm lịch trình!");
            }
        }

        private void btnLuuKS_Click(object sender, EventArgs e)
        {
            if (ThemKs)
            {
                try
                {
                    sqlstr = "Insert into o values( @matour, @maks, @ngayo);";
                    cmd = new SqlCommand(sqlstr, conn);
                    cmd.Parameters.AddWithValue("@matour", cboTenTour.SelectedValue);
                    cmd.Parameters.AddWithValue("@maks", cboKhachSan.SelectedValue);
                    String ngay = "" + (cboNgay.SelectedItem as dynamic).Value;
                    DateTime oDate = DateTime.ParseExact(ngay, "dd/M/yyyy", null);
                    cmd.Parameters.AddWithValue("@ngayo", oDate.Date);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm khách sạn thành công!");
                    TaiLenKhachSan();
                    TaiLenLichTrinh();
                    ThemKs = false;
                }
                catch (SqlException)
                {
                    MessageBox.Show("Lỗi thêm khách sạn!");
                }
               
            }
            if (SuaKs)
            {
                try
                {
                    sqlstr = "Update QuanLyTour.dbo.o set maks=@maks where matour=@matour and ngayo=@ngayo;";
                    cmd = new SqlCommand(sqlstr, conn);
                    cmd.Parameters.AddWithValue("@matour", cboTenTour.SelectedValue);
                    cmd.Parameters.AddWithValue("@maks", cboKhachSan.SelectedValue);
                    String ngay = "" + (cboNgay.SelectedItem as dynamic).Value;
                    DateTime oDate = DateTime.ParseExact(ngay, "dd/M/yyyy", null);
                    cmd.Parameters.AddWithValue("@ngayo", oDate.Date);
                    //MessageBox.Show("ngay: " + oDate.Date);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật khách sạn thành công!");
                    TaiLenKhachSan();
                    TaiLenLichTrinh();
                    SuaKs = false;
                }
                catch (SqlException)
                {
                    MessageBox.Show("Lỗi cập nhật khách sạn!");
                }
                
            }
        }

        private void btnHuyKS_Click(object sender, EventArgs e)
        {
            ThemKs = false;
            SuaKs = false;
            cboKhachSan.SelectedIndex = 0;
            ResetField_TTKhachSan();
            
        }

        private void cboKhachSan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            TaiLenLichTrinh();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (frmCTLT == null)
            {
                frmCTLT = new ChiTietLichTrinh();

            }
            frmCTLT.frmQLLT = this;
            String ngay = "" + (cboNgay.SelectedItem as dynamic).Value;
            DateTime oDate = DateTime.ParseExact(ngay, "dd/M/yyyy", null);
            String matour = "" + cboTenTour.SelectedValue;
            frmCTLT.setThemChiTietLichTrinh(matour, oDate);
            frmCTLT.setTextLabel("Thêm lịch trình");
            frmCTLT.ShowDialog();
            TaiLenLichTrinh();
            //this.Hide();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                int r = dgvLT.CurrentCell.RowIndex;
                
                if (frmCTLT == null)
                {
                    frmCTLT = new ChiTietLichTrinh();

                }
                frmCTLT.frmQLLT = this;
                frmCTLT.setTextLabel("Sửa lịch trình");
                String gio = dgvLT.Rows[r].Cells["gio"].Value.ToString();
                String ngay = "" + (cboNgay.SelectedItem as dynamic).Value;
                DateTime oDate = DateTime.ParseExact(ngay, "dd/M/yyyy", null);
                String matour = "" + cboTenTour.SelectedValue;
                frmCTLT.setSuaChiTietLichTrinh(matour, oDate, gio);
                frmCTLT.ShowDialog();
                TaiLenLichTrinh();
            }
            catch (SqlException ex)
            {
                
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
           
            Xoa = true;
            try
            {
                int r = dgvLT.CurrentCell.RowIndex;
                DialogResult xacnhan_xoa = MessageBox.Show("Bạn có chắc chắn muốn xóa lịch trình này?",
                    "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (xacnhan_xoa == DialogResult.Yes)
                {                           
                    sqlstr = "Delete from lichtrinh where matour = @matour and ngayo = @ngayo and gio = @gio";
                    cmd = new SqlCommand(sqlstr, conn);
                    String gio = dgvLT.Rows[r].Cells["gio"].Value.ToString();
                    String ngay = "" + (cboNgay.SelectedItem as dynamic).Value;
                    DateTime oDate = DateTime.ParseExact(ngay, "dd/M/yyyy", null);
                    String matour = "" + cboTenTour.SelectedValue;
                    cmd.Parameters.AddWithValue("@matour", matour);
                    cmd.Parameters.AddWithValue("@gio", gio);      
                    cmd.Parameters.AddWithValue("@ngayo", oDate.Date);
                    cmd.ExecuteNonQuery();
                    
                    TaiLenLichTrinh();
                    MessageBox.Show("Đã xóa lịch trình thành công!");

                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi! " + ex.Message + ex.StackTrace);
            }
            Xoa = false;
           
        }

        private void btnThemKS_Click(object sender, EventArgs e)
        {
            ThemKs = true;
            this.cboKhachSan.Enabled = true;
            this.btnSuaKS.Enabled = false;
            this.btnLuuKS.Enabled = true;
            this.btnThemKS.Enabled = false;
        }

        private void btnSuaKS_Click(object sender, EventArgs e)
        {
            SuaKs = true;
            this.cboKhachSan.Enabled = true;
            this.btnThemKS.Enabled = false;
            this.btnSuaKS.Enabled = false;
            this.btnLuuKS.Enabled = true;
        }

        String tenTour, sqlstr;
        int mahdv;
        Decimal updMatour, updGiatour;

        public frmQLLichTrinh()
        {
            InitializeComponent();
        }
        
        private void LoadData_Cbo()
        {
            try
            {


                ResetField_TTKhachSan();
                //Vận chuyển dữ liệu lên DataTable dtHoaDon
                daTour = new SqlDataAdapter("SELECT * FROM Tour", conn);
                dtTour = new DataTable();
                dtTour.Clear();
                daTour.Fill(dtTour);
                this.cboTenTour.DataSource = dtTour;
                this.cboTenTour.DisplayMember = "tentour";
                this.cboTenTour.ValueMember = "matour";

                // Vận chuyển dữ liệu lên DataTable dtThanhPho
                daKhachSan = new SqlDataAdapter("SELECT * FROM khachsan", conn);
                dtKhachSan = new DataTable();
                dtKhachSan.Clear();
                daKhachSan.Fill(dtKhachSan);
                this.cboKhachSan.DataSource = dtKhachSan;
                this.cboKhachSan.DisplayMember = "tenks";
                this.cboKhachSan.ValueMember = "maks";

                cboTenTour.SelectedIndex = 0;

                int matour;
                bool result = Int32.TryParse(cboTenTour.SelectedValue.ToString(), out matour);
                if (result)
                {
                   // MessageBox.Show("matour: " + matour.ToString());
                    try
                    {
                        sqlstr = "Select matour, ngaykh, ngayve, diemxp, diemden, nhanvien.tennv, phuongtien.tenpt, tentour " +
                                        " from QuanLyTour.dbo.tour " +
                                        " join QuanLyTour.dbo.nhanvien" +
                                        " on QuanLyTour.dbo.tour.manv = QuanLyTour.dbo.nhanvien.manv" +
                                        " join QuanLyTour.dbo.phuongtien" +
                                        " on QuanLyTour.dbo.tour.mapt = QuanLyTour.dbo.phuongtien.mapt " +
                                        "WHERE matour= @matour ;";

                        cmd = new SqlCommand(sqlstr, conn);
                        cmd.Parameters.AddWithValue("@matour", matour);
                        SqlDataReader drtour = cmd.ExecuteReader();
                        if (drtour.HasRows)
                        {
                            while (drtour.Read())
                            {
                                Double soNgay = (drtour.GetDateTime(2).Date - drtour.GetDateTime(1).Date).TotalDays + 1;

                                DateTime ngaykh = drtour.GetDateTime(1).Date;
                                DateTime ngayve = drtour.GetDateTime(2).Date;
                                //MessageBox.Show(" SelectedChange Ngay kh" + drtour.GetDateTime(1).Date + " Ngày về " + drtour.GetDateTime(2).Date + " So ngay " + soNgay);
                                // Add items in the ComboBox
                                //mybox.Items.Add("C#");
                                //ComboBox cboNgayDL = new ComboBox();
                               
                                cboNgay.Items.Clear();
                                cboNgay.DisplayMember = "Text";
                                cboNgay.ValueMember = "Value";

                                
                                for (int i = 1; i <= (int)soNgay; i++)
                                {
                                    String ngaythu = "Ngày thứ " + i.ToString();
                                    //cboNgayDL.Items.Add(item_ngay);
                                    //this.cboNgay.Items.Add(item_ngay);
                                    DateTime ngay = ngaykh.AddDays(i - 1);
                                    String ngaystr = ngay.ToString("dd/M/yyyy", System.Globalization.CultureInfo.InvariantCulture);


                                    //items_ngay.Add(new KeyValuePair<string, string>(key_ngay, item_ngay));


                                    Ngay ngay_item = new Ngay();
                                    ngay_item.Value = ngaystr;
                                    ngay_item.Text = ngaystr;
                                    //cboNgay.Items.Add(ngay_item);
                                    cboNgay.Items.Add(new { Text = ngaythu, Value = ngaystr });
                                }
                                cboNgay.SelectedIndex = 0;
                                //cboNgay.DataSource = items_ngay;
                                //cboNgay.ValueMember = "Key";
                                //cboNgay.DisplayMember = "Value";
                                //cboNgay.SelectedIndex = 0;
                                //cboNgay = cboNgayDL;
                                //cboNgay.SelectedValue = 1;
                                ResetField_TTTour();

                                this.txtMaTour.Text = "" + drtour.GetDecimal(0);
                                this.txtNgayKH.Text = "" + drtour.GetDateTime(1);
                                this.txtNgayVe.Text = "" + drtour.GetDateTime(2);
                                this.txtHDV.Text = "" + drtour.GetString(5); //join lay ten
                                this.txtPhuongTien.Text = drtour.GetString(6);
                                this.txtDiemXP.Text = drtour.GetString(3);
                                this.txtDiemDen.Text = drtour.GetString(4);
                                this.txtTenTour.Text = drtour.GetString(7);
                                String Mess_tour = " this.txtMaTour.Text:  " + drtour.GetDecimal(0) + "\r \n"
                                 + " NgayKH.Text = " + drtour.GetDateTime(1) + "\r \n"
                                 + " NgayVe.Text = " + drtour.GetDateTime(2) + "\r \n"
                                 + " HDV.Text = " + drtour.GetString(5) + "\r \n"
                                 + " PhuongTien.Text =" + drtour.GetString(6) + "\r \n"
                                 + " DiemXP.Text =" + drtour.GetString(3) + "\r \n"
                                 + " DiemDen.Text =" + drtour.GetString(4) + "\r \n"
                                 + " TenTour.Text =" + drtour.GetString(7);

                                //MessageBox.Show(Mess_tour);
                            }
                           

                        }
                        else
                        {
                            MessageBox.Show("Không có kết quả!");
                        }
                        drtour.Close();
                    }
                    catch (SqlException ex)
                    {
                        //MessageBox.Show("Lỗi Selected Changed! " + ex.Message + ex.StackTrace);
                    }
                }


               

                //  Đưa dữ liệu lên ComboBox trong DataGridView   
                //(dgvTour.Columns["manv"] as DataGridViewComboBoxColumn).DataSource = dtNhanVien;
                //(dgvTour.Columns["manv"] as DataGridViewComboBoxColumn).DisplayMember = "tennv";
                //(dgvTour.Columns["manv"] as DataGridViewComboBoxColumn).ValueMember = "manv";

                
               
                
                
               // conn.Close();

            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi! Không lấy được nội dung trong bảng csdl Tour.");
            }
        }

        private void ResetField_TTTour()
        {
            txtMaTour.ResetText();
            txtNgayKH.ResetText();
            txtNgayVe.ResetText();
            txtHDV.ResetText();
            txtPhuongTien.ResetText();
            txtDiemXP.ResetText();
            txtDiemDen.ResetText();
            txtTenTour.ResetText();
        }

        private  void ResetField_TTKhachSan()
        {
            txtMaKS.ResetText();
            txtDiaChi.ResetText();
            txtSdt.ResetText();
        }


        private void LoadData_cboDataGridView()
        {
            try
            {
                //Khởi động kết nối
                //conn = new SqlConnection(strConnectionString);
                //conn.Open();
                //Vận chuyển dữ liệu lên DataTable dtHoaDon
                daLT = new SqlDataAdapter("SELECT * FROM tour", conn);
                dtLT = new DataTable();
                dtLT.Clear();
                daLT.Fill(dtLT);
                //Đưa dữ liệu lên DataGridView
                //this.dgvLT.DataSource = dtLT;

                sqlstr = "Select * from diadanh";
                daDiaDanh = new SqlDataAdapter(sqlstr, conn);
                dtDiaDanh = new DataTable();
                dtDiaDanh.Clear();
                daDiaDanh.Fill(dtDiaDanh);
                //  Đưa dữ liệu lên ComboBox trong DataGridView   
                (dgvLT.Columns["madd"] as DataGridViewComboBoxColumn).DataSource = dtDiaDanh;
                (dgvLT.Columns["madd"] as DataGridViewComboBoxColumn).DisplayMember = "tendd";
                (dgvLT.Columns["madd"] as DataGridViewComboBoxColumn).ValueMember = "madd";

                // Vận chuyển dữ liệu lên DataTable dtThanhPho
                daPhuongTien = new SqlDataAdapter("SELECT * FROM phuongtien", conn);
                dtPhuongTien = new DataTable();
                dtPhuongTien.Clear();
                daPhuongTien.Fill(dtPhuongTien);



                //  Đưa dữ liệu lên ComboBox trong DataGridView   
                (dgvLT.Columns["mapt"] as DataGridViewComboBoxColumn).DataSource = dtPhuongTien;
                (dgvLT.Columns["mapt"] as DataGridViewComboBoxColumn).DisplayMember = "tenpt";
                (dgvLT.Columns["mapt"] as DataGridViewComboBoxColumn).ValueMember = "mapt";


               

               
                //Cho thao tác trên các nút Thêm / Sửa / Xóa / Trở về
                this.btnThem.Enabled = true;
                //this.btnSua.Enabled = true;
                this.btnTroVe.Enabled = true;
                //Không cho thao tác trên các nút Xóa/ Lưu / Hủy / Grb Thông tin
                this.btnXoa.Enabled = false;
                //this.btnLuu.Enabled = false;
                //this.btnHuy.Enabled = false;
               
                //conn.Close();

            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi! Không lấy được nội dung trong bảng csdl Tour.");
            }
        }

        private void frmQLLichTrinh_Load(object sender, EventArgs e)
        {
            //Khởi động kết nối
            conn = new SqlConnection(strConnectionString);
            conn.Open();
            LoadData_Cbo();
            LoadData_cboDataGridView();
        }
        [Serializable]

        class Tour
        {
            public Decimal matour { set; get; }
            public string tentour { get; set; }

        }
        class Ngay
        {
            public object Value { set; get; }
            public string Text { set; get; }
            public override string ToString()
            {
                return Text;
            }

        }
    }
}
