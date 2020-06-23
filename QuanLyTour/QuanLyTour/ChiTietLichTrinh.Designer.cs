namespace QuanLyTour
{
    partial class ChiTietLichTrinh
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
            this.lblLichTrinh = new System.Windows.Forms.Label();
            this.btnTroVe = new System.Windows.Forms.Button();
            this.dtpGio = new System.Windows.Forms.DateTimePicker();
            this.Giờ = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboDiaDanh = new System.Windows.Forms.ComboBox();
            this.cboPhuongTien = new System.Windows.Forms.ComboBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNgay = new System.Windows.Forms.Label();
            this.txtMatour = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLichTrinh
            // 
            this.lblLichTrinh.AutoSize = true;
            this.lblLichTrinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLichTrinh.Location = new System.Drawing.Point(128, 26);
            this.lblLichTrinh.Name = "lblLichTrinh";
            this.lblLichTrinh.Size = new System.Drawing.Size(76, 25);
            this.lblLichTrinh.TabIndex = 0;
            this.lblLichTrinh.Text = "label1";
            // 
            // btnTroVe
            // 
            this.btnTroVe.Location = new System.Drawing.Point(222, 333);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(75, 23);
            this.btnTroVe.TabIndex = 1;
            this.btnTroVe.Text = "Trở về";
            this.btnTroVe.UseVisualStyleBackColor = true;
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // dtpGio
            // 
            this.dtpGio.CustomFormat = "hh:mm:ss tt";
            this.dtpGio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpGio.Location = new System.Drawing.Point(133, 142);
            this.dtpGio.Name = "dtpGio";
            this.dtpGio.Size = new System.Drawing.Size(200, 20);
            this.dtpGio.TabIndex = 2;
            // 
            // Giờ
            // 
            this.Giờ.AutoSize = true;
            this.Giờ.Location = new System.Drawing.Point(28, 142);
            this.Giờ.Name = "Giờ";
            this.Giờ.Size = new System.Drawing.Size(23, 13);
            this.Giờ.TabIndex = 3;
            this.Giờ.Text = "Giờ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Địa danh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Phương tiện";
            // 
            // cboDiaDanh
            // 
            this.cboDiaDanh.FormattingEnabled = true;
            this.cboDiaDanh.Location = new System.Drawing.Point(133, 194);
            this.cboDiaDanh.Name = "cboDiaDanh";
            this.cboDiaDanh.Size = new System.Drawing.Size(200, 21);
            this.cboDiaDanh.TabIndex = 6;
            // 
            // cboPhuongTien
            // 
            this.cboPhuongTien.FormattingEnabled = true;
            this.cboPhuongTien.Location = new System.Drawing.Point(133, 251);
            this.cboPhuongTien.Name = "cboPhuongTien";
            this.cboPhuongTien.Size = new System.Drawing.Size(200, 21);
            this.cboPhuongTien.TabIndex = 7;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(84, 333);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 8;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mã tour";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ngày";
            // 
            // txtNgay
            // 
            this.txtNgay.AutoSize = true;
            this.txtNgay.Location = new System.Drawing.Point(133, 102);
            this.txtNgay.Name = "txtNgay";
            this.txtNgay.Size = new System.Drawing.Size(35, 13);
            this.txtNgay.TabIndex = 11;
            this.txtNgay.Text = "label5";
            // 
            // txtMatour
            // 
            this.txtMatour.AutoSize = true;
            this.txtMatour.Location = new System.Drawing.Point(133, 63);
            this.txtMatour.Name = "txtMatour";
            this.txtMatour.Size = new System.Drawing.Size(35, 13);
            this.txtMatour.TabIndex = 12;
            this.txtMatour.Text = "label6";
            // 
            // ChiTietLichTrinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 389);
            this.Controls.Add(this.txtMatour);
            this.Controls.Add(this.txtNgay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.cboPhuongTien);
            this.Controls.Add(this.cboDiaDanh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Giờ);
            this.Controls.Add(this.dtpGio);
            this.Controls.Add(this.btnTroVe);
            this.Controls.Add(this.lblLichTrinh);
            this.Name = "ChiTietLichTrinh";
            this.Text = "Chi tiết lịch trình";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChiTietLichTrinh_FormClosing);
            this.Load += new System.EventHandler(this.ChiTietLichTrinh_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLichTrinh;
        private System.Windows.Forms.Button btnTroVe;
        private System.Windows.Forms.DateTimePicker dtpGio;
        private System.Windows.Forms.Label Giờ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboDiaDanh;
        private System.Windows.Forms.ComboBox cboPhuongTien;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtNgay;
        private System.Windows.Forms.Label txtMatour;
    }
}