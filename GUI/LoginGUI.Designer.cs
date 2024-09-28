namespace GUI
{
    partial class LoginGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginGUI));
            panel1 = new Panel();
            closeBtn = new PictureBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            panel2 = new Panel();
            pictureBox4 = new PictureBox();
            btnDangNhap = new Button();
            pictureBox3 = new PictureBox();
            txtMatKhau = new TextBox();
            label5 = new Label();
            pictureBox2 = new PictureBox();
            txtTenDangNhap = new TextBox();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)closeBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumSeaGreen;
            panel1.Controls.Add(closeBtn);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 99);
            panel1.TabIndex = 0;
            // 
            // closeBtn
            // 
            closeBtn.Image = (Image)resources.GetObject("closeBtn.Image");
            closeBtn.Location = new Point(835, 12);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(62, 61);
            closeBtn.SizeMode = PictureBoxSizeMode.Zoom;
            closeBtn.TabIndex = 2;
            closeBtn.TabStop = false;
            closeBtn.Click += closeBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Text", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(96, 25);
            label1.Name = "label1";
            label1.Size = new Size(466, 37);
            label1.TabIndex = 1;
            label1.Text = "Welcome To The SportFashionPOS";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(87, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.MediumSeaGreen;
            label3.Location = new Point(716, 450);
            label3.Name = "label3";
            label3.Size = new Size(172, 27);
            label3.TabIndex = 3;
            label3.Text = "@CNPM Nhóm 7";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(btnDangNhap);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(txtMatKhau);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(txtTenDangNhap);
            panel2.Controls.Add(label4);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 94);
            panel2.Name = "panel2";
            panel2.Size = new Size(900, 486);
            panel2.TabIndex = 1;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(402, 11);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(88, 85);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.MediumSeaGreen;
            btnDangNhap.Font = new Font("Segoe UI Variable Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDangNhap.ForeColor = Color.White;
            btnDangNhap.Location = new Point(285, 352);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(337, 57);
            btnDangNhap.TabIndex = 7;
            btnDangNhap.Text = "Đăng Nhập";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(285, 228);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(53, 55);
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // txtMatKhau
            // 
            txtMatKhau.BorderStyle = BorderStyle.FixedSingle;
            txtMatKhau.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtMatKhau.Location = new Point(285, 289);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(337, 34);
            txtMatKhau.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.MediumSeaGreen;
            label5.Location = new Point(344, 249);
            label5.Name = "label5";
            label5.Size = new Size(96, 27);
            label5.TabIndex = 3;
            label5.Text = "Mật Khẩu";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(285, 97);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(53, 55);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.BorderStyle = BorderStyle.FixedSingle;
            txtTenDangNhap.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenDangNhap.Location = new Point(285, 158);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(337, 34);
            txtTenDangNhap.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.MediumSeaGreen;
            label4.Location = new Point(344, 118);
            label4.Name = "label4";
            label4.Size = new Size(146, 27);
            label4.TabIndex = 0;
            label4.Text = "Tên Đăng Nhập";
            // 
            // LoginGUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 580);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginGUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginGUI";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)closeBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label3;
        private PictureBox pictureBox2;
        private TextBox txtTenDangNhap;
        private Label label4;
        private PictureBox pictureBox3;
        private TextBox txtMatKhau;
        private Label label5;
        private Button btnDangNhap;
        private PictureBox pictureBox4;
        private PictureBox closeBtn;
    }
}