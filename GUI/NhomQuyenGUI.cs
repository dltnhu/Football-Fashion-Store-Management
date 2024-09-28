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
    public partial class NhomQuyenGUI : Form
    {
        NhomQuyenBUS nhomQuyenBUS = new NhomQuyenBUS();
        public NhomQuyenGUI()
        {
            InitializeComponent();
            LoadDataNhomQuyen();
        }

        // load dữ liệu lên bảng
        public void LoadDataNhomQuyen()
        {
            danhSachNhomQuyen.Rows.Clear();
            foreach (var item in nhomQuyenBUS.LayDanhSachNhomQuyen())
            {
                danhSachNhomQuyen.Rows.Add(item.MaNhomQuyen, item.TenNhomQuyen);
            }
        }

        // load dữ liệu tìm kiếm lên bảng
        public void LoadDataNhomQuyen(string text)
        {
            danhSachNhomQuyen.Rows.Clear();
            foreach (var item in nhomQuyenBUS.TimKiemNhomQuyen(text))
            {
                danhSachNhomQuyen.Rows.Add(item.MaNhomQuyen, item.TenNhomQuyen);
            }
        }

        // xử lý sự kiện click 1 dòng trên bảng
        private void danhSachNhomQuyen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            DataGridViewRow row = danhSachNhomQuyen.Rows[e.RowIndex];

            int maNhomQuyen = Convert.ToInt32(row.Cells[0].Value.ToString());
            string tenNhomQuyen = row.Cells[1].Value.ToString();


            NhomQuyen nhomQuyen = nhomQuyenBUS.LayNhomQuyenQuaMa(maNhomQuyen);

            string selectedColumnName = danhSachNhomQuyen.Columns[e.ColumnIndex].Name;

            if (selectedColumnName == "Xoa")
            {
                DialogResult result = MessageBox.Show("Bạn có muốn tiếp tục xóa ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (nhomQuyenBUS.XoaNhomQuyen(maNhomQuyen))
                    {
                        MessageBox.Show("Bạn đã xóa thành công");
                        LoadDataNhomQuyen();
                    }
                    else
                    {
                        MessageBox.Show("Thất bại");
                    }
                }
            }
            else if (selectedColumnName == "Sua")
            {
                NhomQuyenModule nhomQuyenModule = new NhomQuyenModule(maNhomQuyen);
                nhomQuyenModule.txtTenNhomQuyen.Text = nhomQuyen.TenNhomQuyen;
                ShowDialogSua(nhomQuyenModule);
                nhomQuyenModule.ShowDialog();
                LoadDataNhomQuyen();
            }
            else if (selectedColumnName == "ChiTiet")
            {
                NhomQuyenModule nhomQuyenModule = new NhomQuyenModule(maNhomQuyen);
                nhomQuyenModule.txtTenNhomQuyen.Text = nhomQuyen.TenNhomQuyen;
                ShowDialogChiTiet(nhomQuyenModule);
                nhomQuyenModule.ShowDialog();

                LoadDataNhomQuyen();
            }
        }

        // hàm hiển thị dialog chi tiết
        public void ShowDialogChiTiet(NhomQuyenModule module)
        {
            module.btnThem.Visible = false;
            module.btnSua.Visible = false;
            module.btnThoat.Size = new Size(320, 51);
        }

        // hàm hiển thị dialog thêm
        public void ShowDialogThem(NhomQuyenModule module)
        {
            module.btnThem.Visible = true;
            module.btnSua.Visible = false;

        }
        // hàm hiển thị dialog sửa
        public void ShowDialogSua(NhomQuyenModule module)
        {
            module.btnThem.Visible = false;
            module.btnSua.Visible = true;

        }

        // xử lý hiển thị dialog khi ấn nút thêm
        private void btnShowDialog_Click(object sender, EventArgs e)
        {
            NhomQuyenModule nhomQuyenModule = new NhomQuyenModule();
            ShowDialogThem(nhomQuyenModule);
            nhomQuyenModule.ShowDialog();
            LoadDataNhomQuyen();
        }

        // xử lý nhập dữ liệu tìm kiếm
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string text = txtTimKiem.Text;
            if (string.IsNullOrWhiteSpace(text))
            {
                LoadDataNhomQuyen();
            }
            else
            {
                LoadDataNhomQuyen(text);
            }
        }


    }
}
