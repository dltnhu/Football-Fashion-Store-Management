namespace GUI
{
    partial class ChucNangGUI
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChucNangGUI));
            panel1 = new Panel();
            label1 = new Label();
            danhSachChucNang = new DataGridView();
            MaChucNang = new DataGridViewTextBoxColumn();
            TenChucNang = new DataGridViewTextBoxColumn();
            Xoa = new DataGridViewImageColumn();
            Sua = new DataGridViewImageColumn();
            ChiTiet = new DataGridViewImageColumn();
            btnShowDialog = new Button();
            txtTimKiem = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)danhSachChucNang).BeginInit();
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
            label1.Font = new Font("Segoe UI Variable Small", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(666, 23);
            label1.Name = "label1";
            label1.Size = new Size(212, 48);
            label1.TabIndex = 0;
            label1.Text = "Chức Năng";
            // 
            // danhSachChucNang
            // 
            danhSachChucNang.AllowUserToAddRows = false;
            danhSachChucNang.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            danhSachChucNang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            danhSachChucNang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            danhSachChucNang.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            danhSachChucNang.BackgroundColor = SystemColors.ButtonHighlight;
            danhSachChucNang.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            danhSachChucNang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            danhSachChucNang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            danhSachChucNang.Columns.AddRange(new DataGridViewColumn[] { MaChucNang, TenChucNang, Xoa, Sua, ChiTiet });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            danhSachChucNang.DefaultCellStyle = dataGridViewCellStyle6;
            danhSachChucNang.Location = new Point(0, 97);
            danhSachChucNang.Name = "danhSachChucNang";
            danhSachChucNang.ReadOnly = true;
            danhSachChucNang.RowHeadersWidth = 62;
            danhSachChucNang.RowTemplate.Height = 33;
            danhSachChucNang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            danhSachChucNang.Size = new Size(1600, 650);
            danhSachChucNang.TabIndex = 2;
            danhSachChucNang.CellContentClick += danhSachChucNang_CellContentClick;
            // 
            // MaChucNang
            // 
            MaChucNang.DataPropertyName = "MaChucNang";
            MaChucNang.HeaderText = "Mã Chức Năng";
            MaChucNang.MinimumWidth = 8;
            MaChucNang.Name = "MaChucNang";
            MaChucNang.ReadOnly = true;
            // 
            // TenChucNang
            // 
            TenChucNang.DataPropertyName = "TenChucNang";
            TenChucNang.HeaderText = "Tên Chức Năng";
            TenChucNang.MinimumWidth = 8;
            TenChucNang.Name = "TenChucNang";
            TenChucNang.ReadOnly = true;
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
            // btnShowDialog
            // 
            btnShowDialog.BackColor = Color.MediumSeaGreen;
            btnShowDialog.Font = new Font("Segoe UI Variable Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnShowDialog.ForeColor = SystemColors.ButtonHighlight;
            btnShowDialog.Location = new Point(1399, 753);
            btnShowDialog.Name = "btnShowDialog";
            btnShowDialog.Size = new Size(189, 65);
            btnShowDialog.TabIndex = 3;
            btnShowDialog.Text = "Thêm";
            btnShowDialog.UseVisualStyleBackColor = false;
            btnShowDialog.Click += btnShowDialog_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.BorderStyle = BorderStyle.FixedSingle;
            txtTimKiem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimKiem.Location = new Point(133, 767);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(295, 39);
            txtTimKiem.TabIndex = 5;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.MediumSeaGreen;
            label2.Location = new Point(12, 769);
            label2.Name = "label2";
            label2.Size = new Size(115, 32);
            label2.TabIndex = 6;
            label2.Text = "Tìm Kiếm";
            // 
            // ChucNangGUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 900);
            Controls.Add(label2);
            Controls.Add(txtTimKiem);
            Controls.Add(btnShowDialog);
            Controls.Add(danhSachChucNang);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ChucNangGUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChucNangGUI";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)danhSachChucNang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label label1;
        private DataGridViewTextBoxColumn MaChucNang;
        private DataGridViewTextBoxColumn TenChucNang;
        private DataGridViewImageColumn Xoa;
        private DataGridViewImageColumn Sua;
        private DataGridViewImageColumn ChiTiet;
        private TextBox txtTimKiem;
        private Label label2;
        public DataGridView danhSachChucNang;
        public Button btnShowDialog;
    }
}