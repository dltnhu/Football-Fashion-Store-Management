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
    public partial class ThueGUI : Form
    {
        ThueBUS thueBUS = new ThueBUS();
        public ThueGUI()
        {
            InitializeComponent();
            LoadDataTable();
        }

        public void LoadDataTable()
        {
            danhSachThue.RowCount = 0;
            foreach (var item in thueBUS.LayToanBoThue())
            {
                if (item.TrangThai == 1)
                {
                    danhSachThue.Rows.Add(item.MaThue, item.TenThue, item.MucThue);
                }
            }
        }

        public void LoadDataTable(string text)
        {
            danhSachThue.RowCount = 0;
            foreach (var item in thueBUS.TimKiemThue(text))
            {
                if (item.TrangThai == 1)
                {
                    danhSachThue.Rows.Add(item.MaThue, item.TenThue, item.MucThue);
                }
            }
        }

        private void danhSachThue_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            DataGridViewRow row = danhSachThue.Rows[e.RowIndex];

            int maThue = Convert.ToInt32(row.Cells[0].Value.ToString());


            Thue thue = thueBUS.LayThongTinThue(maThue);

            string selectedColumnName = danhSachThue.Columns[e.ColumnIndex].Name;
            if (selectedColumnName == "Xoa")
            {
                DialogResult result = MessageBox.Show("Bạn có muốn tiếp tục xóa ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (thueBUS.XoaThongTinThue(thue.MaThue))
                    {
                        MessageBox.Show("Bạn đã xóa thành công");
                        LoadDataTable();
                    }
                    else
                    {
                        MessageBox.Show("Thất bại");
                    }
                }
            }
        }

        private void btnShowDialog_Click(object sender, EventArgs e)
        {
            ThueModule thueModule = new ThueModule();
            thueModule.ShowDialog();
            LoadDataTable();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTimKiem.Text))
            {
                LoadDataTable();
            }
            else
            {
                string text = txtTimKiem.Text;
                LoadDataTable(text);
            }
        }
    }
}
