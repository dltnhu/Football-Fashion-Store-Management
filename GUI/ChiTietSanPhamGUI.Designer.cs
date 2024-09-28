namespace GUI
{
    partial class ChiTietSanPhamGUI
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
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChiTietSanPhamGUI));
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            danhSachChiTietSanPham = new DataGridView();
            label2 = new Label();
            txtTimKiem = new TextBox();
            MaChiTietSanPham = new DataGridViewTextBoxColumn();
            MaSanPham = new DataGridViewTextBoxColumn();
            MaMauSac = new DataGridViewTextBoxColumn();
            MaKichCo = new DataGridViewTextBoxColumn();
            HinhAnh = new DataGridViewImageColumn();
            SoLuongNhap = new DataGridViewTextBoxColumn();
            SoLuongTon = new DataGridViewTextBoxColumn();
            Xoa = new DataGridViewImageColumn();
            Sua = new DataGridViewImageColumn();
            ChiTiet = new DataGridViewImageColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)danhSachChiTietSanPham).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumSeaGreen;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1600, 100);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MediumSeaGreen;
            label1.Font = new Font("Segoe UI Variable Display", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(626, 33);
            label1.Name = "label1";
            label1.Size = new Size(288, 37);
            label1.TabIndex = 0;
            label1.Text = "CHI TIẾT SẢN PHẨM";
            // 
            // danhSachChiTietSanPham
            // 
            danhSachChiTietSanPham.AllowUserToAddRows = false;
            danhSachChiTietSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            danhSachChiTietSanPham.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            danhSachChiTietSanPham.BackgroundColor = SystemColors.ButtonHighlight;
            danhSachChiTietSanPham.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            danhSachChiTietSanPham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            danhSachChiTietSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            danhSachChiTietSanPham.Columns.AddRange(new DataGridViewColumn[] { MaChiTietSanPham, MaSanPham, MaMauSac, MaKichCo, HinhAnh, SoLuongNhap, SoLuongTon, Xoa, Sua, ChiTiet });
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = SystemColors.Window;
            dataGridViewCellStyle12.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.False;
            danhSachChiTietSanPham.DefaultCellStyle = dataGridViewCellStyle12;
            danhSachChiTietSanPham.Location = new Point(0, 100);
            danhSachChiTietSanPham.Name = "danhSachChiTietSanPham";
            danhSachChiTietSanPham.RowHeadersWidth = 62;
            danhSachChiTietSanPham.RowTemplate.Height = 33;
            danhSachChiTietSanPham.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            danhSachChiTietSanPham.Size = new Size(1600, 638);
            danhSachChiTietSanPham.TabIndex = 2;
            danhSachChiTietSanPham.CellContentClick += danhSachChiTietSanPham_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.MediumSeaGreen;
            label2.Location = new Point(12, 760);
            label2.Name = "label2";
            label2.Size = new Size(115, 32);
            label2.TabIndex = 9;
            label2.Text = "Tìm Kiếm";
            // 
            // txtTimKiem
            // 
            txtTimKiem.BorderStyle = BorderStyle.FixedSingle;
            txtTimKiem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimKiem.Location = new Point(133, 758);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(295, 39);
            txtTimKiem.TabIndex = 8;
            // 
            // MaChiTietSanPham
            // 
            MaChiTietSanPham.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MaChiTietSanPham.DataPropertyName = "MaChiTietSanPham";
            dataGridViewCellStyle2.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            MaChiTietSanPham.DefaultCellStyle = dataGridViewCellStyle2;
            MaChiTietSanPham.HeaderText = "Mã chi tiết";
            MaChiTietSanPham.MinimumWidth = 8;
            MaChiTietSanPham.Name = "MaChiTietSanPham";
            // 
            // MaSanPham
            // 
            MaSanPham.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MaSanPham.DataPropertyName = "MaSanPham";
            dataGridViewCellStyle3.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            MaSanPham.DefaultCellStyle = dataGridViewCellStyle3;
            MaSanPham.HeaderText = "Sản phẩm";
            MaSanPham.MinimumWidth = 8;
            MaSanPham.Name = "MaSanPham";
            // 
            // MaMauSac
            // 
            MaMauSac.DataPropertyName = "MaMauSac";
            dataGridViewCellStyle4.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            MaMauSac.DefaultCellStyle = dataGridViewCellStyle4;
            MaMauSac.HeaderText = "Màu sắc";
            MaMauSac.MinimumWidth = 8;
            MaMauSac.Name = "MaMauSac";
            MaMauSac.Width = 119;
            // 
            // MaKichCo
            // 
            MaKichCo.DataPropertyName = "MaKichCo";
            dataGridViewCellStyle5.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            MaKichCo.DefaultCellStyle = dataGridViewCellStyle5;
            MaKichCo.HeaderText = "Kích cỡ";
            MaKichCo.MinimumWidth = 8;
            MaKichCo.Name = "MaKichCo";
            MaKichCo.Width = 111;
            // 
            // HinhAnh
            // 
            HinhAnh.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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
            HinhAnh.Resizable = DataGridViewTriState.True;
            HinhAnh.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // SoLuongNhap
            // 
            SoLuongNhap.DataPropertyName = "SoLuongNhap";
            dataGridViewCellStyle7.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle7.SelectionForeColor = Color.White;
            SoLuongNhap.DefaultCellStyle = dataGridViewCellStyle7;
            SoLuongNhap.HeaderText = "Số lượng nhập";
            SoLuongNhap.MinimumWidth = 8;
            SoLuongNhap.Name = "SoLuongNhap";
            SoLuongNhap.Width = 177;
            // 
            // SoLuongTon
            // 
            SoLuongTon.DataPropertyName = "SoLuongTon";
            dataGridViewCellStyle8.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle8.SelectionForeColor = Color.White;
            SoLuongTon.DefaultCellStyle = dataGridViewCellStyle8;
            SoLuongTon.HeaderText = "Số lượng tồn";
            SoLuongTon.MinimumWidth = 8;
            SoLuongTon.Name = "SoLuongTon";
            SoLuongTon.Width = 163;
            // 
            // Xoa
            // 
            Xoa.DataPropertyName = "Xóa";
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.NullValue = null;
            dataGridViewCellStyle9.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle9.SelectionForeColor = Color.White;
            Xoa.DefaultCellStyle = dataGridViewCellStyle9;
            Xoa.HeaderText = "Xóa";
            Xoa.Image = (Image)resources.GetObject("Xoa.Image");
            Xoa.MinimumWidth = 8;
            Xoa.Name = "Xoa";
            Xoa.Resizable = DataGridViewTriState.True;
            Xoa.SortMode = DataGridViewColumnSortMode.Automatic;
            Xoa.Width = 82;
            // 
            // Sua
            // 
            Sua.DataPropertyName = "Sua";
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.NullValue = null;
            dataGridViewCellStyle10.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle10.SelectionForeColor = Color.White;
            Sua.DefaultCellStyle = dataGridViewCellStyle10;
            Sua.HeaderText = "Sửa";
            Sua.Image = (Image)resources.GetObject("Sua.Image");
            Sua.MinimumWidth = 8;
            Sua.Name = "Sua";
            Sua.Resizable = DataGridViewTriState.True;
            Sua.SortMode = DataGridViewColumnSortMode.Automatic;
            Sua.Width = 81;
            // 
            // ChiTiet
            // 
            ChiTiet.DataPropertyName = "ChiTiet";
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.NullValue = resources.GetObject("dataGridViewCellStyle11.NullValue");
            dataGridViewCellStyle11.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle11.SelectionForeColor = Color.White;
            ChiTiet.DefaultCellStyle = dataGridViewCellStyle11;
            ChiTiet.HeaderText = "Chi Tiết";
            ChiTiet.Image = (Image)resources.GetObject("ChiTiet.Image");
            ChiTiet.MinimumWidth = 8;
            ChiTiet.Name = "ChiTiet";
            ChiTiet.Resizable = DataGridViewTriState.True;
            ChiTiet.SortMode = DataGridViewColumnSortMode.Automatic;
            ChiTiet.Width = 113;
            // 
            // ChiTietSanPhamGUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 900);
            Controls.Add(label2);
            Controls.Add(txtTimKiem);
            Controls.Add(danhSachChiTietSanPham);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ChiTietSanPhamGUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChiTietSanPhamGUI";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)danhSachChiTietSanPham).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        public DataGridView danhSachChiTietSanPham;
        private Label label2;
        private TextBox txtTimKiem;
        private DataGridViewTextBoxColumn MaChiTietSanPham;
        private DataGridViewTextBoxColumn MaSanPham;
        private DataGridViewTextBoxColumn MaMauSac;
        private DataGridViewTextBoxColumn MaKichCo;
        private DataGridViewImageColumn HinhAnh;
        private DataGridViewTextBoxColumn SoLuongNhap;
        private DataGridViewTextBoxColumn SoLuongTon;
        private DataGridViewImageColumn Xoa;
        private DataGridViewImageColumn Sua;
        private DataGridViewImageColumn ChiTiet;
    }
}