namespace WindowsFormsApp3.GUI
{
    partial class SoLuongDonHangForm
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
            label1 = new Label();
            txtSoLuong = new TextBox();
            label2 = new Label();
            label4 = new Label();
            label6 = new Label();
            lbTen = new Label();
            lbKichCo = new Label();
            lbMauSac = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            txtGia = new TextBox();
            btnHuyBo = new Button();
            btnTiepTuc = new Button();
            panel2 = new Panel();
            label5 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(115, 99);
            label1.Name = "label1";
            label1.Size = new Size(100, 27);
            label1.TabIndex = 0;
            label1.Text = "Số Lượng:";
            // 
            // txtSoLuong
            // 
            txtSoLuong.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtSoLuong.Location = new Point(118, 128);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(335, 34);
            txtSoLuong.TabIndex = 0;
            txtSoLuong.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(56, 88);
            label2.Name = "label2";
            label2.Size = new Size(45, 27);
            label2.TabIndex = 2;
            label2.Text = "Tên:";
            label2.Click += label2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(53, 139);
            label4.Name = "label4";
            label4.Size = new Size(79, 27);
            label4.TabIndex = 2;
            label4.Text = "Kích cỡ:";
            label4.Click += label2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(53, 192);
            label6.Name = "label6";
            label6.Size = new Size(90, 27);
            label6.TabIndex = 2;
            label6.Text = "Màu Sắc:";
            label6.Click += label2_Click;
            // 
            // lbTen
            // 
            lbTen.AutoSize = true;
            lbTen.BorderStyle = BorderStyle.Fixed3D;
            lbTen.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbTen.Location = new Point(157, 86);
            lbTen.Name = "lbTen";
            lbTen.Size = new Size(67, 29);
            lbTen.TabIndex = 2;
            lbTen.Text = "label2";
            lbTen.Click += label2_Click;
            // 
            // lbKichCo
            // 
            lbKichCo.AutoSize = true;
            lbKichCo.BorderStyle = BorderStyle.Fixed3D;
            lbKichCo.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbKichCo.Location = new Point(157, 139);
            lbKichCo.Name = "lbKichCo";
            lbKichCo.Size = new Size(67, 29);
            lbKichCo.TabIndex = 2;
            lbKichCo.Text = "label2";
            lbKichCo.Click += label2_Click;
            // 
            // lbMauSac
            // 
            lbMauSac.AutoSize = true;
            lbMauSac.BorderStyle = BorderStyle.Fixed3D;
            lbMauSac.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbMauSac.Location = new Point(157, 190);
            lbMauSac.Name = "lbMauSac";
            lbMauSac.Size = new Size(67, 29);
            lbMauSac.TabIndex = 2;
            lbMauSac.Text = "label2";
            lbMauSac.Click += label2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lbMauSac);
            panel1.Controls.Add(lbKichCo);
            panel1.Controls.Add(lbTen);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(42, 256);
            panel1.Name = "panel1";
            panel1.Size = new Size(709, 296);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(445, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(232, 262);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(115, 168);
            label3.Name = "label3";
            label3.Size = new Size(45, 27);
            label3.TabIndex = 0;
            label3.Text = "Giá:";
            // 
            // txtGia
            // 
            txtGia.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtGia.Location = new Point(118, 197);
            txtGia.Name = "txtGia";
            txtGia.ReadOnly = true;
            txtGia.Size = new Size(335, 34);
            txtGia.TabIndex = 1;
            txtGia.TextChanged += textBox1_TextChanged;
            // 
            // btnHuyBo
            // 
            btnHuyBo.BackColor = Color.Red;
            btnHuyBo.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnHuyBo.ForeColor = Color.White;
            btnHuyBo.Location = new Point(536, 189);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(137, 49);
            btnHuyBo.TabIndex = 7;
            btnHuyBo.Text = "Hủy Bỏ";
            btnHuyBo.UseVisualStyleBackColor = false;
            btnHuyBo.Click += btnHuyBo_Click_1;
            // 
            // btnTiepTuc
            // 
            btnTiepTuc.BackColor = Color.MediumSeaGreen;
            btnTiepTuc.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnTiepTuc.ForeColor = Color.White;
            btnTiepTuc.Location = new Point(536, 120);
            btnTiepTuc.Name = "btnTiepTuc";
            btnTiepTuc.Size = new Size(137, 49);
            btnTiepTuc.TabIndex = 6;
            btnTiepTuc.Text = "Tiếp Tục";
            btnTiepTuc.UseVisualStyleBackColor = false;
            btnTiepTuc.Click += btnTiepTuc_Click_1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MediumSeaGreen;
            panel2.Controls.Add(label5);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(790, 87);
            panel2.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Variable Display", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(316, 25);
            label5.Name = "label5";
            label5.Size = new Size(161, 37);
            label5.TabIndex = 0;
            label5.Text = "SỐ LƯỢNG";
            // 
            // SoLuongDonHangForm
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(790, 585);
            Controls.Add(panel2);
            Controls.Add(btnHuyBo);
            Controls.Add(btnTiepTuc);
            Controls.Add(panel1);
            Controls.Add(txtGia);
            Controls.Add(label3);
            Controls.Add(txtSoLuong);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SoLuongDonHangForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "soLuongDonHangForm";
            Load += SoLuongDonHangForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSoLuong;
        private Label label2;
        private Label label4;
        private Label label6;
        private Label lbTen;
        private Label lbKichCo;
        private Label lbMauSac;
        private Panel panel1;
        private Label label3;
        private TextBox txtGia;
        private PictureBox pictureBox1;
        private Button btnHuyBo;
        private Button btnTiepTuc;
        private Panel panel2;
        private Label label5;
    }
}