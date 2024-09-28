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
    public partial class KichCoGUI : Form
    {
        KichCoBUS kichCoBUS = new KichCoBUS();
        public KichCoGUI()
        {
            InitializeComponent();
            LoadDataKichCo();
        }

        public void LoadDataKichCo()
        {
            danhSachKichCo.RowCount = 0;
            foreach (var item in kichCoBUS.LayDanhSachKichCo())
            {
                danhSachKichCo.Rows.Add(item.MaKichCo, item.TenKichCo);
            }
        }

        public void LoadDataKichCo(string text)
        {
            danhSachKichCo.RowCount = 0;
            foreach (var item in kichCoBUS.TimKiemKichCo(text))
            {
                danhSachKichCo.Rows.Add(item.MaKichCo, item.TenKichCo);
            }
        }


        // hàm hiển thị dialog chi tiết
        public void ShowDialogChiTiet(KichCoModule module)
        {
            module.btnThem.Visible = false;
            module.btnSua.Visible = false;
            module.btnThoat.Size = new Size(320, 51);
        }

        // hàm hiển thị dialog thêm
        public void ShowDialogThem(KichCoModule module)
        {
            module.btnThem.Visible = true;
            module.btnSua.Visible = false;

        }
        // hàm hiển thị dialog sửa
        public void ShowDialogSua(KichCoModule module)
        {
            module.btnThem.Visible = false;
            module.btnSua.Visible = true;

        }

        private void danhSachKichCo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            DataGridViewRow row = danhSachKichCo.Rows[e.RowIndex];

            int maKichCo = Convert.ToInt32(row.Cells[0].Value.ToString());
            KichCo kichCo = kichCoBUS.LayKichCoQuaMa(maKichCo);

            string selectedColumnName = danhSachKichCo.Columns[e.ColumnIndex].Name;
            if (selectedColumnName == "Xoa")
            {
                DialogResult result = MessageBox.Show("Bạn có muốn tiếp tục xóa ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (kichCoBUS.XoaKichCo(kichCo))
                    {
                        MessageBox.Show("Bạn đã xóa thành công");
                        LoadDataKichCo();
                    }
                    else
                    {
                        MessageBox.Show("Thất bại");
                    }
                }
            }
            else if (selectedColumnName == "Sua")
            {
                KichCoModule kichCoModule = new KichCoModule(maKichCo);
                kichCoModule.txtTenKichCo.Text = kichCo.TenKichCo;
                ShowDialogSua(kichCoModule);
                kichCoModule.ShowDialog();
                LoadDataKichCo();

            }
            else if (selectedColumnName == "ChiTiet")
            {
                KichCoModule kichCoModule = new KichCoModule(maKichCo);
                kichCoModule.txtTenKichCo.Text = kichCo.TenKichCo;
                ShowDialogChiTiet(kichCoModule);
                kichCoModule.ShowDialog();

            }
        }

        private void btnShowDialog_Click(object sender, EventArgs e)
        {
            KichCoModule kichCoModule = new KichCoModule();
            ShowDialogThem(kichCoModule);
            kichCoModule.ShowDialog();
            LoadDataKichCo();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text;
            if (txtTimKiem.Text == "" || txtTimKiem.Text == " ")
            {
                LoadDataKichCo();
            }
            else
            {
                LoadDataKichCo(keyword);
            }
        }
    }
}
