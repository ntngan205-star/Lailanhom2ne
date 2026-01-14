namespace qlks
{
    partial class frmThemNhanVien
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
            this.btnThem = new System.Windows.Forms.Button();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtGioiTinh = new System.Windows.Forms.TextBox();
            this.txtTenNhanVien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTrangThai = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dtpNS = new System.Windows.Forms.DateTimePicker();
            this.dtpNNV = new System.Windows.Forms.DateTimePicker();
            this.cbTT = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(49, 504);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(122, 43);
            this.btnThem.TabIndex = 34;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(260, 321);
            this.txtSoDienThoai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoDienThoai.Multiline = true;
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(222, 41);
            this.txtSoDienThoai.TabIndex = 32;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(260, 262);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(222, 41);
            this.txtDiaChi.TabIndex = 33;
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.Location = new System.Drawing.Point(260, 205);
            this.txtGioiTinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGioiTinh.Multiline = true;
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.Size = new System.Drawing.Size(222, 41);
            this.txtGioiTinh.TabIndex = 31;
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.Location = new System.Drawing.Point(260, 91);
            this.txtTenNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenNhanVien.Multiline = true;
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.Size = new System.Drawing.Size(222, 41);
            this.txtTenNhanVien.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(44, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 26);
            this.label6.TabIndex = 26;
            this.label6.Text = "Số điện thoại:";
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Location = new System.Drawing.Point(260, 37);
            this.txtMaNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaNhanVien.Multiline = true;
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(222, 41);
            this.txtMaNhanVien.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 26);
            this.label5.TabIndex = 27;
            this.label5.Text = "Địa chỉ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 26);
            this.label4.TabIndex = 25;
            this.label4.Text = "Ngày sinh:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 26);
            this.label3.TabIndex = 24;
            this.label3.Text = "Giới tính:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 26);
            this.label2.TabIndex = 23;
            this.label2.Text = "Mã nhân viên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 26);
            this.label1.TabIndex = 22;
            this.label1.Text = "Tên nhân viên:";
            // 
            // txtTrangThai
            // 
            this.txtTrangThai.Location = new System.Drawing.Point(260, 440);
            this.txtTrangThai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTrangThai.Multiline = true;
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.Size = new System.Drawing.Size(222, 37);
            this.txtTrangThai.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(44, 440);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 26);
            this.label7.TabIndex = 35;
            this.label7.Text = "Trạng thái:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(44, 381);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 26);
            this.label8.TabIndex = 36;
            this.label8.Text = "Ngày nhận việc:";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(209, 504);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(122, 43);
            this.btnSua.TabIndex = 39;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(360, 504);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(122, 43);
            this.btnXoa.TabIndex = 40;
            this.btnXoa.Text = "Thoát";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // dtpNS
            // 
            this.dtpNS.Location = new System.Drawing.Point(260, 162);
            this.dtpNS.Name = "dtpNS";
            this.dtpNS.Size = new System.Drawing.Size(200, 22);
            this.dtpNS.TabIndex = 41;
            // 
            // dtpNNV
            // 
            this.dtpNNV.Location = new System.Drawing.Point(260, 385);
            this.dtpNNV.Name = "dtpNNV";
            this.dtpNNV.Size = new System.Drawing.Size(200, 22);
            this.dtpNNV.TabIndex = 42;
            // 
            // cbTT
            // 
            this.cbTT.AutoSize = true;
            this.cbTT.Location = new System.Drawing.Point(260, 456);
            this.cbTT.Name = "cbTT";
            this.cbTT.Size = new System.Drawing.Size(95, 20);
            this.cbTT.TabIndex = 43;
            this.cbTT.Text = "checkBox1";
            this.cbTT.UseVisualStyleBackColor = true;
            // 
            // frmThemNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 592);
            this.Controls.Add(this.cbTT);
            this.Controls.Add(this.dtpNNV);
            this.Controls.Add(this.dtpNS);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.txtTrangThai);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtSoDienThoai);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtGioiTinh);
            this.Controls.Add(this.txtTenNhanVien);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMaNhanVien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmThemNhanVien";
            this.Text = "Thêm nhân viên";
            this.Load += new System.EventHandler(this.frmThemNhanVien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtGioiTinh;
        private System.Windows.Forms.TextBox txtTenNhanVien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTrangThai;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DateTimePicker dtpNS;
        private System.Windows.Forms.DateTimePicker dtpNNV;
        private System.Windows.Forms.CheckBox cbTT;
    }
}