namespace GUI
{
    partial class NhapHangTab
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
            pagePhieuNhap = new TabPage();
            pageChiTietPhieuNhap = new TabPage();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(pagePhieuNhap);
            tabControl1.Controls.Add(pageChiTietPhieuNhap);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1600, 900);
            tabControl1.TabIndex = 0;
            // 
            // pagePhieuNhap
            // 
            pagePhieuNhap.Location = new Point(4, 34);
            pagePhieuNhap.Name = "pagePhieuNhap";
            pagePhieuNhap.Padding = new Padding(3);
            pagePhieuNhap.Size = new Size(1592, 862);
            pagePhieuNhap.TabIndex = 0;
            pagePhieuNhap.Text = "Phiếu Nhập";
            pagePhieuNhap.UseVisualStyleBackColor = true;
            // 
            // pageChiTietPhieuNhap
            // 
            pageChiTietPhieuNhap.Location = new Point(4, 34);
            pageChiTietPhieuNhap.Name = "pageChiTietPhieuNhap";
            pageChiTietPhieuNhap.Padding = new Padding(3);
            pageChiTietPhieuNhap.Size = new Size(1592, 862);
            pageChiTietPhieuNhap.TabIndex = 1;
            pageChiTietPhieuNhap.Text = "Chi Tiết Phiếu Nhập";
            pageChiTietPhieuNhap.UseVisualStyleBackColor = true;
            // 
            // NhapHangTab
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 900);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NhapHangTab";
            Text = "NhapHangTab";
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage pagePhieuNhap;
        private TabPage pageChiTietPhieuNhap;
    }
}