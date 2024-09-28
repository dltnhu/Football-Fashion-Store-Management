namespace GUI
{
    partial class TheLoaiGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TheLoaiGUI));
            panel1 = new Panel();
            label1 = new Label();
            danhSachTheLoai = new DataGridView();
            MaTheLoai = new DataGridViewTextBoxColumn();
            TenTheLoai = new DataGridViewTextBoxColumn();
            Xoa = new DataGridViewImageColumn();
            Sua = new DataGridViewImageColumn();
            ChiTiet = new DataGridViewImageColumn();
            label2 = new Label();
            txtTimKiem = new TextBox();
            btnShowDialog = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)danhSachTheLoai).BeginInit();
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
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Small", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(672, 20);
            label1.Name = "label1";
            label1.Size = new Size(166, 48);
            label1.TabIndex = 0;
            label1.Text = "Thể Loại";
            // 
            // danhSachTheLoai
            // 
            danhSachTheLoai.AllowUserToAddRows = false;
            danhSachTheLoai.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            danhSachTheLoai.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            danhSachTheLoai.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            danhSachTheLoai.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            danhSachTheLoai.BackgroundColor = SystemColors.ButtonHighlight;
            danhSachTheLoai.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            danhSachTheLoai.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            danhSachTheLoai.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            danhSachTheLoai.Columns.AddRange(new DataGridViewColumn[] { MaTheLoai, TenTheLoai, Xoa, Sua, ChiTiet });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            danhSachTheLoai.DefaultCellStyle = dataGridViewCellStyle3;
            danhSachTheLoai.Location = new Point(0, 95);
            danhSachTheLoai.Name = "danhSachTheLoai";
            danhSachTheLoai.ReadOnly = true;
            danhSachTheLoai.RowHeadersWidth = 62;
            danhSachTheLoai.RowTemplate.Height = 33;
            danhSachTheLoai.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            danhSachTheLoai.Size = new Size(1600, 650);
            danhSachTheLoai.TabIndex = 4;
            danhSachTheLoai.CellContentClick += danhSachTheLoai_CellContentClick;
            // 
            // MaTheLoai
            // 
            MaTheLoai.DataPropertyName = "MaTheLoai";
            MaTheLoai.HeaderText = "Mã Thể Loại";
            MaTheLoai.MinimumWidth = 8;
            MaTheLoai.Name = "MaTheLoai";
            MaTheLoai.ReadOnly = true;
            // 
            // TenTheLoai
            // 
            TenTheLoai.DataPropertyName = "TenTheLoai";
            TenTheLoai.HeaderText = "Tên Thể Loại";
            TenTheLoai.MinimumWidth = 8;
            TenTheLoai.Name = "TenTheLoai";
            TenTheLoai.ReadOnly = true;
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
            label2.Location = new Point(12, 767);
            label2.Name = "label2";
            label2.Size = new Size(115, 32);
            label2.TabIndex = 9;
            label2.Text = "Tìm Kiếm";
            // 
            // txtTimKiem
            // 
            txtTimKiem.BorderStyle = BorderStyle.FixedSingle;
            txtTimKiem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimKiem.Location = new Point(133, 765);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(295, 39);
            txtTimKiem.TabIndex = 8;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // btnShowDialog
            // 
            btnShowDialog.BackColor = Color.MediumSeaGreen;
            btnShowDialog.Font = new Font("Segoe UI Variable Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnShowDialog.ForeColor = SystemColors.ButtonHighlight;
            btnShowDialog.Location = new Point(1399, 751);
            btnShowDialog.Name = "btnShowDialog";
            btnShowDialog.Size = new Size(189, 65);
            btnShowDialog.TabIndex = 7;
            btnShowDialog.Text = "Thêm";
            btnShowDialog.UseVisualStyleBackColor = false;
            btnShowDialog.Click += btnShowDialog_Click;
            // 
            // TheLoaiGUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 900);
            Controls.Add(label2);
            Controls.Add(txtTimKiem);
            Controls.Add(btnShowDialog);
            Controls.Add(danhSachTheLoai);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TheLoaiGUI";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)danhSachTheLoai).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        public DataGridView danhSachTheLoai;
        private Label label2;
        private TextBox txtTimKiem;
        public Button btnShowDialog;
        private DataGridViewTextBoxColumn MaTheLoai;
        private DataGridViewTextBoxColumn TenTheLoai;
        private DataGridViewImageColumn Xoa;
        private DataGridViewImageColumn Sua;
        private DataGridViewImageColumn ChiTiet;
    }
}