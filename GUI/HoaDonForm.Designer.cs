namespace WindowsFormsApp3.GUI
{
    partial class HoaDonForm
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle70 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle61 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle62 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle63 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle64 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle65 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle66 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle67 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle68 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle69 = new DataGridViewCellStyle();
            bindingSource1 = new BindingSource(components);
            label5 = new Label();
            lbThoiLai = new Label();
            txtKhachDua = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label10 = new Label();
            txtTongTien = new TextBox();
            txtThue = new TextBox();
            txtTongThanhTien = new TextBox();
            txtKhuyenMai = new TextBox();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            groupBox1 = new GroupBox();
            btnThemKhachHang = new Button();
            label12 = new Label();
            label11 = new Label();
            txtDangKySoDienThoai = new TextBox();
            txtDangKyTen = new TextBox();
            panel1 = new Panel();
            label14 = new Label();
            btn_cancle = new Button();
            btnTiepTuc = new Button();
            groupBox2 = new GroupBox();
            cbThue = new ComboBox();
            cbKhuyenMai = new ComboBox();
            txtMaNhanVien = new TextBox();
            txtTenKhachHang = new TextBox();
            txtSoDienThoai = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label13 = new Label();
            label1 = new Label();
            groupBox3 = new GroupBox();
            dgvDonHang = new DataGridView();
            dataGridViewButtonColumn1 = new DataGridViewButtonColumn();
            dataGridViewButtonColumn2 = new DataGridViewButtonColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            a = new DataGridViewTextBoxColumn();
            dataGridViewButtonColumn3 = new DataGridViewButtonColumn();
            dataGridViewButtonColumn4 = new DataGridViewButtonColumn();
            soLuongDonHang = new DataGridViewButtonColumn();
            tongTienDonHang = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDonHang).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(478, 738);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(160, 27);
            label5.TabIndex = 26;
            label5.Text = "Tổng Thành Tiền:";
            // 
            // lbThoiLai
            // 
            lbThoiLai.AutoSize = true;
            lbThoiLai.BackColor = Color.White;
            lbThoiLai.BorderStyle = BorderStyle.Fixed3D;
            lbThoiLai.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbThoiLai.ForeColor = SystemColors.ActiveCaptionText;
            lbThoiLai.Location = new Point(933, 851);
            lbThoiLai.Margin = new Padding(4, 0, 4, 0);
            lbThoiLai.Name = "lbThoiLai";
            lbThoiLai.Size = new Size(71, 29);
            lbThoiLai.TabIndex = 29;
            lbThoiLai.Text = "0 VNĐ";
            // 
            // txtKhachDua
            // 
            txtKhachDua.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtKhachDua.ForeColor = SystemColors.ActiveCaptionText;
            txtKhachDua.Location = new Point(922, 780);
            txtKhachDua.Margin = new Padding(4, 5, 4, 5);
            txtKhachDua.Name = "txtKhachDua";
            txtKhachDua.Size = new Size(328, 34);
            txtKhachDua.TabIndex = 19;
            txtKhachDua.TextChanged += txtKhachDua_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(922, 819);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(79, 27);
            label9.TabIndex = 15;
            label9.Text = "Thối lại:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(911, 748);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(108, 27);
            label8.TabIndex = 14;
            label8.Text = "Khách đưa:";
            // 
            // label7
            // 
            label7.AutoEllipsis = true;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(46, 738);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(188, 27);
            label7.TabIndex = 13;
            label7.Text = "Tổng tiền đơn hàng:";
            // 
            // label6
            // 
            label6.AutoEllipsis = true;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(484, 814);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(160, 27);
            label6.TabIndex = 13;
            label6.Text = "Tiền Khuyến Mãi:";
            // 
            // label10
            // 
            label10.AutoEllipsis = true;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ActiveCaptionText;
            label10.Location = new Point(44, 814);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(99, 27);
            label10.TabIndex = 13;
            label10.Text = "Tiền Thuế:";
            // 
            // txtTongTien
            // 
            txtTongTien.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtTongTien.ForeColor = SystemColors.ActiveCaptionText;
            txtTongTien.Location = new Point(56, 770);
            txtTongTien.Margin = new Padding(4, 5, 4, 5);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.ReadOnly = true;
            txtTongTien.Size = new Size(321, 34);
            txtTongTien.TabIndex = 19;
            // 
            // txtThue
            // 
            txtThue.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtThue.ForeColor = SystemColors.ActiveCaptionText;
            txtThue.Location = new Point(54, 846);
            txtThue.Margin = new Padding(4, 5, 4, 5);
            txtThue.Name = "txtThue";
            txtThue.ReadOnly = true;
            txtThue.Size = new Size(321, 34);
            txtThue.TabIndex = 19;
            txtThue.Text = "0 VNĐ";
            txtThue.TextChanged += txtThue_TextChanged;
            // 
            // txtTongThanhTien
            // 
            txtTongThanhTien.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtTongThanhTien.ForeColor = SystemColors.ActiveCaptionText;
            txtTongThanhTien.Location = new Point(489, 770);
            txtTongThanhTien.Margin = new Padding(4, 5, 4, 5);
            txtTongThanhTien.Name = "txtTongThanhTien";
            txtTongThanhTien.ReadOnly = true;
            txtTongThanhTien.Size = new Size(328, 34);
            txtTongThanhTien.TabIndex = 19;
            txtTongThanhTien.TextChanged += txtTongThanhTien_TextChanged;
            // 
            // txtKhuyenMai
            // 
            txtKhuyenMai.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtKhuyenMai.ForeColor = SystemColors.ActiveCaptionText;
            txtKhuyenMai.Location = new Point(494, 846);
            txtKhuyenMai.Margin = new Padding(4, 5, 4, 5);
            txtKhuyenMai.Name = "txtKhuyenMai";
            txtKhuyenMai.ReadOnly = true;
            txtKhuyenMai.Size = new Size(323, 34);
            txtKhuyenMai.TabIndex = 19;
            txtKhuyenMai.Text = "0 VNĐ";
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(btnThemKhachHang);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(txtDangKySoDienThoai);
            groupBox1.Controls.Add(txtDangKyTen);
            groupBox1.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(1028, 127);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(365, 319);
            groupBox1.TabIndex = 31;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin khách hàng";
            // 
            // btnThemKhachHang
            // 
            btnThemKhachHang.BackColor = Color.MediumSeaGreen;
            btnThemKhachHang.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnThemKhachHang.ForeColor = Color.White;
            btnThemKhachHang.Location = new Point(112, 238);
            btnThemKhachHang.Margin = new Padding(4);
            btnThemKhachHang.Name = "btnThemKhachHang";
            btnThemKhachHang.Size = new Size(151, 53);
            btnThemKhachHang.TabIndex = 2;
            btnThemKhachHang.Text = "Thêm";
            btnThemKhachHang.UseVisualStyleBackColor = false;
            btnThemKhachHang.Click += btnThemKhachHang_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = SystemColors.Control;
            label12.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.ControlText;
            label12.Location = new Point(22, 150);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(45, 27);
            label12.TabIndex = 1;
            label12.Text = "Tên:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = SystemColors.Control;
            label11.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.ControlText;
            label11.Location = new Point(22, 61);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(137, 27);
            label11.TabIndex = 1;
            label11.Text = "Số Điện Thoại:";
            // 
            // txtDangKySoDienThoai
            // 
            txtDangKySoDienThoai.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtDangKySoDienThoai.ForeColor = SystemColors.ControlText;
            txtDangKySoDienThoai.Location = new Point(22, 90);
            txtDangKySoDienThoai.Margin = new Padding(4);
            txtDangKySoDienThoai.Name = "txtDangKySoDienThoai";
            txtDangKySoDienThoai.Size = new Size(305, 34);
            txtDangKySoDienThoai.TabIndex = 0;
            // 
            // txtDangKyTen
            // 
            txtDangKyTen.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtDangKyTen.ForeColor = SystemColors.ControlText;
            txtDangKyTen.Location = new Point(22, 179);
            txtDangKyTen.Margin = new Padding(4);
            txtDangKyTen.Name = "txtDangKyTen";
            txtDangKyTen.Size = new Size(305, 34);
            txtDangKyTen.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumSeaGreen;
            panel1.Controls.Add(label14);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1444, 91);
            panel1.TabIndex = 32;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Variable Display", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = SystemColors.ButtonHighlight;
            label14.Location = new Point(636, 22);
            label14.Name = "label14";
            label14.Size = new Size(149, 37);
            label14.TabIndex = 0;
            label14.Text = "HÓA ĐƠN";
            // 
            // btn_cancle
            // 
            btn_cancle.BackColor = Color.Red;
            btn_cancle.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_cancle.ForeColor = Color.White;
            btn_cancle.Location = new Point(1271, 831);
            btn_cancle.Margin = new Padding(4, 5, 4, 5);
            btn_cancle.Name = "btn_cancle";
            btn_cancle.Size = new Size(137, 46);
            btn_cancle.TabIndex = 33;
            btn_cancle.Text = "Hủy Bỏ";
            btn_cancle.UseVisualStyleBackColor = false;
            btn_cancle.Click += btn_cancle_Click_1;
            // 
            // btnTiepTuc
            // 
            btnTiepTuc.BackColor = Color.MediumSeaGreen;
            btnTiepTuc.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnTiepTuc.ForeColor = Color.White;
            btnTiepTuc.Location = new Point(1095, 828);
            btnTiepTuc.Margin = new Padding(4, 5, 4, 5);
            btnTiepTuc.Name = "btnTiepTuc";
            btnTiepTuc.Size = new Size(137, 52);
            btnTiepTuc.TabIndex = 34;
            btnTiepTuc.Text = "Tiếp Tục";
            btnTiepTuc.UseVisualStyleBackColor = false;
            btnTiepTuc.Click += btnTiepTuc_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.Control;
            groupBox2.Controls.Add(cbThue);
            groupBox2.Controls.Add(cbKhuyenMai);
            groupBox2.Controls.Add(txtMaNhanVien);
            groupBox2.Controls.Add(txtTenKhachHang);
            groupBox2.Controls.Add(txtSoDienThoai);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label1);
            groupBox2.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.ForeColor = SystemColors.ControlText;
            groupBox2.Location = new Point(49, 117);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(860, 329);
            groupBox2.TabIndex = 35;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin hóa đơn";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // cbThue
            // 
            cbThue.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbThue.ForeColor = SystemColors.ControlText;
            cbThue.FormattingEnabled = true;
            cbThue.Location = new Point(298, 258);
            cbThue.Margin = new Padding(4, 5, 4, 5);
            cbThue.Name = "cbThue";
            cbThue.Size = new Size(293, 35);
            cbThue.TabIndex = 35;
            cbThue.SelectedIndexChanged += cbThue_SelectedIndexChanged;
            // 
            // cbKhuyenMai
            // 
            cbKhuyenMai.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbKhuyenMai.ForeColor = SystemColors.ControlText;
            cbKhuyenMai.FormattingEnabled = true;
            cbKhuyenMai.Location = new Point(492, 175);
            cbKhuyenMai.Margin = new Padding(4, 5, 4, 5);
            cbKhuyenMai.Name = "cbKhuyenMai";
            cbKhuyenMai.Size = new Size(293, 35);
            cbKhuyenMai.TabIndex = 34;
            cbKhuyenMai.SelectedIndexChanged += cbKhuyenMai_SelectedIndexChanged;
            // 
            // txtMaNhanVien
            // 
            txtMaNhanVien.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaNhanVien.ForeColor = SystemColors.ControlText;
            txtMaNhanVien.Location = new Point(115, 96);
            txtMaNhanVien.Margin = new Padding(4, 5, 4, 5);
            txtMaNhanVien.Name = "txtMaNhanVien";
            txtMaNhanVien.ReadOnly = true;
            txtMaNhanVien.Size = new Size(293, 34);
            txtMaNhanVien.TabIndex = 31;
            txtMaNhanVien.Text = "1";
            // 
            // txtTenKhachHang
            // 
            txtTenKhachHang.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenKhachHang.ForeColor = SystemColors.ControlText;
            txtTenKhachHang.Location = new Point(492, 96);
            txtTenKhachHang.Margin = new Padding(4, 5, 4, 5);
            txtTenKhachHang.Name = "txtTenKhachHang";
            txtTenKhachHang.ReadOnly = true;
            txtTenKhachHang.Size = new Size(293, 34);
            txtTenKhachHang.TabIndex = 32;
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtSoDienThoai.ForeColor = SystemColors.ControlText;
            txtSoDienThoai.Location = new Point(115, 176);
            txtSoDienThoai.Margin = new Padding(4, 5, 4, 5);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(293, 34);
            txtSoDienThoai.TabIndex = 33;
            txtSoDienThoai.TextChanged += txtMaKhachHang_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(298, 232);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(88, 27);
            label4.TabIndex = 27;
            label4.Text = "Mã thuế:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(492, 143);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(149, 27);
            label3.TabIndex = 26;
            label3.Text = "Mã khuyến mãi:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(111, 64);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(133, 27);
            label2.TabIndex = 28;
            label2.Text = "Mã nhân viên:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = SystemColors.Control;
            label13.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = SystemColors.ControlText;
            label13.Location = new Point(492, 64);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(155, 27);
            label13.TabIndex = 29;
            label13.Text = "Tên Khách Hàng:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(111, 144);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(137, 27);
            label1.TabIndex = 30;
            label1.Text = "Số Điện Thoại:";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.Control;
            groupBox3.Controls.Add(dgvDonHang);
            groupBox3.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(49, 461);
            groupBox3.Margin = new Padding(4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4);
            groupBox3.Size = new Size(1344, 266);
            groupBox3.TabIndex = 36;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin hóa đơn";
            // 
            // dgvDonHang
            // 
            dgvDonHang.AllowUserToAddRows = false;
            dgvDonHang.BackgroundColor = Color.White;
            dgvDonHang.BorderStyle = BorderStyle.Fixed3D;
            dgvDonHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDonHang.Columns.AddRange(new DataGridViewColumn[] { dataGridViewButtonColumn1, dataGridViewButtonColumn2, Column1, Column2, a, dataGridViewButtonColumn3, dataGridViewButtonColumn4, soLuongDonHang, tongTienDonHang });
            dgvDonHang.GridColor = Color.Blue;
            dgvDonHang.Location = new Point(17, 36);
            dgvDonHang.Margin = new Padding(4, 5, 4, 5);
            dgvDonHang.Name = "dgvDonHang";
            dataGridViewCellStyle70.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle70.BackColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle70.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle70.ForeColor = SystemColors.InactiveCaptionText;
            dataGridViewCellStyle70.SelectionBackColor = SystemColors.HotTrack;
            dataGridViewCellStyle70.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle70.WrapMode = DataGridViewTriState.True;
            dgvDonHang.RowHeadersDefaultCellStyle = dataGridViewCellStyle70;
            dgvDonHang.RowHeadersWidth = 51;
            dgvDonHang.RowTemplate.Height = 24;
            dgvDonHang.Size = new Size(1311, 209);
            dgvDonHang.TabIndex = 31;
            // 
            // dataGridViewButtonColumn1
            // 
            dataGridViewButtonColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewButtonColumn1.DataPropertyName = "MaSanPham";
            dataGridViewCellStyle61.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle61.ForeColor = Color.Black;
            dataGridViewButtonColumn1.DefaultCellStyle = dataGridViewCellStyle61;
            dataGridViewButtonColumn1.HeaderText = "Mã Sản Phẩm";
            dataGridViewButtonColumn1.MinimumWidth = 6;
            dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            dataGridViewButtonColumn1.ReadOnly = true;
            dataGridViewButtonColumn1.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewButtonColumn2
            // 
            dataGridViewButtonColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewButtonColumn2.DataPropertyName = "TenSanPham";
            dataGridViewCellStyle62.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle62.ForeColor = Color.Black;
            dataGridViewButtonColumn2.DefaultCellStyle = dataGridViewCellStyle62;
            dataGridViewButtonColumn2.HeaderText = "Tên Sản Phẩm";
            dataGridViewButtonColumn2.MinimumWidth = 6;
            dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
            dataGridViewButtonColumn2.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle63.ForeColor = Color.Black;
            Column1.DefaultCellStyle = dataGridViewCellStyle63;
            Column1.HeaderText = "Thương Hiệu";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            dataGridViewCellStyle64.ForeColor = Color.Black;
            Column2.DefaultCellStyle = dataGridViewCellStyle64;
            Column2.HeaderText = "Chất Liệu";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 125;
            // 
            // a
            // 
            dataGridViewCellStyle65.ForeColor = Color.Black;
            a.DefaultCellStyle = dataGridViewCellStyle65;
            a.HeaderText = "Thể Loại";
            a.MinimumWidth = 6;
            a.Name = "a";
            a.ReadOnly = true;
            a.Width = 125;
            // 
            // dataGridViewButtonColumn3
            // 
            dataGridViewButtonColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewButtonColumn3.DataPropertyName = "TenMau";
            dataGridViewCellStyle66.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle66.ForeColor = Color.Black;
            dataGridViewButtonColumn3.DefaultCellStyle = dataGridViewCellStyle66;
            dataGridViewButtonColumn3.HeaderText = "Màu Sắc";
            dataGridViewButtonColumn3.MinimumWidth = 6;
            dataGridViewButtonColumn3.Name = "dataGridViewButtonColumn3";
            dataGridViewButtonColumn3.ReadOnly = true;
            // 
            // dataGridViewButtonColumn4
            // 
            dataGridViewButtonColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle67.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle67.ForeColor = Color.Black;
            dataGridViewButtonColumn4.DefaultCellStyle = dataGridViewCellStyle67;
            dataGridViewButtonColumn4.HeaderText = "Kích Cỡ";
            dataGridViewButtonColumn4.MinimumWidth = 6;
            dataGridViewButtonColumn4.Name = "dataGridViewButtonColumn4";
            dataGridViewButtonColumn4.ReadOnly = true;
            // 
            // soLuongDonHang
            // 
            soLuongDonHang.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle68.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle68.ForeColor = Color.Black;
            soLuongDonHang.DefaultCellStyle = dataGridViewCellStyle68;
            soLuongDonHang.HeaderText = "Số Lượng";
            soLuongDonHang.MinimumWidth = 6;
            soLuongDonHang.Name = "soLuongDonHang";
            soLuongDonHang.ReadOnly = true;
            // 
            // tongTienDonHang
            // 
            dataGridViewCellStyle69.ForeColor = Color.Black;
            tongTienDonHang.DefaultCellStyle = dataGridViewCellStyle69;
            tongTienDonHang.HeaderText = "Tổng Tiền";
            tongTienDonHang.MinimumWidth = 6;
            tongTienDonHang.Name = "tongTienDonHang";
            tongTienDonHang.ReadOnly = true;
            tongTienDonHang.Width = 125;
            // 
            // HoaDonForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1444, 952);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(btn_cancle);
            Controls.Add(btnTiepTuc);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Controls.Add(label5);
            Controls.Add(lbThoiLai);
            Controls.Add(txtKhuyenMai);
            Controls.Add(txtThue);
            Controls.Add(txtTongThanhTien);
            Controls.Add(txtTongTien);
            Controls.Add(txtKhachDua);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label10);
            Controls.Add(label6);
            Controls.Add(label7);
            ForeColor = Color.Transparent;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "HoaDonForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "HoaDOnForm";
            Load += HoaDonForm_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDonHang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BindingSource bindingSource1;
        private Label label5;
        private Label lbThoiLai;
        private TextBox txtKhachDua;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label10;
        private TextBox txtTongTien;
        private TextBox txtThue;
        private TextBox txtTongThanhTien;
        private TextBox txtKhuyenMai;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private GroupBox groupBox1;
        private TextBox txtDangKySoDienThoai;
        private TextBox txtDangKyTen;
        private Button btnThemKhachHang;
        private Label label12;
        private Label label11;
        private Panel panel1;
        private Label label14;
        private Button btn_cancle;
        private Button btnTiepTuc;
        private GroupBox groupBox2;
        private ComboBox cbThue;
        private ComboBox cbKhuyenMai;
        private TextBox txtMaNhanVien;
        private TextBox txtTenKhachHang;
        private TextBox txtSoDienThoai;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label13;
        private Label label1;
        private GroupBox groupBox3;
        private DataGridView dgvDonHang;
        private DataGridViewButtonColumn dataGridViewButtonColumn1;
        private DataGridViewButtonColumn dataGridViewButtonColumn2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn a;
        private DataGridViewButtonColumn dataGridViewButtonColumn3;
        private DataGridViewButtonColumn dataGridViewButtonColumn4;
        private DataGridViewButtonColumn soLuongDonHang;
        private DataGridViewTextBoxColumn tongTienDonHang;
    }
}