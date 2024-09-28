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
    public partial class TheLoaiGUI : Form
    {
        TheLoaiBUS theLoaiBUS = new TheLoaiBUS();
        public TheLoaiGUI()
        {
            InitializeComponent();
            LoadDataTheLoai();
        }

        // load dữ liệu thể loại đổ ra bảng
        public void LoadDataTheLoai()
        {
            danhSachTheLoai.RowCount = 0;
            foreach (var item in theLoaiBUS.LayDanhSachTheLoai())
            {
                if (item.TrangThai == 1)
                {
                    danhSachTheLoai.Rows.Add(item.MaTheLoai, item.TenTheLoai);
                }
            }
        }

        public void LoadDataTheLoai(string text)
        {
            danhSachTheLoai.RowCount = 0;
            foreach (var item in theLoaiBUS.TimKiemTheLoai(text))
            {
                if (item.TrangThai == 1)
                {
                    danhSachTheLoai.Rows.Add(item.MaTheLoai, item.TenTheLoai);
                }
            }
        }

        // hàm hiển thị dialog chi tiết
        public void ShowDialogChiTiet(TheLoaiModule module)
        {
            module.btnThem.Visible = false;
            module.btnSua.Visible = false;
            module.btnThoat.Size = new Size(320, 51);
        }

        // hàm hiển thị dialog thêm
        public void ShowDialogThem(TheLoaiModule module)
        {
            module.btnThem.Visible = true;
            module.btnSua.Visible = false;

        }
        // hàm hiển thị dialog sửa
        public void ShowDialogSua(TheLoaiModule module)
        {
            module.btnThem.Visible = false;
            module.btnSua.Visible = true;

        }

        private void btnShowDialog_Click(object sender, EventArgs e)
        {
            TheLoaiModule theLoaiModule = new TheLoaiModule();
            ShowDialogThem(theLoaiModule);
            theLoaiModule.ShowDialog();
            LoadDataTheLoai();
        }

        private void danhSachTheLoai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            // tạo biến dòng được chọn
            DataGridViewRow selectedRow = danhSachTheLoai.Rows[e.RowIndex];

            // lấy ra mã thể loại từ dòng được chọn
            int maTheLoai = Convert.ToInt32(selectedRow.Cells[0].Value.ToString());

            // lấy thể loại qua mã thể loại
            TheLoai theLoai = theLoaiBUS.LayTheLoaiQuaMa(maTheLoai);

            // tạo biến tên cột tại dòng được chọn
            string selectedColumnName = danhSachTheLoai.Columns[e.ColumnIndex].Name;

            // trường hợp tên cột là Xoa
            if (selectedColumnName == "Xoa")
            {
                DialogResult result = MessageBox.Show("Bạn có muốn tiếp tục xóa ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (theLoaiBUS.XoaTheLoai(theLoai.MaTheLoai))
                    {
                        MessageBox.Show("Bạn đã xóa thành công");
                        LoadDataTheLoai();
                    }
                    else
                    {
                        MessageBox.Show("Thất bại");
                    }
                }
            }
            // trường hợp tên cột là Sua
            else if (selectedColumnName == "Sua")
            {
                // khởi tạo module sửa thể loại bằng constructor có tham số và truyền vào mã thể loại tại dòng muốn sửa
                TheLoaiModule theLoaiModule = new TheLoaiModule(maTheLoai);
                theLoaiModule.txtTenTheLoai.Text = theLoai.TenTheLoai;
                ShowDialogSua(theLoaiModule);
                theLoaiModule.ShowDialog();
                LoadDataTheLoai();
            }
            else if (selectedColumnName == "ChiTiet")
            {
                TheLoaiModule theLoaiModule = new TheLoaiModule(maTheLoai);
                theLoaiModule.txtTenTheLoai.Text = theLoai.TenTheLoai;
                ShowDialogChiTiet(theLoaiModule);
                theLoaiModule.ShowDialog();
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text;
            if (txtTimKiem.Text == "" || txtTimKiem.Text == " ")
            {
                LoadDataTheLoai();
            }
            else
            {
                LoadDataTheLoai(keyword);
            }
        }
    }
}
