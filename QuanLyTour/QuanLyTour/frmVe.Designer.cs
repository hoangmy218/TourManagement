namespace QuanLyTour
{
    partial class frmVe
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
            this.dtpNgayKT = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayBD = new System.Windows.Forms.DateTimePicker();
            this.nudGia = new System.Windows.Forms.NumericUpDown();
            this.nudMaTour = new System.Windows.Forms.NumericUpDown();
            this.cbHDV = new System.Windows.Forms.ComboBox();
            this.txtHDV = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTaiLaiDL = new System.Windows.Forms.Button();
            this.dgvTour = new System.Windows.Forms.DataGridView();
            this.matour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tentour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaybd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaykt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manv = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnTroVe = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nudGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaTour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTour)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpNgayKT
            // 
            this.dtpNgayKT.CustomFormat = "dd-MM-yyyy";
            this.dtpNgayKT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayKT.Location = new System.Drawing.Point(329, 69);
            this.dtpNgayKT.Name = "dtpNgayKT";
            this.dtpNgayKT.Size = new System.Drawing.Size(143, 20);
            this.dtpNgayKT.TabIndex = 35;
            // 
            // dtpNgayBD
            // 
            this.dtpNgayBD.CustomFormat = "dd-MM-yyyy";
            this.dtpNgayBD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayBD.Location = new System.Drawing.Point(331, 18);
            this.dtpNgayBD.Name = "dtpNgayBD";
            this.dtpNgayBD.Size = new System.Drawing.Size(141, 20);
            this.dtpNgayBD.TabIndex = 34;
            // 
            // nudGia
            // 
            this.nudGia.Location = new System.Drawing.Point(581, 22);
            this.nudGia.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudGia.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudGia.Name = "nudGia";
            this.nudGia.Size = new System.Drawing.Size(120, 20);
            this.nudGia.TabIndex = 32;
            this.nudGia.Value = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            // 
            // nudMaTour
            // 
            this.nudMaTour.Location = new System.Drawing.Point(67, 20);
            this.nudMaTour.Name = "nudMaTour";
            this.nudMaTour.Size = new System.Drawing.Size(167, 20);
            this.nudMaTour.TabIndex = 31;
            // 
            // cbHDV
            // 
            this.cbHDV.FormattingEnabled = true;
            this.cbHDV.Location = new System.Drawing.Point(581, 66);
            this.cbHDV.Name = "cbHDV";
            this.cbHDV.Size = new System.Drawing.Size(121, 21);
            this.cbHDV.TabIndex = 28;
            // 
            // txtHDV
            // 
            this.txtHDV.AutoSize = true;
            this.txtHDV.Location = new System.Drawing.Point(492, 69);
            this.txtHDV.Name = "txtHDV";
            this.txtHDV.Size = new System.Drawing.Size(83, 13);
            this.txtHDV.TabIndex = 27;
            this.txtHDV.Text = "Hướng dẫn viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Mã vé";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(706, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "VND";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Tên tour";
            // 
            // btnTaiLaiDL
            // 
            this.btnTaiLaiDL.Location = new System.Drawing.Point(118, 369);
            this.btnTaiLaiDL.Name = "btnTaiLaiDL";
            this.btnTaiLaiDL.Size = new System.Drawing.Size(75, 23);
            this.btnTaiLaiDL.TabIndex = 30;
            this.btnTaiLaiDL.Text = "Tải lại";
            this.btnTaiLaiDL.UseVisualStyleBackColor = true;
            // 
            // dgvTour
            // 
            this.dgvTour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTour.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matour,
            this.tentour,
            this.ngaybd,
            this.ngaykt,
            this.gia,
            this.manv});
            this.dgvTour.Location = new System.Drawing.Point(27, 162);
            this.dgvTour.Name = "dgvTour";
            this.dgvTour.Size = new System.Drawing.Size(747, 173);
            this.dgvTour.TabIndex = 29;
            // 
            // matour
            // 
            this.matour.DataPropertyName = "matour";
            this.matour.HeaderText = "Mã tour";
            this.matour.Name = "matour";
            this.matour.Width = 60;
            // 
            // tentour
            // 
            this.tentour.DataPropertyName = "tentour";
            this.tentour.HeaderText = "Tên tour";
            this.tentour.Name = "tentour";
            this.tentour.Width = 150;
            // 
            // ngaybd
            // 
            this.ngaybd.DataPropertyName = "ngaybd";
            this.ngaybd.HeaderText = "Ngày bắt đầu";
            this.ngaybd.Name = "ngaybd";
            // 
            // ngaykt
            // 
            this.ngaykt.DataPropertyName = "ngaykt";
            this.ngaykt.HeaderText = "Ngày kết thúc";
            this.ngaykt.Name = "ngaykt";
            // 
            // gia
            // 
            this.gia.DataPropertyName = "gia";
            this.gia.HeaderText = "Giá";
            this.gia.Name = "gia";
            // 
            // manv
            // 
            this.manv.DataPropertyName = "manv";
            this.manv.HeaderText = "Hướng dẫn viên";
            this.manv.Name = "manv";
            this.manv.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.manv.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.manv.Width = 200;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(253, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Ngày bắt đầu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(253, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Ngày kết thúc";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(314, 369);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 36;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(216, 369);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 33;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(492, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Giá";
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(520, 369);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 38;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(414, 369);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 37;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnTroVe
            // 
            this.btnTroVe.Location = new System.Drawing.Point(613, 369);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(75, 23);
            this.btnTroVe.TabIndex = 39;
            this.btnTroVe.Text = "Trở về";
            this.btnTroVe.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtpNgayKT);
            this.panel1.Controls.Add(this.dtpNgayBD);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.nudGia);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.nudMaTour);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbHDV);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtHDV);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(27, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(747, 114);
            this.panel1.TabIndex = 40;
            // 
            // frmVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnTaiLaiDL);
            this.Controls.Add(this.dgvTour);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnTroVe);
            this.Name = "frmVe";
            this.Text = "Quản lý Vé";
            ((System.ComponentModel.ISupportInitialize)(this.nudGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaTour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTour)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpNgayKT;
        private System.Windows.Forms.DateTimePicker dtpNgayBD;
        private System.Windows.Forms.NumericUpDown nudGia;
        private System.Windows.Forms.NumericUpDown nudMaTour;
        private System.Windows.Forms.ComboBox cbHDV;
        private System.Windows.Forms.Label txtHDV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTaiLaiDL;
        private System.Windows.Forms.DataGridView dgvTour;
        private System.Windows.Forms.DataGridViewTextBoxColumn matour;
        private System.Windows.Forms.DataGridViewTextBoxColumn tentour;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaybd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaykt;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia;
        private System.Windows.Forms.DataGridViewComboBoxColumn manv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnTroVe;
        private System.Windows.Forms.Panel panel1;
    }
}