namespace GUI
{
    partial class DanhMucSanPhamTab
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
            pageTheLoai = new TabPage();
            pageThuongHieu = new TabPage();
            pageChatLieu = new TabPage();
            pageMauSac = new TabPage();
            pageKichCo = new TabPage();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(pageTheLoai);
            tabControl1.Controls.Add(pageThuongHieu);
            tabControl1.Controls.Add(pageChatLieu);
            tabControl1.Controls.Add(pageMauSac);
            tabControl1.Controls.Add(pageKichCo);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1600, 900);
            tabControl1.TabIndex = 0;
            // 
            // pageTheLoai
            // 
            pageTheLoai.Location = new Point(4, 34);
            pageTheLoai.Name = "pageTheLoai";
            pageTheLoai.Padding = new Padding(3);
            pageTheLoai.Size = new Size(1592, 862);
            pageTheLoai.TabIndex = 0;
            pageTheLoai.Text = "Thể Loại";
            pageTheLoai.UseVisualStyleBackColor = true;
            // 
            // pageThuongHieu
            // 
            pageThuongHieu.Location = new Point(4, 34);
            pageThuongHieu.Name = "pageThuongHieu";
            pageThuongHieu.Padding = new Padding(3);
            pageThuongHieu.Size = new Size(1592, 862);
            pageThuongHieu.TabIndex = 1;
            pageThuongHieu.Text = "Thương Hiệu";
            pageThuongHieu.UseVisualStyleBackColor = true;
            // 
            // pageChatLieu
            // 
            pageChatLieu.Location = new Point(4, 34);
            pageChatLieu.Name = "pageChatLieu";
            pageChatLieu.Padding = new Padding(3);
            pageChatLieu.Size = new Size(1592, 862);
            pageChatLieu.TabIndex = 2;
            pageChatLieu.Text = "Chất Liệu";
            pageChatLieu.UseVisualStyleBackColor = true;
            // 
            // pageMauSac
            // 
            pageMauSac.Location = new Point(4, 34);
            pageMauSac.Name = "pageMauSac";
            pageMauSac.Padding = new Padding(3);
            pageMauSac.Size = new Size(1592, 862);
            pageMauSac.TabIndex = 3;
            pageMauSac.Text = "Màu Sắc";
            pageMauSac.UseVisualStyleBackColor = true;
            // 
            // pageKichCo
            // 
            pageKichCo.Location = new Point(4, 34);
            pageKichCo.Name = "pageKichCo";
            pageKichCo.Padding = new Padding(3);
            pageKichCo.Size = new Size(1592, 862);
            pageKichCo.TabIndex = 4;
            pageKichCo.Text = "Kích Cỡ";
            pageKichCo.UseVisualStyleBackColor = true;
            // 
            // DanhMucSanPhamTab
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 900);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DanhMucSanPhamTab";
            Text = "DanhMucSanPhamTab";
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage pageTheLoai;
        private TabPage pageThuongHieu;
        private TabPage pageChatLieu;
        private TabPage pageMauSac;
        private TabPage pageKichCo;
    }
}