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
    public partial class ChucNangGUI : Form
    {
        ChucNangBUS chucNangBUS = new ChucNangBUS();
        public ChucNangGUI()
        {
            InitializeComponent();
            LoadDataChucNang();
        }

        // load dữ liệu lên bảng
        public void LoadDataChucNang()
        {
            danhSachChucNang.Rows.Clear();
            foreach (var item in chucNangBUS.LayDanhSachChucNang())
            {
                danhSachChucNang.Rows.Add(item.MaChucNang, item.TenChucNang);
            }
        }

        // load dữ liệu tìm kiếm lên bảng
        public void LoadDataChucNang(string text)
        {
            danhSachChucNang.Rows.Clear();
            foreach (var item in chucNangBUS.TimKiemChucNang(text))
            {
                danhSachChucNang.Rows.Add(item.MaChucNang, item.TenChucNang);
            }
        }

        // Xử lý ẩn nút thêm chức năng
        private void btnShowDialog_Click(object sender, EventArgs e)
        {
            ChucNangModule chucNangModule = new ChucNangModule();
            ShowDialogThem(chucNangModule);
            chucNangModule.ShowDialog();
            LoadDataChucNang();
        }



        // hàm hiển thị dialog chi tiết
        public void ShowDialogChiTiet(ChucNangModule module)
        {
            module.btnThem.Visible = false;
            module.btnSua.Visible = false;
            module.btnThoat.Size = new Size(320, 51);
        }

        // hàm hiển thị dialog thêm
        public void ShowDialogThem(ChucNangModule module)
        {
            module.btnThem.Visible = true;
            module.btnSua.Visible = false;

        }
        // hàm hiển thị dialog sửa
        public void ShowDialogSua(ChucNangModule module)
        {
            module.btnThem.Visible = false;
            module.btnSua.Visible = true;

        }

        // Xử lý ấn 1 dòng trên danh sách
        private void danhSachChucNang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            DataGridViewRow row = danhSachChucNang.Rows[e.RowIndex];

            int maChucNang = Convert.ToInt32(row.Cells[0].Value.ToString());
            ChucNang chucNang = chucNangBUS.LayChucNangQuaMa(maChucNang);

            string selectedColumnName = danhSachChucNang.Columns[e.ColumnIndex].Name;

            if (selectedColumnName == "Xoa")
            {
                DialogResult result = MessageBox.Show("Bạn có muốn tiếp tục xóa ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (chucNangBUS.XoaChucNang(maChucNang))
                    {
                        MessageBox.Show("Bạn đã xóa thành công");
                        LoadDataChucNang();
                    }
                    else
                    {
                        MessageBox.Show("Thất bại");
                    }
                }
            }
            else if (selectedColumnName == "Sua")
            {
                ChucNangModule chucNangModule = new ChucNangModule(maChucNang);
                chucNangModule.txtTenChucNang.Text = chucNang.TenChucNang;
                ShowDialogSua(chucNangModule);
                chucNangModule.ShowDialog();
                LoadDataChucNang();
            }
            else if (selectedColumnName == "ChiTiet")
            {
                ChucNangModule chucNangModule = new ChucNangModule(maChucNang);
                chucNangModule.txtTenChucNang.Text = chucNang.TenChucNang;
                ShowDialogChiTiet(chucNangModule);
                chucNangModule.ShowDialog();
            }
        }

        private void txtTimKiem_TextChanged_1(object sender, EventArgs e)
        {
            string text = txtTimKiem.Text;
            if (string.IsNullOrWhiteSpace(text))
            {
                LoadDataChucNang();
            }
            else
            {
                LoadDataChucNang(text);
            }
        }


    }
}
