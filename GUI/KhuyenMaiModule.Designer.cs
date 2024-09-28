namespace GUI
{
    partial class KhuyenMaiModule
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
            label2 = new Label();
            txtMucKhuyenMai = new TextBox();
            txtDieuKien = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dateBatDau = new DateTimePicker();
            dateKetThuc = new DateTimePicker();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnThem = new Button();
            btnSua = new Button();
            btnThoat = new Button();
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
            panel1.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Small", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(104, 32);
            label1.Name = "label1";
            label1.Size = new Size(177, 37);
            label1.TabIndex = 0;
            label1.Text = "Khuyến Mãi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.MediumSeaGreen;
            label2.Location = new Point(50, 131);
            label2.Name = "label2";
            label2.Size = new Size(160, 27);
            label2.TabIndex = 1;
            label2.Text = "Mức Khuyến Mãi";
            // 
            // txtMucKhuyenMai
            // 
            txtMucKhuyenMai.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtMucKhuyenMai.Location = new Point(50, 161);
            txtMucKhuyenMai.Name = "txtMucKhuyenMai";
            txtMucKhuyenMai.Size = new Size(306, 34);
            txtMucKhuyenMai.TabIndex = 18;
            // 
            // txtDieuKien
            // 
            txtDieuKien.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtDieuKien.Location = new Point(50, 260);
            txtDieuKien.Name = "txtDieuKien";
            txtDieuKien.Size = new Size(306, 34);
            txtDieuKien.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.MediumSeaGreen;
            label3.Location = new Point(50, 230);
            label3.Name = "label3";
            label3.Size = new Size(95, 27);
            label3.TabIndex = 19;
            label3.Text = "Điều Kiện";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.MediumSeaGreen;
            label4.Location = new Point(50, 430);
            label4.Name = "label4";
            label4.Size = new Size(88, 27);
            label4.TabIndex = 23;
            label4.Text = "Kết Thúc";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.MediumSeaGreen;
            label5.Location = new Point(50, 331);
            label5.Name = "label5";
            label5.Size = new Size(85, 27);
            label5.TabIndex = 21;
            label5.Text = " Bắt Đầu";
            // 
            // dateBatDau
            // 
            dateBatDau.CalendarFont = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dateBatDau.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dateBatDau.Format = DateTimePickerFormat.Short;
            dateBatDau.Location = new Point(50, 361);
            dateBatDau.Name = "dateBatDau";
            dateBatDau.Size = new Size(300, 34);
            dateBatDau.TabIndex = 25;
            // 
            // dateKetThuc
            // 
            dateKetThuc.CalendarFont = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dateKetThuc.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dateKetThuc.Format = DateTimePickerFormat.Short;
            dateKetThuc.Location = new Point(50, 460);
            dateKetThuc.Name = "dateKetThuc";
            dateKetThuc.Size = new Size(300, 34);
            dateKetThuc.TabIndex = 26;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnThem);
            flowLayoutPanel1.Controls.Add(btnSua);
            flowLayoutPanel1.Controls.Add(btnThoat);
            flowLayoutPanel1.Location = new Point(39, 521);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(326, 59);
            flowLayoutPanel1.TabIndex = 27;
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
            // KhuyenMaiModule
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 618);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(dateKetThuc);
            Controls.Add(dateBatDau);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(txtDieuKien);
            Controls.Add(label3);
            Controls.Add(txtMucKhuyenMai);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "KhuyenMaiModule";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KhuyenMaiModule";
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
        public Label label2;
        public TextBox txtMucKhuyenMai;
        public TextBox txtDieuKien;
        public Label label3;
        public Label label4;
        public Label label5;
        public DateTimePicker dateBatDau;
        public DateTimePicker dateKetThuc;
    }
}