using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
using Microsoft.VisualBasic.Devices;

namespace GUI
{
    public partial class MauSacGUI : Form
    {
        MauSacBUS mauSacBUS = new MauSacBUS();
        public MauSacGUI()
        {
            InitializeComponent();
            LoadDataMauSac();
        }

        public void LoadDataMauSac()
        {
            danhSachMauSac.RowCount = 0;
            foreach (var item in mauSacBUS.LayDanhSachMauSac())
            {
                danhSachMauSac.Rows.Add(item.MaMauSac, item.TenMauSac);
            }
        }

        public void LoadDataMauSac(string text)
        {
            danhSachMauSac.RowCount = 0;
            foreach (var item in mauSacBUS.TimKiemMauSac(text))
            {
                danhSachMauSac.Rows.Add(item.MaMauSac, item.TenMauSac);
            }
        }

        // hàm hiển thị dialog chi tiết
        public void ShowDialogChiTiet(MauSacModule module)
        {
            module.btnThem.Visible = false;
            module.btnSua.Visible = false;
            module.btnThoat.Size = new Size(320, 51);
        }

        // hàm hiển thị dialog thêm
        public void ShowDialogThem(MauSacModule module)
        {
            module.btnThem.Visible = true;
            module.btnSua.Visible = false;

        }
        // hàm hiển thị dialog sửa
        public void ShowDialogSua(MauSacModule module)
        {
            module.btnThem.Visible = false;
            module.btnSua.Visible = true;

        }

        private void danhSachMauSac_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            DataGridViewRow row = danhSachMauSac.Rows[e.RowIndex];

            int maMauSac = Convert.ToInt32(row.Cells[0].Value.ToString());
            MauSac mauSac = mauSacBUS.LayMauSacQuaMa(maMauSac);

            string selectedColumnName = danhSachMauSac.Columns[e.ColumnIndex].Name;
            if (selectedColumnName == "Xoa")
            {
                DialogResult result = MessageBox.Show("Bạn có muốn tiếp tục xóa ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (mauSacBUS.XoaMauSac(mauSac))
                    {
                        MessageBox.Show("Bạn đã xóa thành công");
                        LoadDataMauSac();
                    }
                    else
                    {
                        MessageBox.Show("Thất bại");
                    }
                }
            }
            else if (selectedColumnName == "Sua")
            {
                MauSacModule mauSacModule = new MauSacModule(maMauSac);
                mauSacModule.txtTenMauSac.Text = mauSac.TenMauSac;
                ShowDialogSua(mauSacModule);
                mauSacModule.ShowDialog();
                LoadDataMauSac();

            }
            else if (selectedColumnName == "ChiTiet")
            {
                MauSacModule mauSacModule = new MauSacModule(maMauSac);
                mauSacModule.txtTenMauSac.Text = mauSac.TenMauSac;
                ShowDialogChiTiet(mauSacModule);
                mauSacModule.ShowDialog();

            }
        }

        private void btnShowDialog_Click(object sender, EventArgs e)
        {
            MauSacModule mauSacModule = new MauSacModule();
            ShowDialogThem(mauSacModule);
            mauSacModule.ShowDialog();
            LoadDataMauSac();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text;
            if (txtTimKiem.Text == "" || txtTimKiem.Text == " ")
            {
                LoadDataMauSac();
            }
            else
            {
                LoadDataMauSac(keyword);
            }
        }
    }
}
