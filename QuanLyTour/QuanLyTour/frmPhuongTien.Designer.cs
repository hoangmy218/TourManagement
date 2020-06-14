namespace QuanLyTour
{
    partial class frmPhuongTien
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
            this.pnlThongtinpt = new System.Windows.Forms.Panel();
            this.nudSoCho = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenpt = new System.Windows.Forms.TextBox();
            this.txtMapt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnTroVe = new System.Windows.Forms.Button();
            this.dgvPhuongTien = new System.Windows.Forms.DataGridView();
            this.mapt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenpt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.socho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTaiLai = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.pnlThongtinpt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoCho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhuongTien)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlThongtinpt
            // 
            this.pnlThongtinpt.Controls.Add(this.nudSoCho);
            this.pnlThongtinpt.Controls.Add(this.label3);
            this.pnlThongtinpt.Controls.Add(this.txtTenpt);
            this.pnlThongtinpt.Controls.Add(this.txtMapt);
            this.pnlThongtinpt.Controls.Add(this.label5);
            this.pnlThongtinpt.Controls.Add(this.label7);
            this.pnlThongtinpt.Location = new System.Drawing.Point(12, 24);
            this.pnlThongtinpt.Name = "pnlThongtinpt";
            this.pnlThongtinpt.Size = new System.Drawing.Size(581, 87);
            this.pnlThongtinpt.TabIndex = 21;
            // 
            // nudSoCho
            // 
            this.nudSoCho.Location = new System.Drawing.Point(95, 53);
            this.nudSoCho.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSoCho.Name = "nudSoCho";
            this.nudSoCho.Size = new System.Drawing.Size(120, 20);
            this.nudSoCho.TabIndex = 9;
            this.nudSoCho.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tên phương tiện";
            // 
            // txtTenpt
            // 
            this.txtTenpt.Location = new System.Drawing.Point(352, 21);
            this.txtTenpt.Name = "txtTenpt";
            this.txtTenpt.Size = new System.Drawing.Size(210, 20);
            this.txtTenpt.TabIndex = 7;
            // 
            // txtMapt
            // 
            this.txtMapt.Location = new System.Drawing.Point(95, 21);
            this.txtMapt.Name = "txtMapt";
            this.txtMapt.Size = new System.Drawing.Size(120, 20);
            this.txtMapt.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số chỗ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Mã phương tiện";
            // 
            // btnTroVe
            // 
            this.btnTroVe.Location = new System.Drawing.Point(477, 388);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(75, 23);
            this.btnTroVe.TabIndex = 28;
            this.btnTroVe.Text = "Trở về";
            this.btnTroVe.UseVisualStyleBackColor = true;
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // dgvPhuongTien
            // 
            this.dgvPhuongTien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhuongTien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mapt,
            this.tenpt,
            this.socho});
            this.dgvPhuongTien.Location = new System.Drawing.Point(12, 126);
            this.dgvPhuongTien.Name = "dgvPhuongTien";
            this.dgvPhuongTien.Size = new System.Drawing.Size(581, 223);
            this.dgvPhuongTien.TabIndex = 22;
            this.dgvPhuongTien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhuongTien_CellClick);
            // 
            // mapt
            // 
            this.mapt.DataPropertyName = "mapt";
            this.mapt.HeaderText = "Mã phương tiện";
            this.mapt.Name = "mapt";
            this.mapt.Width = 127;
            // 
            // tenpt
            // 
            this.tenpt.DataPropertyName = "tenpt";
            this.tenpt.HeaderText = "Tên phương tiện";
            this.tenpt.Name = "tenpt";
            this.tenpt.Width = 280;
            // 
            // socho
            // 
            this.socho.DataPropertyName = "socho";
            this.socho.HeaderText = "Số chỗ";
            this.socho.Name = "socho";
            this.socho.Width = 130;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(390, 388);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 27;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(302, 388);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 26;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(215, 388);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 25;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTaiLai
            // 
            this.btnTaiLai.Location = new System.Drawing.Point(39, 388);
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.Size = new System.Drawing.Size(75, 23);
            this.btnTaiLai.TabIndex = 23;
            this.btnTaiLai.Text = "Tải lại";
            this.btnTaiLai.UseVisualStyleBackColor = true;
            this.btnTaiLai.Click += new System.EventHandler(this.btnTaiLai_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(126, 388);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 24;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frmPhuongTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 450);
            this.Controls.Add(this.pnlThongtinpt);
            this.Controls.Add(this.btnTroVe);
            this.Controls.Add(this.dgvPhuongTien);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnTaiLai);
            this.Controls.Add(this.btnThem);
            this.Name = "frmPhuongTien";
            this.Text = "Quản lý phương tiện";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPhuongTien_FormClosing);
            this.Load += new System.EventHandler(this.frmPhuongTien_Load);
            this.pnlThongtinpt.ResumeLayout(false);
            this.pnlThongtinpt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoCho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhuongTien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlThongtinpt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenpt;
        private System.Windows.Forms.TextBox txtMapt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnTroVe;
        private System.Windows.Forms.DataGridView dgvPhuongTien;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTaiLai;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.NumericUpDown nudSoCho;
        private System.Windows.Forms.DataGridViewTextBoxColumn mapt;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenpt;
        private System.Windows.Forms.DataGridViewTextBoxColumn socho;
    }
}