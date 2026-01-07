namespace nhom2huongdan
{
    partial class datphongttinphong
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.dtpCheckOut = new System.Windows.Forms.DateTimePicker();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dgvPhongDaChon = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgvDeXuatPhong = new System.Windows.Forms.DataGridView();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdoKieuPhongTatCa = new System.Windows.Forms.RadioButton();
            this.rdoKieuPhongNangCao = new System.Windows.Forms.RadioButton();
            this.rdoKieuPhongTieuChuan = new System.Windows.Forms.RadioButton();
            this.rdoKieuPhongVIP = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.rdoLoaiPhongTatCa = new System.Windows.Forms.RadioButton();
            this.rdoLoaiPhongGiaDinh = new System.Windows.Forms.RadioButton();
            this.rdoLoaiPhongDoi = new System.Windows.Forms.RadioButton();
            this.rdoLoaiPhongDon = new System.Windows.Forms.RadioButton();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongDaChon)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeXuatPhong)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox2.Controls.Add(this.btnThanhToan);
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.btnQuayLai);
            this.groupBox2.Controls.Add(this.groupBox7);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1178, 815);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin phòng";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(936, 677);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(300, 81);
            this.btnThanhToan.TabIndex = 22;
            this.btnThanhToan.Text = "Thanh toán đặt phòng";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.SkyBlue;
            this.groupBox6.Controls.Add(this.groupBox10);
            this.groupBox6.Controls.Add(this.groupBox9);
            this.groupBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox6.Location = new System.Drawing.Point(39, 53);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(254, 237);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Thời gian";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.dtpCheckOut);
            this.groupBox10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox10.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox10.Location = new System.Drawing.Point(3, 128);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(248, 106);
            this.groupBox10.TabIndex = 1;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Check-out";
            // 
            // dtpCheckOut
            // 
            this.dtpCheckOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCheckOut.Location = new System.Drawing.Point(3, 33);
            this.dtpCheckOut.Name = "dtpCheckOut";
            this.dtpCheckOut.Size = new System.Drawing.Size(242, 37);
            this.dtpCheckOut.TabIndex = 9;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.dtpCheckIn);
            this.groupBox9.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox9.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox9.Location = new System.Drawing.Point(3, 36);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(248, 92);
            this.groupBox9.TabIndex = 0;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Check-in";
            // 
            // dtpCheckIn
            // 
            this.dtpCheckIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCheckIn.Location = new System.Drawing.Point(3, 33);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.Size = new System.Drawing.Size(242, 37);
            this.dtpCheckIn.TabIndex = 9;
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Location = new System.Drawing.Point(718, 677);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(196, 81);
            this.btnQuayLai.TabIndex = 23;
            this.btnQuayLai.Text = "Quay lại";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.dgvPhongDaChon);
            this.groupBox7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(330, 394);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(909, 257);
            this.groupBox7.TabIndex = 9;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Phòng đã chọn";
            // 
            // dgvPhongDaChon
            // 
            this.dgvPhongDaChon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhongDaChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhongDaChon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvPhongDaChon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhongDaChon.Location = new System.Drawing.Point(3, 31);
            this.dgvPhongDaChon.Name = "dgvPhongDaChon";
            this.dgvPhongDaChon.RowHeadersWidth = 62;
            this.dgvPhongDaChon.RowTemplate.Height = 28;
            this.dgvPhongDaChon.Size = new System.Drawing.Size(903, 223);
            this.dgvPhongDaChon.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã phòng";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Số phòng";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tầng";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Kiểu phòng";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Loại phòng";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgvDeXuatPhong);
            this.groupBox5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(330, 44);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(909, 331);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Đề xuất phòng";
            // 
            // dgvDeXuatPhong
            // 
            this.dgvDeXuatPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDeXuatPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeXuatPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhong,
            this.SoPhong,
            this.Tang,
            this.TenKP,
            this.TenLP});
            this.dgvDeXuatPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDeXuatPhong.Location = new System.Drawing.Point(3, 31);
            this.dgvDeXuatPhong.Name = "dgvDeXuatPhong";
            this.dgvDeXuatPhong.RowHeadersWidth = 62;
            this.dgvDeXuatPhong.RowTemplate.Height = 28;
            this.dgvDeXuatPhong.Size = new System.Drawing.Size(903, 297);
            this.dgvDeXuatPhong.TabIndex = 4;
            // 
            // MaPhong
            // 
            this.MaPhong.DataPropertyName = "MaPhong";
            this.MaPhong.HeaderText = "Mã phòng";
            this.MaPhong.MinimumWidth = 8;
            this.MaPhong.Name = "MaPhong";
            // 
            // SoPhong
            // 
            this.SoPhong.DataPropertyName = "SoPhong";
            this.SoPhong.HeaderText = "Số phòng";
            this.SoPhong.MinimumWidth = 8;
            this.SoPhong.Name = "SoPhong";
            // 
            // Tang
            // 
            this.Tang.DataPropertyName = "Tang";
            this.Tang.HeaderText = "Tầng";
            this.Tang.MinimumWidth = 8;
            this.Tang.Name = "Tang";
            // 
            // TenKP
            // 
            this.TenKP.DataPropertyName = "TenKP";
            this.TenKP.HeaderText = "Kiểu phòng";
            this.TenKP.MinimumWidth = 8;
            this.TenKP.Name = "TenKP";
            // 
            // TenLP
            // 
            this.TenLP.DataPropertyName = "TenLP";
            this.TenLP.HeaderText = "Loại phòng";
            this.TenLP.MinimumWidth = 8;
            this.TenLP.Name = "TenLP";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.MediumTurquoise;
            this.groupBox4.Controls.Add(this.rdoKieuPhongTatCa);
            this.groupBox4.Controls.Add(this.rdoKieuPhongNangCao);
            this.groupBox4.Controls.Add(this.rdoKieuPhongTieuChuan);
            this.groupBox4.Controls.Add(this.rdoKieuPhongVIP);
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox4.Location = new System.Drawing.Point(39, 556);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(254, 219);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Kiểu phòng:";
            // 
            // rdoKieuPhongTatCa
            // 
            this.rdoKieuPhongTatCa.AutoSize = true;
            this.rdoKieuPhongTatCa.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoKieuPhongTatCa.Location = new System.Drawing.Point(38, 46);
            this.rdoKieuPhongTatCa.Name = "rdoKieuPhongTatCa";
            this.rdoKieuPhongTatCa.Size = new System.Drawing.Size(104, 33);
            this.rdoKieuPhongTatCa.TabIndex = 1;
            this.rdoKieuPhongTatCa.TabStop = true;
            this.rdoKieuPhongTatCa.Text = "Tất cả";
            this.rdoKieuPhongTatCa.UseVisualStyleBackColor = true;
            // 
            // rdoKieuPhongNangCao
            // 
            this.rdoKieuPhongNangCao.AutoSize = true;
            this.rdoKieuPhongNangCao.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoKieuPhongNangCao.Location = new System.Drawing.Point(38, 122);
            this.rdoKieuPhongNangCao.Name = "rdoKieuPhongNangCao";
            this.rdoKieuPhongNangCao.Size = new System.Drawing.Size(138, 33);
            this.rdoKieuPhongNangCao.TabIndex = 0;
            this.rdoKieuPhongNangCao.TabStop = true;
            this.rdoKieuPhongNangCao.Text = "Nâng cao";
            this.rdoKieuPhongNangCao.UseVisualStyleBackColor = true;
            // 
            // rdoKieuPhongTieuChuan
            // 
            this.rdoKieuPhongTieuChuan.AutoSize = true;
            this.rdoKieuPhongTieuChuan.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoKieuPhongTieuChuan.Location = new System.Drawing.Point(38, 165);
            this.rdoKieuPhongTieuChuan.Name = "rdoKieuPhongTieuChuan";
            this.rdoKieuPhongTieuChuan.Size = new System.Drawing.Size(154, 33);
            this.rdoKieuPhongTieuChuan.TabIndex = 0;
            this.rdoKieuPhongTieuChuan.TabStop = true;
            this.rdoKieuPhongTieuChuan.Text = "Tiêu chuẩn";
            this.rdoKieuPhongTieuChuan.UseVisualStyleBackColor = true;
            // 
            // rdoKieuPhongVIP
            // 
            this.rdoKieuPhongVIP.AutoSize = true;
            this.rdoKieuPhongVIP.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoKieuPhongVIP.Location = new System.Drawing.Point(38, 83);
            this.rdoKieuPhongVIP.Name = "rdoKieuPhongVIP";
            this.rdoKieuPhongVIP.Size = new System.Drawing.Size(80, 33);
            this.rdoKieuPhongVIP.TabIndex = 0;
            this.rdoKieuPhongVIP.TabStop = true;
            this.rdoKieuPhongVIP.Text = "VIP";
            this.rdoKieuPhongVIP.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox3.Controls.Add(this.radioButton4);
            this.groupBox3.Controls.Add(this.rdoLoaiPhongTatCa);
            this.groupBox3.Controls.Add(this.rdoLoaiPhongGiaDinh);
            this.groupBox3.Controls.Add(this.rdoLoaiPhongDoi);
            this.groupBox3.Controls.Add(this.rdoLoaiPhongDon);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox3.Location = new System.Drawing.Point(36, 313);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(254, 219);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Loại phòng:";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(284, 110);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(201, 36);
            this.radioButton4.TabIndex = 0;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "radioButton1";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // rdoLoaiPhongTatCa
            // 
            this.rdoLoaiPhongTatCa.AutoSize = true;
            this.rdoLoaiPhongTatCa.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoLoaiPhongTatCa.Location = new System.Drawing.Point(38, 44);
            this.rdoLoaiPhongTatCa.Name = "rdoLoaiPhongTatCa";
            this.rdoLoaiPhongTatCa.Size = new System.Drawing.Size(104, 33);
            this.rdoLoaiPhongTatCa.TabIndex = 1;
            this.rdoLoaiPhongTatCa.TabStop = true;
            this.rdoLoaiPhongTatCa.Text = "Tất cả";
            this.rdoLoaiPhongTatCa.UseVisualStyleBackColor = true;
            // 
            // rdoLoaiPhongGiaDinh
            // 
            this.rdoLoaiPhongGiaDinh.AutoSize = true;
            this.rdoLoaiPhongGiaDinh.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoLoaiPhongGiaDinh.Location = new System.Drawing.Point(38, 167);
            this.rdoLoaiPhongGiaDinh.Name = "rdoLoaiPhongGiaDinh";
            this.rdoLoaiPhongGiaDinh.Size = new System.Drawing.Size(126, 33);
            this.rdoLoaiPhongGiaDinh.TabIndex = 0;
            this.rdoLoaiPhongGiaDinh.TabStop = true;
            this.rdoLoaiPhongGiaDinh.Text = "Gia đình";
            this.rdoLoaiPhongGiaDinh.UseVisualStyleBackColor = true;
            // 
            // rdoLoaiPhongDoi
            // 
            this.rdoLoaiPhongDoi.AutoSize = true;
            this.rdoLoaiPhongDoi.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoLoaiPhongDoi.Location = new System.Drawing.Point(38, 124);
            this.rdoLoaiPhongDoi.Name = "rdoLoaiPhongDoi";
            this.rdoLoaiPhongDoi.Size = new System.Drawing.Size(76, 33);
            this.rdoLoaiPhongDoi.TabIndex = 0;
            this.rdoLoaiPhongDoi.TabStop = true;
            this.rdoLoaiPhongDoi.Text = "Đôi";
            this.rdoLoaiPhongDoi.UseVisualStyleBackColor = true;
            // 
            // rdoLoaiPhongDon
            // 
            this.rdoLoaiPhongDon.AutoSize = true;
            this.rdoLoaiPhongDon.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoLoaiPhongDon.Location = new System.Drawing.Point(38, 84);
            this.rdoLoaiPhongDon.Name = "rdoLoaiPhongDon";
            this.rdoLoaiPhongDon.Size = new System.Drawing.Size(84, 33);
            this.rdoLoaiPhongDon.TabIndex = 0;
            this.rdoLoaiPhongDon.TabStop = true;
            this.rdoLoaiPhongDon.Text = "Đơn";
            this.rdoLoaiPhongDon.UseVisualStyleBackColor = true;
            // 
            // datphongttinphong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Name = "datphongttinphong";
            this.Size = new System.Drawing.Size(1178, 815);
            this.groupBox2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongDaChon)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeXuatPhong)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.DateTimePicker dtpCheckOut;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.DateTimePicker dtpCheckIn;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DataGridView dgvPhongDaChon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewButtonColumn Column6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dgvDeXuatPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLP;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rdoKieuPhongTatCa;
        private System.Windows.Forms.RadioButton rdoKieuPhongNangCao;
        private System.Windows.Forms.RadioButton rdoKieuPhongTieuChuan;
        private System.Windows.Forms.RadioButton rdoKieuPhongVIP;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton rdoLoaiPhongTatCa;
        private System.Windows.Forms.RadioButton rdoLoaiPhongGiaDinh;
        private System.Windows.Forms.RadioButton rdoLoaiPhongDoi;
        private System.Windows.Forms.RadioButton rdoLoaiPhongDon;
    }
}
