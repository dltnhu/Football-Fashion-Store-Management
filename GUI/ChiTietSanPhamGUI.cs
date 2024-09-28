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
    public partial class ChiTietSanPhamGUI : Form
    {
        SanPhamBUS sanPhamBUS = new SanPhamBUS();
        ChiTietSanPhamBUS chiTietSanPhamBUS = new ChiTietSanPhamBUS();
        MauSacBUS mauSacBUS = new MauSacBUS();
        KichCoBUS kichCoBUS = new KichCoBUS();

        public int maSP {  get; set; }

        public ChiTietSanPhamGUI()
        {
            InitializeComponent();
            LoadDataChiTietSanPham();
        }


        public ChiTietSanPhamGUI(int maSanPham)
        {
            InitializeComponent();
            this.maSP = maSanPham;
            LoadDataChiTietSanPham(maSanPham);
        }

        public void LoadDataChiTietSanPham()
        {
            danhSachChiTietSanPham.RowCount = 0;
            foreach (var item in chiTietSanPhamBUS.LayToanBoChiTietSanPham())
            {
                if(item.TrangThai == 1)
                {
                    if (item.HinhAnh != null && item.HinhAnh.Length > 0)
                    {
                        // Chuyển từ kiểu Byte sang đối tượng Image 
                        Image image;
                        using (MemoryStream ms = new MemoryStream(item.HinhAnh))
                        {
                            image = Image.FromStream(ms);
                        }
                        danhSachChiTietSanPham.Rows.Add(item.MaChiTietSanPham, sanPhamBUS.LaySanPhamQuaMa(item.MaSanPham).TenSanPham, mauSacBUS.LayMauSacQuaMa(item.MaMauSac).TenMauSac, kichCoBUS.LayKichCoQuaMa(item.MaKichCo).TenKichCo, image, item.SoLuongNhap, item.SoLuongTon);
                    }
                    else
                    {
                        danhSachChiTietSanPham.Rows.Add(item.MaChiTietSanPham, sanPhamBUS.LaySanPhamQuaMa(item.MaSanPham).TenSanPham, mauSacBUS.LayMauSacQuaMa(item.MaMauSac).TenMauSac, kichCoBUS.LayKichCoQuaMa(item.MaKichCo).TenKichCo, GUI.Properties.Resources.Product, item.SoLuongNhap, item.SoLuongTon);
                    }
                }
                
            }
        }

        public void LoadDataChiTietSanPham(int maSanPham)
        {
            danhSachChiTietSanPham.RowCount = 0;
            foreach (var item in chiTietSanPhamBUS.LayDanhSachChiTietTheoMaSanPham(maSanPham))
            {
                if (item.HinhAnh != null && item.HinhAnh.Length > 0)
                {
                    // Chuyển từ kiểu Byte sang đối tượng Image 
                    Image image;
                    using (MemoryStream ms = new MemoryStream(item.HinhAnh))
                    {
                        image = Image.FromStream(ms);
                    }
                    danhSachChiTietSanPham.Rows.Add(item.MaChiTietSanPham, sanPhamBUS.LaySanPhamQuaMa(item.MaSanPham).TenSanPham, mauSacBUS.LayMauSacQuaMa(item.MaMauSac).TenMauSac, kichCoBUS.LayKichCoQuaMa(item.MaKichCo).TenKichCo, image, item.SoLuongNhap, item.SoLuongTon);
                }
                else
                {
                    danhSachChiTietSanPham.Rows.Add(item.MaChiTietSanPham, sanPhamBUS.LaySanPhamQuaMa(item.MaSanPham).TenSanPham, mauSacBUS.LayMauSacQuaMa(item.MaMauSac).TenMauSac, kichCoBUS.LayKichCoQuaMa(item.MaKichCo).TenKichCo, GUI.Properties.Resources.Product, item.SoLuongNhap, item.SoLuongTon);
                }
            }
        }

        private void danhSachChiTietSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            DataGridViewRow row = danhSachChiTietSanPham.Rows[e.RowIndex];
            int maChiTietSanPham = Convert.ToInt32(row.Cells[0].Value.ToString());
            ChiTietSanPham chiTietSanPham = chiTietSanPhamBUS.LaySanPhamChiTietQuaMa(maChiTietSanPham);




            string selectedColumnName = danhSachChiTietSanPham.Columns[e.ColumnIndex].Name;
            if (selectedColumnName == "Xoa")
            {
                DialogResult result = MessageBox.Show("Bạn có muốn tiếp tục xóa ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (chiTietSanPhamBUS.XoaChiTietSanPham(maChiTietSanPham))
                    {
                        MessageBox.Show("Bạn đã xóa thành công");
                        sanPhamBUS.capNhatSoLuong(chiTietSanPham.MaSanPham);
                        LoadDataChiTietSanPham();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại");
                    }
                }
            }
            else if (selectedColumnName == "Sua")
            {
                ChiTietSanPhamModule chiTietSanPhamModule = new ChiTietSanPhamModule(maChiTietSanPham);
                chiTietSanPhamModule.txtTenSanPham.Text = sanPhamBUS.LaySanPhamQuaMa(chiTietSanPham.MaSanPham).TenSanPham;
                chiTietSanPhamModule.comboxKichCo.DataSource = kichCoBUS.LayDanhSachTenKichCo();
                chiTietSanPhamModule.comboxMauSac.DataSource = mauSacBUS.LayDanhSachTenMauSac();

                chiTietSanPhamModule.comboxKichCo.SelectedItem = kichCoBUS.LayKichCoQuaMa(chiTietSanPham.MaKichCo).TenKichCo;

                chiTietSanPhamModule.comboxMauSac.Text = mauSacBUS.LayMauSacQuaMa(chiTietSanPham.MaMauSac).TenMauSac;
                byte[] img = (byte[])(chiTietSanPham.HinhAnh);
                MemoryStream ms = new MemoryStream(img);
                chiTietSanPhamModule.anhSanPham.Image = Image.FromStream(ms);
                chiTietSanPhamModule.btnSua.Visible = true;

                chiTietSanPhamModule.ShowDialog();

                LoadDataChiTietSanPham();


            }
            else if (selectedColumnName == "ChiTiet")
            {
                ChiTietSanPhamModule chiTietSanPhamModule = new ChiTietSanPhamModule(maChiTietSanPham);
                chiTietSanPhamModule.txtTenSanPham.Text = sanPhamBUS.LaySanPhamQuaMa(chiTietSanPham.MaSanPham).TenSanPham;
                chiTietSanPhamModule.comboxKichCo.DataSource = kichCoBUS.LayDanhSachTenKichCo();
                chiTietSanPhamModule.comboxMauSac.DataSource = mauSacBUS.LayDanhSachTenMauSac();

                chiTietSanPhamModule.comboxKichCo.SelectedItem = kichCoBUS.LayKichCoQuaMa(chiTietSanPham.MaKichCo).TenKichCo;

                chiTietSanPhamModule.comboxMauSac.Text = mauSacBUS.LayMauSacQuaMa(chiTietSanPham.MaMauSac).TenMauSac;
                byte[] img = (byte[])(chiTietSanPham.HinhAnh);
                MemoryStream ms = new MemoryStream(img);
                chiTietSanPhamModule.anhSanPham.Image = Image.FromStream(ms);
                ShowDialogChiTiet(chiTietSanPhamModule);
                chiTietSanPhamModule.ShowDialog();

            }

            
        }
        // hàm hiển thị dialog chi tiết
        public void ShowDialogChiTiet(ChiTietSanPhamModule module)
        {
            module.btnSua.Visible = false;
            module.btnThoat.Size = new Size(320, 51);


        }
    }
}
