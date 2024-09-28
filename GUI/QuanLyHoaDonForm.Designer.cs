namespace WindowsFormsApp3.GUI
{
    partial class QuanLyHoaDonForm
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            dgvHoaDon = new DataGridView();
            MaHoaDon = new DataGridViewTextBoxColumn();
            MaThue = new DataGridViewTextBoxColumn();
            MaKhachHang = new DataGridViewTextBoxColumn();
            MaNhanVien = new DataGridViewTextBoxColumn();
            MaKhuyenMai = new DataGridViewTextBoxColumn();
            TenHoaDon = new DataGridViewTextBoxColumn();
            NgayLapHoaDon = new DataGridViewTextBoxColumn();
            TongTien = new DataGridViewTextBoxColumn();
            HinhThucThanhToan = new DataGridViewTextBoxColumn();
            ThanhTien = new DataGridViewTextBoxColumn();
            dgvCTHD = new DataGridView();
            x = new DataGridViewTextBoxColumn();
            TenSanPham = new DataGridViewTextBoxColumn();
            GiaSanPham = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            ThanhTien1 = new DataGridViewTextBoxColumn();
            contextMenuStrip1 = new ContextMenuStrip(components);
            txtTimKiem = new TextBox();
            btnDelete = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCTHD).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumSeaGreen;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1278, 80);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Text", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(535, 22);
            label1.Name = "label1";
            label1.Size = new Size(240, 32);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ HÓA ĐƠN";
            // 
            // dgvHoaDon
            // 
            dgvHoaDon.AllowUserToAddRows = false;
            dgvHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHoaDon.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvHoaDon.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHoaDon.Columns.AddRange(new DataGridViewColumn[] { MaHoaDon, MaThue, MaKhachHang, MaNhanVien, MaKhuyenMai, TenHoaDon, NgayLapHoaDon, TongTien, HinhThucThanhToan, ThanhTien });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvHoaDon.DefaultCellStyle = dataGridViewCellStyle2;
            dgvHoaDon.Location = new Point(12, 156);
            dgvHoaDon.Margin = new Padding(3, 4, 3, 4);
            dgvHoaDon.Name = "dgvHoaDon";
            dgvHoaDon.RowHeadersWidth = 51;
            dgvHoaDon.RowTemplate.Height = 24;
            dgvHoaDon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHoaDon.Size = new Size(1254, 246);
            dgvHoaDon.TabIndex = 0;
            dgvHoaDon.CellContentClick += dataGridView1_CellContentClick;
            // 
            // MaHoaDon
            // 
            MaHoaDon.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MaHoaDon.DataPropertyName = "MaHoaDon";
            MaHoaDon.HeaderText = "Mã Hóa Đơn";
            MaHoaDon.MinimumWidth = 6;
            MaHoaDon.Name = "MaHoaDon";
            MaHoaDon.ReadOnly = true;
            MaHoaDon.Resizable = DataGridViewTriState.True;
            // 
            // MaThue
            // 
            MaThue.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MaThue.DataPropertyName = "MaThue";
            MaThue.HeaderText = "Mã Thuế";
            MaThue.MinimumWidth = 6;
            MaThue.Name = "MaThue";
            MaThue.ReadOnly = true;
            MaThue.Resizable = DataGridViewTriState.True;
            MaThue.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // MaKhachHang
            // 
            MaKhachHang.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MaKhachHang.DataPropertyName = "MaKhachHang";
            MaKhachHang.HeaderText = "Mã Khách Hàng";
            MaKhachHang.MinimumWidth = 6;
            MaKhachHang.Name = "MaKhachHang";
            MaKhachHang.ReadOnly = true;
            MaKhachHang.Resizable = DataGridViewTriState.True;
            MaKhachHang.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // MaNhanVien
            // 
            MaNhanVien.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MaNhanVien.DataPropertyName = "MaNhanVien";
            MaNhanVien.HeaderText = "Mã Nhân Viên";
            MaNhanVien.MinimumWidth = 6;
            MaNhanVien.Name = "MaNhanVien";
            MaNhanVien.ReadOnly = true;
            MaNhanVien.Resizable = DataGridViewTriState.True;
            MaNhanVien.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // MaKhuyenMai
            // 
            MaKhuyenMai.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MaKhuyenMai.DataPropertyName = "MaKhuyenMai";
            MaKhuyenMai.HeaderText = "Mã Khuyến Mãi";
            MaKhuyenMai.MinimumWidth = 6;
            MaKhuyenMai.Name = "MaKhuyenMai";
            MaKhuyenMai.ReadOnly = true;
            MaKhuyenMai.Resizable = DataGridViewTriState.True;
            MaKhuyenMai.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // TenHoaDon
            // 
            TenHoaDon.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TenHoaDon.DataPropertyName = "TenHoaDon";
            TenHoaDon.HeaderText = "Tên Hóa Đơn";
            TenHoaDon.MinimumWidth = 6;
            TenHoaDon.Name = "TenHoaDon";
            TenHoaDon.ReadOnly = true;
            TenHoaDon.Resizable = DataGridViewTriState.True;
            TenHoaDon.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // NgayLapHoaDon
            // 
            NgayLapHoaDon.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            NgayLapHoaDon.DataPropertyName = "NgayLapHoaDon";
            NgayLapHoaDon.HeaderText = "Ngày Lập Hóa Đơn";
            NgayLapHoaDon.MinimumWidth = 6;
            NgayLapHoaDon.Name = "NgayLapHoaDon";
            NgayLapHoaDon.ReadOnly = true;
            NgayLapHoaDon.Resizable = DataGridViewTriState.True;
            NgayLapHoaDon.SortMode = DataGridViewColumnSortMode.NotSortable;
            NgayLapHoaDon.Width = 116;
            // 
            // TongTien
            // 
            TongTien.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TongTien.DataPropertyName = "TongTien";
            TongTien.HeaderText = "Tổng Tiền";
            TongTien.MinimumWidth = 6;
            TongTien.Name = "TongTien";
            TongTien.ReadOnly = true;
            TongTien.Resizable = DataGridViewTriState.True;
            TongTien.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // HinhThucThanhToan
            // 
            HinhThucThanhToan.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            HinhThucThanhToan.DataPropertyName = "HinhThucThanhToan";
            HinhThucThanhToan.HeaderText = "Hình Thức Thanh Toán";
            HinhThucThanhToan.MinimumWidth = 6;
            HinhThucThanhToan.Name = "HinhThucThanhToan";
            HinhThucThanhToan.ReadOnly = true;
            HinhThucThanhToan.Resizable = DataGridViewTriState.True;
            HinhThucThanhToan.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ThanhTien
            // 
            ThanhTien.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ThanhTien.DataPropertyName = "ThanhTien";
            ThanhTien.HeaderText = "Thành Tiền";
            ThanhTien.MinimumWidth = 6;
            ThanhTien.Name = "ThanhTien";
            ThanhTien.ReadOnly = true;
            ThanhTien.Resizable = DataGridViewTriState.True;
            ThanhTien.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvCTHD
            // 
            dgvCTHD.AllowUserToAddRows = false;
            dgvCTHD.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvCTHD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvCTHD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCTHD.Columns.AddRange(new DataGridViewColumn[] { x, TenSanPham, GiaSanPham, SoLuong, ThanhTien1 });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvCTHD.DefaultCellStyle = dataGridViewCellStyle4;
            dgvCTHD.Location = new Point(12, 438);
            dgvCTHD.Margin = new Padding(3, 4, 3, 4);
            dgvCTHD.Name = "dgvCTHD";
            dgvCTHD.RowHeadersWidth = 51;
            dgvCTHD.RowTemplate.Height = 24;
            dgvCTHD.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCTHD.Size = new Size(1254, 232);
            dgvCTHD.TabIndex = 0;
            dgvCTHD.CellContentClick += dgvCTHD_CellContentClick;
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
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(318, 101);
            txtTimKiem.Margin = new Padding(2);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Tìm kiếm";
            txtTimKiem.Size = new Size(577, 27);
            txtTimKiem.TabIndex = 5;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(899, 98);
            btnDelete.Margin = new Padding(2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(34, 27);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "x";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // QuanLyHoaDonForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1278, 732);
            Controls.Add(btnDelete);
            Controls.Add(txtTimKiem);
            Controls.Add(dgvCTHD);
            Controls.Add(dgvHoaDon);
            Controls.Add(panel1);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "QuanLyHoaDonForm";
            Text = "QuanLyHoaDonForm";
            Load += QuanLyHoaDonForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCTHD).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label label1;
        private DataGridView dgvHoaDon;
        private DataGridView dgvCTHD;
        private DataGridViewTextBoxColumn MaHoaDon;
        private DataGridViewTextBoxColumn MaThue;
        private DataGridViewTextBoxColumn MaKhachHang;
        private DataGridViewTextBoxColumn MaNhanVien;
        private DataGridViewTextBoxColumn MaKhuyenMai;
        private DataGridViewTextBoxColumn TenHoaDon;
        private DataGridViewTextBoxColumn NgayLapHoaDon;
        private DataGridViewTextBoxColumn TongTien;
        private DataGridViewTextBoxColumn HinhThucThanhToan;
        private DataGridViewTextBoxColumn ThanhTien;
        private DataGridViewTextBoxColumn x;
        private DataGridViewTextBoxColumn TenSanPham;
        private DataGridViewTextBoxColumn GiaSanPham;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn ThanhTien1;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox txtTimKiem;
        private Button btnDelete;
    }
}