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

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            items_ngay = null;
            this.Close();
        }

        private void ResetFeild()
        {
            

        }

        private void cboTenTour_SelectedIndexChanged(object sender, EventArgs e)
        {
            //&& cboTenTour.SelectedValue.ToString() != "System.Data.DataRowView"
            if (dtTour != null)
            {
                if (cboTenTour != null || cboTenTour.SelectedValue.ToString() != "" || cboTenTour.SelectedValue != null)
                {

                    items_ngay = new BindingList<KeyValuePair<string, string>>();
                    //cboNgay.Items.Clear();
                    String item_ngay = "";
                    //this.cboNgay.Items.Add(item_ngay);
                    try
                    {
                        sqlstr = "Select * from tour where matour=" + cboTenTour.SelectedValue + ";";
                        cmd = new SqlCommand(sqlstr, conn);
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.HasRows)
                        {
                            dr.Read();
                            Double soNgay = (dr.GetDateTime(3).Date - dr.GetDateTime(2).Date).TotalDays + 1;

                            DateTime ngaykh = dr.GetDateTime(2).Date;
                            DateTime ngayve = dr.GetDateTime(3).Date;
                            MessageBox.Show(" SelectedChange Ngay kh" + dr.GetDateTime(2).Date + " Ngày về " + dr.GetDateTime(3).Date + " So ngay " + soNgay);
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

                        }
                        dr.Close();
                    }
                    catch (SqlException ex)
                    {
                        //MessageBox.Show("Lỗi Selected Changed! " + ex.Message + ex.StackTrace);
                    }
                   
                }
                
            }
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

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Them = true)
            {
                bool dathemo = false;
                DateTime oDate = DateTime.ParseExact(cboNgay.SelectedValue.ToString(), "dd/M/yyyy", null);
                sqlstr = "Select * from o where matour= @matour and ngayo= @ngayo;";

                cmd = new SqlCommand(sqlstr, conn);
                cmd.Parameters.AddWithValue("@matour", cboTenTour.SelectedValue);
                cmd.Parameters.AddWithValue("@ngayo", oDate.Date);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dathemo = true;
                    dr.Close();
                }
                else
                {
                    dr.Close();
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
                    catch(SqlException)
                    {
                        MessageBox.Show("Lỗi thêm khách sạn!");
                    }

                }
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
        }

        private void frmLichTrinh_Load(object sender, EventArgs e)
        {
            conn.Open();
            LoadData();
            cboKhachSan.Enabled = false;
        }

        private void frmLichTrinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            dtKhachSan.Dispose();
            dtKhachSan = null;
            dtTour.Dispose();
            dtTour = null;
            conn.Close();
            conn = null;

        }

        private void cboNgay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboNgay != null || cboNgay.SelectedValue.ToString() != "" || cboNgay.SelectedValue != null)
            {
                MessageBox.Show("Value: " + cboNgay.SelectedValue.ToString() + " Index: " + cboNgay.SelectedIndex.ToString());
                try
                {
                    DateTime oDate = DateTime.ParseExact(cboNgay.SelectedValue.ToString(), "dd/M/yyyy", null);
                    sqlstr = "Select * from o where matour= @matour and ngayo= @ngayo;";

                    cmd = new SqlCommand(sqlstr, conn);
                    cmd.Parameters.AddWithValue("@matour", cboTenTour.SelectedValue);
                    cmd.Parameters.AddWithValue("@ngayo", oDate.Date);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        dr.Read();
                        cboKhachSan.SelectedValue = dr.GetDecimal(1);
                        
                    }
                    dr.Close();

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
                catch (Exception ex) {
                    MessageBox.Show("Lỗi change selected " + ex.Message + ex.StackTrace);
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
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
        }

        private void LoadData()
        {
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
            

            if (cboTenTour != null || cboTenTour.SelectedValue.ToString() != "" || cboTenTour.SelectedValue != null)
            {
                try
                {
                    items_ngay = new BindingList<KeyValuePair<string, string>>();
                    //cboNgay.Items.Clear();
                    String item_ngay = "";
                    sqlstr = "Select * from tour where matour=" + cboTenTour.SelectedValue + ";";
                    cmd = new SqlCommand(sqlstr, conn);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        dr.Read();
                        Double soNgay = (dr.GetDateTime(3).Date - dr.GetDateTime(2).Date).TotalDays + 1;

                        DateTime ngaykh = dr.GetDateTime(2).Date;
                        DateTime ngayve = dr.GetDateTime(3).Date;
                        MessageBox.Show(" SelectedChange Ngay kh" + dr.GetDateTime(2).Date + " Ngày về " + dr.GetDateTime(3).Date + " So ngay " + soNgay);
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


                    }
                    dr.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Lỗi Load Data! " + ex.Message + ex.StackTrace);
                }
            }




            btnXoa.Enabled = false;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;

            btnTaiLai.Enabled = true;
            btnThem.Enabled = true;
            btnTroVe.Enabled = true;

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
