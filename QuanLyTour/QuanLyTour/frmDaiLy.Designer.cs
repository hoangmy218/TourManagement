namespace QuanLyTour
{
    partial class frmDaiLy
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
            this.components = new System.ComponentModel.Container();
            this.pnlDaily = new System.Windows.Forms.Panel();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenDL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.txtMaDL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDaily = new System.Windows.Forms.DataGridView();
            this.btnTaiLai = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnTroVe = new System.Windows.Forms.Button();
            this.dailyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyTourDataSet = new QuanLyTour.QuanLyTourDataSet();
            this.diBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diTableAdapter = new QuanLyTour.QuanLyTourDataSetTableAdapters.diTableAdapter();
            this.dailyTableAdapter = new QuanLyTour.QuanLyTourDataSetTableAdapters.dailyTableAdapter();
            this.madl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tendl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlDaily.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaily)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dailyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyTourDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDaily
            // 
            this.pnlDaily.Controls.Add(this.txtDiaChi);
            this.pnlDaily.Controls.Add(this.txtTenDL);
            this.pnlDaily.Controls.Add(this.label3);
            this.pnlDaily.Controls.Add(this.label4);
            this.pnlDaily.Controls.Add(this.txtSdt);
            this.pnlDaily.Controls.Add(this.txtMaDL);
            this.pnlDaily.Controls.Add(this.label2);
            this.pnlDaily.Controls.Add(this.label1);
            this.pnlDaily.Location = new System.Drawing.Point(13, 13);
            this.pnlDaily.Name = "pnlDaily";
            this.pnlDaily.Size = new System.Drawing.Size(642, 100);
            this.pnlDaily.TabIndex = 0;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(307, 60);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(290, 20);
            this.txtDiaChi.TabIndex = 7;
            // 
            // txtTenDL
            // 
            this.txtTenDL.Location = new System.Drawing.Point(307, 14);
            this.txtTenDL.Name = "txtTenDL";
            this.txtTenDL.Size = new System.Drawing.Size(290, 20);
            this.txtTenDL.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(239, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tên đại lý";
            // 
            // txtSdt
            // 
            this.txtSdt.Location = new System.Drawing.Point(95, 60);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(100, 20);
            this.txtSdt.TabIndex = 3;
            // 
            // txtMaDL
            // 
            this.txtMaDL.Location = new System.Drawing.Point(95, 14);
            this.txtMaDL.Name = "txtMaDL";
            this.txtMaDL.Size = new System.Drawing.Size(100, 20);
            this.txtMaDL.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số điện thoại";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã đại lý";
            // 
            // dgvDaily
            // 
            this.dgvDaily.AutoGenerateColumns = false;
            this.dgvDaily.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDaily.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.madl,
            this.tendl,
            this.diachi,
            this.sdt});
            this.dgvDaily.DataSource = this.dailyBindingSource;
            this.dgvDaily.Location = new System.Drawing.Point(13, 139);
            this.dgvDaily.Name = "dgvDaily";
            this.dgvDaily.Size = new System.Drawing.Size(642, 150);
            this.dgvDaily.TabIndex = 1;
            this.dgvDaily.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDaily_CellClick);
            // 
            // btnTaiLai
            // 
            this.btnTaiLai.Location = new System.Drawing.Point(43, 341);
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.Size = new System.Drawing.Size(75, 23);
            this.btnTaiLai.TabIndex = 2;
            this.btnTaiLai.Text = "Tải lại";
            this.btnTaiLai.UseVisualStyleBackColor = true;
            this.btnTaiLai.Click += new System.EventHandler(this.btnTaiLai_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(133, 341);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(231, 341);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(320, 341);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 5;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(406, 341);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 6;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnTroVe
            // 
            this.btnTroVe.Location = new System.Drawing.Point(504, 341);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(75, 23);
            this.btnTroVe.TabIndex = 7;
            this.btnTroVe.Text = "Trở về";
            this.btnTroVe.UseVisualStyleBackColor = true;
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // dailyBindingSource
            // 
            this.dailyBindingSource.DataMember = "daily";
            this.dailyBindingSource.DataSource = this.quanLyTourDataSet;
            // 
            // quanLyTourDataSet
            // 
            this.quanLyTourDataSet.DataSetName = "QuanLyTourDataSet";
            this.quanLyTourDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // diBindingSource
            // 
            this.diBindingSource.DataMember = "di";
            this.diBindingSource.DataSource = this.quanLyTourDataSet;
            // 
            // diTableAdapter
            // 
            this.diTableAdapter.ClearBeforeFill = true;
            // 
            // dailyTableAdapter
            // 
            this.dailyTableAdapter.ClearBeforeFill = true;
            // 
            // madl
            // 
            this.madl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.madl.DataPropertyName = "madl";
            this.madl.HeaderText = "Mã đại lý";
            this.madl.Name = "madl";
            // 
            // tendl
            // 
            this.tendl.DataPropertyName = "tendl";
            this.tendl.HeaderText = "Tên đại lý";
            this.tendl.Name = "tendl";
            this.tendl.Width = 150;
            // 
            // diachi
            // 
            this.diachi.DataPropertyName = "diachi";
            this.diachi.HeaderText = "Địa chỉ";
            this.diachi.Name = "diachi";
            this.diachi.Width = 245;
            // 
            // sdt
            // 
            this.sdt.DataPropertyName = "sdt";
            this.sdt.HeaderText = "Số điện thoại";
            this.sdt.Name = "sdt";
            // 
            // frmDaiLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 450);
            this.Controls.Add(this.btnTroVe);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnTaiLai);
            this.Controls.Add(this.dgvDaily);
            this.Controls.Add(this.pnlDaily);
            this.Name = "frmDaiLy";
            this.Text = "Quản lý đại lý";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDaiLy_FormClosing);
            this.Load += new System.EventHandler(this.DaiLy_Load);
            this.pnlDaily.ResumeLayout(false);
            this.pnlDaily.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaily)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dailyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyTourDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDaily;
        private System.Windows.Forms.DataGridView dgvDaily;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenDL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.TextBox txtMaDL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private QuanLyTourDataSet quanLyTourDataSet;
        private System.Windows.Forms.BindingSource diBindingSource;
        private QuanLyTourDataSetTableAdapters.diTableAdapter diTableAdapter;
        private System.Windows.Forms.BindingSource dailyBindingSource;
        private QuanLyTourDataSetTableAdapters.dailyTableAdapter dailyTableAdapter;
        private System.Windows.Forms.Button btnTaiLai;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnTroVe;
        private System.Windows.Forms.DataGridViewTextBoxColumn madl;
        private System.Windows.Forms.DataGridViewTextBoxColumn tendl;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
    }
}