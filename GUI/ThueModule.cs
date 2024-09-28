using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class ThueModule : Form
    {
        ThueBUS thueBUS = new ThueBUS();
        public ThueModule()
        {
            InitializeComponent();
        }

        private void buttonThemThue_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(txtTenThue.Text) || string.IsNullOrEmpty(txtMucThue.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                Thue thue = new Thue();
                thue.TenThue = txtTenThue.Text;
                thue.MucThue = Convert.ToSingle(txtMucThue.Text);
                thue.TrangThai = 1;
                if (thueBUS.ThemThongTinThue(thue))
                {
                    MessageBox.Show("Thêm thành công");
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");

                }
            }
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
