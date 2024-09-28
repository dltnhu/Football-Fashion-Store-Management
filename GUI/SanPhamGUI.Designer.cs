namespace GUI
{
    partial class SanPhamGUI
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
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SanPhamGUI));
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            txtTimKiem = new TextBox();
            btnShowDialog = new Button();
            danhSachSanPham = new DataGridView();
            MaSanPham = new DataGridViewTextBoxColumn();
            MaTheLoai = new DataGridViewTextBoxColumn();
            MaThuongHieu = new DataGridViewTextBoxColumn();
            MaChatLieu = new DataGridViewTextBoxColumn();
            TenSanPham = new DataGridViewTextBoxColumn();
            GiaSanPham = new DataGridViewTextBoxColumn();
            GiaNhap = new DataGridViewTextBoxColumn();
            SoLuongNhap = new DataGridViewTextBoxColumn();
            SoLuongTon = new DataGridViewTextBoxColumn();
            Xoa = new DataGridViewImageColumn();
            Sua = new DataGridViewImageColumn();
            ChiTiet = new DataGridViewImageColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)danhSachSanPham).BeginInit();
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
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Small", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(659, 28);
            label1.Name = "label1";
            label1.Size = new Size(191, 48);
            label1.TabIndex = 0;
            label1.Text = "Sản Phẩm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.MediumSeaGreen;
            label2.Location = new Point(12, 770);
            label2.Name = "label2";
            label2.Size = new Size(115, 32);
            label2.TabIndex = 11;
            label2.Text = "Tìm Kiếm";
            // 
            // txtTimKiem
            // 
            txtTimKiem.BorderStyle = BorderStyle.FixedSingle;
            txtTimKiem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimKiem.Location = new Point(133, 768);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(295, 39);
            txtTimKiem.TabIndex = 10;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // btnShowDialog
            // 
            btnShowDialog.BackColor = Color.MediumSeaGreen;
            btnShowDialog.Font = new Font("Segoe UI Variable Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnShowDialog.ForeColor = SystemColors.ButtonHighlight;
            btnShowDialog.Location = new Point(1399, 754);
            btnShowDialog.Name = "btnShowDialog";
            btnShowDialog.Size = new Size(189, 65);
            btnShowDialog.TabIndex = 9;
            btnShowDialog.Text = "Thêm";
            btnShowDialog.UseVisualStyleBackColor = false;
            btnShowDialog.Click += btnShowDialog_Click;
            // 
            // danhSachSanPham
            // 
            danhSachSanPham.AllowUserToAddRows = false;
            danhSachSanPham.AllowUserToOrderColumns = true;
            danhSachSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            danhSachSanPham.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            danhSachSanPham.BackgroundColor = SystemColors.ButtonHighlight;
            danhSachSanPham.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            danhSachSanPham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            danhSachSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            danhSachSanPham.Columns.AddRange(new DataGridViewColumn[] { MaSanPham, MaTheLoai, MaThuongHieu, MaChatLieu, TenSanPham, GiaSanPham, GiaNhap, SoLuongNhap, SoLuongTon, Xoa, Sua, ChiTiet });
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = SystemColors.Window;
            dataGridViewCellStyle14.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle14.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.False;
            danhSachSanPham.DefaultCellStyle = dataGridViewCellStyle14;
            danhSachSanPham.GridColor = SystemColors.WindowText;
            danhSachSanPham.Location = new Point(0, 98);
            danhSachSanPham.Name = "danhSachSanPham";
            danhSachSanPham.ReadOnly = true;
            danhSachSanPham.RowHeadersWidth = 62;
            danhSachSanPham.RowTemplate.Height = 33;
            danhSachSanPham.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            danhSachSanPham.Size = new Size(1600, 650);
            danhSachSanPham.TabIndex = 12;
            danhSachSanPham.CellContentClick += danhSachSanPham_CellContentClick;
            // 
            // MaSanPham
            // 
            MaSanPham.DataPropertyName = "MaSanPham";
            dataGridViewCellStyle2.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            MaSanPham.DefaultCellStyle = dataGridViewCellStyle2;
            MaSanPham.HeaderText = "Mã sản phẩm";
            MaSanPham.MinimumWidth = 8;
            MaSanPham.Name = "MaSanPham";
            MaSanPham.ReadOnly = true;
            // 
            // MaTheLoai
            // 
            MaTheLoai.DataPropertyName = "MaTheLoai";
            dataGridViewCellStyle3.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            MaTheLoai.DefaultCellStyle = dataGridViewCellStyle3;
            MaTheLoai.HeaderText = "Thể loại";
            MaTheLoai.MinimumWidth = 8;
            MaTheLoai.Name = "MaTheLoai";
            MaTheLoai.ReadOnly = true;
            // 
            // MaThuongHieu
            // 
            MaThuongHieu.DataPropertyName = "MaThuongHieu";
            dataGridViewCellStyle4.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            MaThuongHieu.DefaultCellStyle = dataGridViewCellStyle4;
            MaThuongHieu.HeaderText = "Thương hiệu";
            MaThuongHieu.MinimumWidth = 8;
            MaThuongHieu.Name = "MaThuongHieu";
            MaThuongHieu.ReadOnly = true;
            // 
            // MaChatLieu
            // 
            MaChatLieu.DataPropertyName = "MaChatLieu";
            dataGridViewCellStyle5.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            MaChatLieu.DefaultCellStyle = dataGridViewCellStyle5;
            MaChatLieu.HeaderText = "Chất liệu";
            MaChatLieu.MinimumWidth = 8;
            MaChatLieu.Name = "MaChatLieu";
            MaChatLieu.ReadOnly = true;
            // 
            // TenSanPham
            // 
            TenSanPham.DataPropertyName = "TenSanPham";
            dataGridViewCellStyle6.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            TenSanPham.DefaultCellStyle = dataGridViewCellStyle6;
            TenSanPham.HeaderText = "Tên sản phẩm";
            TenSanPham.MinimumWidth = 8;
            TenSanPham.Name = "TenSanPham";
            TenSanPham.ReadOnly = true;
            // 
            // GiaSanPham
            // 
            GiaSanPham.DataPropertyName = "GiaSanPham";
            dataGridViewCellStyle7.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle7.SelectionForeColor = Color.White;
            GiaSanPham.DefaultCellStyle = dataGridViewCellStyle7;
            GiaSanPham.HeaderText = "Giá sản phẩm";
            GiaSanPham.MinimumWidth = 8;
            GiaSanPham.Name = "GiaSanPham";
            GiaSanPham.ReadOnly = true;
            // 
            // GiaNhap
            // 
            GiaNhap.DataPropertyName = "GiaNhap";
            dataGridViewCellStyle8.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle8.SelectionForeColor = Color.White;
            GiaNhap.DefaultCellStyle = dataGridViewCellStyle8;
            GiaNhap.HeaderText = "Giá nhập";
            GiaNhap.MinimumWidth = 8;
            GiaNhap.Name = "GiaNhap";
            GiaNhap.ReadOnly = true;
            // 
            // SoLuongNhap
            // 
            SoLuongNhap.DataPropertyName = "SoLuongNhap";
            dataGridViewCellStyle9.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle9.SelectionForeColor = Color.White;
            SoLuongNhap.DefaultCellStyle = dataGridViewCellStyle9;
            SoLuongNhap.HeaderText = "Số lượng nhập";
            SoLuongNhap.MinimumWidth = 8;
            SoLuongNhap.Name = "SoLuongNhap";
            SoLuongNhap.ReadOnly = true;
            // 
            // SoLuongTon
            // 
            SoLuongTon.DataPropertyName = "SoLuongTon";
            dataGridViewCellStyle10.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle10.SelectionForeColor = Color.White;
            SoLuongTon.DefaultCellStyle = dataGridViewCellStyle10;
            SoLuongTon.HeaderText = "Số lượng tồn";
            SoLuongTon.MinimumWidth = 8;
            SoLuongTon.Name = "SoLuongTon";
            SoLuongTon.ReadOnly = true;
            // 
            // Xoa
            // 
            Xoa.DataPropertyName = "Xoa";
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.NullValue = resources.GetObject("dataGridViewCellStyle11.NullValue");
            dataGridViewCellStyle11.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle11.SelectionForeColor = Color.White;
            Xoa.DefaultCellStyle = dataGridViewCellStyle11;
            Xoa.HeaderText = "Xóa";
            Xoa.Image = (Image)resources.GetObject("Xoa.Image");
            Xoa.MinimumWidth = 8;
            Xoa.Name = "Xoa";
            Xoa.ReadOnly = true;
            // 
            // Sua
            // 
            Sua.DataPropertyName = "Sua";
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.NullValue = resources.GetObject("dataGridViewCellStyle12.NullValue");
            dataGridViewCellStyle12.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle12.SelectionForeColor = Color.White;
            Sua.DefaultCellStyle = dataGridViewCellStyle12;
            Sua.HeaderText = "Sửa";
            Sua.Image = (Image)resources.GetObject("Sua.Image");
            Sua.MinimumWidth = 8;
            Sua.Name = "Sua";
            Sua.ReadOnly = true;
            // 
            // ChiTiet
            // 
            ChiTiet.DataPropertyName = "ChiTiet";
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.NullValue = resources.GetObject("dataGridViewCellStyle13.NullValue");
            dataGridViewCellStyle13.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle13.SelectionForeColor = Color.White;
            ChiTiet.DefaultCellStyle = dataGridViewCellStyle13;
            ChiTiet.HeaderText = "Chi tiết";
            ChiTiet.Image = (Image)resources.GetObject("ChiTiet.Image");
            ChiTiet.MinimumWidth = 8;
            ChiTiet.Name = "ChiTiet";
            ChiTiet.ReadOnly = true;
            // 
            // SanPhamGUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 900);
            Controls.Add(danhSachSanPham);
            Controls.Add(label2);
            Controls.Add(txtTimKiem);
            Controls.Add(btnShowDialog);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SanPhamGUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SanPhamGUI";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)danhSachSanPham).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox txtTimKiem;
        public Button btnShowDialog;
        public DataGridView danhSachSanPham;
        private DataGridViewTextBoxColumn MaSanPham;
        private DataGridViewTextBoxColumn MaTheLoai;
        private DataGridViewTextBoxColumn MaThuongHieu;
        private DataGridViewTextBoxColumn MaChatLieu;
        private DataGridViewTextBoxColumn TenSanPham;
        private DataGridViewTextBoxColumn GiaSanPham;
        private DataGridViewTextBoxColumn GiaNhap;
        private DataGridViewTextBoxColumn SoLuongNhap;
        private DataGridViewTextBoxColumn SoLuongTon;
        private DataGridViewImageColumn Xoa;
        private DataGridViewImageColumn Sua;
        private DataGridViewImageColumn ChiTiet;
    }
}