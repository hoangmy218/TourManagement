namespace QuanLyTour
{
    partial class frmTour
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenTour = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.grBThongTin = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDiemden = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDiemxp = new System.Windows.Forms.TextBox();
            this.cboPhuongTien = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudGiaTE = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nudGiaNL = new System.Windows.Forms.NumericUpDown();
            this.dtpNgayKT = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayBD = new System.Windows.Forms.DateTimePicker();
            this.nudMaTour = new System.Windows.Forms.NumericUpDown();
            this.cbHDV = new System.Windows.Forms.ComboBox();
            this.txtHDV = new System.Windows.Forms.Label();
            this.btnTaiLaiDL = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnTroVe = new System.Windows.Forms.Button();
            this.matour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTour = new System.Windows.Forms.DataGridView();
            this.matour1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tentour1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaykh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayve = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemxp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manv = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.mapt = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.grBThongTin.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGiaTE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGiaNL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaTour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTour)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã tour";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên tour";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày khởi hành";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(250, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày về";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(101, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Giá";
            // 
            // txtTenTour
            // 
            this.txtTenTour.Location = new System.Drawing.Point(64, 66);
            this.txtTenTour.Name = "txtTenTour";
            this.txtTenTour.Size = new System.Drawing.Size(167, 20);
            this.txtTenTour.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(257, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "VND";
            // 
            // grBThongTin
            // 
            this.grBThongTin.Controls.Add(this.label11);
            this.grBThongTin.Controls.Add(this.txtDiemden);
            this.grBThongTin.Controls.Add(this.label10);
            this.grBThongTin.Controls.Add(this.txtDiemxp);
            this.grBThongTin.Controls.Add(this.cboPhuongTien);
            this.grBThongTin.Controls.Add(this.label9);
            this.grBThongTin.Controls.Add(this.groupBox1);
            this.grBThongTin.Controls.Add(this.dtpNgayKT);
            this.grBThongTin.Controls.Add(this.dtpNgayBD);
            this.grBThongTin.Controls.Add(this.nudMaTour);
            this.grBThongTin.Controls.Add(this.cbHDV);
            this.grBThongTin.Controls.Add(this.txtHDV);
            this.grBThongTin.Controls.Add(this.label1);
            this.grBThongTin.Controls.Add(this.label2);
            this.grBThongTin.Controls.Add(this.txtTenTour);
            this.grBThongTin.Controls.Add(this.label3);
            this.grBThongTin.Controls.Add(this.label4);
            this.grBThongTin.Location = new System.Drawing.Point(15, 12);
            this.grBThongTin.Name = "grBThongTin";
            this.grBThongTin.Size = new System.Drawing.Size(865, 186);
            this.grBThongTin.TabIndex = 11;
            this.grBThongTin.TabStop = false;
            this.grBThongTin.Text = "Thông tin tour";
            this.grBThongTin.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 151);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Điếm đến";
            // 
            // txtDiemden
            // 
            this.txtDiemden.Location = new System.Drawing.Point(105, 149);
            this.txtDiemden.Name = "txtDiemden";
            this.txtDiemden.Size = new System.Drawing.Size(126, 20);
            this.txtDiemden.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Điểm xuất phát";
            // 
            // txtDiemxp
            // 
            this.txtDiemxp.Location = new System.Drawing.Point(105, 112);
            this.txtDiemxp.Name = "txtDiemxp";
            this.txtDiemxp.Size = new System.Drawing.Size(126, 20);
            this.txtDiemxp.TabIndex = 23;
            // 
            // cboPhuongTien
            // 
            this.cboPhuongTien.FormattingEnabled = true;
            this.cboPhuongTien.Location = new System.Drawing.Point(334, 116);
            this.cboPhuongTien.Name = "cboPhuongTien";
            this.cboPhuongTien.Size = new System.Drawing.Size(141, 21);
            this.cboPhuongTien.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(250, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Phương tiện";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudGiaTE);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.nudGiaNL);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(487, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 107);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loại vé";
            // 
            // nudGiaTE
            // 
            this.nudGiaTE.Location = new System.Drawing.Point(131, 60);
            this.nudGiaTE.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudGiaTE.Minimum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.nudGiaTE.Name = "nudGiaTE";
            this.nudGiaTE.Size = new System.Drawing.Size(120, 20);
            this.nudGiaTE.TabIndex = 21;
            this.nudGiaTE.Value = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.nudGiaTE.ValueChanged += new System.EventHandler(this.nudGiaTE_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(101, 64);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Giá";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(257, 64);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "VND";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Vé người lớn";
            this.label7.Click += new System.EventHandler(this.label7_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Vé trẻ em";
            // 
            // nudGiaNL
            // 
            this.nudGiaNL.Location = new System.Drawing.Point(131, 22);
            this.nudGiaNL.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudGiaNL.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudGiaNL.Name = "nudGiaNL";
            this.nudGiaNL.Size = new System.Drawing.Size(120, 20);
            this.nudGiaNL.TabIndex = 14;
            this.nudGiaNL.Value = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudGiaNL.ValueChanged += new System.EventHandler(this.nudGia_ValueChanged);
            // 
            // dtpNgayKT
            // 
            this.dtpNgayKT.CustomFormat = "hh:mm tt dd-MM-yyyy";
            this.dtpNgayKT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayKT.Location = new System.Drawing.Point(332, 73);
            this.dtpNgayKT.Name = "dtpNgayKT";
            this.dtpNgayKT.Size = new System.Drawing.Size(143, 20);
            this.dtpNgayKT.TabIndex = 16;
            this.dtpNgayKT.ValueChanged += new System.EventHandler(this.dtpNgayKT_ValueChanged);
            // 
            // dtpNgayBD
            // 
            this.dtpNgayBD.CustomFormat = "hh:mm tt dd-MM-yyyy ";
            this.dtpNgayBD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayBD.Location = new System.Drawing.Point(334, 22);
            this.dtpNgayBD.Name = "dtpNgayBD";
            this.dtpNgayBD.Size = new System.Drawing.Size(141, 20);
            this.dtpNgayBD.TabIndex = 15;
            this.dtpNgayBD.ValueChanged += new System.EventHandler(this.dtpNgayBD_ValueChanged);
            // 
            // nudMaTour
            // 
            this.nudMaTour.Location = new System.Drawing.Point(64, 24);
            this.nudMaTour.Name = "nudMaTour";
            this.nudMaTour.Size = new System.Drawing.Size(167, 20);
            this.nudMaTour.TabIndex = 13;
            this.nudMaTour.ValueChanged += new System.EventHandler(this.nudMaTour_ValueChanged);
            // 
            // cbHDV
            // 
            this.cbHDV.FormattingEnabled = true;
            this.cbHDV.Location = new System.Drawing.Point(579, 21);
            this.cbHDV.Name = "cbHDV";
            this.cbHDV.Size = new System.Drawing.Size(121, 21);
            this.cbHDV.TabIndex = 12;
            this.cbHDV.SelectedIndexChanged += new System.EventHandler(this.cbHDV_SelectedIndexChanged);
            // 
            // txtHDV
            // 
            this.txtHDV.AutoSize = true;
            this.txtHDV.Location = new System.Drawing.Point(490, 24);
            this.txtHDV.Name = "txtHDV";
            this.txtHDV.Size = new System.Drawing.Size(83, 13);
            this.txtHDV.TabIndex = 11;
            this.txtHDV.Text = "Hướng dẫn viên";
            this.txtHDV.Click += new System.EventHandler(this.label7_Click);
            // 
            // btnTaiLaiDL
            // 
            this.btnTaiLaiDL.Location = new System.Drawing.Point(106, 411);
            this.btnTaiLaiDL.Name = "btnTaiLaiDL";
            this.btnTaiLaiDL.Size = new System.Drawing.Size(75, 23);
            this.btnTaiLaiDL.TabIndex = 13;
            this.btnTaiLaiDL.Text = "Tải lại";
            this.btnTaiLaiDL.UseVisualStyleBackColor = true;
            this.btnTaiLaiDL.Click += new System.EventHandler(this.btnTaiLaiDL_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(204, 411);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 14;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(302, 411);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 16;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(402, 411);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 17;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(508, 411);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 18;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnTroVe
            // 
            this.btnTroVe.Location = new System.Drawing.Point(601, 411);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(75, 23);
            this.btnTroVe.TabIndex = 19;
            this.btnTroVe.Text = "Trở về";
            this.btnTroVe.UseVisualStyleBackColor = true;
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // matour
            // 
            this.matour.DataPropertyName = "matour";
            this.matour.HeaderText = "Mã tour";
            this.matour.Name = "matour";
            this.matour.Width = 60;
            // 
            // dgvTour
            // 
            this.dgvTour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTour.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matour1,
            this.tentour1,
            this.Ngaykh,
            this.ngayve,
            this.diemxp,
            this.diemden,
            this.manv,
            this.mapt});
            this.dgvTour.Location = new System.Drawing.Point(15, 223);
            this.dgvTour.Name = "dgvTour";
            this.dgvTour.Size = new System.Drawing.Size(865, 150);
            this.dgvTour.TabIndex = 20;
            this.dgvTour.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTour_CellClick_1);
            this.dgvTour.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTour_CellContentClick_1);
            // 
            // matour1
            // 
            this.matour1.DataPropertyName = "matour";
            this.matour1.HeaderText = "Mã tour";
            this.matour1.Name = "matour1";
            this.matour1.Width = 80;
            // 
            // tentour1
            // 
            this.tentour1.DataPropertyName = "tentour";
            this.tentour1.HeaderText = "Tên tour";
            this.tentour1.Name = "tentour1";
            // 
            // Ngaykh
            // 
            this.Ngaykh.DataPropertyName = "ngaykh";
            this.Ngaykh.HeaderText = "Ngày khởi hành";
            this.Ngaykh.Name = "Ngaykh";
            this.Ngaykh.Width = 120;
            // 
            // ngayve
            // 
            this.ngayve.DataPropertyName = "ngayve";
            this.ngayve.HeaderText = "Ngày về";
            this.ngayve.Name = "ngayve";
            this.ngayve.Width = 120;
            // 
            // diemxp
            // 
            this.diemxp.DataPropertyName = "diemxp";
            this.diemxp.HeaderText = "Điểm xuất phát";
            this.diemxp.Name = "diemxp";
            // 
            // diemden
            // 
            this.diemden.DataPropertyName = "diemden";
            this.diemden.HeaderText = "Điểm đến";
            this.diemden.Name = "diemden";
            this.diemden.Width = 150;
            // 
            // manv
            // 
            this.manv.DataPropertyName = "manv";
            this.manv.HeaderText = "Hướng dẫn viên";
            this.manv.Name = "manv";
            this.manv.Width = 150;
            // 
            // mapt
            // 
            this.mapt.DataPropertyName = "mapt";
            this.mapt.HeaderText = "Phương tiện";
            this.mapt.Name = "mapt";
            this.mapt.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.mapt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // frmTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 450);
            this.Controls.Add(this.dgvTour);
            this.Controls.Add(this.btnTroVe);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnTaiLaiDL);
            this.Controls.Add(this.grBThongTin);
            this.Name = "frmTour";
            this.Text = "Quản lý Tour";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTour_FormClosing);
            this.Load += new System.EventHandler(this.frmTour_Load);
            this.grBThongTin.ResumeLayout(false);
            this.grBThongTin.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGiaTE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGiaNL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaTour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTour)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTenTour;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grBThongTin;
        private System.Windows.Forms.Button btnTaiLaiDL;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnTroVe;
        private System.Windows.Forms.Label txtHDV;
        private System.Windows.Forms.ComboBox cbHDV;
        private System.Windows.Forms.NumericUpDown nudGiaNL;
        private System.Windows.Forms.NumericUpDown nudMaTour;
        private System.Windows.Forms.DateTimePicker dtpNgayBD;
        private System.Windows.Forms.DateTimePicker dtpNgayKT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDiemden;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDiemxp;
        private System.Windows.Forms.ComboBox cboPhuongTien;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn matour;
        private System.Windows.Forms.DataGridView dgvTour;
        private System.Windows.Forms.NumericUpDown nudGiaTE;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn matour1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tentour1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaykh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayve;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemxp;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemden;
        private System.Windows.Forms.DataGridViewComboBoxColumn manv;
        private System.Windows.Forms.DataGridViewComboBoxColumn mapt;
    }
}