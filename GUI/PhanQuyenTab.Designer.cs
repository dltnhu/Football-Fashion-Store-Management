namespace GUI
{
    partial class PhanQuyenTab
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
            pageNhomQuyen = new TabPage();
            pageChucNang = new TabPage();
            pageChiTietQuyen = new TabPage();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(pageNhomQuyen);
            tabControl1.Controls.Add(pageChucNang);
            tabControl1.Controls.Add(pageChiTietQuyen);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1600, 800);
            tabControl1.TabIndex = 0;
            // 
            // pageNhomQuyen
            // 
            pageNhomQuyen.Location = new Point(4, 34);
            pageNhomQuyen.Name = "pageNhomQuyen";
            pageNhomQuyen.Padding = new Padding(3);
            pageNhomQuyen.Size = new Size(1592, 762);
            pageNhomQuyen.TabIndex = 0;
            pageNhomQuyen.Text = "Nhóm Quyền";
            pageNhomQuyen.UseVisualStyleBackColor = true;
            // 
            // pageChucNang
            // 
            pageChucNang.Location = new Point(4, 34);
            pageChucNang.Name = "pageChucNang";
            pageChucNang.Padding = new Padding(3);
            pageChucNang.Size = new Size(1592, 762);
            pageChucNang.TabIndex = 1;
            pageChucNang.Text = "Chức Năng";
            pageChucNang.UseVisualStyleBackColor = true;
            // 
            // pageChiTietQuyen
            // 
            pageChiTietQuyen.Location = new Point(4, 34);
            pageChiTietQuyen.Name = "pageChiTietQuyen";
            pageChiTietQuyen.Padding = new Padding(3);
            pageChiTietQuyen.Size = new Size(1592, 762);
            pageChiTietQuyen.TabIndex = 2;
            pageChiTietQuyen.Text = "Chi Tiết Quyền";
            pageChiTietQuyen.UseVisualStyleBackColor = true;
            // 
            // PhanQuyenTab
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 800);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PhanQuyenTab";
            Text = "PhanQuyenTab";
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage pageNhomQuyen;
        private TabPage pageChucNang;
        private TabPage pageChiTietQuyen;
    }
}