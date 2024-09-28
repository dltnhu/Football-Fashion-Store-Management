namespace GUI
{
    partial class NhomQuyenGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhomQuyenGUI));
            panel1 = new Panel();
            label1 = new Label();
            danhSachNhomQuyen = new DataGridView();
            MaNhomQuyen = new DataGridViewTextBoxColumn();
            TenNhomQuyen = new DataGridViewTextBoxColumn();
            Xoa = new DataGridViewImageColumn();
            Sua = new DataGridViewImageColumn();
            ChiTiet = new DataGridViewImageColumn();
            btnShowDialog = new Button();
            txtTimKiem = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)danhSachNhomQuyen).BeginInit();
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
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Small", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(624, 22);
            label1.Name = "label1";
            label1.Size = new Size(250, 48);
            label1.TabIndex = 0;
            label1.Text = "Nhóm Quyền";
            // 
            // danhSachNhomQuyen
            // 
            danhSachNhomQuyen.AllowUserToAddRows = false;
            danhSachNhomQuyen.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            danhSachNhomQuyen.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            danhSachNhomQuyen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            danhSachNhomQuyen.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            danhSachNhomQuyen.BackgroundColor = SystemColors.ButtonHighlight;
            danhSachNhomQuyen.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            danhSachNhomQuyen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            danhSachNhomQuyen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            danhSachNhomQuyen.Columns.AddRange(new DataGridViewColumn[] { MaNhomQuyen, TenNhomQuyen, Xoa, Sua, ChiTiet });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            danhSachNhomQuyen.DefaultCellStyle = dataGridViewCellStyle6;
            danhSachNhomQuyen.Location = new Point(0, 97);
            danhSachNhomQuyen.Name = "danhSachNhomQuyen";
            danhSachNhomQuyen.ReadOnly = true;
            danhSachNhomQuyen.RowHeadersWidth = 62;
            danhSachNhomQuyen.RowTemplate.Height = 33;
            danhSachNhomQuyen.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            danhSachNhomQuyen.Size = new Size(1600, 650);
            danhSachNhomQuyen.TabIndex = 1;
            danhSachNhomQuyen.CellContentClick += danhSachNhomQuyen_CellContentClick;
            // 
            // MaNhomQuyen
            // 
            MaNhomQuyen.DataPropertyName = "MaNhomQuyen";
            MaNhomQuyen.HeaderText = "Mã Nhóm Quyền";
            MaNhomQuyen.MinimumWidth = 8;
            MaNhomQuyen.Name = "MaNhomQuyen";
            MaNhomQuyen.ReadOnly = true;
            // 
            // TenNhomQuyen
            // 
            TenNhomQuyen.DataPropertyName = "TenNhomQuyen";
            TenNhomQuyen.HeaderText = "Tên Nhóm Quyền";
            TenNhomQuyen.MinimumWidth = 8;
            TenNhomQuyen.Name = "TenNhomQuyen";
            TenNhomQuyen.ReadOnly = true;
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
            btnShowDialog.TabIndex = 2;
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
            txtTimKiem.TabIndex = 3;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.MediumSeaGreen;
            label2.Location = new Point(12, 769);
            label2.Name = "label2";
            label2.Size = new Size(115, 32);
            label2.TabIndex = 5;
            label2.Text = "Tìm Kiếm";
            // 
            // NhomQuyenGUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 900);
            Controls.Add(label2);
            Controls.Add(txtTimKiem);
            Controls.Add(btnShowDialog);
            Controls.Add(danhSachNhomQuyen);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NhomQuyenGUI";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)danhSachNhomQuyen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridViewTextBoxColumn MaNhomQuyen;
        private DataGridViewTextBoxColumn TenNhomQuyen;
        private DataGridViewImageColumn Xoa;
        private DataGridViewImageColumn Sua;
        private DataGridViewImageColumn ChiTiet;
        private TextBox txtTimKiem;
        private Label label2;
        public DataGridView danhSachNhomQuyen;
        public Button btnShowDialog;
    }
}