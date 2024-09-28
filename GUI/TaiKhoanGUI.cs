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
    public partial class TaiKhoanGUI : Form
    {
        TaiKhoanBUS taiKhoanBUS = new TaiKhoanBUS();
        NhomQuyenBUS nhomQuyenBUS = new NhomQuyenBUS();
        NhanVienBUS nhanVienBUS = new NhanVienBUS();
        public TaiKhoanGUI()
        {
            InitializeComponent();
            LoadDataTaiKhoan();
        }

        public void LoadDataTaiKhoan()
        {
            danhSachTaiKhoan.Rows.Clear();
            foreach (var i in taiKhoanBUS.LayDanhSachTaiKhoan())
            {
                if (i.TrangThai == 1)
                {
                    danhSachTaiKhoan.Rows.Add(i.MaTaiKhoan, nhomQuyenBUS.LayNhomQuyenQuaMa(i.MaNhomQuyen).TenNhomQuyen, i.TenTaikhoan, i.MatKhau);
                }
            }
            danhSachTaiKhoan.ClearSelection();
        }

        public void LoadDataTaiKhoan(string text)
        {
            danhSachTaiKhoan.Rows.Clear();
            foreach (var i in taiKhoanBUS.TimKiemTaiKhoan(text))
            {
                if (i.TrangThai == 1)
                {
                    danhSachTaiKhoan.Rows.Add(i.MaTaiKhoan, nhomQuyenBUS.LayNhomQuyenQuaMa(i.MaNhomQuyen).TenNhomQuyen, i.TenTaikhoan, i.MatKhau);
                }
            }
            danhSachTaiKhoan.ClearSelection();

        }

        private void danhSachTaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            DataGridViewRow row = danhSachTaiKhoan.Rows[e.RowIndex];

            int maTaiKhoan = Convert.ToInt32(row.Cells[0].Value.ToString());
            TaiKhoan taiKhoan = taiKhoanBUS.LayTaiKhoanQuaMa(maTaiKhoan);

            string selectedColumnName = danhSachTaiKhoan.Columns[e.ColumnIndex].Name;
            if (selectedColumnName == "Xoa")
            {
                DialogResult result = MessageBox.Show("Bạn có muốn tiếp tục xóa ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (taiKhoanBUS.XoaTaiKhoan(maTaiKhoan))
                    {
                        MessageBox.Show("Bạn đã xóa thành công");
                        LoadDataTaiKhoan();
                    }
                    else
                    {
                        MessageBox.Show("Thất bại");
                    }
                }
            }
            else if (selectedColumnName == "Sua")
            {
                TaiKhoanModule taiKhoanModule = new TaiKhoanModule();
                taiKhoanModule.comboBoxNhomQuyen.DataSource = nhomQuyenBUS.LayDanhSachTenNhomQuyen();
                taiKhoanModule.comboBoxNhanVien.DataSource = nhanVienBUS.DanhSachTenNhanVien();

                string tenNhanVien = nhanVienBUS.LayNhanVienQuaMa(taiKhoan.MaTaiKhoan).TenNhanVien;
                taiKhoanModule.comboBoxNhanVien.SelectedItem = taiKhoan.MaTaiKhoan + "-" + tenNhanVien;
                taiKhoanModule.comboBoxNhanVien.Enabled = false;


                taiKhoanModule.comboBoxNhomQuyen.SelectedItem = nhomQuyenBUS.LayNhomQuyenQuaMa(taiKhoan.MaNhomQuyen).TenNhomQuyen;
                taiKhoanModule.txtTenDangNhap.Text = taiKhoan.TenTaikhoan;
                taiKhoanModule.txtMatKhau.Text = taiKhoan.MatKhau;
                ShowDialogSua(taiKhoanModule);
                taiKhoanModule.ShowDialog();
                LoadDataTaiKhoan();
            }
            else if (selectedColumnName == "ChiTiet")
            {
                TaiKhoanModule taiKhoanModule = new TaiKhoanModule();
                taiKhoanModule.comboBoxNhomQuyen.DataSource = nhomQuyenBUS.LayDanhSachTenNhomQuyen();
                taiKhoanModule.comboBoxNhanVien.DataSource = nhanVienBUS.DanhSachTenNhanVien();

                string tenNhanVien = nhanVienBUS.LayNhanVienQuaMa(taiKhoan.MaTaiKhoan).TenNhanVien;
                taiKhoanModule.comboBoxNhanVien.SelectedItem = taiKhoan.MaTaiKhoan + "-" + tenNhanVien;
                taiKhoanModule.comboBoxNhanVien.Enabled = false;


                taiKhoanModule.comboBoxNhomQuyen.SelectedItem = nhomQuyenBUS.LayNhomQuyenQuaMa(taiKhoan.MaNhomQuyen).TenNhomQuyen;
                taiKhoanModule.txtTenDangNhap.Text = taiKhoan.TenTaikhoan;
                taiKhoanModule.txtMatKhau.Text = taiKhoan.MatKhau;
                ShowDialogChiTiet(taiKhoanModule);
                taiKhoanModule.ShowDialog();
                LoadDataTaiKhoan();
            }
        }

        // hàm hiển thị dialog chi tiết
        public void ShowDialogChiTiet(TaiKhoanModule module)
        {
            module.btnThem.Visible = false;
            module.btnSua.Visible = false;
            module.btnThoat.Size = new Size(320, 51);
        }

        // hàm hiển thị dialog thêm
        public void ShowDialogThem(TaiKhoanModule module)
        {
            module.btnThem.Visible = true;
            module.btnSua.Visible = false;

        }
        // hàm hiển thị dialog sửa
        public void ShowDialogSua(TaiKhoanModule module)
        {
            module.btnThem.Visible = false;
            module.btnSua.Visible = true;

        }

        private void btnShowDialog_Click(object sender, EventArgs e)
        {
            TaiKhoanModule taiKhoanModule = new TaiKhoanModule();
            ShowDialogThem(taiKhoanModule);
            taiKhoanModule.comboBoxNhanVien.DataSource = nhanVienBUS.DanhSachTenNhanVien();
            taiKhoanModule.comboBoxNhomQuyen.DataSource = nhomQuyenBUS.LayDanhSachTenNhomQuyen();
            taiKhoanModule.ShowDialog();
            LoadDataTaiKhoan();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTimKiem.Text))
            {
                LoadDataTaiKhoan();
            }
            else
            {
                LoadDataTaiKhoan(txtTimKiem.Text);
            }
        }
    }
}
