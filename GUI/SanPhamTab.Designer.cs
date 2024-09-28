namespace GUI
{
    partial class SanPhamTab
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
            tabControl1 = new TabControl();
            pageSanPham = new TabPage();
            pageChiTietSanPham = new TabPage();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(pageSanPham);
            tabControl1.Controls.Add(pageChiTietSanPham);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1600, 900);
            tabControl1.TabIndex = 0;
            // 
            // pageSanPham
            // 
            pageSanPham.Location = new Point(4, 34);
            pageSanPham.Name = "pageSanPham";
            pageSanPham.Padding = new Padding(3);
            pageSanPham.Size = new Size(1592, 862);
            pageSanPham.TabIndex = 0;
            pageSanPham.Text = "Sản Phẩm";
            pageSanPham.UseVisualStyleBackColor = true;
            // 
            // pageChiTietSanPham
            // 
            pageChiTietSanPham.Location = new Point(4, 34);
            pageChiTietSanPham.Name = "pageChiTietSanPham";
            pageChiTietSanPham.Padding = new Padding(3);
            pageChiTietSanPham.Size = new Size(1592, 862);
            pageChiTietSanPham.TabIndex = 1;
            pageChiTietSanPham.Text = "Chi Tiết Sản Phẩm";
            pageChiTietSanPham.UseVisualStyleBackColor = true;
            // 
            // SanPhamTab
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 900);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SanPhamTab";
            Text = "SanPhamTab";
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage pageSanPham;
        private TabPage pageChiTietSanPham;
    }
}