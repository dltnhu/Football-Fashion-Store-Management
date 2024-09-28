namespace GUI
{
    partial class PhieuNhapModule
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhieuNhapModule));
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            txtTienNhap = new TextBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            buttonLuuPhieuNhap = new Button();
            buttonThoat = new Button();
            danhSachChiTietPhieuNhap = new DataGridView();
            MaChiTietSP = new DataGridViewTextBoxColumn();
            MauSac = new DataGridViewTextBoxColumn();
            KichCo = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            DonVi = new DataGridViewTextBoxColumn();
            TienNhap = new DataGridViewTextBoxColumn();
            ThanhTien = new DataGridViewTextBoxColumn();
            txtTenNhanVien = new TextBox();
            panel2 = new Panel();
            label2 = new Label();
            danhSachChiTietSanPham = new DataGridView();
            MaChiTietSanPham = new DataGridViewTextBoxColumn();
            MaSanPham = new DataGridViewTextBoxColumn();
            MaMauSac = new DataGridViewTextBoxColumn();
            MaKichCo = new DataGridViewTextBoxColumn();
            HinhAnh = new DataGridViewImageColumn();
            SoLuongNhap = new DataGridViewTextBoxColumn();
            SoLuongTon = new DataGridViewTextBoxColumn();
            label5 = new Label();
            txtMaPhieuNhap = new TextBox();
            label3 = new Label();
            comboxNhaCungCap = new ComboBox();
            txtNgayNhap = new TextBox();
            labelGiaNhap = new Label();
            txtTongTien = new TextBox();
            labelGiaSanPham = new Label();
            txtTenPhieuNhap = new TextBox();
            labelTenSanPham = new Label();
            labelTheLoai = new Label();
            btnThem = new Button();
            slNhap = new NumericUpDown();
            comboxDonVi = new ComboBox();
            txtMaChiTietSanPham = new TextBox();
            label1 = new Label();
            btnSua = new Button();
            ((System.ComponentModel.ISupportInitialize)danhSachChiTietPhieuNhap).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)danhSachChiTietSanPham).BeginInit();
            ((System.ComponentModel.ISupportInitialize)slNhap).BeginInit();
            SuspendLayout();
            // 
            // txtTienNhap
            // 
            txtTienNhap.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtTienNhap.Location = new Point(1464, 506);
            txtTienNhap.Name = "txtTienNhap";
            txtTienNhap.ReadOnly = true;
            txtTienNhap.Size = new Size(221, 34);
            txtTienNhap.TabIndex = 130;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.MediumSeaGreen;
            label13.Location = new Point(1356, 508);
            label13.Name = "label13";
            label13.Size = new Size(102, 27);
            label13.TabIndex = 129;
            label13.Text = " Tiền nhập";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.MediumSeaGreen;
            label12.Location = new Point(1169, 508);
            label12.Name = "label12";
            label12.Size = new Size(69, 27);
            label12.TabIndex = 127;
            label12.Text = "Đơn vị";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.MediumSeaGreen;
            label11.Location = new Point(982, 509);
            label11.Name = "label11";
            label11.Size = new Size(92, 27);
            label11.TabIndex = 125;
            label11.Text = "Số lượng";
            // 
            // buttonLuuPhieuNhap
            // 
            buttonLuuPhieuNhap.BackColor = Color.Green;
            buttonLuuPhieuNhap.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLuuPhieuNhap.ForeColor = SystemColors.ButtonHighlight;
            buttonLuuPhieuNhap.Location = new Point(1333, 555);
            buttonLuuPhieuNhap.Name = "buttonLuuPhieuNhap";
            buttonLuuPhieuNhap.Size = new Size(173, 60);
            buttonLuuPhieuNhap.TabIndex = 110;
            buttonLuuPhieuNhap.Text = "Lưu ";
            buttonLuuPhieuNhap.UseVisualStyleBackColor = false;
            buttonLuuPhieuNhap.Click += buttonLuuPhieuNhap_Click;
            // 
            // buttonThoat
            // 
            buttonThoat.BackColor = Color.Red;
            buttonThoat.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Bold, GraphicsUnit.Point);
            buttonThoat.ForeColor = SystemColors.ButtonHighlight;
            buttonThoat.Location = new Point(1512, 555);
            buttonThoat.Name = "buttonThoat";
            buttonThoat.Size = new Size(173, 60);
            buttonThoat.TabIndex = 109;
            buttonThoat.Text = "Thoát";
            buttonThoat.UseVisualStyleBackColor = false;
            buttonThoat.Click += buttonThoat_Click;
            // 
            // danhSachChiTietPhieuNhap
            // 
            danhSachChiTietPhieuNhap.AllowUserToAddRows = false;
            danhSachChiTietPhieuNhap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            danhSachChiTietPhieuNhap.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            danhSachChiTietPhieuNhap.BackgroundColor = SystemColors.ButtonHighlight;
            danhSachChiTietPhieuNhap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            danhSachChiTietPhieuNhap.Columns.AddRange(new DataGridViewColumn[] { MaChiTietSP, MauSac, KichCo, SoLuong, DonVi, TienNhap, ThanhTien });
            danhSachChiTietPhieuNhap.Location = new Point(0, 621);
            danhSachChiTietPhieuNhap.Name = "danhSachChiTietPhieuNhap";
            danhSachChiTietPhieuNhap.RowHeadersWidth = 62;
            danhSachChiTietPhieuNhap.RowTemplate.Height = 33;
            danhSachChiTietPhieuNhap.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            danhSachChiTietPhieuNhap.Size = new Size(1697, 346);
            danhSachChiTietPhieuNhap.TabIndex = 108;
            danhSachChiTietPhieuNhap.CellContentClick += danhSachChiTietPhieuNhap_CellContentClick;
            // 
            // MaChiTietSP
            // 
            MaChiTietSP.DataPropertyName = "MaChiTietSanPham";
            dataGridViewCellStyle1.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            MaChiTietSP.DefaultCellStyle = dataGridViewCellStyle1;
            MaChiTietSP.HeaderText = "Chi tiết sản phẩm";
            MaChiTietSP.MinimumWidth = 8;
            MaChiTietSP.Name = "MaChiTietSP";
            // 
            // MauSac
            // 
            MauSac.DataPropertyName = "MaMauSac";
            dataGridViewCellStyle2.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            MauSac.DefaultCellStyle = dataGridViewCellStyle2;
            MauSac.HeaderText = "Màu sắc";
            MauSac.MinimumWidth = 8;
            MauSac.Name = "MauSac";
            // 
            // KichCo
            // 
            KichCo.DataPropertyName = "MaKichCo";
            dataGridViewCellStyle3.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            KichCo.DefaultCellStyle = dataGridViewCellStyle3;
            KichCo.HeaderText = "Kích cở";
            KichCo.MinimumWidth = 8;
            KichCo.Name = "KichCo";
            // 
            // SoLuong
            // 
            SoLuong.DataPropertyName = "SoLuongNhap";
            dataGridViewCellStyle4.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            SoLuong.DefaultCellStyle = dataGridViewCellStyle4;
            SoLuong.HeaderText = "Số lượng nhập";
            SoLuong.MinimumWidth = 8;
            SoLuong.Name = "SoLuong";
            // 
            // DonVi
            // 
            DonVi.DataPropertyName = "DonVi";
            dataGridViewCellStyle5.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            DonVi.DefaultCellStyle = dataGridViewCellStyle5;
            DonVi.HeaderText = "Đơn vị";
            DonVi.MinimumWidth = 8;
            DonVi.Name = "DonVi";
            // 
            // TienNhap
            // 
            TienNhap.DataPropertyName = "TienNhap";
            dataGridViewCellStyle6.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            TienNhap.DefaultCellStyle = dataGridViewCellStyle6;
            TienNhap.HeaderText = "Tiền nhập";
            TienNhap.MinimumWidth = 8;
            TienNhap.Name = "TienNhap";
            // 
            // ThanhTien
            // 
            ThanhTien.DataPropertyName = "ThanhTien";
            dataGridViewCellStyle7.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle7.SelectionForeColor = Color.White;
            ThanhTien.DefaultCellStyle = dataGridViewCellStyle7;
            ThanhTien.HeaderText = "Thành tiền";
            ThanhTien.MinimumWidth = 8;
            ThanhTien.Name = "ThanhTien";
            // 
            // txtTenNhanVien
            // 
            txtTenNhanVien.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenNhanVien.Location = new Point(30, 354);
            txtTenNhanVien.Name = "txtTenNhanVien";
            txtTenNhanVien.ReadOnly = true;
            txtTenNhanVien.Size = new Size(302, 34);
            txtTenNhanVien.TabIndex = 107;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MediumSeaGreen;
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1697, 92);
            panel2.TabIndex = 106;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Display", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(724, 26);
            label2.Name = "label2";
            label2.Size = new Size(186, 37);
            label2.TabIndex = 0;
            label2.Text = "PHIẾU NHẬP";
            // 
            // danhSachChiTietSanPham
            // 
            danhSachChiTietSanPham.AllowUserToAddRows = false;
            danhSachChiTietSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            danhSachChiTietSanPham.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            danhSachChiTietSanPham.BackgroundColor = SystemColors.ButtonHighlight;
            danhSachChiTietSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            danhSachChiTietSanPham.Columns.AddRange(new DataGridViewColumn[] { MaChiTietSanPham, MaSanPham, MaMauSac, MaKichCo, HinhAnh, SoLuongNhap, SoLuongTon });
            danhSachChiTietSanPham.Location = new Point(354, 111);
            danhSachChiTietSanPham.Name = "danhSachChiTietSanPham";
            danhSachChiTietSanPham.RowHeadersWidth = 62;
            danhSachChiTietSanPham.RowTemplate.Height = 33;
            danhSachChiTietSanPham.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            danhSachChiTietSanPham.Size = new Size(1331, 371);
            danhSachChiTietSanPham.TabIndex = 104;
            danhSachChiTietSanPham.CellContentClick += danhSachChiTietSanPham_CellContentClick;
            // 
            // MaChiTietSanPham
            // 
            MaChiTietSanPham.DataPropertyName = "MaChiTietSanPham";
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.NullValue = null;
            dataGridViewCellStyle8.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle8.SelectionForeColor = Color.White;
            MaChiTietSanPham.DefaultCellStyle = dataGridViewCellStyle8;
            MaChiTietSanPham.HeaderText = "Mã chi tiết";
            MaChiTietSanPham.MinimumWidth = 8;
            MaChiTietSanPham.Name = "MaChiTietSanPham";
            // 
            // MaSanPham
            // 
            MaSanPham.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MaSanPham.DataPropertyName = "MaSanPham";
            dataGridViewCellStyle9.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle9.SelectionForeColor = Color.White;
            MaSanPham.DefaultCellStyle = dataGridViewCellStyle9;
            MaSanPham.HeaderText = "Sản phẩm";
            MaSanPham.MinimumWidth = 8;
            MaSanPham.Name = "MaSanPham";
            // 
            // MaMauSac
            // 
            MaMauSac.DataPropertyName = "MaMauSac";
            dataGridViewCellStyle10.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle10.SelectionForeColor = Color.White;
            MaMauSac.DefaultCellStyle = dataGridViewCellStyle10;
            MaMauSac.HeaderText = "Màu sắc";
            MaMauSac.MinimumWidth = 8;
            MaMauSac.Name = "MaMauSac";
            // 
            // MaKichCo
            // 
            MaKichCo.DataPropertyName = "MaKichCo";
            dataGridViewCellStyle11.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle11.SelectionForeColor = Color.White;
            MaKichCo.DefaultCellStyle = dataGridViewCellStyle11;
            MaKichCo.HeaderText = "Kích cỡ";
            MaKichCo.MinimumWidth = 8;
            MaKichCo.Name = "MaKichCo";
            // 
            // HinhAnh
            // 
            HinhAnh.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            HinhAnh.DataPropertyName = "HinhAnh";
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.NullValue = resources.GetObject("dataGridViewCellStyle12.NullValue");
            dataGridViewCellStyle12.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle12.SelectionForeColor = Color.White;
            HinhAnh.DefaultCellStyle = dataGridViewCellStyle12;
            HinhAnh.HeaderText = "Hình ảnh";
            HinhAnh.ImageLayout = DataGridViewImageCellLayout.Zoom;
            HinhAnh.MinimumWidth = 8;
            HinhAnh.Name = "HinhAnh";
            HinhAnh.Resizable = DataGridViewTriState.True;
            HinhAnh.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // SoLuongNhap
            // 
            SoLuongNhap.DataPropertyName = "SoLuongNhap";
            dataGridViewCellStyle13.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle13.SelectionForeColor = Color.White;
            SoLuongNhap.DefaultCellStyle = dataGridViewCellStyle13;
            SoLuongNhap.HeaderText = "Số lượng nhập";
            SoLuongNhap.MinimumWidth = 8;
            SoLuongNhap.Name = "SoLuongNhap";
            // 
            // SoLuongTon
            // 
            SoLuongTon.DataPropertyName = "SoLuongTon";
            dataGridViewCellStyle14.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle14.SelectionForeColor = Color.White;
            SoLuongTon.DefaultCellStyle = dataGridViewCellStyle14;
            SoLuongTon.HeaderText = "Số lượng tồn";
            SoLuongTon.MinimumWidth = 8;
            SoLuongTon.Name = "SoLuongTon";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.MediumSeaGreen;
            label5.Location = new Point(30, 324);
            label5.Name = "label5";
            label5.Size = new Size(100, 27);
            label5.TabIndex = 103;
            label5.Text = "Nhân viên";
            // 
            // txtMaPhieuNhap
            // 
            txtMaPhieuNhap.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaPhieuNhap.Location = new Point(30, 150);
            txtMaPhieuNhap.Name = "txtMaPhieuNhap";
            txtMaPhieuNhap.ReadOnly = true;
            txtMaPhieuNhap.Size = new Size(302, 34);
            txtMaPhieuNhap.TabIndex = 102;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.MediumSeaGreen;
            label3.Location = new Point(30, 120);
            label3.Name = "label3";
            label3.Size = new Size(143, 27);
            label3.TabIndex = 101;
            label3.Text = "Mã phiếu nhập";
            // 
            // comboxNhaCungCap
            // 
            comboxNhaCungCap.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Regular, GraphicsUnit.Point);
            comboxNhaCungCap.FormattingEnabled = true;
            comboxNhaCungCap.Location = new Point(30, 217);
            comboxNhaCungCap.Name = "comboxNhaCungCap";
            comboxNhaCungCap.Size = new Size(302, 35);
            comboxNhaCungCap.TabIndex = 100;
            // 
            // txtNgayNhap
            // 
            txtNgayNhap.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtNgayNhap.Location = new Point(30, 422);
            txtNgayNhap.Name = "txtNgayNhap";
            txtNgayNhap.ReadOnly = true;
            txtNgayNhap.Size = new Size(302, 34);
            txtNgayNhap.TabIndex = 99;
            // 
            // labelGiaNhap
            // 
            labelGiaNhap.AutoSize = true;
            labelGiaNhap.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelGiaNhap.ForeColor = Color.MediumSeaGreen;
            labelGiaNhap.Location = new Point(30, 392);
            labelGiaNhap.Name = "labelGiaNhap";
            labelGiaNhap.Size = new Size(108, 27);
            labelGiaNhap.TabIndex = 98;
            labelGiaNhap.Text = "Ngày nhập";
            // 
            // txtTongTien
            // 
            txtTongTien.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtTongTien.Location = new Point(30, 494);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.ReadOnly = true;
            txtTongTien.Size = new Size(302, 34);
            txtTongTien.TabIndex = 97;
            txtTongTien.Text = "0";
            // 
            // labelGiaSanPham
            // 
            labelGiaSanPham.AutoSize = true;
            labelGiaSanPham.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelGiaSanPham.ForeColor = Color.MediumSeaGreen;
            labelGiaSanPham.Location = new Point(30, 464);
            labelGiaSanPham.Name = "labelGiaSanPham";
            labelGiaSanPham.Size = new Size(95, 27);
            labelGiaSanPham.TabIndex = 96;
            labelGiaSanPham.Text = "Tổng tiền";
            // 
            // txtTenPhieuNhap
            // 
            txtTenPhieuNhap.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenPhieuNhap.Location = new Point(30, 287);
            txtTenPhieuNhap.Name = "txtTenPhieuNhap";
            txtTenPhieuNhap.Size = new Size(302, 34);
            txtTenPhieuNhap.TabIndex = 95;
            // 
            // labelTenSanPham
            // 
            labelTenSanPham.AutoSize = true;
            labelTenSanPham.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelTenSanPham.ForeColor = Color.MediumSeaGreen;
            labelTenSanPham.Location = new Point(30, 257);
            labelTenSanPham.Name = "labelTenSanPham";
            labelTenSanPham.Size = new Size(144, 27);
            labelTenSanPham.TabIndex = 94;
            labelTenSanPham.Text = "Tên phiếu nhập";
            // 
            // labelTheLoai
            // 
            labelTheLoai.AutoSize = true;
            labelTheLoai.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelTheLoai.ForeColor = Color.MediumSeaGreen;
            labelTheLoai.Location = new Point(30, 187);
            labelTheLoai.Name = "labelTheLoai";
            labelTheLoai.Size = new Size(134, 27);
            labelTheLoai.TabIndex = 93;
            labelTheLoai.Text = "Nhà cung cấp";
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.MediumSeaGreen;
            btnThem.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnThem.ForeColor = SystemColors.ButtonHighlight;
            btnThem.Location = new Point(949, 555);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(186, 60);
            btnThem.TabIndex = 131;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // slNhap
            // 
            slNhap.Location = new Point(1080, 509);
            slNhap.Name = "slNhap";
            slNhap.Size = new Size(69, 31);
            slNhap.TabIndex = 132;
            // 
            // comboxDonVi
            // 
            comboxDonVi.FormattingEnabled = true;
            comboxDonVi.Items.AddRange(new object[] { "Bộ", "Cái", "Đôi" });
            comboxDonVi.Location = new Point(1237, 507);
            comboxDonVi.Name = "comboxDonVi";
            comboxDonVi.Size = new Size(113, 33);
            comboxDonVi.TabIndex = 133;
            // 
            // txtMaChiTietSanPham
            // 
            txtMaChiTietSanPham.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaChiTietSanPham.Location = new Point(836, 506);
            txtMaChiTietSanPham.Name = "txtMaChiTietSanPham";
            txtMaChiTietSanPham.ReadOnly = true;
            txtMaChiTietSanPham.Size = new Size(124, 34);
            txtMaChiTietSanPham.TabIndex = 135;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.MediumSeaGreen;
            label1.Location = new Point(718, 509);
            label1.Name = "label1";
            label1.Size = new Size(112, 27);
            label1.TabIndex = 134;
            label1.Text = "Mã Chi Tiết";
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.Orange;
            btnSua.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnSua.ForeColor = SystemColors.ButtonHighlight;
            btnSua.Location = new Point(1141, 555);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(186, 60);
            btnSua.TabIndex = 136;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // PhieuNhapModule
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1697, 966);
            Controls.Add(btnSua);
            Controls.Add(txtMaChiTietSanPham);
            Controls.Add(label1);
            Controls.Add(comboxDonVi);
            Controls.Add(slNhap);
            Controls.Add(btnThem);
            Controls.Add(txtTienNhap);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(buttonLuuPhieuNhap);
            Controls.Add(buttonThoat);
            Controls.Add(danhSachChiTietPhieuNhap);
            Controls.Add(txtTenNhanVien);
            Controls.Add(panel2);
            Controls.Add(danhSachChiTietSanPham);
            Controls.Add(label5);
            Controls.Add(txtMaPhieuNhap);
            Controls.Add(label3);
            Controls.Add(comboxNhaCungCap);
            Controls.Add(txtNgayNhap);
            Controls.Add(labelGiaNhap);
            Controls.Add(txtTongTien);
            Controls.Add(labelGiaSanPham);
            Controls.Add(txtTenPhieuNhap);
            Controls.Add(labelTenSanPham);
            Controls.Add(labelTheLoai);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PhieuNhapModule";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PhieuNhapModule";
            ((System.ComponentModel.ISupportInitialize)danhSachChiTietPhieuNhap).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)danhSachChiTietSanPham).EndInit();
            ((System.ComponentModel.ISupportInitialize)slNhap).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public TextBox txtTienNhap;
        private Label label13;
        private Label label12;
        private Label label11;
        private Button buttonLuuPhieuNhap;
        private Button buttonThoat;
        private DataGridView danhSachChiTietPhieuNhap;
        public TextBox txtTenNhanVien;
        private Panel panel2;
        private Label label2;
        public DataGridView danhSachChiTietSanPham;
        private Label label5;
        public TextBox txtMaPhieuNhap;
        private Label label3;
        public ComboBox comboxNhaCungCap;
        public TextBox txtNgayNhap;
        private Label labelGiaNhap;
        public TextBox txtTongTien;
        private Label labelGiaSanPham;
        public TextBox txtTenPhieuNhap;
        private Label labelTenSanPham;
        private Label labelTheLoai;
        private DataGridViewTextBoxColumn MaChiTietSanPham;
        private DataGridViewTextBoxColumn MaSanPham;
        private DataGridViewTextBoxColumn MaMauSac;
        private DataGridViewTextBoxColumn MaKichCo;
        private DataGridViewImageColumn HinhAnh;
        private DataGridViewTextBoxColumn SoLuongNhap;
        private DataGridViewTextBoxColumn SoLuongTon;
        private Button btnThem;
        private DataGridViewTextBoxColumn MaChiTietSP;
        private DataGridViewTextBoxColumn MauSac;
        private DataGridViewTextBoxColumn KichCo;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn DonVi;
        private DataGridViewTextBoxColumn TienNhap;
        private DataGridViewTextBoxColumn ThanhTien;
        private NumericUpDown slNhap;
        private ComboBox comboxDonVi;
        public TextBox txtMaChiTietSanPham;
        private Label label1;
        private Button btnSua;
    }
}