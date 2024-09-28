namespace GUI
{
    partial class SanPhamModule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SanPhamModule));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            anhSanPham = new PictureBox();
            label5 = new Label();
            btnThemChiTietSanPham = new Button();
            comboxMaSanPham = new ComboBox();
            label4 = new Label();
            comboxKichCo = new ComboBox();
            label1 = new Label();
            comboxMauSac = new ComboBox();
            label2 = new Label();
            txtMaSanPham = new TextBox();
            label3 = new Label();
            btnLuuChiTietSanPham = new Button();
            danhSachChiTietSanPham = new DataGridView();
            panel1 = new Panel();
            label6 = new Label();
            comboxChatLieu = new ComboBox();
            comboxTheLoai = new ComboBox();
            comboxThuongHieu = new ComboBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnThem = new Button();
            btnSua = new Button();
            btnThoat = new Button();
            txtGiaNhap = new TextBox();
            labelGiaNhap = new Label();
            txtGiaSanPham = new TextBox();
            labelGiaSanPham = new Label();
            txtTenSanPham = new TextBox();
            labelTenSanPham = new Label();
            labelChatLieu = new Label();
            labelTheLoai = new Label();
            labelThuongHieu = new Label();
            label7 = new Label();
            TenSanPham = new DataGridViewTextBoxColumn();
            MauSac = new DataGridViewTextBoxColumn();
            KichCo = new DataGridViewTextBoxColumn();
            HinhAnh = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)anhSanPham).BeginInit();
            ((System.ComponentModel.ISupportInitialize)danhSachChiTietSanPham).BeginInit();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // anhSanPham
            // 
            anhSanPham.Image = (Image)resources.GetObject("anhSanPham.Image");
            anhSanPham.Location = new Point(1094, 699);
            anhSanPham.Name = "anhSanPham";
            anhSanPham.Size = new Size(157, 138);
            anhSanPham.SizeMode = PictureBoxSizeMode.Zoom;
            anhSanPham.TabIndex = 75;
            anhSanPham.TabStop = false;
            anhSanPham.Click += anhSanPham_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.MediumSeaGreen;
            label5.Location = new Point(394, 199);
            label5.Name = "label5";
            label5.Size = new Size(90, 27);
            label5.TabIndex = 74;
            label5.Text = "Chất liệu";
            // 
            // btnThemChiTietSanPham
            // 
            btnThemChiTietSanPham.BackColor = Color.MediumSeaGreen;
            btnThemChiTietSanPham.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnThemChiTietSanPham.ForeColor = SystemColors.Control;
            btnThemChiTietSanPham.Location = new Point(1283, 699);
            btnThemChiTietSanPham.Name = "btnThemChiTietSanPham";
            btnThemChiTietSanPham.Size = new Size(187, 63);
            btnThemChiTietSanPham.TabIndex = 73;
            btnThemChiTietSanPham.Text = "Thêm chi tiết";
            btnThemChiTietSanPham.UseVisualStyleBackColor = false;
            btnThemChiTietSanPham.Click += btnThemChiTietSanPham_Click;
            // 
            // comboxMaSanPham
            // 
            comboxMaSanPham.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Regular, GraphicsUnit.Point);
            comboxMaSanPham.FormattingEnabled = true;
            comboxMaSanPham.Location = new Point(50, 727);
            comboxMaSanPham.Name = "comboxMaSanPham";
            comboxMaSanPham.Size = new Size(302, 35);
            comboxMaSanPham.TabIndex = 72;
            comboxMaSanPham.SelectedValueChanged += comboxMaSanPham_SelectedValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.MediumSeaGreen;
            label4.Location = new Point(50, 699);
            label4.Name = "label4";
            label4.Size = new Size(130, 27);
            label4.TabIndex = 71;
            label4.Text = "Mã sản phẩm";
            // 
            // comboxKichCo
            // 
            comboxKichCo.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Regular, GraphicsUnit.Point);
            comboxKichCo.FormattingEnabled = true;
            comboxKichCo.Location = new Point(734, 727);
            comboxKichCo.Name = "comboxKichCo";
            comboxKichCo.Size = new Size(302, 35);
            comboxKichCo.TabIndex = 70;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.MediumSeaGreen;
            label1.Location = new Point(734, 699);
            label1.Name = "label1";
            label1.Size = new Size(77, 27);
            label1.TabIndex = 69;
            label1.Text = "Kích cở";
            // 
            // comboxMauSac
            // 
            comboxMauSac.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Regular, GraphicsUnit.Point);
            comboxMauSac.FormattingEnabled = true;
            comboxMauSac.Location = new Point(389, 727);
            comboxMauSac.Name = "comboxMauSac";
            comboxMauSac.Size = new Size(302, 35);
            comboxMauSac.TabIndex = 68;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.MediumSeaGreen;
            label2.Location = new Point(389, 699);
            label2.Name = "label2";
            label2.Size = new Size(85, 27);
            label2.TabIndex = 67;
            label2.Text = "Màu sắc";
            // 
            // txtMaSanPham
            // 
            txtMaSanPham.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaSanPham.Location = new Point(50, 148);
            txtMaSanPham.Name = "txtMaSanPham";
            txtMaSanPham.ReadOnly = true;
            txtMaSanPham.Size = new Size(302, 34);
            txtMaSanPham.TabIndex = 66;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.MediumSeaGreen;
            label3.Location = new Point(50, 118);
            label3.Name = "label3";
            label3.Size = new Size(130, 27);
            label3.TabIndex = 65;
            label3.Text = "Mã sản phẩm";
            // 
            // btnLuuChiTietSanPham
            // 
            btnLuuChiTietSanPham.BackColor = Color.Teal;
            btnLuuChiTietSanPham.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnLuuChiTietSanPham.ForeColor = SystemColors.Control;
            btnLuuChiTietSanPham.Location = new Point(1283, 774);
            btnLuuChiTietSanPham.Name = "btnLuuChiTietSanPham";
            btnLuuChiTietSanPham.Size = new Size(187, 63);
            btnLuuChiTietSanPham.TabIndex = 64;
            btnLuuChiTietSanPham.Text = "Lưu";
            btnLuuChiTietSanPham.UseVisualStyleBackColor = false;
            btnLuuChiTietSanPham.Click += btnLuuChiTietSanPham_Click;
            // 
            // danhSachChiTietSanPham
            // 
            danhSachChiTietSanPham.AllowUserToAddRows = false;
            danhSachChiTietSanPham.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            danhSachChiTietSanPham.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            danhSachChiTietSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            danhSachChiTietSanPham.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            danhSachChiTietSanPham.BackgroundColor = SystemColors.ButtonHighlight;
            danhSachChiTietSanPham.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            danhSachChiTietSanPham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            danhSachChiTietSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            danhSachChiTietSanPham.Columns.AddRange(new DataGridViewColumn[] { TenSanPham, MauSac, KichCo, HinhAnh });
            danhSachChiTietSanPham.GridColor = SystemColors.HotTrack;
            danhSachChiTietSanPham.Location = new Point(0, 293);
            danhSachChiTietSanPham.Name = "danhSachChiTietSanPham";
            danhSachChiTietSanPham.ReadOnly = true;
            danhSachChiTietSanPham.RowHeadersWidth = 62;
            danhSachChiTietSanPham.RowTemplate.Height = 33;
            danhSachChiTietSanPham.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            danhSachChiTietSanPham.Size = new Size(1493, 358);
            danhSachChiTietSanPham.TabIndex = 63;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumSeaGreen;
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1493, 100);
            panel1.TabIndex = 62;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Variable Display", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(654, 31);
            label6.Name = "label6";
            label6.Size = new Size(147, 37);
            label6.TabIndex = 27;
            label6.Text = "Sản Phẩm";
            // 
            // comboxChatLieu
            // 
            comboxChatLieu.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Regular, GraphicsUnit.Point);
            comboxChatLieu.FormattingEnabled = true;
            comboxChatLieu.Location = new Point(389, 229);
            comboxChatLieu.Name = "comboxChatLieu";
            comboxChatLieu.Size = new Size(302, 35);
            comboxChatLieu.TabIndex = 61;
            // 
            // comboxTheLoai
            // 
            comboxTheLoai.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Regular, GraphicsUnit.Point);
            comboxTheLoai.FormattingEnabled = true;
            comboxTheLoai.Location = new Point(50, 229);
            comboxTheLoai.Name = "comboxTheLoai";
            comboxTheLoai.Size = new Size(302, 35);
            comboxTheLoai.TabIndex = 60;
            // 
            // comboxThuongHieu
            // 
            comboxThuongHieu.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Regular, GraphicsUnit.Point);
            comboxThuongHieu.FormattingEnabled = true;
            comboxThuongHieu.Location = new Point(734, 229);
            comboxThuongHieu.Name = "comboxThuongHieu";
            comboxThuongHieu.Size = new Size(302, 35);
            comboxThuongHieu.TabIndex = 59;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnThem);
            flowLayoutPanel1.Controls.Add(btnSua);
            flowLayoutPanel1.Controls.Add(btnThoat);
            flowLayoutPanel1.Location = new Point(1080, 199);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(390, 69);
            flowLayoutPanel1.TabIndex = 58;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.MediumSeaGreen;
            btnThem.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnThem.ForeColor = SystemColors.Control;
            btnThem.Location = new Point(3, 3);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(187, 63);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm sản phẩm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.Orange;
            btnSua.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnSua.ForeColor = SystemColors.Control;
            btnSua.Location = new Point(196, 3);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(187, 63);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.Red;
            btnThoat.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnThoat.ForeColor = SystemColors.Control;
            btnThoat.Location = new Point(3, 72);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(187, 63);
            btnThoat.TabIndex = 2;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // txtGiaNhap
            // 
            txtGiaNhap.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtGiaNhap.Location = new Point(734, 148);
            txtGiaNhap.Name = "txtGiaNhap";
            txtGiaNhap.Size = new Size(302, 34);
            txtGiaNhap.TabIndex = 57;
            // 
            // labelGiaNhap
            // 
            labelGiaNhap.AutoSize = true;
            labelGiaNhap.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelGiaNhap.ForeColor = Color.MediumSeaGreen;
            labelGiaNhap.Location = new Point(734, 118);
            labelGiaNhap.Name = "labelGiaNhap";
            labelGiaNhap.Size = new Size(90, 27);
            labelGiaNhap.TabIndex = 56;
            labelGiaNhap.Text = "Giá nhập";
            // 
            // txtGiaSanPham
            // 
            txtGiaSanPham.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtGiaSanPham.Location = new Point(1106, 148);
            txtGiaSanPham.Name = "txtGiaSanPham";
            txtGiaSanPham.Size = new Size(302, 34);
            txtGiaSanPham.TabIndex = 55;
            // 
            // labelGiaSanPham
            // 
            labelGiaSanPham.AutoSize = true;
            labelGiaSanPham.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelGiaSanPham.ForeColor = Color.MediumSeaGreen;
            labelGiaSanPham.Location = new Point(1106, 118);
            labelGiaSanPham.Name = "labelGiaSanPham";
            labelGiaSanPham.Size = new Size(131, 27);
            labelGiaSanPham.TabIndex = 54;
            labelGiaSanPham.Text = "Giá sản phẩm";
            // 
            // txtTenSanPham
            // 
            txtTenSanPham.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenSanPham.Location = new Point(389, 148);
            txtTenSanPham.Name = "txtTenSanPham";
            txtTenSanPham.Size = new Size(302, 34);
            txtTenSanPham.TabIndex = 53;
            // 
            // labelTenSanPham
            // 
            labelTenSanPham.AutoSize = true;
            labelTenSanPham.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelTenSanPham.ForeColor = Color.MediumSeaGreen;
            labelTenSanPham.Location = new Point(389, 118);
            labelTenSanPham.Name = "labelTenSanPham";
            labelTenSanPham.Size = new Size(131, 27);
            labelTenSanPham.TabIndex = 52;
            labelTenSanPham.Text = "Tên sản phẩm";
            // 
            // labelChatLieu
            // 
            labelChatLieu.AutoSize = true;
            labelChatLieu.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelChatLieu.ForeColor = Color.DodgerBlue;
            labelChatLieu.Location = new Point(69, 407);
            labelChatLieu.Name = "labelChatLieu";
            labelChatLieu.Size = new Size(109, 32);
            labelChatLieu.TabIndex = 51;
            labelChatLieu.Text = "Chất liệu";
            // 
            // labelTheLoai
            // 
            labelTheLoai.AutoSize = true;
            labelTheLoai.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelTheLoai.ForeColor = Color.MediumSeaGreen;
            labelTheLoai.Location = new Point(50, 199);
            labelTheLoai.Name = "labelTheLoai";
            labelTheLoai.Size = new Size(80, 27);
            labelTheLoai.TabIndex = 50;
            labelTheLoai.Text = "Thể loại";
            // 
            // labelThuongHieu
            // 
            labelThuongHieu.AutoSize = true;
            labelThuongHieu.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelThuongHieu.ForeColor = Color.MediumSeaGreen;
            labelThuongHieu.Location = new Point(734, 194);
            labelThuongHieu.Name = "labelThuongHieu";
            labelThuongHieu.Size = new Size(122, 27);
            labelThuongHieu.TabIndex = 49;
            labelThuongHieu.Text = "Thương hiệu";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.MediumSeaGreen;
            label7.Location = new Point(1094, 669);
            label7.Name = "label7";
            label7.Size = new Size(100, 27);
            label7.TabIndex = 76;
            label7.Text = "Chọn Ảnh";
            // 
            // TenSanPham
            // 
            TenSanPham.DataPropertyName = "TenSanPham";
            dataGridViewCellStyle3.Font = new Font("Segoe UI Variable Display", 8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            TenSanPham.DefaultCellStyle = dataGridViewCellStyle3;
            TenSanPham.HeaderText = "Tên sản phẩm";
            TenSanPham.MinimumWidth = 8;
            TenSanPham.Name = "TenSanPham";
            TenSanPham.ReadOnly = true;
            // 
            // MauSac
            // 
            dataGridViewCellStyle4.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            MauSac.DefaultCellStyle = dataGridViewCellStyle4;
            MauSac.HeaderText = "Màu sắc";
            MauSac.MinimumWidth = 8;
            MauSac.Name = "MauSac";
            MauSac.ReadOnly = true;
            // 
            // KichCo
            // 
            dataGridViewCellStyle5.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            KichCo.DefaultCellStyle = dataGridViewCellStyle5;
            KichCo.HeaderText = "Kích cỡ";
            KichCo.MinimumWidth = 8;
            KichCo.Name = "KichCo";
            KichCo.ReadOnly = true;
            // 
            // HinhAnh
            // 
            HinhAnh.DataPropertyName = "HinhAnh";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.NullValue = null;
            dataGridViewCellStyle6.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            HinhAnh.DefaultCellStyle = dataGridViewCellStyle6;
            HinhAnh.HeaderText = "Hình ảnh";
            HinhAnh.ImageLayout = DataGridViewImageCellLayout.Zoom;
            HinhAnh.MinimumWidth = 8;
            HinhAnh.Name = "HinhAnh";
            HinhAnh.ReadOnly = true;
            // 
            // SanPhamModule
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1493, 856);
            Controls.Add(label7);
            Controls.Add(anhSanPham);
            Controls.Add(label5);
            Controls.Add(btnThemChiTietSanPham);
            Controls.Add(comboxMaSanPham);
            Controls.Add(label4);
            Controls.Add(comboxKichCo);
            Controls.Add(label1);
            Controls.Add(comboxMauSac);
            Controls.Add(label2);
            Controls.Add(txtMaSanPham);
            Controls.Add(label3);
            Controls.Add(btnLuuChiTietSanPham);
            Controls.Add(danhSachChiTietSanPham);
            Controls.Add(panel1);
            Controls.Add(comboxChatLieu);
            Controls.Add(comboxTheLoai);
            Controls.Add(comboxThuongHieu);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(txtGiaNhap);
            Controls.Add(labelGiaNhap);
            Controls.Add(txtGiaSanPham);
            Controls.Add(labelGiaSanPham);
            Controls.Add(txtTenSanPham);
            Controls.Add(labelTenSanPham);
            Controls.Add(labelChatLieu);
            Controls.Add(labelTheLoai);
            Controls.Add(labelThuongHieu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SanPhamModule";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SanPhamModule";
            ((System.ComponentModel.ISupportInitialize)anhSanPham).EndInit();
            ((System.ComponentModel.ISupportInitialize)danhSachChiTietSanPham).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public PictureBox anhSanPham;
        private Label label5;
        public Button btnThemChiTietSanPham;
        public ComboBox comboxMaSanPham;
        private Label label4;
        public ComboBox comboxKichCo;
        private Label label1;
        public ComboBox comboxMauSac;
        private Label label2;
        public TextBox txtMaSanPham;
        private Label label3;
        public Button btnLuuChiTietSanPham;
        public DataGridView danhSachChiTietSanPham;
        private Panel panel1;
        private Label label6;
        public ComboBox comboxChatLieu;
        public ComboBox comboxTheLoai;
        public ComboBox comboxThuongHieu;
        private FlowLayoutPanel flowLayoutPanel1;
        public Button btnThem;
        public Button btnSua;
        private Button btnThoat;
        public TextBox txtGiaNhap;
        private Label labelGiaNhap;
        public TextBox txtGiaSanPham;
        private Label labelGiaSanPham;
        public TextBox txtTenSanPham;
        private Label labelTenSanPham;
        private Label labelChatLieu;
        private Label labelTheLoai;
        private Label labelThuongHieu;
        private Label label7;
        private DataGridViewTextBoxColumn TenSanPham;
        private DataGridViewTextBoxColumn MauSac;
        private DataGridViewTextBoxColumn KichCo;
        private DataGridViewImageColumn HinhAnh;
    }
}