namespace GUI
{
    partial class ChiTietSanPhamModule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChiTietSanPhamModule));
            panel1 = new Panel();
            label3 = new Label();
            anhSanPham = new PictureBox();
            label4 = new Label();
            comboxKichCo = new ComboBox();
            label1 = new Label();
            comboxMauSac = new ComboBox();
            label2 = new Label();
            txtTenSanPham = new TextBox();
            btnThoat = new Button();
            btnSua = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)anhSanPham).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumSeaGreen;
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(432, 94);
            panel1.TabIndex = 66;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.MediumSeaGreen;
            label3.Font = new Font("Segoe UI Variable Display", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(78, 30);
            label3.Name = "label3";
            label3.Size = new Size(288, 37);
            label3.TabIndex = 0;
            label3.Text = "CHI TIẾT SẢN PHẨM";
            // 
            // anhSanPham
            // 
            anhSanPham.Image = (Image)resources.GetObject("anhSanPham.Image");
            anhSanPham.Location = new Point(133, 331);
            anhSanPham.Name = "anhSanPham";
            anhSanPham.Size = new Size(171, 174);
            anhSanPham.SizeMode = PictureBoxSizeMode.StretchImage;
            anhSanPham.TabIndex = 65;
            anhSanPham.TabStop = false;
            anhSanPham.Click += anhSanPham_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.MediumSeaGreen;
            label4.Location = new Point(68, 18);
            label4.Name = "label4";
            label4.Size = new Size(157, 32);
            label4.TabIndex = 64;
            label4.Text = "Tên sản phẩm";
            // 
            // comboxKichCo
            // 
            comboxKichCo.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Regular, GraphicsUnit.Point);
            comboxKichCo.FormattingEnabled = true;
            comboxKichCo.Location = new Point(57, 274);
            comboxKichCo.Name = "comboxKichCo";
            comboxKichCo.Size = new Size(323, 35);
            comboxKichCo.TabIndex = 63;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.MediumSeaGreen;
            label1.Location = new Point(57, 234);
            label1.Name = "label1";
            label1.Size = new Size(77, 27);
            label1.TabIndex = 62;
            label1.Text = "Kích cở";
            // 
            // comboxMauSac
            // 
            comboxMauSac.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Regular, GraphicsUnit.Point);
            comboxMauSac.FormattingEnabled = true;
            comboxMauSac.Location = new Point(57, 166);
            comboxMauSac.Name = "comboxMauSac";
            comboxMauSac.Size = new Size(323, 35);
            comboxMauSac.TabIndex = 61;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.MediumSeaGreen;
            label2.Location = new Point(52, 126);
            label2.Name = "label2";
            label2.Size = new Size(85, 27);
            label2.TabIndex = 60;
            label2.Text = "Màu sắc";
            // 
            // txtTenSanPham
            // 
            txtTenSanPham.Font = new Font("Segoe UI Variable Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenSanPham.Location = new Point(68, 53);
            txtTenSanPham.Name = "txtTenSanPham";
            txtTenSanPham.Size = new Size(361, 39);
            txtTenSanPham.TabIndex = 69;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.Red;
            btnThoat.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnThoat.ForeColor = SystemColors.ButtonHighlight;
            btnThoat.Location = new Point(172, 3);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(163, 56);
            btnThoat.TabIndex = 68;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.Orange;
            btnSua.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnSua.ForeColor = SystemColors.ButtonHighlight;
            btnSua.Location = new Point(3, 3);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(163, 56);
            btnSua.TabIndex = 67;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnSua);
            flowLayoutPanel1.Controls.Add(btnThoat);
            flowLayoutPanel1.Location = new Point(52, 523);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(339, 65);
            flowLayoutPanel1.TabIndex = 70;
            // 
            // ChiTietSanPhamModule
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 639);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Controls.Add(anhSanPham);
            Controls.Add(label4);
            Controls.Add(comboxKichCo);
            Controls.Add(label1);
            Controls.Add(comboxMauSac);
            Controls.Add(label2);
            Controls.Add(txtTenSanPham);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ChiTietSanPhamModule";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChiTietSanPhamModule";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)anhSanPham).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label3;
        public PictureBox anhSanPham;
        private Label label4;
        public ComboBox comboxKichCo;
        private Label label1;
        public ComboBox comboxMauSac;
        private Label label2;
        public TextBox txtTenSanPham;
        public Button btnThoat;
        public Button btnSua;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}