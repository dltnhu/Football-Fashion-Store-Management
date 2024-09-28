namespace GUI
{
    partial class ThueGUI
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThueGUI));
            panel1 = new Panel();
            label1 = new Label();
            danhSachThue = new DataGridView();
            MaThue = new DataGridViewTextBoxColumn();
            TenThue = new DataGridViewTextBoxColumn();
            MucThue = new DataGridViewTextBoxColumn();
            Xoa = new DataGridViewImageColumn();
            label2 = new Label();
            txtTimKiem = new TextBox();
            btnShowDialog = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)danhSachThue).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumSeaGreen;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1600, 100);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Small", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(724, 23);
            label1.Name = "label1";
            label1.Size = new Size(105, 48);
            label1.TabIndex = 0;
            label1.Text = "Thuế";
            // 
            // danhSachThue
            // 
            danhSachThue.AllowUserToAddRows = false;
            danhSachThue.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            danhSachThue.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            danhSachThue.BackgroundColor = SystemColors.ButtonHighlight;
            danhSachThue.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            danhSachThue.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            danhSachThue.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            danhSachThue.Columns.AddRange(new DataGridViewColumn[] { MaThue, TenThue, MucThue, Xoa });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            danhSachThue.DefaultCellStyle = dataGridViewCellStyle6;
            danhSachThue.Location = new Point(0, 96);
            danhSachThue.Name = "danhSachThue";
            danhSachThue.ReadOnly = true;
            danhSachThue.RowHeadersWidth = 62;
            danhSachThue.RowTemplate.Height = 33;
            danhSachThue.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            danhSachThue.Size = new Size(1600, 660);
            danhSachThue.TabIndex = 5;
            danhSachThue.CellContentClick += danhSachThue_CellContentClick;
            // 
            // MaThue
            // 
            MaThue.DataPropertyName = "MaThue";
            dataGridViewCellStyle2.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            MaThue.DefaultCellStyle = dataGridViewCellStyle2;
            MaThue.HeaderText = "Mã thuế";
            MaThue.MinimumWidth = 8;
            MaThue.Name = "MaThue";
            MaThue.ReadOnly = true;
            // 
            // TenThue
            // 
            TenThue.DataPropertyName = "TenThue";
            dataGridViewCellStyle3.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            TenThue.DefaultCellStyle = dataGridViewCellStyle3;
            TenThue.HeaderText = "Tên thuế";
            TenThue.MinimumWidth = 8;
            TenThue.Name = "TenThue";
            TenThue.ReadOnly = true;
            // 
            // MucThue
            // 
            MucThue.DataPropertyName = "MucThue";
            dataGridViewCellStyle4.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            MucThue.DefaultCellStyle = dataGridViewCellStyle4;
            MucThue.HeaderText = "Mức thuế";
            MucThue.MinimumWidth = 8;
            MucThue.Name = "MucThue";
            MucThue.ReadOnly = true;
            // 
            // Xoa
            // 
            Xoa.DataPropertyName = "Xoa";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.NullValue = resources.GetObject("dataGridViewCellStyle5.NullValue");
            dataGridViewCellStyle5.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            Xoa.DefaultCellStyle = dataGridViewCellStyle5;
            Xoa.HeaderText = "Xóa";
            Xoa.Image = (Image)resources.GetObject("Xoa.Image");
            Xoa.MinimumWidth = 8;
            Xoa.Name = "Xoa";
            Xoa.ReadOnly = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.MediumSeaGreen;
            label2.Location = new Point(12, 778);
            label2.Name = "label2";
            label2.Size = new Size(115, 32);
            label2.TabIndex = 12;
            label2.Text = "Tìm Kiếm";
            // 
            // txtTimKiem
            // 
            txtTimKiem.BorderStyle = BorderStyle.FixedSingle;
            txtTimKiem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimKiem.Location = new Point(133, 776);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(295, 39);
            txtTimKiem.TabIndex = 11;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // btnShowDialog
            // 
            btnShowDialog.BackColor = Color.MediumSeaGreen;
            btnShowDialog.Font = new Font("Segoe UI Variable Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnShowDialog.ForeColor = SystemColors.ButtonHighlight;
            btnShowDialog.Location = new Point(1399, 762);
            btnShowDialog.Name = "btnShowDialog";
            btnShowDialog.Size = new Size(189, 65);
            btnShowDialog.TabIndex = 10;
            btnShowDialog.Text = "Thêm";
            btnShowDialog.UseVisualStyleBackColor = false;
            btnShowDialog.Click += btnShowDialog_Click;
            // 
            // ThueGUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 900);
            Controls.Add(label2);
            Controls.Add(txtTimKiem);
            Controls.Add(btnShowDialog);
            Controls.Add(danhSachThue);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ThueGUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ThueGUI";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)danhSachThue).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        public DataGridView danhSachThue;
        private Label label2;
        private TextBox txtTimKiem;
        public Button btnShowDialog;
        private DataGridViewTextBoxColumn MaThue;
        private DataGridViewTextBoxColumn TenThue;
        private DataGridViewTextBoxColumn MucThue;
        private DataGridViewImageColumn Xoa;
        private Label label1;
    }
}