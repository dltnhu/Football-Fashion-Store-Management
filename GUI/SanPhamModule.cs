using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing;
using System.Security.Cryptography;

namespace GUI
{
    public partial class SanPhamModule : Form
    {
        SanPhamBUS sanPhamBUS = new SanPhamBUS();
        TheLoaiBUS theLoaiBUS = new TheLoaiBUS();
        ThuongHieuBUS thuongHieuBUS = new ThuongHieuBUS();
        ChatLieuBUS chatLieuBUS = new ChatLieuBUS();
        KichCoBUS kichCoBUS = new KichCoBUS();
        MauSacBUS mauSacBUS = new MauSacBUS();
        ChiTietSanPhamBUS chiTietSanPhamBUS = new ChiTietSanPhamBUS();

        public int MaSanPham { get; set; }
        public SanPhamModule()
        {
            InitializeComponent();
            LoadComboboxMaSanPham();
        }

        public SanPhamModule(int maSanPham)
        {

            InitializeComponent();
            this.MaSanPham = maSanPham;
            LoadComboboxMaSanPham();
        }

        // Load toàn bộ mã sản phẩm để lựa chọn khi thêm sản phẩm chi tiết
        public void LoadComboboxMaSanPham()
        {
            comboxMaSanPham.Items.Clear();
            foreach (var item in sanPhamBUS.LayDanhSachSanPham())
            {
                if (item.TrangThai == 1)
                {
                    comboxMaSanPham.Items.Add(item.MaSanPham);
                }
            }
        }

        private void anhSanPham_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                anhSanPham.ImageLocation = dialog.FileName.ToString();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuuChiTietSanPham_Click(object sender, EventArgs e)
        {
            List<ChiTietSanPham> chiTietSanPhamHienCo = chiTietSanPhamBUS.LayDanhSachChiTietTheoMaSanPham(Convert.ToInt32(comboxMaSanPham.Text));
            // số lượng sản phẩm chi tiết của 1 sản phẩm đã có hiện tại
            int count = 0;
            // cho chạy từ số lượng chi tiết sản phẩm hiện tại tới sản phẩm được thêm vào bảng tạm
            for (int i = chiTietSanPhamHienCo.Count; i < danhSachChiTietSanPham.Rows.Count; i++)
            {

                ChiTietSanPham chiTietSanPham = new ChiTietSanPham();
                chiTietSanPham.MaSanPham = Convert.ToInt32(txtMaSanPham.Text);
                chiTietSanPham.MaMauSac = Convert.ToInt32(mauSacBUS.LayMauSacQuaTen(danhSachChiTietSanPham.Rows[i].Cells[1].Value.ToString()).MaMauSac);
                chiTietSanPham.MaKichCo = Convert.ToInt32(kichCoBUS.LayKichCoQuaTen(danhSachChiTietSanPham.Rows[i].Cells[2].Value.ToString()).MaKichCo);

                Image image = (Image)danhSachChiTietSanPham.Rows[i].Cells[3].Value;

                // Chuyển đổi ảnh thành mảng byte
                byte[] imageBytes;
                using (MemoryStream ms = new MemoryStream())
                {
                    image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    imageBytes = ms.ToArray();
                }
                chiTietSanPham.HinhAnh = imageBytes;
                chiTietSanPham.SoLuongNhap = 0;
                chiTietSanPham.SoLuongTon = 0;
                chiTietSanPham.TrangThai = 1;
                if (chiTietSanPhamBUS.ThemChiTietSanPham(chiTietSanPham))
                {
                    count++;
                }

            }
            MessageBox.Show("Thêm thành công " + count + " chi tiết sản phẩm");
            this.Dispose();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SanPham sanPham = new SanPham();
            if (string.IsNullOrWhiteSpace(txtTenSanPham.Text) || string.IsNullOrWhiteSpace(txtGiaNhap.Text) || string.IsNullOrWhiteSpace(txtGiaSanPham.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                try
                {
                    sanPham.MaThuongHieu = thuongHieuBUS.LayThuongHieuQuaTen(comboxThuongHieu.Text).MaThuongHieu;
                    sanPham.MaTheLoai = theLoaiBUS.LayTheLoaiQuaTen(comboxTheLoai.Text).MaTheLoai;
                    sanPham.MaChatLieu = chatLieuBUS.LayChatLieuQuaTen(comboxChatLieu.Text).MaChatLieu;
                    sanPham.TenSanPham = txtTenSanPham.Text;
                    sanPham.GiaSanPham = Convert.ToSingle(txtGiaSanPham.Text);
                    sanPham.GiaNhap = Convert.ToSingle(txtGiaNhap.Text);
                    sanPham.SoLuongNhap = 0;
                    sanPham.SoLuongTon = 0;
                    sanPham.TrangThai = 1;

                    if (sanPhamBUS.ThemSanPham(sanPham))
                    {

                        MessageBox.Show("Thêm thành công");
                        LoadComboboxMaSanPham();

                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại");
                    }
                }
                catch (Exception ez)
                {
                    MessageBox.Show("Thông tin bạn nhập không hợp lệ");
                }
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SanPham sanPham = new SanPham();

            if (string.IsNullOrWhiteSpace(txtTenSanPham.Text) || string.IsNullOrWhiteSpace(txtGiaNhap.Text) || string.IsNullOrWhiteSpace(txtGiaSanPham.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                try
                {
                    sanPham.MaSanPham = this.MaSanPham;
                    sanPham.MaThuongHieu = thuongHieuBUS.LayThuongHieuQuaTen(comboxThuongHieu.Text).MaThuongHieu;
                    sanPham.MaTheLoai = theLoaiBUS.LayTheLoaiQuaTen(comboxTheLoai.Text).MaTheLoai;
                    sanPham.MaChatLieu = chatLieuBUS.LayChatLieuQuaTen(comboxChatLieu.Text).MaChatLieu;
                    sanPham.TenSanPham = txtTenSanPham.Text;
                    sanPham.GiaSanPham = Convert.ToSingle(txtGiaSanPham.Text);
                    sanPham.GiaNhap = Convert.ToSingle(txtGiaNhap.Text);
                    sanPham.SoLuongNhap = 0;
                    sanPham.SoLuongTon = 0;
                    sanPham.TrangThai = 1;

                    if (sanPhamBUS.SuaSanPham(sanPham))
                    {

                        MessageBox.Show("Sửa thành công");
                        LoadComboboxMaSanPham();

                    }
                    else
                    {
                        MessageBox.Show("Sửa thất bại");
                    }
                }
                catch (Exception ez)
                {
                    MessageBox.Show("Thông tin bạn nhập không hợp lệ");
                }
            }
        }

        public bool kiemTraTrungChiTietSanPham(string tenMauSac, string tenKichCo)
        {
            for (int i = 0; i < danhSachChiTietSanPham.RowCount; i++)
            {
                if (tenMauSac == danhSachChiTietSanPham.Rows[i].Cells[1].Value.ToString() && tenKichCo == danhSachChiTietSanPham.Rows[i].Cells[2].Value.ToString())
                {
                    return true;
                }
            }
            return false;
        }
        private void btnThemChiTietSanPham_Click(object sender, EventArgs e)
        {
            if (kiemTraTrungChiTietSanPham(comboxMauSac.Text, comboxKichCo.Text))
            {
                MessageBox.Show("Chi tiết sản phẩm đã có");
            }
            else
            {
                byte[] images = null;
                if(anhSanPham.ImageLocation == null)
                {
                    danhSachChiTietSanPham.Rows.Add(txtTenSanPham.Text, comboxMauSac.Text, comboxKichCo.Text, GUI.Properties.Resources.Product);

                }
                else
                {
                    FileStream stream = new FileStream(anhSanPham.ImageLocation, FileMode.Open, FileAccess.Read);
                    BinaryReader brs = new BinaryReader(stream);
                    images = brs.ReadBytes((int)stream.Length);
                    MemoryStream ms = new MemoryStream(images);
                    anhSanPham.Image = Image.FromStream(ms);
                    danhSachChiTietSanPham.Rows.Add(txtTenSanPham.Text, comboxMauSac.Text, comboxKichCo.Text, anhSanPham.Image);
                }
                


            }
        }


        // hiển thị chi tiết sản phẩm hiện tại của sản phẩm đã chọn trong combobox mã sản phẩm
        private void comboxMaSanPham_SelectedValueChanged(object sender, EventArgs e)
        {
            string maSanPham = comboxMaSanPham.Text;
            SanPham sanPham = sanPhamBUS.LaySanPhamQuaMa(Convert.ToInt32(maSanPham));

            // đẩy thông tin sản phẩm lên các trường dữ liệu khi chọn mã sản phẩm trong combobox
            txtMaSanPham.Text = sanPham.MaSanPham + "";
            txtTenSanPham.Text = sanPham.TenSanPham;
            txtGiaSanPham.Text = sanPham.GiaSanPham + "";
            txtGiaNhap.Text = sanPham.GiaNhap + "";
            comboxTheLoai.SelectedItem = theLoaiBUS.LayTheLoaiQuaMa(sanPham.MaTheLoai).TenTheLoai;
            comboxChatLieu.SelectedItem = chatLieuBUS.LayChatLieuQuaMa(sanPham.MaChatLieu).TenChatLieu;
            comboxThuongHieu.SelectedItem = thuongHieuBUS.LayThuongHieuQuaMa(sanPham.MaThuongHieu).TenThuongHieu;
            danhSachChiTietSanPham.RowCount = 0;

            // lặp toàn bộ danh sách chi tiết sản phẩm để lọc ra chi tiết sản phẩm có mã sản phẩm
            foreach (var item in chiTietSanPhamBUS.LayToanBoChiTietSanPham())
            {
                if (item.MaSanPham == Convert.ToInt32(maSanPham))
                {
                    if (item.HinhAnh != null && item.HinhAnh.Length > 0)
                    {
                        Image image;
                        using (MemoryStream ms = new MemoryStream(item.HinhAnh))
                        {
                            image = Image.FromStream(ms);
                        }
                        danhSachChiTietSanPham.Rows.Add(sanPham.TenSanPham, mauSacBUS.LayMauSacQuaMa(item.MaMauSac).TenMauSac, kichCoBUS.LayKichCoQuaMa(item.MaKichCo).TenKichCo, image);

                    }
                    else
                    {
                        danhSachChiTietSanPham.Rows.Add(sanPham.TenSanPham, mauSacBUS.LayMauSacQuaMa(item.MaMauSac).TenMauSac, kichCoBUS.LayKichCoQuaMa(item.MaKichCo).TenKichCo, GUI.Properties.Resources.Product);
                    }
                }
            }
        }
    }
}
