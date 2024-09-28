namespace GUI
{
    partial class NhanVienTab
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
            pageNhanVien = new TabPage();
            pageTaiKhoan = new TabPage();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(pageNhanVien);
            tabControl1.Controls.Add(pageTaiKhoan);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1600, 900);
            tabControl1.TabIndex = 0;
            // 
            // pageNhanVien
            // 
            pageNhanVien.Location = new Point(4, 34);
            pageNhanVien.Name = "pageNhanVien";
            pageNhanVien.Padding = new Padding(3);
            pageNhanVien.Size = new Size(1592, 862);
            pageNhanVien.TabIndex = 0;
            pageNhanVien.Text = "Nhân Viên";
            pageNhanVien.UseVisualStyleBackColor = true;
            // 
            // pageTaiKhoan
            // 
            pageTaiKhoan.Location = new Point(4, 34);
            pageTaiKhoan.Name = "pageTaiKhoan";
            pageTaiKhoan.Padding = new Padding(3);
            pageTaiKhoan.Size = new Size(1592, 862);
            pageTaiKhoan.TabIndex = 1;
            pageTaiKhoan.Text = "Tài Khoản";
            pageTaiKhoan.UseVisualStyleBackColor = true;
            // 
            // NhanVienTab
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 900);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NhanVienTab";
            Text = "NhanVienTab";
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage pageNhanVien;
        private TabPage pageTaiKhoan;
    }
}