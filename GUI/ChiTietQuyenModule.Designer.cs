namespace GUI
{
    partial class ChiTietQuyenModule
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
            comboBoxNhomQuyen = new ComboBox();
            comboBoxChucNang = new ComboBox();
            label3 = new Label();
            comboBoxHanhDong = new ComboBox();
            label4 = new Label();
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
            panel1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Text", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(91, 32);
            label1.Name = "label1";
            label1.Size = new Size(210, 37);
            label1.TabIndex = 1;
            label1.Text = "Chi Tiết Quyền";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.MediumSeaGreen;
            label2.Location = new Point(38, 123);
            label2.Name = "label2";
            label2.Size = new Size(129, 27);
            label2.TabIndex = 6;
            label2.Text = "Nhóm Quyền";
            // 
            // comboBoxNhomQuyen
            // 
            comboBoxNhomQuyen.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxNhomQuyen.FormattingEnabled = true;
            comboBoxNhomQuyen.Location = new Point(38, 158);
            comboBoxNhomQuyen.Name = "comboBoxNhomQuyen";
            comboBoxNhomQuyen.Size = new Size(324, 35);
            comboBoxNhomQuyen.TabIndex = 7;
            // 
            // comboBoxChucNang
            // 
            comboBoxChucNang.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxChucNang.FormattingEnabled = true;
            comboBoxChucNang.Location = new Point(38, 264);
            comboBoxChucNang.Name = "comboBoxChucNang";
            comboBoxChucNang.Size = new Size(324, 35);
            comboBoxChucNang.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.MediumSeaGreen;
            label3.Location = new Point(38, 229);
            label3.Name = "label3";
            label3.Size = new Size(112, 27);
            label3.TabIndex = 8;
            label3.Text = "Chức Năng";
            // 
            // comboBoxHanhDong
            // 
            comboBoxHanhDong.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxHanhDong.FormattingEnabled = true;
            comboBoxHanhDong.Items.AddRange(new object[] { "Xem", "Sửa", "Xóa", "Thêm" });
            comboBoxHanhDong.Location = new Point(38, 372);
            comboBoxHanhDong.Name = "comboBoxHanhDong";
            comboBoxHanhDong.Size = new Size(324, 35);
            comboBoxHanhDong.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.MediumSeaGreen;
            label4.Location = new Point(38, 337);
            label4.Name = "label4";
            label4.Size = new Size(112, 27);
            label4.TabIndex = 10;
            label4.Text = "Hành Động";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnThem);
            flowLayoutPanel1.Controls.Add(btnSua);
            flowLayoutPanel1.Controls.Add(btnThoat);
            flowLayoutPanel1.Location = new Point(36, 437);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(326, 59);
            flowLayoutPanel1.TabIndex = 12;
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
            // ChiTietQuyenModule
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 536);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(comboBoxHanhDong);
            Controls.Add(label4);
            Controls.Add(comboBoxChucNang);
            Controls.Add(label3);
            Controls.Add(comboBoxNhomQuyen);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ChiTietQuyenModule";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private FlowLayoutPanel flowLayoutPanel1;
        public Button btnThem;
        public Button btnSua;
        public Button btnThoat;
        public ComboBox comboBoxNhomQuyen;
        public ComboBox comboBoxChucNang;
        public ComboBox comboBoxHanhDong;
    }
}