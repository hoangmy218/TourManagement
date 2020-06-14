namespace QuanLyTour
{
    partial class frmdiadanh
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
            this.pnlThongTinDD = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMadd = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTendd = new System.Windows.Forms.TextBox();
            this.dgvDiaDanh = new System.Windows.Forms.DataGridView();
            this.btnTaiLai = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnTroVe = new System.Windows.Forms.Button();
            this.madd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tendd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlThongTinDD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiaDanh)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlThongTinDD
            // 
            this.pnlThongTinDD.Controls.Add(this.txtTendd);
            this.pnlThongTinDD.Controls.Add(this.txtDiaChi);
            this.pnlThongTinDD.Controls.Add(this.txtMadd);
            this.pnlThongTinDD.Controls.Add(this.label3);
            this.pnlThongTinDD.Controls.Add(this.label2);
            this.pnlThongTinDD.Controls.Add(this.label1);
            this.pnlThongTinDD.Location = new System.Drawing.Point(13, 13);
            this.pnlThongTinDD.Name = "pnlThongTinDD";
            this.pnlThongTinDD.Size = new System.Drawing.Size(529, 100);
            this.pnlThongTinDD.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã địa danh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên địa danh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Địa chỉ";
            // 
            // txtMadd
            // 
            this.txtMadd.Location = new System.Drawing.Point(91, 19);
            this.txtMadd.Name = "txtMadd";
            this.txtMadd.Size = new System.Drawing.Size(136, 20);
            this.txtMadd.TabIndex = 3;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(91, 63);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(426, 20);
            this.txtDiaChi.TabIndex = 4;
            // 
            // txtTendd
            // 
            this.txtTendd.Location = new System.Drawing.Point(324, 19);
            this.txtTendd.Name = "txtTendd";
            this.txtTendd.Size = new System.Drawing.Size(193, 20);
            this.txtTendd.TabIndex = 5;
            // 
            // dgvDiaDanh
            // 
            this.dgvDiaDanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiaDanh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.madd,
            this.tendd,
            this.diachi});
            this.dgvDiaDanh.Location = new System.Drawing.Point(13, 130);
            this.dgvDiaDanh.Name = "dgvDiaDanh";
            this.dgvDiaDanh.Size = new System.Drawing.Size(529, 150);
            this.dgvDiaDanh.TabIndex = 1;
            this.dgvDiaDanh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDiaDanh_CellClick);
            // 
            // btnTaiLai
            // 
            this.btnTaiLai.Location = new System.Drawing.Point(12, 325);
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.Size = new System.Drawing.Size(75, 23);
            this.btnTaiLai.TabIndex = 2;
            this.btnTaiLai.Text = "Tải lại";
            this.btnTaiLai.UseVisualStyleBackColor = true;
            this.btnTaiLai.Click += new System.EventHandler(this.btnTaiLai_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(105, 325);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(197, 325);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(288, 325);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 5;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(379, 325);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 6;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnTroVe
            // 
            this.btnTroVe.Location = new System.Drawing.Point(467, 325);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(75, 23);
            this.btnTroVe.TabIndex = 7;
            this.btnTroVe.Text = "Trở về";
            this.btnTroVe.UseVisualStyleBackColor = true;
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // madd
            // 
            this.madd.DataPropertyName = "madd";
            this.madd.HeaderText = "Mã địa danh";
            this.madd.Name = "madd";
            // 
            // tendd
            // 
            this.tendd.DataPropertyName = "tendd";
            this.tendd.HeaderText = "Tên địa danh";
            this.tendd.Name = "tendd";
            this.tendd.Width = 150;
            // 
            // diachi
            // 
            this.diachi.DataPropertyName = "diachi";
            this.diachi.HeaderText = "Địa chỉ";
            this.diachi.Name = "diachi";
            this.diachi.Width = 235;
            // 
            // frmdiadanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 450);
            this.Controls.Add(this.btnTroVe);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnTaiLai);
            this.Controls.Add(this.dgvDiaDanh);
            this.Controls.Add(this.pnlThongTinDD);
            this.Name = "frmdiadanh";
            this.Text = "Quản lý địa danh";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmdiadanh_FormClosing);
            this.Load += new System.EventHandler(this.frmdiadanh_Load);
            this.pnlThongTinDD.ResumeLayout(false);
            this.pnlThongTinDD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiaDanh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlThongTinDD;
        private System.Windows.Forms.TextBox txtTendd;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtMadd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDiaDanh;
        private System.Windows.Forms.Button btnTaiLai;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnTroVe;
        private System.Windows.Forms.DataGridViewTextBoxColumn madd;
        private System.Windows.Forms.DataGridViewTextBoxColumn tendd;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
    }
}