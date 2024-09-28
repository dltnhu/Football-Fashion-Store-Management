namespace WindowsFormsApp3.GUI
{
    partial class BanHangFrom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BanHangFrom));
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle19 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle20 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle21 = new DataGridViewCellStyle();
            dgvDonHang = new DataGridView();
            dataGridViewButtonColumn1 = new DataGridViewButtonColumn();
            dataGridViewButtonColumn2 = new DataGridViewButtonColumn();
            a = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            dataGridViewButtonColumn3 = new DataGridViewButtonColumn();
            dataGridViewButtonColumn4 = new DataGridViewButtonColumn();
            soLuongDonHang = new DataGridViewButtonColumn();
            tongTienDonHang = new DataGridViewTextBoxColumn();
            Cong = new DataGridViewImageColumn();
            Tru = new DataGridViewImageColumn();
            Xoa = new DataGridViewImageColumn();
            dgvSanPham = new DataGridView();
            MaChiTietSanPham = new DataGridViewTextBoxColumn();
            TenSanPham = new DataGridViewTextBoxColumn();
            TenThuongHieu = new DataGridViewTextBoxColumn();
            TenMauSac = new DataGridViewTextBoxColumn();
            TenTheLoai = new DataGridViewTextBoxColumn();
            TenChatLieu = new DataGridViewTextBoxColumn();
            TenKichCo = new DataGridViewTextBoxColumn();
            SoLuongTon = new DataGridViewTextBoxColumn();
            them2 = new DataGridViewImageColumn();
            btnThanhToan = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            panel1 = new Panel();
            label1 = new Label();
            button1 = new Button();
            txtFind = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvDonHang).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvDonHang
            // 
            dgvDonHang.AllowUserToAddRows = false;
            dgvDonHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDonHang.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvDonHang.BackgroundColor = Color.White;
            dgvDonHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDonHang.Columns.AddRange(new DataGridViewColumn[] { dataGridViewButtonColumn1, dataGridViewButtonColumn2, a, Column2, Column1, dataGridViewButtonColumn3, dataGridViewButtonColumn4, soLuongDonHang, tongTienDonHang, Cong, Tru, Xoa });
            dgvDonHang.Location = new Point(8, 27);
            dgvDonHang.Margin = new Padding(4, 5, 4, 5);
            dgvDonHang.Name = "dgvDonHang";
            dgvDonHang.RowHeadersWidth = 51;
            dgvDonHang.RowTemplate.Height = 24;
            dgvDonHang.Size = new Size(1509, 269);
            dgvDonHang.TabIndex = 1;
            dgvDonHang.CellContentClick += dgvDonHang_CellContentClick;
            // 
            // dataGridViewButtonColumn1
            // 
            dataGridViewButtonColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewButtonColumn1.DataPropertyName = "MaSanPham";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewButtonColumn1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewButtonColumn1.HeaderText = "Mã Sản Phẩm";
            dataGridViewButtonColumn1.MinimumWidth = 6;
            dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            // 
            // dataGridViewButtonColumn2
            // 
            dataGridViewButtonColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewButtonColumn2.DataPropertyName = "TenSanPham";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewButtonColumn2.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewButtonColumn2.HeaderText = "Tên Sản Phẩm";
            dataGridViewButtonColumn2.MinimumWidth = 6;
            dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
            // 
            // a
            // 
            dataGridViewCellStyle3.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            a.DefaultCellStyle = dataGridViewCellStyle3;
            a.HeaderText = "Thể Loại";
            a.MinimumWidth = 6;
            a.Name = "a";
            // 
            // Column2
            // 
            dataGridViewCellStyle4.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            Column2.DefaultCellStyle = dataGridViewCellStyle4;
            Column2.HeaderText = "Chất Liệu";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column1
            // 
            dataGridViewCellStyle5.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            Column1.DefaultCellStyle = dataGridViewCellStyle5;
            Column1.HeaderText = "Thương Hiêu";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // dataGridViewButtonColumn3
            // 
            dataGridViewButtonColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewButtonColumn3.DataPropertyName = "TenMau";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewButtonColumn3.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewButtonColumn3.HeaderText = "Màu Sắc";
            dataGridViewButtonColumn3.MinimumWidth = 6;
            dataGridViewButtonColumn3.Name = "dataGridViewButtonColumn3";
            // 
            // dataGridViewButtonColumn4
            // 
            dataGridViewButtonColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle7.SelectionForeColor = Color.White;
            dataGridViewButtonColumn4.DefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewButtonColumn4.HeaderText = "Kích Cỡ";
            dataGridViewButtonColumn4.MinimumWidth = 6;
            dataGridViewButtonColumn4.Name = "dataGridViewButtonColumn4";
            // 
            // soLuongDonHang
            // 
            soLuongDonHang.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle8.SelectionForeColor = Color.White;
            soLuongDonHang.DefaultCellStyle = dataGridViewCellStyle8;
            soLuongDonHang.HeaderText = "Số Lượng";
            soLuongDonHang.MinimumWidth = 6;
            soLuongDonHang.Name = "soLuongDonHang";
            // 
            // tongTienDonHang
            // 
            dataGridViewCellStyle9.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle9.SelectionForeColor = Color.White;
            tongTienDonHang.DefaultCellStyle = dataGridViewCellStyle9;
            tongTienDonHang.HeaderText = "Tổng Tiền";
            tongTienDonHang.MinimumWidth = 6;
            tongTienDonHang.Name = "tongTienDonHang";
            // 
            // Cong
            // 
            Cong.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.NullValue = null;
            dataGridViewCellStyle10.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle10.SelectionForeColor = Color.White;
            Cong.DefaultCellStyle = dataGridViewCellStyle10;
            Cong.HeaderText = "Cộng";
            Cong.Image = (Image)resources.GetObject("Cong.Image");
            Cong.MinimumWidth = 6;
            Cong.Name = "Cong";
            Cong.Resizable = DataGridViewTriState.True;
            Cong.Width = 65;
            // 
            // Tru
            // 
            Tru.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.NullValue = null;
            dataGridViewCellStyle11.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle11.SelectionForeColor = Color.White;
            Tru.DefaultCellStyle = dataGridViewCellStyle11;
            Tru.HeaderText = "Trừ";
            Tru.Image = (Image)resources.GetObject("Tru.Image");
            Tru.MinimumWidth = 6;
            Tru.Name = "Tru";
            Tru.Resizable = DataGridViewTriState.True;
            Tru.Width = 45;
            // 
            // Xoa
            // 
            Xoa.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.NullValue = null;
            dataGridViewCellStyle12.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle12.SelectionForeColor = Color.White;
            Xoa.DefaultCellStyle = dataGridViewCellStyle12;
            Xoa.HeaderText = "Xóa";
            Xoa.Image = (Image)resources.GetObject("Xoa.Image");
            Xoa.MinimumWidth = 6;
            Xoa.Name = "Xoa";
            Xoa.Resizable = DataGridViewTriState.True;
            Xoa.SortMode = DataGridViewColumnSortMode.Automatic;
            Xoa.Width = 82;
            // 
            // dgvSanPham
            // 
            dgvSanPham.AllowUserToAddRows = false;
            dgvSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSanPham.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvSanPham.BackgroundColor = Color.White;
            dgvSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSanPham.Columns.AddRange(new DataGridViewColumn[] { MaChiTietSanPham, TenSanPham, TenThuongHieu, TenMauSac, TenTheLoai, TenChatLieu, TenKichCo, SoLuongTon, them2 });
            dgvSanPham.Location = new Point(8, 32);
            dgvSanPham.Margin = new Padding(4, 5, 4, 5);
            dgvSanPham.Name = "dgvSanPham";
            dgvSanPham.RowHeadersWidth = 51;
            dgvSanPham.RowTemplate.Height = 24;
            dgvSanPham.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSanPham.Size = new Size(1509, 275);
            dgvSanPham.TabIndex = 2;
            dgvSanPham.CellContentClick += dgvSanPham_CellContentClick_1;
            // 
            // MaChiTietSanPham
            // 
            MaChiTietSanPham.DataPropertyName = "MaChiTietSanPham";
            dataGridViewCellStyle13.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle13.SelectionForeColor = Color.White;
            MaChiTietSanPham.DefaultCellStyle = dataGridViewCellStyle13;
            MaChiTietSanPham.HeaderText = "Mã";
            MaChiTietSanPham.MinimumWidth = 6;
            MaChiTietSanPham.Name = "MaChiTietSanPham";
            MaChiTietSanPham.ReadOnly = true;
            // 
            // TenSanPham
            // 
            TenSanPham.DataPropertyName = "TenSanPham";
            dataGridViewCellStyle14.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle14.SelectionForeColor = Color.White;
            TenSanPham.DefaultCellStyle = dataGridViewCellStyle14;
            TenSanPham.HeaderText = "Tên Sản Phẩm";
            TenSanPham.MinimumWidth = 6;
            TenSanPham.Name = "TenSanPham";
            TenSanPham.ReadOnly = true;
            // 
            // TenThuongHieu
            // 
            TenThuongHieu.DataPropertyName = "TenMauSac";
            dataGridViewCellStyle15.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle15.SelectionForeColor = Color.White;
            TenThuongHieu.DefaultCellStyle = dataGridViewCellStyle15;
            TenThuongHieu.HeaderText = "Tên Màu Sắc";
            TenThuongHieu.MinimumWidth = 6;
            TenThuongHieu.Name = "TenThuongHieu";
            TenThuongHieu.ReadOnly = true;
            // 
            // TenMauSac
            // 
            TenMauSac.DataPropertyName = "TenKichCo";
            dataGridViewCellStyle16.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle16.SelectionForeColor = Color.White;
            TenMauSac.DefaultCellStyle = dataGridViewCellStyle16;
            TenMauSac.HeaderText = "Tên Kích Cỡ";
            TenMauSac.MinimumWidth = 6;
            TenMauSac.Name = "TenMauSac";
            TenMauSac.ReadOnly = true;
            // 
            // TenTheLoai
            // 
            TenTheLoai.DataPropertyName = "TenTheLoai";
            dataGridViewCellStyle17.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle17.SelectionForeColor = Color.White;
            TenTheLoai.DefaultCellStyle = dataGridViewCellStyle17;
            TenTheLoai.HeaderText = "Tên Thể Loại";
            TenTheLoai.MinimumWidth = 6;
            TenTheLoai.Name = "TenTheLoai";
            TenTheLoai.ReadOnly = true;
            // 
            // TenChatLieu
            // 
            TenChatLieu.DataPropertyName = "TenChatLieu";
            dataGridViewCellStyle18.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle18.SelectionForeColor = Color.White;
            TenChatLieu.DefaultCellStyle = dataGridViewCellStyle18;
            TenChatLieu.HeaderText = "Tên Chất Liệu";
            TenChatLieu.MinimumWidth = 6;
            TenChatLieu.Name = "TenChatLieu";
            TenChatLieu.ReadOnly = true;
            // 
            // TenKichCo
            // 
            TenKichCo.DataPropertyName = "TenThuongHieu";
            dataGridViewCellStyle19.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle19.SelectionForeColor = Color.White;
            TenKichCo.DefaultCellStyle = dataGridViewCellStyle19;
            TenKichCo.HeaderText = "Tên Thương Hiệu";
            TenKichCo.MinimumWidth = 6;
            TenKichCo.Name = "TenKichCo";
            TenKichCo.ReadOnly = true;
            // 
            // SoLuongTon
            // 
            SoLuongTon.DataPropertyName = "SoLuongTon";
            dataGridViewCellStyle20.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle20.SelectionForeColor = Color.White;
            SoLuongTon.DefaultCellStyle = dataGridViewCellStyle20;
            SoLuongTon.HeaderText = "Số Lượng Tồn";
            SoLuongTon.MinimumWidth = 6;
            SoLuongTon.Name = "SoLuongTon";
            SoLuongTon.ReadOnly = true;
            // 
            // them2
            // 
            dataGridViewCellStyle21.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.NullValue = resources.GetObject("dataGridViewCellStyle21.NullValue");
            dataGridViewCellStyle21.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle21.SelectionForeColor = Color.White;
            them2.DefaultCellStyle = dataGridViewCellStyle21;
            them2.HeaderText = "Thêm";
            them2.Image = (Image)resources.GetObject("them2.Image");
            them2.MinimumWidth = 6;
            them2.Name = "them2";
            them2.Resizable = DataGridViewTriState.True;
            // 
            // btnThanhToan
            // 
            btnThanhToan.BackColor = Color.MediumSeaGreen;
            btnThanhToan.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnThanhToan.ForeColor = Color.White;
            btnThanhToan.Location = new Point(1357, 807);
            btnThanhToan.Margin = new Padding(4, 5, 4, 5);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(206, 68);
            btnThanhToan.TabIndex = 3;
            btnThanhToan.Text = "Thanh Toán";
            btnThanhToan.UseVisualStyleBackColor = false;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(dgvDonHang);
            groupBox1.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(38, 489);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(1525, 308);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Giỏ Hàng";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(dgvSanPham);
            groupBox2.Cursor = Cursors.IBeam;
            groupBox2.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(38, 163);
            groupBox2.Margin = new Padding(4, 5, 4, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 5, 4, 5);
            groupBox2.Size = new Size(1525, 316);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh Sách Sản Phẩm";
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumSeaGreen;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1600, 100);
            panel1.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Small", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(683, 23);
            label1.Name = "label1";
            label1.Size = new Size(188, 48);
            label1.TabIndex = 0;
            label1.Text = "Bán Hàng";
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(386, 120);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(67, 34);
            button1.TabIndex = 13;
            button1.UseVisualStyleBackColor = true;
            // 
            // txtFind
            // 
            txtFind.BorderStyle = BorderStyle.FixedSingle;
            txtFind.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtFind.Location = new Point(46, 120);
            txtFind.Margin = new Padding(4);
            txtFind.Name = "txtFind";
            txtFind.PlaceholderText = "Tìm kiếm";
            txtFind.Size = new Size(342, 34);
            txtFind.TabIndex = 12;
            // 
            // BanHangFrom
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1600, 900);
            Controls.Add(button1);
            Controls.Add(txtFind);
            Controls.Add(panel1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnThanhToan);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "BanHangFrom";
            Text = "BanHangFrom";
            Load += BanHangFrom_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDonHang).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvDonHang;
        private DataGridView dgvSanPham;
        private Button btnThanhToan;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridViewTextBoxColumn MaChiTietSanPham;
        private DataGridViewTextBoxColumn TenSanPham;
        private DataGridViewTextBoxColumn TenThuongHieu;
        private DataGridViewTextBoxColumn TenMauSac;
        private DataGridViewTextBoxColumn TenTheLoai;
        private DataGridViewTextBoxColumn TenChatLieu;
        private DataGridViewTextBoxColumn TenKichCo;
        private DataGridViewTextBoxColumn SoLuongTon;
        private DataGridViewImageColumn them2;
        private Panel panel1;
        private Label label1;
        private DataGridViewButtonColumn dataGridViewButtonColumn1;
        private DataGridViewButtonColumn dataGridViewButtonColumn2;
        private DataGridViewTextBoxColumn a;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewButtonColumn dataGridViewButtonColumn3;
        private DataGridViewButtonColumn dataGridViewButtonColumn4;
        private DataGridViewButtonColumn soLuongDonHang;
        private DataGridViewTextBoxColumn tongTienDonHang;
        private DataGridViewImageColumn Cong;
        private DataGridViewImageColumn Tru;
        private DataGridViewImageColumn Xoa;
        private Button button1;
        private TextBox txtFind;
    }
}