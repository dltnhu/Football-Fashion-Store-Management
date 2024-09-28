namespace GUI
{
    partial class PhieuNhapGUI
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
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhieuNhapGUI));
            danhSachPhieuNhap = new DataGridView();
            MaPhieuNhap = new DataGridViewTextBoxColumn();
            MaNhaCungCap = new DataGridViewTextBoxColumn();
            MaNhanVien = new DataGridViewTextBoxColumn();
            NgayNhap = new DataGridViewTextBoxColumn();
            TenPhieuNhap = new DataGridViewTextBoxColumn();
            TongTien = new DataGridViewTextBoxColumn();
            ChiTiet = new DataGridViewImageColumn();
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            txtTimKiem = new TextBox();
            btnShowDialog = new Button();
            ((System.ComponentModel.ISupportInitialize)danhSachPhieuNhap).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // danhSachPhieuNhap
            // 
            danhSachPhieuNhap.AllowUserToAddRows = false;
            danhSachPhieuNhap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            danhSachPhieuNhap.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            danhSachPhieuNhap.BackgroundColor = SystemColors.ButtonHighlight;
            danhSachPhieuNhap.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            danhSachPhieuNhap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            danhSachPhieuNhap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            danhSachPhieuNhap.Columns.AddRange(new DataGridViewColumn[] { MaPhieuNhap, MaNhaCungCap, MaNhanVien, NgayNhap, TenPhieuNhap, TongTien, ChiTiet });
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Window;
            dataGridViewCellStyle9.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            danhSachPhieuNhap.DefaultCellStyle = dataGridViewCellStyle9;
            danhSachPhieuNhap.Location = new Point(0, 94);
            danhSachPhieuNhap.Name = "danhSachPhieuNhap";
            danhSachPhieuNhap.RowHeadersWidth = 62;
            danhSachPhieuNhap.RowTemplate.Height = 33;
            danhSachPhieuNhap.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            danhSachPhieuNhap.Size = new Size(1600, 642);
            danhSachPhieuNhap.TabIndex = 10;
            danhSachPhieuNhap.CellContentClick += danhSachPhieuNhap_CellContentClick;
            // 
            // MaPhieuNhap
            // 
            MaPhieuNhap.DataPropertyName = "MaPhieuNhap";
            dataGridViewCellStyle2.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            MaPhieuNhap.DefaultCellStyle = dataGridViewCellStyle2;
            MaPhieuNhap.HeaderText = "Mã phiếu nhập";
            MaPhieuNhap.MinimumWidth = 8;
            MaPhieuNhap.Name = "MaPhieuNhap";
            // 
            // MaNhaCungCap
            // 
            MaNhaCungCap.DataPropertyName = "MaNhaCungCap";
            dataGridViewCellStyle3.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            MaNhaCungCap.DefaultCellStyle = dataGridViewCellStyle3;
            MaNhaCungCap.HeaderText = "Nhà cung cấp";
            MaNhaCungCap.MinimumWidth = 8;
            MaNhaCungCap.Name = "MaNhaCungCap";
            // 
            // MaNhanVien
            // 
            MaNhanVien.DataPropertyName = "MaNhanVien";
            dataGridViewCellStyle4.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            MaNhanVien.DefaultCellStyle = dataGridViewCellStyle4;
            MaNhanVien.HeaderText = "Nhân viên";
            MaNhanVien.MinimumWidth = 8;
            MaNhanVien.Name = "MaNhanVien";
            // 
            // NgayNhap
            // 
            NgayNhap.DataPropertyName = "NgayNhap";
            dataGridViewCellStyle5.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            NgayNhap.DefaultCellStyle = dataGridViewCellStyle5;
            NgayNhap.HeaderText = "Ngày nhập";
            NgayNhap.MinimumWidth = 8;
            NgayNhap.Name = "NgayNhap";
            // 
            // TenPhieuNhap
            // 
            TenPhieuNhap.DataPropertyName = "TenPhieuNhap";
            dataGridViewCellStyle6.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            TenPhieuNhap.DefaultCellStyle = dataGridViewCellStyle6;
            TenPhieuNhap.HeaderText = "Tên phiếu nhập";
            TenPhieuNhap.MinimumWidth = 8;
            TenPhieuNhap.Name = "TenPhieuNhap";
            // 
            // TongTien
            // 
            TongTien.DataPropertyName = "TongTien";
            dataGridViewCellStyle7.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle7.SelectionForeColor = Color.White;
            TongTien.DefaultCellStyle = dataGridViewCellStyle7;
            TongTien.HeaderText = "Tổng tiền";
            TongTien.MinimumWidth = 8;
            TongTien.Name = "TongTien";
            // 
            // ChiTiet
            // 
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.NullValue = resources.GetObject("dataGridViewCellStyle8.NullValue");
            dataGridViewCellStyle8.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle8.SelectionForeColor = Color.White;
            ChiTiet.DefaultCellStyle = dataGridViewCellStyle8;
            ChiTiet.HeaderText = "Chi tiết";
            ChiTiet.Image = (Image)resources.GetObject("ChiTiet.Image");
            ChiTiet.MinimumWidth = 8;
            ChiTiet.Name = "ChiTiet";
            ChiTiet.Resizable = DataGridViewTriState.True;
            ChiTiet.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Display", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(684, 32);
            label1.Name = "label1";
            label1.Size = new Size(169, 37);
            label1.TabIndex = 0;
            label1.Text = "Phiếu Nhập";
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumSeaGreen;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1600, 100);
            panel1.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.MediumSeaGreen;
            label2.Location = new Point(12, 758);
            label2.Name = "label2";
            label2.Size = new Size(115, 32);
            label2.TabIndex = 14;
            label2.Text = "Tìm Kiếm";
            // 
            // txtTimKiem
            // 
            txtTimKiem.BorderStyle = BorderStyle.FixedSingle;
            txtTimKiem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimKiem.Location = new Point(133, 756);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(295, 39);
            txtTimKiem.TabIndex = 13;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // btnShowDialog
            // 
            btnShowDialog.BackColor = Color.MediumSeaGreen;
            btnShowDialog.Font = new Font("Segoe UI Variable Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnShowDialog.ForeColor = SystemColors.ButtonHighlight;
            btnShowDialog.Location = new Point(1399, 742);
            btnShowDialog.Name = "btnShowDialog";
            btnShowDialog.Size = new Size(189, 65);
            btnShowDialog.TabIndex = 12;
            btnShowDialog.Text = "Thêm";
            btnShowDialog.UseVisualStyleBackColor = false;
            btnShowDialog.Click += btnShowDialog_Click;
            // 
            // PhieuNhapGUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 900);
            Controls.Add(label2);
            Controls.Add(txtTimKiem);
            Controls.Add(btnShowDialog);
            Controls.Add(danhSachPhieuNhap);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PhieuNhapGUI";
            Text = "PhieuNhapGUI";
            ((System.ComponentModel.ISupportInitialize)danhSachPhieuNhap).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView danhSachPhieuNhap;
        private DataGridViewTextBoxColumn MaPhieuNhap;
        private DataGridViewTextBoxColumn MaNhaCungCap;
        private DataGridViewTextBoxColumn MaNhanVien;
        private DataGridViewTextBoxColumn NgayNhap;
        private DataGridViewTextBoxColumn TenPhieuNhap;
        private DataGridViewTextBoxColumn TongTien;
        private DataGridViewImageColumn ChiTiet;
        private Label label1;
        private Panel panel1;
        private Label label2;
        private TextBox txtTimKiem;
        public Button btnShowDialog;
    }
}