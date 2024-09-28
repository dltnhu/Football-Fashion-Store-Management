namespace GUI
{
    partial class TaiKhoanModule
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
            panel1 = new Panel();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnThem = new Button();
            btnSua = new Button();
            btnThoat = new Button();
            label2 = new Label();
            comboBoxNhanVien = new ComboBox();
            comboBoxNhomQuyen = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtTenDangNhap = new TextBox();
            txtMatKhau = new TextBox();
            panel1.SuspendLayout();
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
            panel1.Size = new Size(400, 100);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Text", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(124, 28);
            label1.Name = "label1";
            label1.Size = new Size(145, 37);
            label1.TabIndex = 1;
            label1.Text = "Tài Khoản";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnThem);
            flowLayoutPanel1.Controls.Add(btnSua);
            flowLayoutPanel1.Controls.Add(btnThoat);
            flowLayoutPanel1.Location = new Point(37, 492);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(326, 59);
            flowLayoutPanel1.TabIndex = 4;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.MediumSeaGreen;
            label2.Location = new Point(37, 122);
            label2.Name = "label2";
            label2.Size = new Size(102, 27);
            label2.TabIndex = 5;
            label2.Text = "Nhân Viên";
            // 
            // comboBoxNhanVien
            // 
            comboBoxNhanVien.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxNhanVien.FormattingEnabled = true;
            comboBoxNhanVien.Location = new Point(37, 152);
            comboBoxNhanVien.Name = "comboBoxNhanVien";
            comboBoxNhanVien.Size = new Size(326, 35);
            comboBoxNhanVien.TabIndex = 6;
            // 
            // comboBoxNhomQuyen
            // 
            comboBoxNhomQuyen.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxNhomQuyen.FormattingEnabled = true;
            comboBoxNhomQuyen.Location = new Point(37, 243);
            comboBoxNhomQuyen.Name = "comboBoxNhomQuyen";
            comboBoxNhomQuyen.Size = new Size(326, 35);
            comboBoxNhomQuyen.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.MediumSeaGreen;
            label3.Location = new Point(37, 213);
            label3.Name = "label3";
            label3.Size = new Size(129, 27);
            label3.TabIndex = 7;
            label3.Text = "Nhóm Quyền";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.MediumSeaGreen;
            label4.Location = new Point(37, 395);
            label4.Name = "label4";
            label4.Size = new Size(96, 27);
            label4.TabIndex = 11;
            label4.Text = "Mật Khẩu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.MediumSeaGreen;
            label5.Location = new Point(37, 304);
            label5.Name = "label5";
            label5.Size = new Size(146, 27);
            label5.TabIndex = 9;
            label5.Text = "Tên Đăng Nhập";
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenDangNhap.Location = new Point(37, 334);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(326, 34);
            txtTenDangNhap.TabIndex = 13;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtMatKhau.Location = new Point(37, 425);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(326, 34);
            txtMatKhau.TabIndex = 14;
            // 
            // TaiKhoanModule
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 577);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTenDangNhap);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(comboBoxNhomQuyen);
            Controls.Add(label3);
            Controls.Add(comboBoxNhanVien);
            Controls.Add(label2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TaiKhoanModule";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TaiKhoanModule";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        public Button btnThem;
        public Button btnSua;
        public Button btnThoat;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        public ComboBox comboBoxNhanVien;
        public ComboBox comboBoxNhomQuyen;
        public TextBox txtTenDangNhap;
        public TextBox txtMatKhau;
    }
}