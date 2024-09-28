namespace GUI
{
    partial class ChiTietPhieuNhapGUI
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
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            panel2 = new Panel();
            label2 = new Label();
            danhSachChiPhieuNhap = new DataGridView();
            MaChiTietPhieuNhap = new DataGridViewTextBoxColumn();
            MaPhieuNhap = new DataGridViewTextBoxColumn();
            MaSanPham = new DataGridViewTextBoxColumn();
            MauSac = new DataGridViewTextBoxColumn();
            MaKichCo = new DataGridViewTextBoxColumn();
            SoLuongNhap = new DataGridViewTextBoxColumn();
            DonVi = new DataGridViewTextBoxColumn();
            TienNhap = new DataGridViewTextBoxColumn();
            ThanhTien = new DataGridViewTextBoxColumn();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)danhSachChiPhieuNhap).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.MediumSeaGreen;
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1600, 100);
            panel2.TabIndex = 70;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Display", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(632, 30);
            label2.Name = "label2";
            label2.Size = new Size(279, 37);
            label2.TabIndex = 0;
            label2.Text = "Chi Tiết Phiếu Nhập";
            // 
            // danhSachChiPhieuNhap
            // 
            danhSachChiPhieuNhap.AllowUserToAddRows = false;
            danhSachChiPhieuNhap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            danhSachChiPhieuNhap.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            danhSachChiPhieuNhap.BackgroundColor = SystemColors.ButtonHighlight;
            danhSachChiPhieuNhap.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            danhSachChiPhieuNhap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            danhSachChiPhieuNhap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            danhSachChiPhieuNhap.Columns.AddRange(new DataGridViewColumn[] { MaChiTietPhieuNhap, MaPhieuNhap, MaSanPham, MauSac, MaKichCo, SoLuongNhap, DonVi, TienNhap, ThanhTien });
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = SystemColors.Window;
            dataGridViewCellStyle11.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            danhSachChiPhieuNhap.DefaultCellStyle = dataGridViewCellStyle11;
            danhSachChiPhieuNhap.Location = new Point(0, 99);
            danhSachChiPhieuNhap.Name = "danhSachChiPhieuNhap";
            danhSachChiPhieuNhap.RowHeadersWidth = 62;
            danhSachChiPhieuNhap.RowTemplate.Height = 33;
            danhSachChiPhieuNhap.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            danhSachChiPhieuNhap.Size = new Size(1600, 650);
            danhSachChiPhieuNhap.TabIndex = 71;
            danhSachChiPhieuNhap.CellContentClick += danhSachChiPhieuNhap_CellContentClick;
            // 
            // MaChiTietPhieuNhap
            // 
            dataGridViewCellStyle2.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            MaChiTietPhieuNhap.DefaultCellStyle = dataGridViewCellStyle2;
            MaChiTietPhieuNhap.HeaderText = "Mã chi tiết";
            MaChiTietPhieuNhap.MinimumWidth = 8;
            MaChiTietPhieuNhap.Name = "MaChiTietPhieuNhap";
            // 
            // MaPhieuNhap
            // 
            MaPhieuNhap.DataPropertyName = "MaPhieuNhap";
            dataGridViewCellStyle3.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            MaPhieuNhap.DefaultCellStyle = dataGridViewCellStyle3;
            MaPhieuNhap.HeaderText = "Tên phiếu";
            MaPhieuNhap.MinimumWidth = 8;
            MaPhieuNhap.Name = "MaPhieuNhap";
            // 
            // MaSanPham
            // 
            MaSanPham.DataPropertyName = "MaSanPham";
            dataGridViewCellStyle4.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            MaSanPham.DefaultCellStyle = dataGridViewCellStyle4;
            MaSanPham.HeaderText = "Tên sản phẩm";
            MaSanPham.MinimumWidth = 8;
            MaSanPham.Name = "MaSanPham";
            // 
            // MauSac
            // 
            MauSac.DataPropertyName = "MaMauSac";
            dataGridViewCellStyle5.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            MauSac.DefaultCellStyle = dataGridViewCellStyle5;
            MauSac.HeaderText = "Màu sắc";
            MauSac.MinimumWidth = 8;
            MauSac.Name = "MauSac";
            // 
            // MaKichCo
            // 
            MaKichCo.DataPropertyName = "MaKichCo";
            dataGridViewCellStyle6.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            MaKichCo.DefaultCellStyle = dataGridViewCellStyle6;
            MaKichCo.HeaderText = "Kích cỡ";
            MaKichCo.MinimumWidth = 8;
            MaKichCo.Name = "MaKichCo";
            // 
            // SoLuongNhap
            // 
            SoLuongNhap.DataPropertyName = "SoLuongNhap";
            dataGridViewCellStyle7.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle7.SelectionForeColor = Color.White;
            SoLuongNhap.DefaultCellStyle = dataGridViewCellStyle7;
            SoLuongNhap.HeaderText = "Số lượng";
            SoLuongNhap.MinimumWidth = 8;
            SoLuongNhap.Name = "SoLuongNhap";
            // 
            // DonVi
            // 
            DonVi.DataPropertyName = "DonVi";
            dataGridViewCellStyle8.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle8.SelectionForeColor = Color.White;
            DonVi.DefaultCellStyle = dataGridViewCellStyle8;
            DonVi.HeaderText = "Đơn vị";
            DonVi.MinimumWidth = 8;
            DonVi.Name = "DonVi";
            // 
            // TienNhap
            // 
            TienNhap.DataPropertyName = "TienNhap";
            dataGridViewCellStyle9.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle9.SelectionForeColor = Color.White;
            TienNhap.DefaultCellStyle = dataGridViewCellStyle9;
            TienNhap.HeaderText = "Tiền nhập";
            TienNhap.MinimumWidth = 8;
            TienNhap.Name = "TienNhap";
            // 
            // ThanhTien
            // 
            ThanhTien.DataPropertyName = "ThanhTien";
            dataGridViewCellStyle10.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle10.SelectionForeColor = Color.White;
            ThanhTien.DefaultCellStyle = dataGridViewCellStyle10;
            ThanhTien.HeaderText = "Thành tiền";
            ThanhTien.MinimumWidth = 8;
            ThanhTien.Name = "ThanhTien";
            // 
            // ChiTietPhieuNhapGUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 900);
            Controls.Add(panel2);
            Controls.Add(danhSachChiPhieuNhap);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ChiTietPhieuNhapGUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChiTietPhieuNhapGUI";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)danhSachChiPhieuNhap).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label2;
        private DataGridView danhSachChiPhieuNhap;
        private DataGridViewTextBoxColumn MaChiTietPhieuNhap;
        private DataGridViewTextBoxColumn MaPhieuNhap;
        private DataGridViewTextBoxColumn MaSanPham;
        private DataGridViewTextBoxColumn MauSac;
        private DataGridViewTextBoxColumn MaKichCo;
        private DataGridViewTextBoxColumn SoLuongNhap;
        private DataGridViewTextBoxColumn DonVi;
        private DataGridViewTextBoxColumn TienNhap;
        private DataGridViewTextBoxColumn ThanhTien;
    }
}