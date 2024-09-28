namespace GUI
{
    partial class ThueModule
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
            txtMucThue = new TextBox();
            label2 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            buttonThemThue = new Button();
            buttonThoat = new Button();
            txtTenThue = new TextBox();
            labelTenChatLieu = new Label();
            panel1 = new Panel();
            label1 = new Label();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtMucThue
            // 
            txtMucThue.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtMucThue.Location = new Point(61, 215);
            txtMucThue.Name = "txtMucThue";
            txtMucThue.Size = new Size(311, 34);
            txtMucThue.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.MediumSeaGreen;
            label2.Location = new Point(58, 185);
            label2.Name = "label2";
            label2.Size = new Size(95, 27);
            label2.TabIndex = 25;
            label2.Text = "Mức thuế";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(buttonThemThue);
            flowLayoutPanel1.Controls.Add(buttonThoat);
            flowLayoutPanel1.Location = new Point(58, 268);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(333, 60);
            flowLayoutPanel1.TabIndex = 24;
            // 
            // buttonThemThue
            // 
            buttonThemThue.BackColor = Color.MediumSeaGreen;
            buttonThemThue.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonThemThue.ForeColor = SystemColors.ButtonHighlight;
            buttonThemThue.Location = new Point(3, 3);
            buttonThemThue.Name = "buttonThemThue";
            buttonThemThue.Size = new Size(160, 55);
            buttonThemThue.TabIndex = 0;
            buttonThemThue.Text = "Thêm";
            buttonThemThue.UseVisualStyleBackColor = false;
            buttonThemThue.Click += buttonThemThue_Click;
            // 
            // buttonThoat
            // 
            buttonThoat.BackColor = Color.Red;
            buttonThoat.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonThoat.ForeColor = SystemColors.ButtonHighlight;
            buttonThoat.Location = new Point(169, 3);
            buttonThoat.Name = "buttonThoat";
            buttonThoat.Size = new Size(160, 55);
            buttonThoat.TabIndex = 2;
            buttonThoat.Text = "Thoát";
            buttonThoat.UseVisualStyleBackColor = false;
            buttonThoat.Click += buttonThoat_Click;
            // 
            // txtTenThue
            // 
            txtTenThue.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenThue.Location = new Point(58, 135);
            txtTenThue.Name = "txtTenThue";
            txtTenThue.Size = new Size(314, 34);
            txtTenThue.TabIndex = 23;
            // 
            // labelTenChatLieu
            // 
            labelTenChatLieu.AutoSize = true;
            labelTenChatLieu.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelTenChatLieu.ForeColor = Color.MediumSeaGreen;
            labelTenChatLieu.Location = new Point(58, 105);
            labelTenChatLieu.Name = "labelTenChatLieu";
            labelTenChatLieu.Size = new Size(85, 27);
            labelTenChatLieu.TabIndex = 22;
            labelTenChatLieu.Text = "Tên thuế";
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumSeaGreen;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(434, 81);
            panel1.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Display", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(174, 22);
            label1.Name = "label1";
            label1.Size = new Size(89, 37);
            label1.TabIndex = 0;
            label1.Text = "THUẾ";
            // 
            // ThueModule
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 363);
            Controls.Add(txtMucThue);
            Controls.Add(label2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(txtTenThue);
            Controls.Add(labelTenChatLieu);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ThueModule";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ThueModule";
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox txtMucThue;
        public Label label2;
        private FlowLayoutPanel flowLayoutPanel1;
        public Button buttonThemThue;
        public Button buttonThoat;
        public TextBox txtTenThue;
        public Label labelTenChatLieu;
        private Panel panel1;
        private Label label1;
    }
}