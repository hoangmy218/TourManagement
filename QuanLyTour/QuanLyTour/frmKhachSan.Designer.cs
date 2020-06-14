namespace QuanLyTour
{
    partial class frmKhachSan
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
            this.btnTroVe = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnTaiLai = new System.Windows.Forms.Button();
            this.dgvKhachSan = new System.Windows.Forms.DataGridView();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenks = new System.Windows.Forms.TextBox();
            this.txtMaks = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlThongtinks = new System.Windows.Forms.Panel();
            this.maks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachSan)).BeginInit();
            this.pnlThongtinks.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTroVe
            // 
            this.btnTroVe.Location = new System.Drawing.Point(498, 406);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(75, 23);
            this.btnTroVe.TabIndex = 15;
            this.btnTroVe.Text = "Trở về";
            this.btnTroVe.UseVisualStyleBackColor = true;
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(406, 406);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 14;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(315, 406);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 13;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(225, 406);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(129, 406);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnTaiLai
            // 
            this.btnTaiLai.Location = new System.Drawing.Point(41, 406);
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.Size = new System.Drawing.Size(75, 23);
            this.btnTaiLai.TabIndex = 10;
            this.btnTaiLai.Text = "Tải lại";
            this.btnTaiLai.UseVisualStyleBackColor = true;
            this.btnTaiLai.Click += new System.EventHandler(this.btnTaiLai_Click);
            // 
            // dgvKhachSan
            // 
            this.dgvKhachSan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachSan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maks,
            this.tenks,
            this.diachi,
            this.sdt});
            this.dgvKhachSan.Location = new System.Drawing.Point(13, 169);
            this.dgvKhachSan.Name = "dgvKhachSan";
            this.dgvKhachSan.Size = new System.Drawing.Size(589, 217);
            this.dgvKhachSan.TabIndex = 9;
            this.dgvKhachSan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachSan_CellClick);
            // 
            // txtSdt
            // 
            this.txtSdt.Location = new System.Drawing.Point(82, 72);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(104, 20);
            this.txtSdt.TabIndex = 14;
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(306, 72);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(260, 20);
            this.txtDiachi.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tên khách sạn";
            // 
            // txtTenks
            // 
            this.txtTenks.Location = new System.Drawing.Point(306, 21);
            this.txtTenks.Name = "txtTenks";
            this.txtTenks.Size = new System.Drawing.Size(260, 20);
            this.txtTenks.TabIndex = 7;
            // 
            // txtMaks
            // 
            this.txtMaks.Location = new System.Drawing.Point(86, 21);
            this.txtMaks.Name = "txtMaks";
            this.txtMaks.Size = new System.Drawing.Size(100, 20);
            this.txtMaks.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(224, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Địa chỉ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã khách sạn";
            // 
            // pnlThongtinks
            // 
            this.pnlThongtinks.Controls.Add(this.txtSdt);
            this.pnlThongtinks.Controls.Add(this.txtDiachi);
            this.pnlThongtinks.Controls.Add(this.label3);
            this.pnlThongtinks.Controls.Add(this.txtTenks);
            this.pnlThongtinks.Controls.Add(this.txtMaks);
            this.pnlThongtinks.Controls.Add(this.label5);
            this.pnlThongtinks.Controls.Add(this.label4);
            this.pnlThongtinks.Controls.Add(this.label1);
            this.pnlThongtinks.Location = new System.Drawing.Point(12, 21);
            this.pnlThongtinks.Name = "pnlThongtinks";
            this.pnlThongtinks.Size = new System.Drawing.Size(590, 117);
            this.pnlThongtinks.TabIndex = 8;
            // 
            // maks
            // 
            this.maks.DataPropertyName = "maks";
            this.maks.HeaderText = "Mã khách sạn";
            this.maks.Name = "maks";
            this.maks.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.maks.Width = 90;
            // 
            // tenks
            // 
            this.tenks.DataPropertyName = "tenks";
            this.tenks.HeaderText = "Tên khách sạn";
            this.tenks.Name = "tenks";
            this.tenks.Width = 130;
            // 
            // diachi
            // 
            this.diachi.DataPropertyName = "diachi";
            this.diachi.HeaderText = "Địa chỉ";
            this.diachi.Name = "diachi";
            this.diachi.Width = 230;
            // 
            // sdt
            // 
            this.sdt.DataPropertyName = "sdt";
            this.sdt.HeaderText = "Số điện thoại";
            this.sdt.Name = "sdt";
            this.sdt.Width = 95;
            // 
            // frmKhachSan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 450);
            this.Controls.Add(this.btnTroVe);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnTaiLai);
            this.Controls.Add(this.dgvKhachSan);
            this.Controls.Add(this.pnlThongtinks);
            this.Name = "frmKhachSan";
            this.Text = "Quản lý khách sạn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmKhachSan_FormClosing);
            this.Load += new System.EventHandler(this.frmKhachSan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachSan)).EndInit();
            this.pnlThongtinks.ResumeLayout(false);
            this.pnlThongtinks.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTroVe;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnTaiLai;
        private System.Windows.Forms.DataGridView dgvKhachSan;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenks;
        private System.Windows.Forms.TextBox txtMaks;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlThongtinks;
        private System.Windows.Forms.DataGridViewTextBoxColumn maks;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenks;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
    }
}