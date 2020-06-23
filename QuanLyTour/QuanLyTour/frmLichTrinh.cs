using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTour
{
    public partial class frmLichTrinh : Form
    {
        bool Them;
        String sqlstr;

        SqlConnection conn = new SqlConnection("Server=dell\\sqlexpress;uid=sa;pwd=sa2008;Database=QuanLyTour");
        SqlCommand cmd = null;
        SqlDataAdapter daLichTrinh = null, daTour = null, daKhachSan = null, daDiaDanh= null, daPhuongTien = null;
        DataTable dtLichTrinh = null, dtTour = null, dtKhachSan = null, dtDiaDanh = null, dtPhuongTien = null;
        BindingList<KeyValuePair<string, string>> items_ngay = new BindingList<KeyValuePair<string, string>>();
        bool themks = false, themlt = false;

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            items_ngay = null;
            this.Close();
        }

        private void ResetFeild()
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

        private void cboTenTour_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (conn != null && conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            
            //&& cboTenTour.SelectedValue.ToString() != "System.Data.DataRowView"
            ResetText();
            ResetFeild_KhachSan();
            if (dtTour != null)
            {
                if (cboTenTour != null || cboTenTour.SelectedValue.ToString() != "" || cboTenTour.SelectedValue != null)
                {

                    items_ngay = new BindingList<KeyValuePair<string, string>>();
                    //cboNgay.Items.Clear();
                    String item_ngay = "";
                    //this.cboNgay.Items.Add(item_ngay);
                    int matour;
                    bool result = Int32.TryParse(cboTenTour.SelectedValue.ToString(), out matour);
                    if (result)
                    {
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
                                drtour.Read();
                                Double soNgay = (drtour.GetDateTime(2).Date - drtour.GetDateTime(1).Date).TotalDays + 1;

                                DateTime ngaykh = drtour.GetDateTime(1).Date;
                                DateTime ngayve = drtour.GetDateTime(2).Date;
                                MessageBox.Show(" SelectedChange Ngay kh" + drtour.GetDateTime(1).Date + " Ngày về " + drtour.GetDateTime(2).Date + " So ngay " + soNgay);
                                // Add items in the ComboBox
                                //mybox.Items.Add("C#");
                                //ComboBox cboNgayDL = new ComboBox();

                                for (int i = 1; i <= (int)soNgay; i++)
                                {
                                    item_ngay = "Ngày thứ " + i;
                                    //cboNgayDL.Items.Add(item_ngay);
                                    //this.cboNgay.Items.Add(item_ngay);
                                    DateTime ngay = ngaykh.AddDays(i - 1);
                                    String key_ngay = ngay.ToString("dd/M/yyyy", CultureInfo.InvariantCulture);


                                    items_ngay.Add(new KeyValuePair<string, string>(key_ngay, item_ngay));


                                }
                                cboNgay.DataSource = items_ngay;
                                cboNgay.ValueMember = "Key";
                                cboNgay.DisplayMember = "Value";
                                cboNgay.SelectedIndex = 0;
                                //cboNgay = cboNgayDL;
                                //cboNgay.SelectedValue = 1;

                                this.txtMaTour.Text = "" + drtour.GetDecimal(0);
                                this.txtNgayKH.Text = "" + drtour.GetDateTime(1);
                                this.txtNgayVe.Text = "" + drtour.GetDateTime(2);
                                this.txtHDV.Text = "" + drtour.GetString(5); //join lay ten
                                this.txtPhuongTien.Text = drtour.GetString(6);
                                this.txtDiemXP.Text = drtour.GetString(3);
                                this.txtDiemDen.Text = drtour.GetString(4);
                                this.txtTenTour.Text = drtour.GetString(7);

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
                    else
                        return;
                }
                else
                    return;

            }
            else
                return;
            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            //Cho phep Them / TroVe / TaiLai
            btnThem.Enabled = true;
            btnTroVe.Enabled = true;
            btnHuy.Enabled = true;

            //khong cho phep xoa / luu / huy/ 
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cboKhachSan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (conn != null && conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            if (cboKhachSan.SelectedValue.GetType() == typeof(object) || cboKhachSan.SelectedValue == null)
                return;
            else
            {

                if (cboKhachSan != null || cboKhachSan.SelectedValue.ToString() != "" || cboKhachSan.SelectedValue != null)
                {
                    int maks;
                    MessageBox.Show("cboKs " + cboKhachSan.SelectedValue);
                    bool result = Int32.TryParse(cboKhachSan.SelectedValue.ToString(), out maks);
                    if (result)
                    {
                        try
                        {
                            sqlstr = "Select * from khachsan where maks=" + cboKhachSan.SelectedValue + ";";
                            cmd = new SqlCommand(sqlstr, conn);

                            SqlDataReader drks = cmd.ExecuteReader();
                            if (drks.HasRows)
                            {
                                drks.Read();
                                txtMaKS.Text = "" + drks.GetDecimal(0);
                                txtDiaChi.Text = drks.GetString(2);
                                txtSdt.Text = drks.GetString(3);
                            }

                            drks.Close();

                        }
                        catch (SqlException)
                        {

                        }
                    }
                    else
                        return;
                }
                else
                    return;
            }
            //conn.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (conn != null && conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            if (Them = true)
            {
                //bool dathemo = false;
                DateTime oDate = DateTime.ParseExact(cboNgay.SelectedValue.ToString(), "dd/M/yyyy", null);
                //sqlstr = "Select * from o where matour= @matour and ngayo= @ngayo;";

                //cmd = new SqlCommand(sqlstr, conn);
                //cmd.Parameters.AddWithValue("@matour", cboTenTour.SelectedValue);
                //cmd.Parameters.AddWithValue("@ngayo", oDate.Date);
                //SqlDataReader dr = cmd.ExecuteReader();
                //if (dr.HasRows)
                //{
                //    dathemo = true;
                //    dr.Close();
                //}
                //else
                //{
                //    dr.Close();
                if (!themks)
                {
                    try
                    {
                        sqlstr = "Insert into o values( @matour, @maks, @ngayo);";
                        cmd = new SqlCommand(sqlstr, conn);
                        cmd.Parameters.AddWithValue("@matour", cboTenTour.SelectedValue);
                        cmd.Parameters.AddWithValue("@maks", cboKhachSan.SelectedValue);

                        cmd.Parameters.AddWithValue("@ngayo", oDate.Date);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm khách sạn thành công!");
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Lỗi thêm khách sạn!");
                    }
                }

                //}
                if (dgvLT.Rows[0].Cells["gio"].Value != null)
                {
                    

                    for (int i = 0; i < dgvLT.Rows.Count; i++)
                    {
                        try
                        {
                            sqlstr = "Insert into lichtrinh values(@matour, @ngayo, @madd, @mapt, @gio)";
                            cmd = new SqlCommand(sqlstr, conn);
                            cmd.Parameters.AddWithValue("@matour", cboTenTour.SelectedValue);
                            cmd.Parameters.AddWithValue("@ngayo", oDate.Date);
                            cmd.Parameters.AddWithValue("@madd", dgvLT.Rows[i].Cells["madd"].Value);
                            cmd.Parameters.AddWithValue("@mapt", dgvLT.Rows[i].Cells["mapt"].Value);

                            DateTime date = DateTime.ParseExact(dgvLT.Rows[i].Cells["gio"].Value.ToString(), "hh:mm", CultureInfo.CurrentCulture);

                            cmd.Parameters.AddWithValue("@gio", date);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Thêm lịch trình thành công!");
                        }
                        catch (SqlException)
                        {
                            MessageBox.Show("Lỗi thêm lịch trình!");
                        }
                    }
                }
                else
                {
                    // dgvLT.Rows[0].ReadOnly = true;
                    dgvLT.Rows[0].Cells["gio"].ReadOnly = true;
                }
            }
            conn.Close();
        }

        private void frmLichTrinh_Load(object sender, EventArgs e)
        {
            
            LoadData();
            cboKhachSan.Enabled = false;
        }

        private void frmLichTrinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            dtKhachSan.Dispose();
            dtKhachSan = null;
            dtTour.Dispose();
            dtTour = null;
            dtDiaDanh.Dispose();
            dtDiaDanh = null;
            dtPhuongTien.Dispose();
            dtPhuongTien = null;
            dtLichTrinh.Dispose();
            dtLichTrinh = null;
            //conn.Close();
            conn = null;

        }

        private void ResetFeild_KhachSan()
        {
            txtMaKS.ResetText();
            txtDiaChi.ResetText();
            txtSdt.ResetText();
           
        }

        private void cboNgay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (conn != null && conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            if (cboNgay != null || cboNgay.SelectedValue.ToString() != "" || cboNgay.SelectedValue != null)
            {
                ResetFeild_KhachSan();
                //MessageBox.Show("Value: " + cboNgay.SelectedValue.ToString() + " Index: " + cboNgay.SelectedIndex.ToString());

                txtNgay.Text = cboNgay.SelectedValue.ToString();
                //DateTime oDate = DateTime.ParseExact(cboNgay.SelectedValue.ToString(), "dd/M/yyyy", null);
                

                string data = cboNgay.SelectedValue.ToString();
                var dateFormats = "dd/M/yyyy";

                if (IsValidDate(data, dateFormats))
                {
                    try
                    {
                        DateTime oDate = DateTime.ParseExact(cboNgay.SelectedValue.ToString(), "dd/M/yyyy", null);
                        sqlstr = "Select * from o where matour= @matour and ngayo= @ngayo;";

                        cmd = new SqlCommand(sqlstr, conn);
                        cmd.Parameters.AddWithValue("@matour", cboTenTour.SelectedValue);
                        cmd.Parameters.AddWithValue("@ngayo", oDate.Date);
                        SqlDataReader dro = cmd.ExecuteReader();
                        if (dro.HasRows)
                        {
                            dro.Read();
                            cboKhachSan.SelectedValue = dro.GetDecimal(1);
                            MessageBox.Show("cboKs when select o /cbodate change: " + dro.GetDecimal(1));
                            themks = true;
                        }

                        dro.Close();

                        sqlstr = "Select * from lichtrinh where matour= @matour and ngayo= @ngayo;";

                        cmd = new SqlCommand(sqlstr, conn);
                        cmd.Parameters.AddWithValue("@matour", cboTenTour.SelectedValue);
                        cmd.Parameters.AddWithValue("@ngayo", oDate.Date);
                        SqlDataReader drlt = cmd.ExecuteReader();
                        if (drlt.HasRows)
                        {
                            themlt = true;
                        }

                        drlt.Close();


                        if (themks == false && themlt == false)
                        {
                            MessageBox.Show("Khách sạn và lịch trình trống. Vui lòng thêm khách sạn và lịch trình!");
                            cboKhachSan.SelectedIndex = 0;
                            cboKhachSan.Enabled = true;

                        }
                        else
                        {
                            if (themks == false)
                            {
                                MessageBox.Show("Khách sạn trống. Vui lòng thêm khách sạn!");
                                cboKhachSan.Enabled = true;
                            }
                            else
                            {
                                MessageBox.Show("Lịch trình trống. Vui lòng thêm lịch trình!");
                            }
                        }



                        sqlstr = "Select * from diadanh";
                        daDiaDanh = new SqlDataAdapter(sqlstr, conn);
                        dtDiaDanh = new DataTable();
                        dtDiaDanh.Clear();
                        daDiaDanh.Fill(dtDiaDanh);
                        //  Đưa dữ liệu lên ComboBox trong DataGridView   
                        (dgvLT.Columns["madd"] as DataGridViewComboBoxColumn).DataSource = dtDiaDanh;
                        (dgvLT.Columns["madd"] as DataGridViewComboBoxColumn).DisplayMember = "tendd";
                        (dgvLT.Columns["madd"] as DataGridViewComboBoxColumn).ValueMember = "madd";


                        sqlstr = "Select * from phuongtien";
                        daPhuongTien = new SqlDataAdapter(sqlstr, conn);
                        dtPhuongTien = new DataTable();
                        dtPhuongTien.Clear();
                        daPhuongTien.Fill(dtPhuongTien);

                        (dgvLT.Columns["mapt"] as DataGridViewComboBoxColumn).DataSource = dtPhuongTien;
                        (dgvLT.Columns["mapt"] as DataGridViewComboBoxColumn).DisplayMember = "tenpt";
                        (dgvLT.Columns["mapt"] as DataGridViewComboBoxColumn).ValueMember = "mapt";

                        sqlstr = "Select gio, madd, mapt from lichtrinh where matour= @matour and ngayo= @ngayo";
                        daLichTrinh = new SqlDataAdapter(sqlstr, conn);
                        daLichTrinh.SelectCommand.Parameters.AddWithValue("@matour", cboTenTour.SelectedValue);
                        daLichTrinh.SelectCommand.Parameters.AddWithValue("@ngayo", oDate.Date);
                        dtLichTrinh = new DataTable();
                        dtLichTrinh.Clear();
                        daLichTrinh.Fill(dtLichTrinh);
                        this.dgvLT.DataSource = dtLichTrinh;
                    }
                    catch (Exception ex)
                    {
                        //MessageBox.Show("Lỗi change selected " + ex.Message + ex.StackTrace);
                    }
                }
                else
                    return;



            }
            else
                return;
            //conn.Open();
        }

        public static bool IsValidDate(string value, string dateFormats)
        {
            DateTime tempDate;
            bool validDate = DateTime.TryParseExact(value, dateFormats, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None, out tempDate);
            if (validDate)
                return true;
            else
                return false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (conn != null && conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            Them = true;

            cboKhachSan.Enabled = true;
            //Không Cho thao tác trên các nút Thêm / Sửa / Xóa / Trở về
            this.btnThem.Enabled = false;
            //this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnTroVe.Enabled = false;
            //Cho thao tác trên các nút Lưu / Hủy / Grb Thông tin
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;

            sqlstr = "Select * from diadanh";
            daDiaDanh = new SqlDataAdapter(sqlstr, conn);
            dtDiaDanh = new DataTable();
            dtDiaDanh.Clear();
            daDiaDanh.Fill(dtDiaDanh);
            //  Đưa dữ liệu lên ComboBox trong DataGridView   
            (dgvLT.Columns["madd"] as DataGridViewComboBoxColumn).DataSource = dtDiaDanh;
            (dgvLT.Columns["madd"] as DataGridViewComboBoxColumn).DisplayMember = "tendd";
            (dgvLT.Columns["madd"] as DataGridViewComboBoxColumn).ValueMember = "madd";


            sqlstr = "Select * from phuongtien";
            daPhuongTien = new SqlDataAdapter(sqlstr, conn);
            dtPhuongTien = new DataTable();
            dtPhuongTien.Clear();
            daPhuongTien.Fill(dtPhuongTien);

            (dgvLT.Columns["mapt"] as DataGridViewComboBoxColumn).DataSource = dtPhuongTien;
            (dgvLT.Columns["mapt"] as DataGridViewComboBoxColumn).DisplayMember = "tenpt";
            (dgvLT.Columns["mapt"] as DataGridViewComboBoxColumn).ValueMember = "mapt";
            for (int i = 0; i < dgvLT.Rows.Count; i++)
            {
                if (dgvLT.Rows[i].Cells["gio"].Value != null)
                {
                    dgvLT.Rows[i].ReadOnly = true;
                }
            }
            conn.Close();
        }

        private void LoadData()
        {
            if (conn != null && conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            sqlstr = "Select * from tour";
            daTour = new SqlDataAdapter(sqlstr, conn);
            dtTour = new DataTable();
            dtTour.Clear();
            daTour.Fill(dtTour);
            this.cboTenTour.DataSource = dtTour;
            this.cboTenTour.DisplayMember = "tentour";
            this.cboTenTour.ValueMember = "matour";

            sqlstr = "Select * from khachsan";
            daKhachSan = new SqlDataAdapter(sqlstr, conn);
            dtKhachSan = new DataTable();
            dtKhachSan.Clear();
            daKhachSan.Fill(dtKhachSan);
            this.cboKhachSan.DataSource = dtKhachSan;
            this.cboKhachSan.DisplayMember = "tenks";
            this.cboKhachSan.ValueMember = "maks";
            String cbotentour = this.cboTenTour.Text;

            
                sqlstr = "Select * from khachsan";
                daKhachSan = new SqlDataAdapter(sqlstr, conn);
                dtKhachSan = new DataTable();
                dtKhachSan.Clear();
                daKhachSan.Fill(dtKhachSan);
                this.cboKhachSan.DataSource = dtKhachSan;
                this.cboKhachSan.DisplayMember = "tenks";
                this.cboKhachSan.ValueMember = "maks";


            ResetText();
            ResetFeild_KhachSan();

            if (cboTenTour != null || cboTenTour.SelectedValue.ToString() != "" || cboTenTour.SelectedValue != null)
                {

                    items_ngay = new BindingList<KeyValuePair<string, string>>();
                    //cboNgay.Items.Clear();
                    String item_ngay = "";
                    //this.cboNgay.Items.Add(item_ngay);
                    try
                    {
                        sqlstr = "Select matour, ngaykh, ngayve, diemxp, diemden, nhanvien.tennv, phuongtien.tenpt, tentour " +
                                        " from QuanLyTour.dbo.tour " +
                                        " join QuanLyTour.dbo.nhanvien" +
                                        " on QuanLyTour.dbo.tour.manv = QuanLyTour.dbo.nhanvien.manv" +
                                        " join QuanLyTour.dbo.phuongtien" +
                                        " on QuanLyTour.dbo.tour.mapt = QuanLyTour.dbo.phuongtien.mapt " +
                                        "WHERE matour= " + cboTenTour.SelectedValue.ToString() + ";";
                        cmd = new SqlCommand(sqlstr, conn);
                        SqlDataReader drt = cmd.ExecuteReader();
                        if (drt.HasRows)
                        {
                        drt.Read();
                            Double soNgay = (drt.GetDateTime(2).Date - drt.GetDateTime(1).Date).TotalDays + 1;

                            DateTime ngaykh = drt.GetDateTime(1).Date;
                            DateTime ngayve = drt.GetDateTime(2).Date;
                            MessageBox.Show(" SelectedChange Ngay kh" + drt.GetDateTime(1).Date + " Ngày về " + drt.GetDateTime(2).Date + " So ngay " + soNgay);
                            // Add items in the ComboBox
                            //mybox.Items.Add("C#");
                            //ComboBox cboNgayDL = new ComboBox();

                            for (int i = 1; i <= (int)soNgay; i++)
                            {
                                item_ngay = "Ngày thứ " + i;
                                //cboNgayDL.Items.Add(item_ngay);
                                //this.cboNgay.Items.Add(item_ngay);
                                DateTime ngay = ngaykh.AddDays(i - 1);
                                String key_ngay = ngay.ToString("dd/M/yyyy", CultureInfo.InvariantCulture);


                                items_ngay.Add(new KeyValuePair<string, string>(key_ngay, item_ngay));


                            }
                            cboNgay.DataSource = items_ngay;
                            cboNgay.ValueMember = "Key";
                            cboNgay.DisplayMember = "Value";
                            cboNgay.SelectedIndex = 0;
                            //cboNgay = cboNgayDL;
                            //cboNgay.SelectedValue = 1;

                            this.txtMaTour.Text = "" + drt.GetDecimal(0);
                            this.txtNgayKH.Text = "" + drt.GetDateTime(1);
                            this.txtNgayVe.Text = "" + drt.GetDateTime(2);
                            this.txtHDV.Text = "" + drt.GetString(5); //join lay ten
                            this.txtPhuongTien.Text = drt.GetString(6);
                            this.txtDiemXP.Text = drt.GetString(3);
                            this.txtDiemDen.Text = drt.GetString(4);
                            this.txtTenTour.Text = drt.GetString(7);

                        }
                        else
                        {
                        MessageBox.Show("Không có kết quả!");
                        }
                    drt.Close();
                    }
                    catch (SqlException ex)
                    {
                        //MessageBox.Show("Lỗi Selected Changed! " + ex.Message + ex.StackTrace);
                    }

                

            }

            btnXoa.Enabled = false;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;

            btnTaiLai.Enabled = true;
            btnThem.Enabled = true;
            btnTroVe.Enabled = true;
            conn.Close();
        }

        public frmLichTrinh()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnTaiLaiDL_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
