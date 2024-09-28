namespace GUI
{
    partial class KhuyenMaiGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KhuyenMaiGUI));
            panel1 = new Panel();
            label1 = new Label();
            danhSachKhuyenMai = new DataGridView();
            MaKhuyenMai = new DataGridViewTextBoxColumn();
            MucKhuyenMai = new DataGridViewTextBoxColumn();
            DieuKien = new DataGridViewTextBoxColumn();
            ThoiGianBatDau = new DataGridViewTextBoxColumn();
            ThoiGianKetThuc = new DataGridViewTextBoxColumn();
            Xoa = new DataGridViewImageColumn();
            Sua = new DataGridViewImageColumn();
            ChiTiet = new DataGridViewImageColumn();
            label2 = new Label();
            txtTimKiem = new TextBox();
            btnShowDialog = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)danhSachKhuyenMai).BeginInit();
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
            panel1.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Small", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(651, 24);
            label1.Name = "label1";
            label1.Size = new Size(226, 48);
            label1.TabIndex = 0;
            label1.Text = "Khuyến Mãi";
            // 
            // danhSachKhuyenMai
            // 
            danhSachKhuyenMai.AllowUserToAddRows = false;
            danhSachKhuyenMai.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            danhSachKhuyenMai.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            danhSachKhuyenMai.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            danhSachKhuyenMai.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            danhSachKhuyenMai.BackgroundColor = SystemColors.ButtonHighlight;
            danhSachKhuyenMai.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            danhSachKhuyenMai.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            danhSachKhuyenMai.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            danhSachKhuyenMai.Columns.AddRange(new DataGridViewColumn[] { MaKhuyenMai, MucKhuyenMai, DieuKien, ThoiGianBatDau, ThoiGianKetThuc, Xoa, Sua, ChiTiet });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            danhSachKhuyenMai.DefaultCellStyle = dataGridViewCellStyle3;
            danhSachKhuyenMai.Location = new Point(0, 97);
            danhSachKhuyenMai.Name = "danhSachKhuyenMai";
            danhSachKhuyenMai.ReadOnly = true;
            danhSachKhuyenMai.RowHeadersWidth = 62;
            danhSachKhuyenMai.RowTemplate.Height = 33;
            danhSachKhuyenMai.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            danhSachKhuyenMai.Size = new Size(1600, 650);
            danhSachKhuyenMai.TabIndex = 17;
            danhSachKhuyenMai.CellContentClick += danhSachKhuyenMai_CellContentClick;
            // 
            // MaKhuyenMai
            // 
            MaKhuyenMai.DataPropertyName = "MaKhuyenMai";
            MaKhuyenMai.HeaderText = "Mã Khuyến Mãi";
            MaKhuyenMai.MinimumWidth = 8;
            MaKhuyenMai.Name = "MaKhuyenMai";
            MaKhuyenMai.ReadOnly = true;
            // 
            // MucKhuyenMai
            // 
            MucKhuyenMai.DataPropertyName = "MucKhuyenMai";
            MucKhuyenMai.HeaderText = "Mức Khuyến Mãi";
            MucKhuyenMai.MinimumWidth = 8;
            MucKhuyenMai.Name = "MucKhuyenMai";
            MucKhuyenMai.ReadOnly = true;
            // 
            // DieuKien
            // 
            DieuKien.HeaderText = "Điều Kiện";
            DieuKien.MinimumWidth = 8;
            DieuKien.Name = "DieuKien";
            DieuKien.ReadOnly = true;
            // 
            // ThoiGianBatDau
            // 
            ThoiGianBatDau.HeaderText = "Bắt Đầu";
            ThoiGianBatDau.MinimumWidth = 8;
            ThoiGianBatDau.Name = "ThoiGianBatDau";
            ThoiGianBatDau.ReadOnly = true;
            // 
            // ThoiGianKetThuc
            // 
            ThoiGianKetThuc.HeaderText = "Kết Thúc";
            ThoiGianKetThuc.MinimumWidth = 8;
            ThoiGianKetThuc.Name = "ThoiGianKetThuc";
            ThoiGianKetThuc.ReadOnly = true;
            // 
            // Xoa
            // 
            Xoa.DataPropertyName = "Xoa";
            Xoa.HeaderText = "Xóa";
            Xoa.Image = (Image)resources.GetObject("Xoa.Image");
            Xoa.MinimumWidth = 8;
            Xoa.Name = "Xoa";
            Xoa.ReadOnly = true;
            Xoa.Resizable = DataGridViewTriState.True;
            Xoa.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Sua
            // 
            Sua.DataPropertyName = "Sua";
            Sua.HeaderText = "Sửa";
            Sua.Image = (Image)resources.GetObject("Sua.Image");
            Sua.MinimumWidth = 8;
            Sua.Name = "Sua";
            Sua.ReadOnly = true;
            Sua.Resizable = DataGridViewTriState.True;
            Sua.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // ChiTiet
            // 
            ChiTiet.DataPropertyName = "ChiTiet";
            ChiTiet.HeaderText = "Chi Tiết";
            ChiTiet.Image = (Image)resources.GetObject("ChiTiet.Image");
            ChiTiet.MinimumWidth = 8;
            ChiTiet.Name = "ChiTiet";
            ChiTiet.ReadOnly = true;
            ChiTiet.Resizable = DataGridViewTriState.True;
            ChiTiet.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.MediumSeaGreen;
            label2.Location = new Point(12, 769);
            label2.Name = "label2";
            label2.Size = new Size(115, 32);
            label2.TabIndex = 20;
            label2.Text = "Tìm Kiếm";
            // 
            // txtTimKiem
            // 
            txtTimKiem.BorderStyle = BorderStyle.FixedSingle;
            txtTimKiem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimKiem.Location = new Point(133, 767);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(295, 39);
            txtTimKiem.TabIndex = 19;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // btnShowDialog
            // 
            btnShowDialog.BackColor = Color.MediumSeaGreen;
            btnShowDialog.Font = new Font("Segoe UI Variable Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnShowDialog.ForeColor = SystemColors.ButtonHighlight;
            btnShowDialog.Location = new Point(1399, 753);
            btnShowDialog.Name = "btnShowDialog";
            btnShowDialog.Size = new Size(189, 65);
            btnShowDialog.TabIndex = 18;
            btnShowDialog.Text = "Thêm";
            btnShowDialog.UseVisualStyleBackColor = false;
            btnShowDialog.Click += btnShowDialog_Click;
            // 
            // KhuyenMaiGUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 900);
            Controls.Add(panel1);
            Controls.Add(danhSachKhuyenMai);
            Controls.Add(label2);
            Controls.Add(txtTimKiem);
            Controls.Add(btnShowDialog);
            FormBorderStyle = FormBorderStyle.None;
            Name = "KhuyenMaiGUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KhuyenMaiGUI";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)danhSachKhuyenMai).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        public DataGridView danhSachKhuyenMai;
        private DataGridViewTextBoxColumn MaKhuyenMai;
        private DataGridViewTextBoxColumn MucKhuyenMai;
        private DataGridViewTextBoxColumn DieuKien;
        private DataGridViewTextBoxColumn ThoiGianBatDau;
        private DataGridViewTextBoxColumn ThoiGianKetThuc;
        private DataGridViewImageColumn Xoa;
        private DataGridViewImageColumn Sua;
        private DataGridViewImageColumn ChiTiet;
        private Label label2;
        private TextBox txtTimKiem;
        public Button btnShowDialog;
    }
}