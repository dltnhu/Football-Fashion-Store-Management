namespace GUI
{
    partial class HoaDonModel
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            DanhSachChiTietSanPhamHoaDon = new DataGridView();
            x = new DataGridViewTextBoxColumn();
            TenSanPham = new DataGridViewTextBoxColumn();
            GiaSanPham = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            ThanhTien1 = new DataGridViewTextBoxColumn();
            txtMaNhanVien = new TextBox();
            label13 = new Label();
            txtKhachDua = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            txtMaKhachHang = new TextBox();
            textBox3 = new TextBox();
            label2 = new Label();
            txtTenKhachHang = new TextBox();
            textBox5 = new TextBox();
            lb3 = new Label();
            txtMaThue = new TextBox();
            textBox7 = new TextBox();
            label4 = new Label();
            txtMaKhuyenMai = new TextBox();
            textBox9 = new TextBox();
            label5 = new Label();
            txtThanhTien = new TextBox();
            label6 = new Label();
            textBox4 = new TextBox();
            label8 = new Label();
            txtThanhTien1 = new TextBox();
            label9 = new Label();
            txtTongTienDonHang = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DanhSachChiTietSanPhamHoaDon).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.AccessibleRole = AccessibleRole.TitleBar;
            groupBox1.Controls.Add(DanhSachChiTietSanPhamHoaDon);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1238, 271);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh Sách Chi Tiết Hóa Đơn";
            // 
            // DanhSachChiTietSanPhamHoaDon
            // 
            DanhSachChiTietSanPhamHoaDon.AllowUserToAddRows = false;
            DanhSachChiTietSanPhamHoaDon.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            DanhSachChiTietSanPhamHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            DanhSachChiTietSanPhamHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DanhSachChiTietSanPhamHoaDon.Columns.AddRange(new DataGridViewColumn[] { x, TenSanPham, GiaSanPham, SoLuong, ThanhTien1 });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            DanhSachChiTietSanPhamHoaDon.DefaultCellStyle = dataGridViewCellStyle4;
            DanhSachChiTietSanPhamHoaDon.Location = new Point(6, 27);
            DanhSachChiTietSanPhamHoaDon.Margin = new Padding(3, 4, 3, 4);
            DanhSachChiTietSanPhamHoaDon.Name = "DanhSachChiTietSanPhamHoaDon";
            DanhSachChiTietSanPhamHoaDon.RowHeadersWidth = 51;
            DanhSachChiTietSanPhamHoaDon.RowTemplate.Height = 24;
            DanhSachChiTietSanPhamHoaDon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DanhSachChiTietSanPhamHoaDon.Size = new Size(1226, 237);
            DanhSachChiTietSanPhamHoaDon.TabIndex = 1;
            DanhSachChiTietSanPhamHoaDon.CellContentClick += danhSachChiTietSanPham_CellContentClick;
            // 
            // x
            // 
            x.DataPropertyName = "MaHoaDon";
            x.HeaderText = "MaHoaDon";
            x.MinimumWidth = 6;
            x.Name = "x";
            x.ReadOnly = true;
            x.Resizable = DataGridViewTriState.True;
            x.Width = 125;
            // 
            // TenSanPham
            // 
            TenSanPham.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TenSanPham.DataPropertyName = "TenSanPham";
            TenSanPham.HeaderText = "Tên Sản Phẩm";
            TenSanPham.MinimumWidth = 6;
            TenSanPham.Name = "TenSanPham";
            TenSanPham.Resizable = DataGridViewTriState.True;
            TenSanPham.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // GiaSanPham
            // 
            GiaSanPham.DataPropertyName = "GiaSanPham";
            GiaSanPham.HeaderText = "Giá";
            GiaSanPham.MinimumWidth = 6;
            GiaSanPham.Name = "GiaSanPham";
            GiaSanPham.Resizable = DataGridViewTriState.True;
            GiaSanPham.SortMode = DataGridViewColumnSortMode.NotSortable;
            GiaSanPham.Width = 125;
            // 
            // SoLuong
            // 
            SoLuong.DataPropertyName = "SoLuong";
            SoLuong.HeaderText = "Số Lượng";
            SoLuong.MinimumWidth = 6;
            SoLuong.Name = "SoLuong";
            SoLuong.Resizable = DataGridViewTriState.True;
            SoLuong.SortMode = DataGridViewColumnSortMode.NotSortable;
            SoLuong.Width = 125;
            // 
            // ThanhTien1
            // 
            ThanhTien1.DataPropertyName = "ThanhTien";
            ThanhTien1.HeaderText = "Thành Tiền";
            ThanhTien1.MinimumWidth = 6;
            ThanhTien1.Name = "ThanhTien1";
            ThanhTien1.Resizable = DataGridViewTriState.True;
            ThanhTien1.SortMode = DataGridViewColumnSortMode.NotSortable;
            ThanhTien1.Width = 125;
            // 
            // txtMaNhanVien
            // 
            txtMaNhanVien.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaNhanVien.ForeColor = SystemColors.ControlText;
            txtMaNhanVien.Location = new Point(18, 310);
            txtMaNhanVien.Margin = new Padding(3, 4, 3, 4);
            txtMaNhanVien.Name = "txtMaNhanVien";
            txtMaNhanVien.ReadOnly = true;
            txtMaNhanVien.Size = new Size(235, 30);
            txtMaNhanVien.TabIndex = 35;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.White;
            label13.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = SystemColors.ControlText;
            label13.Location = new Point(18, 284);
            label13.Name = "label13";
            label13.Size = new Size(120, 22);
            label13.TabIndex = 34;
            label13.Text = "Mã Nhân Viên";
            // 
            // txtKhachDua
            // 
            txtKhachDua.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtKhachDua.ForeColor = SystemColors.ActiveCaptionText;
            txtKhachDua.Location = new Point(362, 857);
            txtKhachDua.Margin = new Padding(3, 4, 3, 4);
            txtKhachDua.Name = "txtKhachDua";
            txtKhachDua.Size = new Size(263, 30);
            txtKhachDua.TabIndex = 33;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = SystemColors.ActiveCaptionText;
            textBox1.Location = new Point(362, 923);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(263, 30);
            textBox1.TabIndex = 33;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(18, 344);
            label1.Name = "label1";
            label1.Size = new Size(132, 22);
            label1.TabIndex = 34;
            label1.Text = "Mã Khách Hàng";
            // 
            // txtMaKhachHang
            // 
            txtMaKhachHang.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaKhachHang.ForeColor = SystemColors.ControlText;
            txtMaKhachHang.Location = new Point(18, 370);
            txtMaKhachHang.Margin = new Padding(3, 4, 3, 4);
            txtMaKhachHang.Name = "txtMaKhachHang";
            txtMaKhachHang.ReadOnly = true;
            txtMaKhachHang.Size = new Size(235, 30);
            txtMaKhachHang.TabIndex = 35;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.ForeColor = SystemColors.ActiveCaptionText;
            textBox3.Location = new Point(362, 991);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(263, 30);
            textBox3.TabIndex = 33;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(18, 404);
            label2.Name = "label2";
            label2.Size = new Size(138, 22);
            label2.TabIndex = 34;
            label2.Text = "Tên Khách Hàng:";
            label2.Click += label2_Click_1;
            // 
            // txtTenKhachHang
            // 
            txtTenKhachHang.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenKhachHang.ForeColor = SystemColors.ControlText;
            txtTenKhachHang.Location = new Point(18, 430);
            txtTenKhachHang.Margin = new Padding(3, 4, 3, 4);
            txtTenKhachHang.Name = "txtTenKhachHang";
            txtTenKhachHang.ReadOnly = true;
            txtTenKhachHang.Size = new Size(235, 30);
            txtTenKhachHang.TabIndex = 35;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.ForeColor = SystemColors.ActiveCaptionText;
            textBox5.Location = new Point(1353, 857);
            textBox5.Margin = new Padding(3, 4, 3, 4);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(263, 30);
            textBox5.TabIndex = 33;
            // 
            // lb3
            // 
            lb3.AutoSize = true;
            lb3.BackColor = Color.White;
            lb3.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lb3.ForeColor = SystemColors.ControlText;
            lb3.Location = new Point(376, 318);
            lb3.Name = "lb3";
            lb3.Size = new Size(77, 22);
            lb3.TabIndex = 34;
            lb3.Text = "Mã Thuế";
            // 
            // txtMaThue
            // 
            txtMaThue.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaThue.ForeColor = SystemColors.ControlText;
            txtMaThue.Location = new Point(376, 344);
            txtMaThue.Margin = new Padding(3, 4, 3, 4);
            txtMaThue.Name = "txtMaThue";
            txtMaThue.ReadOnly = true;
            txtMaThue.Size = new Size(235, 30);
            txtMaThue.TabIndex = 35;
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox7.ForeColor = SystemColors.ActiveCaptionText;
            textBox7.Location = new Point(1353, 897);
            textBox7.Margin = new Padding(3, 4, 3, 4);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(263, 30);
            textBox7.TabIndex = 33;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(661, 318);
            label4.Name = "label4";
            label4.Size = new Size(100, 22);
            label4.TabIndex = 34;
            label4.Text = "Khuyến Mãi";
            // 
            // txtMaKhuyenMai
            // 
            txtMaKhuyenMai.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaKhuyenMai.ForeColor = SystemColors.ControlText;
            txtMaKhuyenMai.Location = new Point(661, 344);
            txtMaKhuyenMai.Margin = new Padding(3, 4, 3, 4);
            txtMaKhuyenMai.Name = "txtMaKhuyenMai";
            txtMaKhuyenMai.ReadOnly = true;
            txtMaKhuyenMai.Size = new Size(235, 30);
            txtMaKhuyenMai.TabIndex = 35;
            // 
            // textBox9
            // 
            textBox9.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox9.ForeColor = SystemColors.ActiveCaptionText;
            textBox9.Location = new Point(1353, 977);
            textBox9.Margin = new Padding(3, 4, 3, 4);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(263, 30);
            textBox9.TabIndex = 33;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(1009, 404);
            label5.Name = "label5";
            label5.Size = new Size(95, 22);
            label5.TabIndex = 34;
            label5.Text = "Thành Tiền";
            // 
            // txtThanhTien
            // 
            txtThanhTien.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtThanhTien.ForeColor = SystemColors.ControlText;
            txtThanhTien.Location = new Point(1009, 430);
            txtThanhTien.Margin = new Padding(3, 4, 3, 4);
            txtThanhTien.Name = "txtThanhTien";
            txtThanhTien.ReadOnly = true;
            txtThanhTien.Size = new Size(235, 30);
            txtThanhTien.TabIndex = 35;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlText;
            label6.Location = new Point(1009, 490);
            label6.Name = "label6";
            label6.Size = new Size(95, 22);
            label6.TabIndex = 34;
            label6.Text = "Thành Tiền";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.ForeColor = SystemColors.ControlText;
            textBox4.Location = new Point(1009, 516);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(235, 30);
            textBox4.TabIndex = 35;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ControlText;
            label8.Location = new Point(1009, 404);
            label8.Name = "label8";
            label8.Size = new Size(95, 22);
            label8.TabIndex = 34;
            label8.Text = "Thành Tiền";
            // 
            // txtThanhTien1
            // 
            txtThanhTien1.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtThanhTien1.ForeColor = SystemColors.ControlText;
            txtThanhTien1.Location = new Point(1009, 430);
            txtThanhTien1.Margin = new Padding(3, 4, 3, 4);
            txtThanhTien1.Name = "txtThanhTien1";
            txtThanhTien1.ReadOnly = true;
            txtThanhTien1.Size = new Size(235, 30);
            txtThanhTien1.TabIndex = 35;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ControlText;
            label9.Location = new Point(1009, 334);
            label9.Name = "label9";
            label9.Size = new Size(162, 22);
            label9.TabIndex = 34;
            label9.Text = "Tổng tiền đơn hàng";
            // 
            // txtTongTienDonHang
            // 
            txtTongTienDonHang.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtTongTienDonHang.ForeColor = SystemColors.ControlText;
            txtTongTienDonHang.Location = new Point(1009, 360);
            txtTongTienDonHang.Margin = new Padding(3, 4, 3, 4);
            txtTongTienDonHang.Name = "txtTongTienDonHang";
            txtTongTienDonHang.ReadOnly = true;
            txtTongTienDonHang.Size = new Size(235, 30);
            txtTongTienDonHang.TabIndex = 35;
            // 
            // HoaDonModel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 473);
            Controls.Add(textBox4);
            Controls.Add(txtTongTienDonHang);
            Controls.Add(txtThanhTien1);
            Controls.Add(label9);
            Controls.Add(txtThanhTien);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtMaKhuyenMai);
            Controls.Add(label4);
            Controls.Add(txtMaThue);
            Controls.Add(lb3);
            Controls.Add(txtTenKhachHang);
            Controls.Add(textBox9);
            Controls.Add(label2);
            Controls.Add(textBox7);
            Controls.Add(txtMaKhachHang);
            Controls.Add(textBox5);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(txtMaNhanVien);
            Controls.Add(textBox1);
            Controls.Add(label13);
            Controls.Add(txtKhachDua);
            Controls.Add(groupBox1);
            Name = "HoaDonModel";
            StartPosition = FormStartPosition.CenterParent;
            Text = "HoaDonModel";
            Load += HoaDonModel_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DanhSachChiTietSanPhamHoaDon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView DanhSachChiTietSanPhamHoaDon;
        private DataGridViewTextBoxColumn x;
        private DataGridViewTextBoxColumn TenSanPham;
        private DataGridViewTextBoxColumn GiaSanPham;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn ThanhTien1;
        public TextBox txtMaNhanVien;
        private Label label13;
        public TextBox txtKhachDua;
        private TextBox textBox1;
        private Label label1;
        public TextBox txtMaKhachHang;
        public TextBox textBox3;
        private Label label2;
        public TextBox txtTenKhachHang;
        public TextBox textBox5;
        private Label lb3;
        public TextBox txtMaThue;
        public TextBox textBox7;
        private Label label4;
        public TextBox txtMaKhuyenMai;
        public TextBox textBox9;
        private Label label5;
        public TextBox txtThanhTien;
        private Label label3;
        public TextBox txtTongTienKhuyenMai;
        private Label label6;
        public TextBox textBox4;
        private Label label7;
        public TextBox txtTongTienThue;
        private Label label8;
        public TextBox txtThanhTien1;
        private Label label9;
        public TextBox txtTongTienDonHang;
    }
}