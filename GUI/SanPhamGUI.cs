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
    public partial class SanPhamGUI : Form
    {
        SanPhamBUS sanPhamBUS = new SanPhamBUS();
        TheLoaiBUS theLoaiBUS = new TheLoaiBUS();
        ThuongHieuBUS thuongHieuBUS = new ThuongHieuBUS();
        ChatLieuBUS chatLieuBUS = new ChatLieuBUS();
        KichCoBUS kichCoBUS = new KichCoBUS();
        MauSacBUS mauSacBUS = new MauSacBUS();

        public SanPhamGUI()
        {
            InitializeComponent();
            LoadDataSanPham();
        }

        // Load dữ liệu sản phẩm lên bảng
        public void LoadDataSanPham()
        {
            danhSachSanPham.RowCount = 0;
            foreach (SanPham sanPham in sanPhamBUS.LayDanhSachSanPham())
            {
                if (sanPham.TrangThai == 1)
                {
                    danhSachSanPham.Rows.Add(
                    sanPham.MaSanPham,
                       thuongHieuBUS.LayThuongHieuQuaMa(sanPham.MaThuongHieu).TenThuongHieu,
                       theLoaiBUS.LayTheLoaiQuaMa(sanPham.MaTheLoai).TenTheLoai,
                       chatLieuBUS.LayChatLieuQuaMa(sanPham.MaChatLieu).TenChatLieu,
                       sanPham.TenSanPham,
                       sanPham.GiaSanPham,
                       sanPham.GiaNhap,
                       sanPham.SoLuongNhap,
                       sanPham.SoLuongTon);
                }
            }
        }
        public void LoadDataSanPham(string text)
        {
            danhSachSanPham.RowCount = 0;
            foreach (SanPham sanPham in sanPhamBUS.TimKiemSanPham(text))
            {
                if (sanPham.TrangThai == 1)
                {
                    danhSachSanPham.Rows.Add(
                    sanPham.MaSanPham,
                       thuongHieuBUS.LayThuongHieuQuaMa(sanPham.MaThuongHieu).TenThuongHieu,
                       theLoaiBUS.LayTheLoaiQuaMa(sanPham.MaTheLoai).TenTheLoai,
                       chatLieuBUS.LayChatLieuQuaMa(sanPham.MaChatLieu).TenChatLieu,
                       sanPham.TenSanPham,
                       sanPham.GiaSanPham,
                       sanPham.GiaNhap,
                       sanPham.SoLuongNhap,
                       sanPham.SoLuongTon);
                }
            }
        }
        private void danhSachSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            DataGridViewRow row = danhSachSanPham.Rows[e.RowIndex];
            int maSanPham = Convert.ToInt32(row.Cells[0].Value.ToString());
            SanPham sanPham = sanPhamBUS.LaySanPhamQuaMa(maSanPham);


            string selectedColumnName = danhSachSanPham.Columns[e.ColumnIndex].Name;
            if (selectedColumnName == "Xoa")
            {
                DialogResult result = MessageBox.Show("Bạn có muốn tiếp tục xóa ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (sanPhamBUS.XoaSanPham(maSanPham))
                    {
                        MessageBox.Show("Xóa thành công");
                        LoadDataSanPham();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại");
                    }
                }
            }
            else if (selectedColumnName == "Sua")
            {
                SanPhamModule sanPhamModule = new SanPhamModule(maSanPham);
                // khóa các trường dữ liệu không được sửa hoặc không được thao tác khi sửa
                sanPhamModule.comboxMauSac.Enabled = false;
                sanPhamModule.comboxKichCo.Enabled = false;
                sanPhamModule.comboxMaSanPham.Enabled = false;
                sanPhamModule.anhSanPham.Enabled = false;
                // ---------------------------------------------------------------------------

                // load dữ liệu cho các combobox 
                LoadComboboxChatLieu(sanPhamModule);
                LoadComboboxTheLoai(sanPhamModule);
                LoadComboboxMauSac(sanPhamModule);
                LoadComboboxKichCo(sanPhamModule);
                LoadComboboxThuongHieu(sanPhamModule);
                //------------------------------------------------------------------------------


                // set giá trị cho các combobox thuộc tính trùng với sản phẩm chọn
                sanPhamModule.comboxThuongHieu.Text = thuongHieuBUS.LayThuongHieuQuaMa(sanPham.MaThuongHieu).TenThuongHieu;
                sanPhamModule.comboxTheLoai.Text = theLoaiBUS.LayTheLoaiQuaMa(sanPham.MaTheLoai).TenTheLoai;
                sanPhamModule.comboxChatLieu.Text = chatLieuBUS.LayChatLieuQuaMa(sanPham.MaChatLieu).TenChatLieu;
                //-------------------------------------------------------------------------------


                // set giá trị cho các trường dữ liệu còn lại
                sanPhamModule.txtTenSanPham.Text = sanPham.TenSanPham;
                sanPhamModule.txtGiaSanPham.Text = sanPham.GiaSanPham.ToString();
                sanPhamModule.txtGiaNhap.Text = sanPham.GiaNhap.ToString();
                ShowDialogSua(sanPhamModule);
                sanPhamModule.ShowDialog();
                LoadDataSanPham();
                //-------------------------------------------------------------------------------
            }

            else if (selectedColumnName == "ChiTiet")
            {
                ChiTietSanPhamGUI chiTietSanPhamGUI = new ChiTietSanPhamGUI(sanPham.MaSanPham);
                chiTietSanPhamGUI.FormBorderStyle = FormBorderStyle.Sizable;
                chiTietSanPhamGUI.ShowDialog();

            }
        }



        public void ShowDialogThem(SanPhamModule sanPhamModule)
        {
            sanPhamModule.btnThem.Visible = true;
            sanPhamModule.btnSua.Visible = false;


        }

        public void ShowDialogSua(SanPhamModule sanPhamModule)
        {
            sanPhamModule.btnThem.Visible = false;
            sanPhamModule.btnSua.Visible = true;
        }



        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtTimKiem.Text))
            {
                LoadDataSanPham();
            }
            else
            {
                LoadDataSanPham(txtTimKiem.Text);
            }
        }


        // load tên thương hiệu lên combobox
        public void LoadComboboxThuongHieu(SanPhamModule sanPhamModule)
        {
            sanPhamModule.comboxThuongHieu.DataSource = thuongHieuBUS.LayDanhSachTenThuongHieu();
        }

        // load tên chất liệu lên combobox
        public void LoadComboboxChatLieu(SanPhamModule sanPhamModule)
        {
            sanPhamModule.comboxChatLieu.DataSource = chatLieuBUS.LayDanhSachTenChatLieu();
        }
        // load tên thể loại lên combobox
        public void LoadComboboxTheLoai(SanPhamModule sanPhamModule)
        {
            sanPhamModule.comboxTheLoai.DataSource = theLoaiBUS.LayDanhSachTenTheLoai();
        }

        // load tên kích cỡ lên combobox
        public void LoadComboboxKichCo(SanPhamModule sanPhamModule)
        {
            sanPhamModule.comboxKichCo.DataSource = kichCoBUS.LayDanhSachTenKichCo();
        }

        // load tên màu sắc lên combobox
        public void LoadComboboxMauSac(SanPhamModule sanPhamModule)
        {
            sanPhamModule.comboxMauSac.DataSource = mauSacBUS.LayDanhSachTenMauSac();
        }

        private void btnShowDialog_Click(object sender, EventArgs e)
        {
            SanPhamModule sanPhamModule = new SanPhamModule();
            ShowDialogThem(sanPhamModule);

            LoadComboboxChatLieu(sanPhamModule);
            LoadComboboxTheLoai(sanPhamModule);
            LoadComboboxThuongHieu(sanPhamModule);
            LoadComboboxKichCo(sanPhamModule);
            LoadComboboxMauSac(sanPhamModule);
            sanPhamModule.ShowDialog();
            LoadDataSanPham();
        }
    }
}
