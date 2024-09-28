namespace WindowsFormsApp3.GUI
{
    partial class themKhachHang
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
            Tên = new Label();
            label2 = new Label();
            txtTen = new TextBox();
            txtSoDienThoai = new TextBox();
            btnSua = new Button();
            btnHuyBo = new Button();
            panel1 = new Panel();
            text = new Label();
            btnThem = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // Tên
            // 
            Tên.AutoSize = true;
            Tên.Font = new Font("Segoe UI Variable Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Tên.ForeColor = Color.MediumSeaGreen;
            Tên.Location = new Point(117, 133);
            Tên.Margin = new Padding(4, 0, 4, 0);
            Tên.Name = "Tên";
            Tên.Size = new Size(87, 32);
            Tên.TabIndex = 0;
            Tên.Text = "Họ tên";
            Tên.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.MediumSeaGreen;
            label2.Location = new Point(117, 246);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(156, 32);
            label2.TabIndex = 1;
            label2.Text = "Số điện thoại";
            // 
            // txtTen
            // 
            txtTen.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtTen.Location = new Point(117, 170);
            txtTen.Margin = new Padding(4, 5, 4, 5);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(347, 39);
            txtTen.TabIndex = 2;
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtSoDienThoai.Location = new Point(117, 283);
            txtSoDienThoai.Margin = new Padding(4, 5, 4, 5);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(347, 39);
            txtSoDienThoai.TabIndex = 2;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.Orange;
            btnSua.Font = new Font("Segoe UI Variable Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(182, 5);
            btnSua.Margin = new Padding(4, 5, 4, 5);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(170, 60);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.BackColor = Color.Red;
            btnHuyBo.Font = new Font("Segoe UI Variable Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnHuyBo.ForeColor = Color.White;
            btnHuyBo.Location = new Point(4, 75);
            btnHuyBo.Margin = new Padding(4, 5, 4, 5);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(170, 60);
            btnHuyBo.TabIndex = 3;
            btnHuyBo.Text = "Thoát";
            btnHuyBo.UseVisualStyleBackColor = false;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumSeaGreen;
            panel1.Controls.Add(text);
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(0, 1);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1298, 100);
            panel1.TabIndex = 4;
            // 
            // text
            // 
            text.AutoSize = true;
            text.Font = new Font("Segoe UI Variable Display", 14F, FontStyle.Bold, GraphicsUnit.Point);
            text.ForeColor = SystemColors.ButtonHighlight;
            text.Location = new Point(117, 26);
            text.Margin = new Padding(4, 0, 4, 0);
            text.Name = "text";
            text.Size = new Size(207, 37);
            text.TabIndex = 0;
            text.Text = "KHÁCH HÀNG";
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.MediumSeaGreen;
            btnThem.Font = new Font("Segoe UI Variable Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(4, 5);
            btnThem.Margin = new Padding(4, 5, 4, 5);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(170, 60);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnThem);
            flowLayoutPanel1.Controls.Add(btnSua);
            flowLayoutPanel1.Controls.Add(btnHuyBo);
            flowLayoutPanel1.Location = new Point(105, 357);
            flowLayoutPanel1.Margin = new Padding(4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(359, 72);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // themKhachHang
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(589, 469);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Controls.Add(txtSoDienThoai);
            Controls.Add(txtTen);
            Controls.Add(label2);
            Controls.Add(Tên);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "themKhachHang";
            StartPosition = FormStartPosition.CenterParent;
            Text = "themKhachHang";
            Load += themKhachHang_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Tên;
        private Label label2;
        private TextBox txtTen;
        private TextBox txtSoDienThoai;
        private Button btnSua;
        private Button btnHuyBo;
        private Panel panel1;
        private Label text;
        private Button btnThem;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}