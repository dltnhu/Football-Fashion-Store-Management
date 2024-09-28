namespace GUI
{
    partial class NhanVienModule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhanVienModule));
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            txtTenNhanVien = new TextBox();
            txtTuoi = new TextBox();
            label3 = new Label();
            txtSoDienThoai = new TextBox();
            label4 = new Label();
            label5 = new Label();
            picNhanVien = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnThem = new Button();
            btnSua = new Button();
            btnThoat = new Button();
            btnChonAnh = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picNhanVien).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumSeaGreen;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(385, 100);
            panel1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Text", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(106, 30);
            label1.Name = "label1";
            label1.Size = new Size(155, 37);
            label1.TabIndex = 1;
            label1.Text = "Nhân Viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.MediumSeaGreen;
            label2.Location = new Point(39, 126);
            label2.Name = "label2";
            label2.Size = new Size(98, 27);
            label2.TabIndex = 6;
            label2.Text = "Họ Và Tên";
            // 
            // txtTenNhanVien
            // 
            txtTenNhanVien.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenNhanVien.Location = new Point(39, 156);
            txtTenNhanVien.Name = "txtTenNhanVien";
            txtTenNhanVien.Size = new Size(308, 34);
            txtTenNhanVien.TabIndex = 7;
            // 
            // txtTuoi
            // 
            txtTuoi.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtTuoi.Location = new Point(39, 242);
            txtTuoi.Name = "txtTuoi";
            txtTuoi.Size = new Size(308, 34);
            txtTuoi.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.MediumSeaGreen;
            label3.Location = new Point(39, 212);
            label3.Name = "label3";
            label3.Size = new Size(50, 27);
            label3.TabIndex = 8;
            label3.Text = "Tuổi";
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtSoDienThoai.Location = new Point(39, 336);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(308, 34);
            txtSoDienThoai.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.MediumSeaGreen;
            label4.Location = new Point(39, 306);
            label4.Name = "label4";
            label4.Size = new Size(133, 27);
            label4.TabIndex = 10;
            label4.Text = "Số Điện Thoại";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.MediumSeaGreen;
            label5.Location = new Point(44, 398);
            label5.Name = "label5";
            label5.Size = new Size(93, 27);
            label5.TabIndex = 12;
            label5.Text = "Hình Ảnh";
            // 
            // picNhanVien
            // 
            picNhanVien.BorderStyle = BorderStyle.FixedSingle;
            picNhanVien.Image = (Image)resources.GetObject("picNhanVien.Image");
            picNhanVien.Location = new Point(106, 450);
            picNhanVien.Name = "picNhanVien";
            picNhanVien.Size = new Size(171, 177);
            picNhanVien.SizeMode = PictureBoxSizeMode.StretchImage;
            picNhanVien.TabIndex = 13;
            picNhanVien.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnThem);
            flowLayoutPanel1.Controls.Add(btnSua);
            flowLayoutPanel1.Controls.Add(btnThoat);
            flowLayoutPanel1.Location = new Point(30, 718);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(326, 58);
            flowLayoutPanel1.TabIndex = 14;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.MediumSeaGreen;
            btnThem.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnThem.ForeColor = SystemColors.ButtonHighlight;
            btnThem.Location = new Point(3, 3);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(157, 51);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.Orange;
            btnSua.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnSua.ForeColor = SystemColors.ButtonHighlight;
            btnSua.Location = new Point(166, 3);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(157, 51);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.Red;
            btnThoat.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnThoat.ForeColor = Color.White;
            btnThoat.Location = new Point(3, 60);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(157, 51);
            btnThoat.TabIndex = 2;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnChonAnh
            // 
            btnChonAnh.BackColor = Color.DodgerBlue;
            btnChonAnh.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnChonAnh.ForeColor = SystemColors.ButtonHighlight;
            btnChonAnh.Location = new Point(106, 633);
            btnChonAnh.Name = "btnChonAnh";
            btnChonAnh.Size = new Size(171, 51);
            btnChonAnh.TabIndex = 3;
            btnChonAnh.Text = "Chọn Ảnh";
            btnChonAnh.UseVisualStyleBackColor = false;
            btnChonAnh.Click += btnChonAnh_Click;
            // 
            // NhanVienModule
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 806);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(picNhanVien);
            Controls.Add(label5);
            Controls.Add(btnChonAnh);
            Controls.Add(txtSoDienThoai);
            Controls.Add(label4);
            Controls.Add(txtTuoi);
            Controls.Add(label3);
            Controls.Add(txtTenNhanVien);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NhanVienModule";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NhanVienModule";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picNhanVien).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private FlowLayoutPanel flowLayoutPanel1;
        public Button btnThem;
        public Button btnSua;
        public Button btnThoat;
        public Button btnChonAnh;
        public TextBox txtTenNhanVien;
        public TextBox txtTuoi;
        public TextBox txtSoDienThoai;
        public PictureBox picNhanVien;
    }
}