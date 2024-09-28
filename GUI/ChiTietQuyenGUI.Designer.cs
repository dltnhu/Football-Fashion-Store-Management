namespace GUI
{
    partial class ChiTietQuyenGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChiTietQuyenGUI));
            panel1 = new Panel();
            label1 = new Label();
            danhSachChiTietQuyen = new DataGridView();
            MaChiTietQuyen = new DataGridViewTextBoxColumn();
            MaNhomQuyen = new DataGridViewTextBoxColumn();
            ChucNang = new DataGridViewTextBoxColumn();
            HanhDong = new DataGridViewTextBoxColumn();
            Xoa = new DataGridViewImageColumn();
            Sua = new DataGridViewImageColumn();
            ChiTiet = new DataGridViewImageColumn();
            txtTimKiem = new TextBox();
            btnShowDialog = new Button();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)danhSachChiTietQuyen).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumSeaGreen;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1280, 80);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Small", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(524, 20);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(231, 40);
            label1.TabIndex = 0;
            label1.Text = "Chi Tiết Quyền";
            // 
            // danhSachChiTietQuyen
            // 
            danhSachChiTietQuyen.AllowUserToAddRows = false;
            danhSachChiTietQuyen.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            danhSachChiTietQuyen.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            danhSachChiTietQuyen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            danhSachChiTietQuyen.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            danhSachChiTietQuyen.BackgroundColor = SystemColors.ButtonHighlight;
            danhSachChiTietQuyen.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            danhSachChiTietQuyen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            danhSachChiTietQuyen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            danhSachChiTietQuyen.Columns.AddRange(new DataGridViewColumn[] { MaChiTietQuyen, MaNhomQuyen, ChucNang, HanhDong, Xoa, Sua, ChiTiet });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            danhSachChiTietQuyen.DefaultCellStyle = dataGridViewCellStyle3;
            danhSachChiTietQuyen.Location = new Point(0, 76);
            danhSachChiTietQuyen.Margin = new Padding(2, 2, 2, 2);
            danhSachChiTietQuyen.Name = "danhSachChiTietQuyen";
            danhSachChiTietQuyen.ReadOnly = true;
            danhSachChiTietQuyen.RowHeadersWidth = 62;
            danhSachChiTietQuyen.RowTemplate.Height = 33;
            danhSachChiTietQuyen.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            danhSachChiTietQuyen.Size = new Size(1280, 520);
            danhSachChiTietQuyen.TabIndex = 3;
            danhSachChiTietQuyen.CellContentClick += danhSachChiTietQuyen_CellContentClick;
            // 
            // MaChiTietQuyen
            // 
            MaChiTietQuyen.DataPropertyName = "MaChiTietQuyen";
            MaChiTietQuyen.HeaderText = "Mã Chi Tiết";
            MaChiTietQuyen.MinimumWidth = 8;
            MaChiTietQuyen.Name = "MaChiTietQuyen";
            MaChiTietQuyen.ReadOnly = true;
            // 
            // MaNhomQuyen
            // 
            MaNhomQuyen.DataPropertyName = "MaNhomQuyen";
            MaNhomQuyen.HeaderText = "Nhóm Quyền";
            MaNhomQuyen.MinimumWidth = 8;
            MaNhomQuyen.Name = "MaNhomQuyen";
            MaNhomQuyen.ReadOnly = true;
            // 
            // ChucNang
            // 
            ChucNang.DataPropertyName = "ChucNang";
            ChucNang.HeaderText = "Chức Năng";
            ChucNang.MinimumWidth = 8;
            ChucNang.Name = "ChucNang";
            ChucNang.ReadOnly = true;
            // 
            // HanhDong
            // 
            HanhDong.DataPropertyName = "HanhDong";
            HanhDong.HeaderText = "Hành Động";
            HanhDong.MinimumWidth = 8;
            HanhDong.Name = "HanhDong";
            HanhDong.ReadOnly = true;
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
            // txtTimKiem
            // 
            txtTimKiem.BorderStyle = BorderStyle.FixedSingle;
            txtTimKiem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimKiem.Location = new Point(106, 612);
            txtTimKiem.Margin = new Padding(2, 2, 2, 2);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(236, 34);
            txtTimKiem.TabIndex = 7;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // btnShowDialog
            // 
            btnShowDialog.BackColor = Color.MediumSeaGreen;
            btnShowDialog.Font = new Font("Segoe UI Variable Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnShowDialog.ForeColor = SystemColors.ButtonHighlight;
            btnShowDialog.Location = new Point(1119, 601);
            btnShowDialog.Margin = new Padding(2, 2, 2, 2);
            btnShowDialog.Name = "btnShowDialog";
            btnShowDialog.Size = new Size(151, 52);
            btnShowDialog.TabIndex = 9;
            btnShowDialog.Text = "Thêm";
            btnShowDialog.UseVisualStyleBackColor = false;
            btnShowDialog.Click += btnShowDialog_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.MediumSeaGreen;
            label2.Location = new Point(10, 614);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(93, 27);
            label2.TabIndex = 10;
            label2.Text = "Tìm Kiếm";
            // 
            // ChiTietQuyenGUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 720);
            Controls.Add(label2);
            Controls.Add(btnShowDialog);
            Controls.Add(txtTimKiem);
            Controls.Add(danhSachChiTietQuyen);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 2, 2, 2);
            Name = "ChiTietQuyenGUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChiTietQuyenGUI";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)danhSachChiTietQuyen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox txtTimKiem;
        public DataGridView danhSachChiTietQuyen;
        private DataGridViewTextBoxColumn MaChiTietQuyen;
        private DataGridViewTextBoxColumn MaNhomQuyen;
        private DataGridViewTextBoxColumn ChucNang;
        private DataGridViewTextBoxColumn HanhDong;
        private DataGridViewImageColumn Xoa;
        private DataGridViewImageColumn Sua;
        private DataGridViewImageColumn ChiTiet;
        private Label label2;
        public Button btnShowDialog;
    }
}