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
using static System.Net.Mime.MediaTypeNames;

namespace GUI
{
    public partial class ThuongHieuGUI : Form
    {
        ThuongHieuBUS thuongHieuBUS = new ThuongHieuBUS();
        public ThuongHieuGUI()
        {
            InitializeComponent();
            LoadDataThuongHieu();
        }



        // load dữ liệu thương hiệu đẩy lên bảng
        private void LoadDataThuongHieu()
        {
            danhSachThuongHieu.RowCount = 0;
            foreach (var item in thuongHieuBUS.LayDanhSachThuongHieu())
            {
                if (item.TrangThai == 1)
                {
                    danhSachThuongHieu.Rows.Add(item.MaThuongHieu, item.TenThuongHieu);
                }
            }
            danhSachThuongHieu.ClearSelection();
        }

        // Load dữ liệu thương hiệu tìm kiếm
        private void LoadDataThuongHieu(string text)
        {
            danhSachThuongHieu.RowCount = 0;
            foreach (var item in thuongHieuBUS.TimKiemThuongHieu(text))
            {
                if (item.TrangThai == 1)
                {
                    danhSachThuongHieu.Rows.Add(item.MaThuongHieu, item.TenThuongHieu);
                }
            }
            danhSachThuongHieu.ClearSelection();
        }

        // hàm hiển thị dialog chi tiết
        public void ShowDialogChiTiet(ThuongHieuModule module)
        {
            module.btnThem.Visible = false;
            module.btnSua.Visible = false;
            module.btnThoat.Size = new Size(320, 51);
        }

        // hàm hiển thị dialog thêm
        public void ShowDialogThem(ThuongHieuModule module)
        {
            module.btnThem.Visible = true;
            module.btnSua.Visible = false;

        }
        // hàm hiển thị dialog sửa
        public void ShowDialogSua(ThuongHieuModule module)
        {
            module.btnThem.Visible = false;
            module.btnSua.Visible = true;

        }
        private void btnThemThuongHieu_Click(object sender, EventArgs e)
        {
            ThuongHieuModule thuongHieuModule = new ThuongHieuModule();
            ShowDialogThem(thuongHieuModule);
            thuongHieuModule.ShowDialog();
            LoadDataThuongHieu();

        }


        // Xử lý sự kiện khi ấn sửa, xóa trên bảng
        private void danhSachThuongHieu_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            // dòng được chọn
            DataGridViewRow selectedRow = danhSachThuongHieu.Rows[e.RowIndex];

            // lấy ra mã thương hiệu của dòng được chọn
            int maThuongHieu = Convert.ToInt32(selectedRow.Cells[0].Value.ToString());


            ThuongHieu thuongHieu = thuongHieuBUS.LayThuongHieuQuaMa(maThuongHieu);

            // Lấy tên cột được chọn
            string selectedColumnName = danhSachThuongHieu.Columns[e.ColumnIndex].Name;

            // trường hợp chọn cột Xóa
            if (selectedColumnName == "Xoa")
            {
                DialogResult result = MessageBox.Show("Bạn có muốn tiếp tục xóa ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (thuongHieuBUS.XoaThuongHieu(maThuongHieu))
                    {
                        MessageBox.Show("Bạn đã xóa thành công");
                        LoadDataThuongHieu();
                    }
                    else
                    {
                        MessageBox.Show("Thất bại");
                    }
                }
                else if (result == DialogResult.No)
                {

                }
            }
            // Trường hợp ấn tên cột sửa
            else if (selectedColumnName == "Sua")
            {
                ThuongHieuModule thuongHieuModule = new ThuongHieuModule(maThuongHieu);
                thuongHieuModule.txtTenThuongHieu.Text = thuongHieu.TenThuongHieu;
                ShowDialogSua(thuongHieuModule);
                thuongHieuModule.ShowDialog();
                LoadDataThuongHieu();
            }
            else if (selectedColumnName == "ChiTiet")
            {
                ThuongHieuModule thuongHieuModule = new ThuongHieuModule(maThuongHieu);
                thuongHieuModule.txtTenThuongHieu.Text = thuongHieu.TenThuongHieu;
                ShowDialogChiTiet(thuongHieuModule);
                thuongHieuModule.ShowDialog();
                LoadDataThuongHieu();
            }
        }

        private void btnShowDialog_Click(object sender, EventArgs e)
        {
            ThuongHieuModule thuongHieuModule = new ThuongHieuModule();
            ShowDialogThem(thuongHieuModule);
            thuongHieuModule.ShowDialog();
            LoadDataThuongHieu();
        }

        private void txtTimKiem_TextChanged_1(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text;
            if (txtTimKiem.Text == "" || txtTimKiem.Text == " ")
            {
                LoadDataThuongHieu();
            }
            else
            {
                LoadDataThuongHieu(keyword);
            }
        }
    }
}
