namespace QuanLyTour
{
    partial class frmLichTrinh
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
            this.dgvLT = new System.Windows.Forms.DataGridView();
            this.btnTroVe = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnTaiLai = new System.Windows.Forms.Button();
            this.grbLocTour = new System.Windows.Forms.GroupBox();
            this.cboNgay = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboTenTour = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboMaTour = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grbLichTrinh = new System.Windows.Forms.GroupBox();
            this.cboKhachSan = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.madd = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.mapt = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLT)).BeginInit();
            this.grbLocTour.SuspendLayout();
            this.grbLichTrinh.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLT
            // 
            this.dgvLT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gio,
            this.madd,
            this.mapt});
            this.dgvLT.Location = new System.Drawing.Point(9, 72);
            this.dgvLT.Name = "dgvLT";
            this.dgvLT.Size = new System.Drawing.Size(750, 170);
            this.dgvLT.TabIndex = 27;
            // 
            // btnTroVe
            // 
            this.btnTroVe.Location = new System.Drawing.Point(599, 401);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(75, 23);
            this.btnTroVe.TabIndex = 26;
            this.btnTroVe.Text = "Trở về";
            this.btnTroVe.UseVisualStyleBackColor = true;
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(506, 401);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 25;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(400, 401);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 24;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(300, 401);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 23;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(202, 401);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 22;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnTaiLai
            // 
            this.btnTaiLai.Location = new System.Drawing.Point(104, 401);
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.Size = new System.Drawing.Size(75, 23);
            this.btnTaiLai.TabIndex = 21;
            this.btnTaiLai.Text = "Tải lại";
            this.btnTaiLai.UseVisualStyleBackColor = true;
            this.btnTaiLai.Click += new System.EventHandler(this.btnTaiLaiDL_Click);
            // 
            // grbLocTour
            // 
            this.grbLocTour.Controls.Add(this.cboNgay);
            this.grbLocTour.Controls.Add(this.label3);
            this.grbLocTour.Controls.Add(this.cboTenTour);
            this.grbLocTour.Controls.Add(this.label2);
            this.grbLocTour.Controls.Add(this.cboMaTour);
            this.grbLocTour.Controls.Add(this.label1);
            this.grbLocTour.Location = new System.Drawing.Point(13, 13);
            this.grbLocTour.Name = "grbLocTour";
            this.grbLocTour.Size = new System.Drawing.Size(775, 72);
            this.grbLocTour.TabIndex = 28;
            this.grbLocTour.TabStop = false;
            this.grbLocTour.Text = "Lọc Tour";
            // 
            // cboNgay
            // 
            this.cboNgay.FormattingEnabled = true;
            this.cboNgay.Location = new System.Drawing.Point(507, 30);
            this.cboNgay.Name = "cboNgay";
            this.cboNgay.Size = new System.Drawing.Size(121, 21);
            this.cboNgay.TabIndex = 5;
            this.cboNgay.SelectedIndexChanged += new System.EventHandler(this.cboNgay_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(459, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày";
            // 
            // cboTenTour
            // 
            this.cboTenTour.FormattingEnabled = true;
            this.cboTenTour.Location = new System.Drawing.Point(287, 30);
            this.cboTenTour.Name = "cboTenTour";
            this.cboTenTour.Size = new System.Drawing.Size(121, 21);
            this.cboTenTour.TabIndex = 3;
            this.cboTenTour.SelectedIndexChanged += new System.EventHandler(this.cboTenTour_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên tour";
            // 
            // cboMaTour
            // 
            this.cboMaTour.FormattingEnabled = true;
            this.cboMaTour.Location = new System.Drawing.Point(62, 30);
            this.cboMaTour.Name = "cboMaTour";
            this.cboMaTour.Size = new System.Drawing.Size(121, 21);
            this.cboMaTour.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã tour";
            // 
            // grbLichTrinh
            // 
            this.grbLichTrinh.Controls.Add(this.cboKhachSan);
            this.grbLichTrinh.Controls.Add(this.label4);
            this.grbLichTrinh.Controls.Add(this.dgvLT);
            this.grbLichTrinh.Location = new System.Drawing.Point(13, 116);
            this.grbLichTrinh.Name = "grbLichTrinh";
            this.grbLichTrinh.Size = new System.Drawing.Size(775, 261);
            this.grbLichTrinh.TabIndex = 29;
            this.grbLichTrinh.TabStop = false;
            this.grbLichTrinh.Text = "Thiết lập lịch trình";
            // 
            // cboKhachSan
            // 
            this.cboKhachSan.FormattingEnabled = true;
            this.cboKhachSan.Location = new System.Drawing.Point(110, 33);
            this.cboKhachSan.Name = "cboKhachSan";
            this.cboKhachSan.Size = new System.Drawing.Size(235, 21);
            this.cboKhachSan.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Tên khách sạn";
            // 
            // gio
            // 
            this.gio.DataPropertyName = "gio";
            this.gio.HeaderText = "Giờ";
            this.gio.Name = "gio";
            // 
            // madd
            // 
            this.madd.DataPropertyName = "madd";
            this.madd.HeaderText = "Địa danh";
            this.madd.Name = "madd";
            this.madd.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.madd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.madd.Width = 300;
            // 
            // mapt
            // 
            this.mapt.DataPropertyName = "mapt";
            this.mapt.HeaderText = "Phương tiện";
            this.mapt.Name = "mapt";
            this.mapt.Width = 200;
            // 
            // frmLichTrinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 450);
            this.Controls.Add(this.grbLichTrinh);
            this.Controls.Add(this.grbLocTour);
            this.Controls.Add(this.btnTroVe);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnTaiLai);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Name = "frmLichTrinh";
            this.Text = "Quản lý lịch trình";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLichTrinh_FormClosing);
            this.Load += new System.EventHandler(this.frmLichTrinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLT)).EndInit();
            this.grbLocTour.ResumeLayout(false);
            this.grbLocTour.PerformLayout();
            this.grbLichTrinh.ResumeLayout(false);
            this.grbLichTrinh.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvLT;
        private System.Windows.Forms.Button btnTroVe;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnTaiLai;
        private System.Windows.Forms.GroupBox grbLocTour;
        private System.Windows.Forms.ComboBox cboNgay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboTenTour;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboMaTour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbLichTrinh;
        private System.Windows.Forms.ComboBox cboKhachSan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn gio;
        private System.Windows.Forms.DataGridViewComboBoxColumn madd;
        private System.Windows.Forms.DataGridViewComboBoxColumn mapt;
    }
}