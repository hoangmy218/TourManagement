namespace QuanLyTour
{
    partial class frmQLLichTrinh
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboKhachSan = new System.Windows.Forms.ComboBox();
            this.txtSdt = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grbLichTrinh = new System.Windows.Forms.GroupBox();
            this.btnPDF = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.dgvLT = new System.Windows.Forms.DataGridView();
            this.gio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.madd = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.mapt = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.btnTaiLai = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtTenTour = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtHDV = new System.Windows.Forms.Label();
            this.txtPhuongTien = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtDiemDen = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtDiemXP = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtNgayVe = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNgayKH = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtMaTour = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.grbLocTour = new System.Windows.Forms.GroupBox();
            this.txtNgay = new System.Windows.Forms.Label();
            this.cboNgay = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboTenTour = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTroVe = new System.Windows.Forms.Button();
            this.txtDiaChi = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaKS = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grbThongTinTour = new System.Windows.Forms.GroupBox();
            this.grbKhachSan = new System.Windows.Forms.GroupBox();
            this.btnSuaKS = new System.Windows.Forms.Button();
            this.btnHuyKS = new System.Windows.Forms.Button();
            this.btnLuuKS = new System.Windows.Forms.Button();
            this.btnThemKS = new System.Windows.Forms.Button();
            this.btnPDFAll = new System.Windows.Forms.Button();
            this.btnXoaKS = new System.Windows.Forms.Button();
            this.grbLichTrinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLT)).BeginInit();
            this.grbLocTour.SuspendLayout();
            this.grbThongTinTour.SuspendLayout();
            this.grbKhachSan.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboKhachSan
            // 
            this.cboKhachSan.FormattingEnabled = true;
            this.cboKhachSan.Location = new System.Drawing.Point(91, 32);
            this.cboKhachSan.Name = "cboKhachSan";
            this.cboKhachSan.Size = new System.Drawing.Size(235, 21);
            this.cboKhachSan.TabIndex = 29;
            this.cboKhachSan.SelectedIndexChanged += new System.EventHandler(this.cboKhachSan_SelectedIndexChanged);
            // 
            // txtSdt
            // 
            this.txtSdt.AutoSize = true;
            this.txtSdt.Location = new System.Drawing.Point(88, 131);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(13, 13);
            this.txtSdt.TabIndex = 5;
            this.txtSdt.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Tên khách sạn";
            // 
            // grbLichTrinh
            // 
            this.grbLichTrinh.Controls.Add(this.btnPDF);
            this.grbLichTrinh.Controls.Add(this.btnSua);
            this.grbLichTrinh.Controls.Add(this.dgvLT);
            this.grbLichTrinh.Controls.Add(this.btnTaiLai);
            this.grbLichTrinh.Controls.Add(this.btnXoa);
            this.grbLichTrinh.Controls.Add(this.btnThem);
            this.grbLichTrinh.Location = new System.Drawing.Point(40, 346);
            this.grbLichTrinh.Name = "grbLichTrinh";
            this.grbLichTrinh.Size = new System.Drawing.Size(775, 315);
            this.grbLichTrinh.TabIndex = 39;
            this.grbLichTrinh.TabStop = false;
            this.grbLichTrinh.Text = "Thiết lập lịch trình";
            // 
            // btnPDF
            // 
            this.btnPDF.Location = new System.Drawing.Point(484, 270);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(184, 23);
            this.btnPDF.TabIndex = 42;
            this.btnPDF.Text = "Xuất 1 ngày lịch trình sang PDF";
            this.btnPDF.UseVisualStyleBackColor = true;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(308, 270);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 38;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // dgvLT
            // 
            this.dgvLT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gio,
            this.madd,
            this.mapt});
            this.dgvLT.Location = new System.Drawing.Point(9, 31);
            this.dgvLT.Name = "dgvLT";
            this.dgvLT.Size = new System.Drawing.Size(750, 217);
            this.dgvLT.TabIndex = 27;
            // 
            // gio
            // 
            this.gio.DataPropertyName = "gio";
            this.gio.HeaderText = "Giờ";
            this.gio.Name = "gio";
            this.gio.ReadOnly = true;
            this.gio.Width = 150;
            // 
            // madd
            // 
            this.madd.DataPropertyName = "madd";
            this.madd.HeaderText = "Địa danh";
            this.madd.Name = "madd";
            this.madd.ReadOnly = true;
            this.madd.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.madd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.madd.Width = 308;
            // 
            // mapt
            // 
            this.mapt.DataPropertyName = "mapt";
            this.mapt.HeaderText = "Phương tiện";
            this.mapt.Name = "mapt";
            this.mapt.ReadOnly = true;
            this.mapt.Width = 248;
            // 
            // btnTaiLai
            // 
            this.btnTaiLai.Location = new System.Drawing.Point(121, 270);
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.Size = new System.Drawing.Size(75, 23);
            this.btnTaiLai.TabIndex = 32;
            this.btnTaiLai.Text = "Tải lại";
            this.btnTaiLai.UseVisualStyleBackColor = true;
            this.btnTaiLai.Click += new System.EventHandler(this.btnTaiLai_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(399, 270);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 34;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(219, 270);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 33;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtTenTour
            // 
            this.txtTenTour.AutoSize = true;
            this.txtTenTour.Location = new System.Drawing.Point(326, 35);
            this.txtTenTour.Name = "txtTenTour";
            this.txtTenTour.Size = new System.Drawing.Size(16, 13);
            this.txtTenTour.TabIndex = 15;
            this.txtTenTour.Text = "...";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(247, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Tên tour";
            // 
            // txtHDV
            // 
            this.txtHDV.AutoSize = true;
            this.txtHDV.Location = new System.Drawing.Point(88, 133);
            this.txtHDV.Name = "txtHDV";
            this.txtHDV.Size = new System.Drawing.Size(16, 13);
            this.txtHDV.TabIndex = 13;
            this.txtHDV.Text = "...";
            // 
            // txtPhuongTien
            // 
            this.txtPhuongTien.AutoSize = true;
            this.txtPhuongTien.Location = new System.Drawing.Point(88, 165);
            this.txtPhuongTien.Name = "txtPhuongTien";
            this.txtPhuongTien.Size = new System.Drawing.Size(16, 13);
            this.txtPhuongTien.TabIndex = 11;
            this.txtPhuongTien.Text = "...";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(9, 165);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(64, 13);
            this.label18.TabIndex = 10;
            this.label18.Text = "Phương tiện";
            // 
            // txtDiemDen
            // 
            this.txtDiemDen.AutoSize = true;
            this.txtDiemDen.Location = new System.Drawing.Point(88, 195);
            this.txtDiemDen.Name = "txtDiemDen";
            this.txtDiemDen.Size = new System.Drawing.Size(16, 13);
            this.txtDiemDen.TabIndex = 9;
            this.txtDiemDen.Text = "...";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(9, 195);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(53, 13);
            this.label20.TabIndex = 8;
            this.label20.Text = "Điểm đến";
            // 
            // txtDiemXP
            // 
            this.txtDiemXP.AutoSize = true;
            this.txtDiemXP.Location = new System.Drawing.Point(326, 195);
            this.txtDiemXP.Name = "txtDiemXP";
            this.txtDiemXP.Size = new System.Drawing.Size(16, 13);
            this.txtDiemXP.TabIndex = 7;
            this.txtDiemXP.Text = "...";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(247, 195);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(78, 13);
            this.label22.TabIndex = 6;
            this.label22.Text = "Điểm xuất phát";
            // 
            // txtNgayVe
            // 
            this.txtNgayVe.AutoSize = true;
            this.txtNgayVe.Location = new System.Drawing.Point(88, 103);
            this.txtNgayVe.Name = "txtNgayVe";
            this.txtNgayVe.Size = new System.Drawing.Size(16, 13);
            this.txtNgayVe.TabIndex = 5;
            this.txtNgayVe.Text = "...";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 103);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Ngày về";
            // 
            // txtNgayKH
            // 
            this.txtNgayKH.AutoSize = true;
            this.txtNgayKH.Location = new System.Drawing.Point(88, 71);
            this.txtNgayKH.Name = "txtNgayKH";
            this.txtNgayKH.Size = new System.Drawing.Size(16, 13);
            this.txtNgayKH.TabIndex = 3;
            this.txtNgayKH.Text = "...";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 71);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Ngày khởi hành";
            // 
            // txtMaTour
            // 
            this.txtMaTour.AutoSize = true;
            this.txtMaTour.Location = new System.Drawing.Point(88, 38);
            this.txtMaTour.Name = "txtMaTour";
            this.txtMaTour.Size = new System.Drawing.Size(13, 13);
            this.txtMaTour.TabIndex = 1;
            this.txtMaTour.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 38);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(43, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Mã tour";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Số điện thoại";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(9, 133);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(83, 13);
            this.label24.TabIndex = 12;
            this.label24.Text = "Hướng dẫn viên";
            // 
            // grbLocTour
            // 
            this.grbLocTour.Controls.Add(this.txtNgay);
            this.grbLocTour.Controls.Add(this.cboNgay);
            this.grbLocTour.Controls.Add(this.label3);
            this.grbLocTour.Controls.Add(this.cboTenTour);
            this.grbLocTour.Controls.Add(this.label2);
            this.grbLocTour.Location = new System.Drawing.Point(31, 16);
            this.grbLocTour.Name = "grbLocTour";
            this.grbLocTour.Size = new System.Drawing.Size(823, 72);
            this.grbLocTour.TabIndex = 38;
            this.grbLocTour.TabStop = false;
            this.grbLocTour.Text = "Lọc Tour";
            // 
            // txtNgay
            // 
            this.txtNgay.AutoSize = true;
            this.txtNgay.Location = new System.Drawing.Point(431, 36);
            this.txtNgay.Name = "txtNgay";
            this.txtNgay.Size = new System.Drawing.Size(16, 13);
            this.txtNgay.TabIndex = 6;
            this.txtNgay.Text = "...";
            // 
            // cboNgay
            // 
            this.cboNgay.FormattingEnabled = true;
            this.cboNgay.Location = new System.Drawing.Point(294, 33);
            this.cboNgay.Name = "cboNgay";
            this.cboNgay.Size = new System.Drawing.Size(121, 21);
            this.cboNgay.TabIndex = 5;
            this.cboNgay.SelectedIndexChanged += new System.EventHandler(this.cboNgay_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày";
            // 
            // cboTenTour
            // 
            this.cboTenTour.FormattingEnabled = true;
            this.cboTenTour.Location = new System.Drawing.Point(74, 33);
            this.cboTenTour.Name = "cboTenTour";
            this.cboTenTour.Size = new System.Drawing.Size(121, 21);
            this.cboTenTour.TabIndex = 3;
            this.cboTenTour.SelectedIndexChanged += new System.EventHandler(this.cboTenTour_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên tour";
            // 
            // btnTroVe
            // 
            this.btnTroVe.Location = new System.Drawing.Point(703, 678);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(75, 23);
            this.btnTroVe.TabIndex = 37;
            this.btnTroVe.Text = "Trở về";
            this.btnTroVe.UseVisualStyleBackColor = true;
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.AutoSize = true;
            this.txtDiaChi.Location = new System.Drawing.Point(88, 100);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(16, 13);
            this.txtDiaChi.TabIndex = 3;
            this.txtDiaChi.Text = "...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Địa chỉ";
            // 
            // txtMaKS
            // 
            this.txtMaKS.AutoSize = true;
            this.txtMaKS.Location = new System.Drawing.Point(88, 70);
            this.txtMaKS.Name = "txtMaKS";
            this.txtMaKS.Size = new System.Drawing.Size(13, 13);
            this.txtMaKS.TabIndex = 1;
            this.txtMaKS.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã khách sạn";
            // 
            // grbThongTinTour
            // 
            this.grbThongTinTour.Controls.Add(this.txtTenTour);
            this.grbThongTinTour.Controls.Add(this.label8);
            this.grbThongTinTour.Controls.Add(this.txtHDV);
            this.grbThongTinTour.Controls.Add(this.label24);
            this.grbThongTinTour.Controls.Add(this.txtPhuongTien);
            this.grbThongTinTour.Controls.Add(this.label18);
            this.grbThongTinTour.Controls.Add(this.txtDiemDen);
            this.grbThongTinTour.Controls.Add(this.label20);
            this.grbThongTinTour.Controls.Add(this.txtDiemXP);
            this.grbThongTinTour.Controls.Add(this.label22);
            this.grbThongTinTour.Controls.Add(this.txtNgayVe);
            this.grbThongTinTour.Controls.Add(this.label12);
            this.grbThongTinTour.Controls.Add(this.txtNgayKH);
            this.grbThongTinTour.Controls.Add(this.label14);
            this.grbThongTinTour.Controls.Add(this.txtMaTour);
            this.grbThongTinTour.Controls.Add(this.label16);
            this.grbThongTinTour.Location = new System.Drawing.Point(436, 101);
            this.grbThongTinTour.Name = "grbThongTinTour";
            this.grbThongTinTour.Size = new System.Drawing.Size(418, 227);
            this.grbThongTinTour.TabIndex = 41;
            this.grbThongTinTour.TabStop = false;
            this.grbThongTinTour.Text = "Thông tin tour";
            // 
            // grbKhachSan
            // 
            this.grbKhachSan.Controls.Add(this.btnXoaKS);
            this.grbKhachSan.Controls.Add(this.btnSuaKS);
            this.grbKhachSan.Controls.Add(this.btnHuyKS);
            this.grbKhachSan.Controls.Add(this.btnLuuKS);
            this.grbKhachSan.Controls.Add(this.btnThemKS);
            this.grbKhachSan.Controls.Add(this.cboKhachSan);
            this.grbKhachSan.Controls.Add(this.txtSdt);
            this.grbKhachSan.Controls.Add(this.label4);
            this.grbKhachSan.Controls.Add(this.label10);
            this.grbKhachSan.Controls.Add(this.txtDiaChi);
            this.grbKhachSan.Controls.Add(this.label7);
            this.grbKhachSan.Controls.Add(this.txtMaKS);
            this.grbKhachSan.Controls.Add(this.label5);
            this.grbKhachSan.Location = new System.Drawing.Point(40, 104);
            this.grbKhachSan.Name = "grbKhachSan";
            this.grbKhachSan.Size = new System.Drawing.Size(374, 224);
            this.grbKhachSan.TabIndex = 40;
            this.grbKhachSan.TabStop = false;
            this.grbKhachSan.Text = "Thiết lập khách sạn";
            // 
            // btnSuaKS
            // 
            this.btnSuaKS.Location = new System.Drawing.Point(154, 152);
            this.btnSuaKS.Name = "btnSuaKS";
            this.btnSuaKS.Size = new System.Drawing.Size(75, 23);
            this.btnSuaKS.TabIndex = 40;
            this.btnSuaKS.Text = "Sửa";
            this.btnSuaKS.UseVisualStyleBackColor = true;
            this.btnSuaKS.Click += new System.EventHandler(this.btnSuaKS_Click);
            // 
            // btnHuyKS
            // 
            this.btnHuyKS.Location = new System.Drawing.Point(219, 192);
            this.btnHuyKS.Name = "btnHuyKS";
            this.btnHuyKS.Size = new System.Drawing.Size(75, 23);
            this.btnHuyKS.TabIndex = 39;
            this.btnHuyKS.Text = "Hủy";
            this.btnHuyKS.UseVisualStyleBackColor = true;
            this.btnHuyKS.Click += new System.EventHandler(this.btnHuyKS_Click);
            // 
            // btnLuuKS
            // 
            this.btnLuuKS.Location = new System.Drawing.Point(91, 192);
            this.btnLuuKS.Name = "btnLuuKS";
            this.btnLuuKS.Size = new System.Drawing.Size(75, 23);
            this.btnLuuKS.TabIndex = 38;
            this.btnLuuKS.Text = "Lưu";
            this.btnLuuKS.UseVisualStyleBackColor = true;
            this.btnLuuKS.Click += new System.EventHandler(this.btnLuuKS_Click);
            // 
            // btnThemKS
            // 
            this.btnThemKS.Location = new System.Drawing.Point(26, 157);
            this.btnThemKS.Name = "btnThemKS";
            this.btnThemKS.Size = new System.Drawing.Size(75, 23);
            this.btnThemKS.TabIndex = 36;
            this.btnThemKS.Text = "Thêm";
            this.btnThemKS.UseVisualStyleBackColor = true;
            this.btnThemKS.Click += new System.EventHandler(this.btnThemKS_Click);
            // 
            // btnPDFAll
            // 
            this.btnPDFAll.Location = new System.Drawing.Point(553, 678);
            this.btnPDFAll.Name = "btnPDFAll";
            this.btnPDFAll.Size = new System.Drawing.Size(137, 23);
            this.btnPDFAll.TabIndex = 42;
            this.btnPDFAll.Text = "Xuất tất cả sang PDF";
            this.btnPDFAll.UseVisualStyleBackColor = true;
            this.btnPDFAll.Click += new System.EventHandler(this.btnPDFAll_Click);
            // 
            // btnXoaKS
            // 
            this.btnXoaKS.Location = new System.Drawing.Point(285, 152);
            this.btnXoaKS.Name = "btnXoaKS";
            this.btnXoaKS.Size = new System.Drawing.Size(75, 23);
            this.btnXoaKS.TabIndex = 41;
            this.btnXoaKS.Text = "Xóa";
            this.btnXoaKS.UseVisualStyleBackColor = true;
            this.btnXoaKS.Click += new System.EventHandler(this.btnXoaKS_Click);
            // 
            // frmQLLichTrinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 725);
            this.Controls.Add(this.btnPDFAll);
            this.Controls.Add(this.grbLichTrinh);
            this.Controls.Add(this.grbLocTour);
            this.Controls.Add(this.grbThongTinTour);
            this.Controls.Add(this.btnTroVe);
            this.Controls.Add(this.grbKhachSan);
            this.Name = "frmQLLichTrinh";
            this.Text = "frmQLLichTrinh";
            this.Load += new System.EventHandler(this.frmQLLichTrinh_Load);
            this.grbLichTrinh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLT)).EndInit();
            this.grbLocTour.ResumeLayout(false);
            this.grbLocTour.PerformLayout();
            this.grbThongTinTour.ResumeLayout(false);
            this.grbThongTinTour.PerformLayout();
            this.grbKhachSan.ResumeLayout(false);
            this.grbKhachSan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboKhachSan;
        private System.Windows.Forms.Label txtSdt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grbLichTrinh;
        private System.Windows.Forms.DataGridView dgvLT;
        private System.Windows.Forms.Label txtTenTour;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label txtHDV;
        private System.Windows.Forms.Label txtPhuongTien;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label txtDiemDen;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label txtDiemXP;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label txtNgayVe;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label txtNgayKH;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label txtMaTour;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.GroupBox grbLocTour;
        private System.Windows.Forms.Label txtNgay;
        private System.Windows.Forms.ComboBox cboNgay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboTenTour;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTroVe;
        private System.Windows.Forms.Button btnTaiLai;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label txtDiaChi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label txtMaKS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grbThongTinTour;
        private System.Windows.Forms.GroupBox grbKhachSan;
        private System.Windows.Forms.Button btnHuyKS;
        private System.Windows.Forms.Button btnLuuKS;
        private System.Windows.Forms.Button btnThemKS;
        private System.Windows.Forms.Button btnSuaKS;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DataGridViewTextBoxColumn gio;
        private System.Windows.Forms.DataGridViewComboBoxColumn madd;
        private System.Windows.Forms.DataGridViewComboBoxColumn mapt;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.Button btnPDFAll;
        private System.Windows.Forms.Button btnXoaKS;
    }
}