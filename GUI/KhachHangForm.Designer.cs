namespace WindowsFormsApp3.GUI
{
    partial class KhachHangForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KhachHangForm));
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            btnThem = new Button();
            btnDelete = new Button();
            txtTimKiem = new TextBox();
            panel1 = new Panel();
            label1 = new Label();
            sua = new DataGridViewImageColumn();
            xoa = new DataGridViewImageColumn();
            TrangThai = new DataGridViewTextBoxColumn();
            SoDienThoai = new DataGridViewTextBoxColumn();
            TenKhachHang = new DataGridViewTextBoxColumn();
            MaKhachHang = new DataGridViewTextBoxColumn();
            dgvKhachHang = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            SuspendLayout();
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.MediumSeaGreen;
            btnThem.Font = new Font("Segoe UI Variable Display", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnThem.ForeColor = SystemColors.ButtonHighlight;
            btnThem.Location = new Point(1382, 750);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(206, 65);
            btnThem.TabIndex = 5;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click_1;
            // 
            // btnDelete
            // 
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Location = new Point(343, 765);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(36, 39);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "x";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.BorderStyle = BorderStyle.FixedSingle;
            txtTimKiem.Font = new Font("Segoe UI Variable Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimKiem.Location = new Point(39, 765);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Tìm kiếm";
            txtTimKiem.Size = new Size(308, 39);
            txtTimKiem.TabIndex = 3;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
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
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Text", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(597, 33);
            label1.Name = "label1";
            label1.Size = new Size(376, 37);
            label1.TabIndex = 1;
            label1.Text = "DANH SÁCH KHÁCH HÀNG";
            // 
            // sua
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.NullValue = resources.GetObject("dataGridViewCellStyle1.NullValue");
            dataGridViewCellStyle1.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            sua.DefaultCellStyle = dataGridViewCellStyle1;
            sua.HeaderText = "Sửa";
            sua.Image = (Image)resources.GetObject("sua.Image");
            sua.MinimumWidth = 6;
            sua.Name = "sua";
            sua.Resizable = DataGridViewTriState.True;
            // 
            // xoa
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = resources.GetObject("dataGridViewCellStyle2.NullValue");
            dataGridViewCellStyle2.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            xoa.DefaultCellStyle = dataGridViewCellStyle2;
            xoa.HeaderText = "Xóa";
            xoa.Image = (Image)resources.GetObject("xoa.Image");
            xoa.MinimumWidth = 6;
            xoa.Name = "xoa";
            xoa.Resizable = DataGridViewTriState.True;
            xoa.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // TrangThai
            // 
            TrangThai.DataPropertyName = "TrangThai";
            dataGridViewCellStyle3.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            TrangThai.DefaultCellStyle = dataGridViewCellStyle3;
            TrangThai.HeaderText = "Trạng Thái";
            TrangThai.MinimumWidth = 6;
            TrangThai.Name = "TrangThai";
            TrangThai.ReadOnly = true;
            TrangThai.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // SoDienThoai
            // 
            SoDienThoai.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SoDienThoai.DataPropertyName = "SoDienThoai";
            dataGridViewCellStyle4.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            SoDienThoai.DefaultCellStyle = dataGridViewCellStyle4;
            SoDienThoai.HeaderText = "Số Điện Thoại";
            SoDienThoai.MinimumWidth = 6;
            SoDienThoai.Name = "SoDienThoai";
            // 
            // TenKhachHang
            // 
            TenKhachHang.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TenKhachHang.DataPropertyName = "TenKhachHang";
            dataGridViewCellStyle5.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            TenKhachHang.DefaultCellStyle = dataGridViewCellStyle5;
            TenKhachHang.HeaderText = "Tên Khách Hàng";
            TenKhachHang.MinimumWidth = 6;
            TenKhachHang.Name = "TenKhachHang";
            // 
            // MaKhachHang
            // 
            MaKhachHang.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MaKhachHang.DataPropertyName = "MaKhachHang";
            dataGridViewCellStyle6.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            MaKhachHang.DefaultCellStyle = dataGridViewCellStyle6;
            MaKhachHang.HeaderText = "Mã Khách Hàng";
            MaKhachHang.MinimumWidth = 6;
            MaKhachHang.Name = "MaKhachHang";
            // 
            // dgvKhachHang
            // 
            dgvKhachHang.AllowUserToAddRows = false;
            dataGridViewCellStyle7.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dgvKhachHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKhachHang.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvKhachHang.BackgroundColor = Color.White;
            dgvKhachHang.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Control;
            dataGridViewCellStyle8.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dgvKhachHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dgvKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhachHang.Columns.AddRange(new DataGridViewColumn[] { MaKhachHang, TenKhachHang, SoDienThoai, TrangThai, xoa, sua });
            dgvKhachHang.Location = new Point(3, 94);
            dgvKhachHang.Name = "dgvKhachHang";
            dgvKhachHang.RowHeadersWidth = 51;
            dgvKhachHang.RowTemplate.Height = 24;
            dgvKhachHang.Size = new Size(1597, 650);
            dgvKhachHang.TabIndex = 0;
            dgvKhachHang.CellContentClick += dgvKhachHang_CellContentClick;
            // 
            // KhachHangForm
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1600, 900);
            Controls.Add(btnThem);
            Controls.Add(btnDelete);
            Controls.Add(txtTimKiem);
            Controls.Add(panel1);
            Controls.Add(dgvKhachHang);
            Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "KhachHangForm";
            Text = "KhachHangForm";
            Load += KhachHangForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Button btnThem;
        private Button btnDelete;
        private TextBox txtTimKiem;
        private Panel panel1;
        private Label label1;
        private DataGridViewImageColumn sua;
        private DataGridViewImageColumn xoa;
        private DataGridViewTextBoxColumn TrangThai;
        private DataGridViewTextBoxColumn SoDienThoai;
        private DataGridViewTextBoxColumn TenKhachHang;
        private DataGridViewTextBoxColumn MaKhachHang;
        public DataGridView dgvKhachHang;
    }
}