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
using WindowsFormsApp3.GUI;

namespace GUI
{
    public partial class TrangChuGUI : Form
    {
        public int MaTaiKhoan { get; set; }
        public int MaNhomQuyen { get; set; }
        NhanVienBUS nhanVienBUS = new NhanVienBUS();
        ChucNangBUS chucNangBUS = new ChucNangBUS();
        ChiTietQuyenBUS chiTietQuyenBUS = new ChiTietQuyenBUS();
        Form activeForm = null;

        // Phân Quyền
        ChucNangGUI chucNangGUI = null;
        ChiTietQuyenGUI chiTietQuyenGUI = null;
        NhomQuyenGUI nhomQuyenGUI = null;
        PhanQuyenTab phanQuyenTab = null;

        // Nhân Viên
        NhanVienGUI nhanVienGUI = null;
        TaiKhoanGUI taiKhoanGUI = null;
        NhanVienTab nhanVienTab = null;

        // Danh mục sản phẩm
        TheLoaiGUI theLoaiGUI = null;
        ThuongHieuGUI thuongHieuGUI = null;
        ChatLieuGUI chatLieuGUI = null;
        MauSacGUI mauSacGUI = null;
        KichCoGUI kichCoGUI = null;
        DanhMucSanPhamTab danhMucSanPhamTab = null;


        // Sản phẩm
        SanPhamGUI sanPhamGUI = null;
        ChiTietSanPhamGUI chiTietSanPhamGUI = null;
        SanPhamTab sanPhamTab = null;

        //Bán Hàng
        BanHangFrom banHangFrom = null;

        ThueGUI thueGUI = null;
        KhuyenMaiGUI khuyenMaiGUI = null;

        // Nhập hàng
        PhieuNhapGUI phieuNhapGUI = null;
        ChiTietPhieuNhapGUI chiTietPhieuNhapGUI = null;

        // Nhà cung cấp
        NhaCungCapGUI nhaCungCapGUI = null;

        // Thống kê
        ThongKeGUI thongKeGUI = null;


        public TrangChuGUI()
        {
            InitializeComponent();
        }

        public TrangChuGUI(int maTaiKhoan, int maNhomQuyen, List<string> danhSachTenChucNang)
        {
            InitializeComponent();
            this.MaNhomQuyen = maNhomQuyen;
            NhanVien nhanVien = nhanVienBUS.LayNhanVienQuaMa(maTaiKhoan);
            this.MaTaiKhoan = maTaiKhoan;

            // hiển thị tên nhân viên
            lbTenNhanVien.Text = nhanVien.TenNhanVien;
            // Chuyển từ kiểu Byte sang đối tượng Image 
            Image image;
            if (nhanVien.HinhAnh.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(nhanVien.HinhAnh))
                {

                    image = Image.FromStream(ms);
                }
                picAvatar.Image = image;
            }
            else
            {
                picAvatar.Image = Properties.Resources.Manager;
            }

            // hiển thị ảnh nhân viên

            //dùng vòng lặp tạo ra các nút chức năng của nhóm quyền 
            if (danhSachTenChucNang.Count > 0)
            {
                foreach (var item in danhSachTenChucNang)
                {
                    Button btn = new Button();
                    btn.Text = item;
                    if (btn.Text == "Sản Phẩm")
                    {
                        btn.Image = Properties.Resources.Product;
                    }
                    else if (btn.Text == "Danh Mục Sản Phẩm")
                    {
                        btn.Image = Properties.Resources.Holding_Box;
                    }
                    else if (btn.Text == "Bán Hàng")
                    {
                        btn.Image = Properties.Resources.Sell_Stock;
                    }
                    else if (btn.Text == "Nhập Hàng")
                    {
                        btn.Image = Properties.Resources.Sell;
                    }
                    else if (btn.Text == "Nhân Viên")
                    {
                        btn.Image = Properties.Resources.Salesman;
                    }
                    else if (btn.Text == "Khách Hàng")
                    {
                        btn.Image = Properties.Resources.Customer;
                    }
                    else if (btn.Text == "Hóa Đơn")
                    {
                        btn.Image = Properties.Resources.Transaction_Approved;
                    }
                    else if (btn.Text == "Khuyến Mãi")
                    {
                        btn.Image = Properties.Resources.Discount;
                    }
                    else if (btn.Text == "Thuế")
                    {
                        btn.Image = Properties.Resources.Tax;
                    }
                    else if (btn.Text == "Phân Quyền")
                    {
                        btn.Image = Properties.Resources.Registration;
                    }
                    else if (btn.Text == "Thống Kê")
                    {
                        btn.Image = Properties.Resources.Group_of_Projects;
                    }
                    else if (btn.Text == "Nhà Cung Cấp")
                    {
                        btn.Image = Properties.Resources.Deployment;
                    }
                    btn.Size = new System.Drawing.Size(250, 55);
                    btn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
                    btn.Font = new System.Drawing.Font("Segoe UI Variable", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    btn.ForeColor = System.Drawing.Color.White;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                    btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                    btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
                    btn.Click += new EventHandler(Click);

                    sideBar.Controls.Add(btn);

                }
            }

            // Tạo nút đăng xuất
            Button btnDangXuat = new Button();
            btnDangXuat.Text = "Đăng Xuất";
            btnDangXuat.Size = new System.Drawing.Size(250, 55);
            btnDangXuat.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            btnDangXuat.Font = new System.Drawing.Font("Segoe UI Variable", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnDangXuat.ForeColor = System.Drawing.Color.White;
            btnDangXuat.FlatStyle = FlatStyle.Flat;
            btnDangXuat.FlatAppearance.BorderSize = 0;
            btnDangXuat.Image = Properties.Resources.Open_Pane;
            btnDangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnDangXuat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnDangXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnDangXuat.Click += new EventHandler(Click);

            sideBar.Controls.Add(btnDangXuat);
        }

        // xử lý sự kiện khi ấn vào 1 nút chức năng
        private void Click(object sender, EventArgs e)
        {
            Button check = sender as Button;
            if (check.Text == "Phân Quyền")
            {
                nhomQuyenGUI = new NhomQuyenGUI();
                chucNangGUI = new ChucNangGUI();
                chiTietQuyenGUI = new ChiTietQuyenGUI();

                // Kiểm tra hành động của nhóm quyền 
                int maChucNang = chucNangBUS.LayChucNangQuaTen(check.Text).MaChucNang;
                nhomQuyenGUI.btnShowDialog.Visible = chiTietQuyenBUS.kiemTraHanhDong(this.MaNhomQuyen, maChucNang, "Thêm");
                nhomQuyenGUI.danhSachNhomQuyen.Columns["Xoa"].Visible = chiTietQuyenBUS.kiemTraHanhDong(this.MaNhomQuyen, maChucNang, "Xóa");
                nhomQuyenGUI.danhSachNhomQuyen.Columns["Sua"].Visible = chiTietQuyenBUS.kiemTraHanhDong(this.MaNhomQuyen, maChucNang, "Sửa");

                chucNangGUI.btnShowDialog.Visible = chiTietQuyenBUS.kiemTraHanhDong(this.MaNhomQuyen, maChucNang, "Thêm");
                chucNangGUI.danhSachChucNang.Columns["Xoa"].Visible = chiTietQuyenBUS.kiemTraHanhDong(this.MaNhomQuyen, maChucNang, "Xóa");
                chucNangGUI.danhSachChucNang.Columns["Sua"].Visible = chiTietQuyenBUS.kiemTraHanhDong(this.MaNhomQuyen, maChucNang, "Sửa");

                chiTietQuyenGUI.btnShowDialog.Visible = chiTietQuyenBUS.kiemTraHanhDong(this.MaNhomQuyen, maChucNang, "Thêm");
                chiTietQuyenGUI.danhSachChiTietQuyen.Columns["Xoa"].Visible = chiTietQuyenBUS.kiemTraHanhDong(this.MaNhomQuyen, maChucNang, "Xóa");
                chiTietQuyenGUI.danhSachChiTietQuyen.Columns["Sua"].Visible = chiTietQuyenBUS.kiemTraHanhDong(this.MaNhomQuyen, maChucNang, "Sửa");

                phanQuyenTab = new PhanQuyenTab(nhomQuyenGUI, chucNangGUI, chiTietQuyenGUI);
                OpenForm(phanQuyenTab);
            }
            else if (check.Text == "Bán Hàng")
            {
                banHangFrom = new BanHangFrom(this);
                banHangFrom.MaTaiKhoan = this.MaTaiKhoan;
                OpenForm(banHangFrom);
            }
            else if (check.Text == "Nhân Viên")
            {


                nhanVienGUI = new NhanVienGUI();
                taiKhoanGUI = new TaiKhoanGUI();

                // Kiểm tra hành động của nhóm quyền 
                int maChucNang = chucNangBUS.LayChucNangQuaTen(check.Text).MaChucNang;
                nhanVienGUI.btnShowDialog.Visible = chiTietQuyenBUS.kiemTraHanhDong(this.MaNhomQuyen, maChucNang, "Thêm");
                nhanVienGUI.danhSachNhanVien.Columns["Xoa"].Visible = chiTietQuyenBUS.kiemTraHanhDong(this.MaNhomQuyen, maChucNang, "Xóa");
                nhanVienGUI.danhSachNhanVien.Columns["Sua"].Visible = chiTietQuyenBUS.kiemTraHanhDong(this.MaNhomQuyen, maChucNang, "Sửa");

                taiKhoanGUI.btnShowDialog.Visible = chiTietQuyenBUS.kiemTraHanhDong(this.MaNhomQuyen, maChucNang, "Thêm");
                taiKhoanGUI.danhSachTaiKhoan.Columns["Xoa"].Visible = chiTietQuyenBUS.kiemTraHanhDong(this.MaNhomQuyen, maChucNang, "Xóa");
                taiKhoanGUI.danhSachTaiKhoan.Columns["Sua"].Visible = chiTietQuyenBUS.kiemTraHanhDong(this.MaNhomQuyen, maChucNang, "Sửa");

                nhanVienTab = new NhanVienTab(nhanVienGUI, taiKhoanGUI);
                OpenForm(nhanVienTab);
            }
            else if (check.Text == "Danh Mục Sản Phẩm")
            {
                theLoaiGUI = new TheLoaiGUI();
                thuongHieuGUI = new ThuongHieuGUI();
                chatLieuGUI = new ChatLieuGUI();
                mauSacGUI = new MauSacGUI();
                kichCoGUI = new KichCoGUI();

                // Kiểm tra hành động của nhóm quyền 
                int maChucNang = chucNangBUS.LayChucNangQuaTen(check.Text).MaChucNang;

                theLoaiGUI.btnShowDialog.Visible = chiTietQuyenBUS.kiemTraHanhDong(this.MaNhomQuyen, maChucNang, "Thêm");
                theLoaiGUI.danhSachTheLoai.Columns["Xoa"].Visible = chiTietQuyenBUS.kiemTraHanhDong(this.MaNhomQuyen, maChucNang, "Xóa");
                theLoaiGUI.danhSachTheLoai.Columns["Sua"].Visible = chiTietQuyenBUS.kiemTraHanhDong(this.MaNhomQuyen, maChucNang, "Sửa");

                thuongHieuGUI.btnShowDialog.Visible = chiTietQuyenBUS.kiemTraHanhDong(this.MaNhomQuyen, maChucNang, "Thêm");
                thuongHieuGUI.danhSachThuongHieu.Columns["Xoa"].Visible = chiTietQuyenBUS.kiemTraHanhDong(this.MaNhomQuyen, maChucNang, "Xóa");
                thuongHieuGUI.danhSachThuongHieu.Columns["Sua"].Visible = chiTietQuyenBUS.kiemTraHanhDong(this.MaNhomQuyen, maChucNang, "Sửa");

                chatLieuGUI.btnShowDialog.Visible = chiTietQuyenBUS.kiemTraHanhDong(this.MaNhomQuyen, maChucNang, "Thêm");
                chatLieuGUI.danhSachChatLieu.Columns["Xoa"].Visible = chiTietQuyenBUS.kiemTraHanhDong(this.MaNhomQuyen, maChucNang, "Xóa");
                chatLieuGUI.danhSachChatLieu.Columns["Sua"].Visible = chiTietQuyenBUS.kiemTraHanhDong(this.MaNhomQuyen, maChucNang, "Sửa");

                mauSacGUI.btnShowDialog.Visible = chiTietQuyenBUS.kiemTraHanhDong(this.MaNhomQuyen, maChucNang, "Thêm");
                mauSacGUI.danhSachMauSac.Columns["Xoa"].Visible = chiTietQuyenBUS.kiemTraHanhDong(this.MaNhomQuyen, maChucNang, "Xóa");
                mauSacGUI.danhSachMauSac.Columns["Sua"].Visible = chiTietQuyenBUS.kiemTraHanhDong(this.MaNhomQuyen, maChucNang, "Sửa");

                kichCoGUI.btnShowDialog.Visible = chiTietQuyenBUS.kiemTraHanhDong(this.MaNhomQuyen, maChucNang, "Thêm");
                kichCoGUI.danhSachKichCo.Columns["Xoa"].Visible = chiTietQuyenBUS.kiemTraHanhDong(this.MaNhomQuyen, maChucNang, "Xóa");
                kichCoGUI.danhSachKichCo.Columns["Sua"].Visible = chiTietQuyenBUS.kiemTraHanhDong(this.MaNhomQuyen, maChucNang, "Sửa");

                danhMucSanPhamTab = new DanhMucSanPhamTab(theLoaiGUI, thuongHieuGUI, chatLieuGUI, mauSacGUI, kichCoGUI);
                OpenForm(danhMucSanPhamTab);

            }
            else if (check.Text == "Sản Phẩm")
            {
                sanPhamGUI = new SanPhamGUI();
                chiTietSanPhamGUI = new ChiTietSanPhamGUI();
                int maChucNang = chucNangBUS.LayChucNangQuaTen(check.Text).MaChucNang;

                sanPhamGUI.btnShowDialog.Visible = chiTietQuyenBUS.kiemTraHanhDong(this.MaNhomQuyen, maChucNang, "Thêm");
                sanPhamGUI.danhSachSanPham.Columns["Sua"].Visible = chiTietQuyenBUS.kiemTraHanhDong(this.MaNhomQuyen, maChucNang, "Sửa");
                sanPhamGUI.danhSachSanPham.Columns["Xoa"].Visible = chiTietQuyenBUS.kiemTraHanhDong(this.MaNhomQuyen, maChucNang, "Xóa");


                sanPhamTab = new SanPhamTab(sanPhamGUI, chiTietSanPhamGUI);
                OpenForm(sanPhamTab);
            }
            else if (check.Text == "Khách Hàng")
            {
                KhachHangForm khachHangForm = new KhachHangForm();
                int maChucNang = chucNangBUS.LayChucNangQuaTen(check.Text).MaChucNang;
                khachHangForm.btnThem.Visible = chiTietQuyenBUS.kiemTraHanhDong(this.MaNhomQuyen, maChucNang, "Thêm");
                khachHangForm.dgvKhachHang.Columns["sua"].Visible = chiTietQuyenBUS.kiemTraHanhDong(this.MaNhomQuyen, maChucNang, "Sửa");
                khachHangForm.dgvKhachHang.Columns["xoa"].Visible = chiTietQuyenBUS.kiemTraHanhDong(this.MaNhomQuyen, maChucNang, "Xóa");
                OpenForm(khachHangForm);
            }
            else if (check.Text == "Thuế")
            {
                thueGUI = new ThueGUI();
                int maChucNang = chucNangBUS.LayChucNangQuaTen(check.Text).MaChucNang;
                thueGUI.btnShowDialog.Visible = chiTietQuyenBUS.kiemTraHanhDong(this.MaNhomQuyen, maChucNang, "Thêm");
                thueGUI.danhSachThue.Columns["Xoa"].Visible = chiTietQuyenBUS.kiemTraHanhDong(this.MaNhomQuyen, maChucNang, "Xóa");
                OpenForm(thueGUI);
            }
            else if (check.Text == "Khuyến Mãi")
            {
                khuyenMaiGUI = new KhuyenMaiGUI();
                int maChucNang = chucNangBUS.LayChucNangQuaTen(check.Text).MaChucNang;
                khuyenMaiGUI.btnShowDialog.Visible = chiTietQuyenBUS.kiemTraHanhDong(this.MaNhomQuyen, maChucNang, "Thêm");
                khuyenMaiGUI.danhSachKhuyenMai.Columns["Xoa"].Visible = chiTietQuyenBUS.kiemTraHanhDong(this.MaNhomQuyen, maChucNang, "Xóa");
                khuyenMaiGUI.danhSachKhuyenMai.Columns["Sua"].Visible = chiTietQuyenBUS.kiemTraHanhDong(this.MaNhomQuyen, maChucNang, "Sửa");
                OpenForm(khuyenMaiGUI);
            }
            else if (check.Text == "Hóa Đơn")
            {
                QuanLyHoaDonForm quanLyHoaDonForm = new QuanLyHoaDonForm();
                OpenForm(quanLyHoaDonForm);
            }
            else if (check.Text == "Nhà Cung Cấp")
            {
                nhaCungCapGUI = new NhaCungCapGUI();
                int maChucNang = chucNangBUS.LayChucNangQuaTen(check.Text).MaChucNang;
                nhaCungCapGUI.btnShowDialog.Visible = chiTietQuyenBUS.kiemTraHanhDong(this.MaNhomQuyen, maChucNang, "Thêm");
                nhaCungCapGUI.danhSachNhaCungCap.Columns["Xoa"].Visible = chiTietQuyenBUS.kiemTraHanhDong(this.MaNhomQuyen, maChucNang, "Xóa");
                nhaCungCapGUI.danhSachNhaCungCap.Columns["Sua"].Visible = chiTietQuyenBUS.kiemTraHanhDong(this.MaNhomQuyen, maChucNang, "Sửa");
                OpenForm(nhaCungCapGUI);
            }
            else if (check.Text == "Nhập Hàng")
            {
                phieuNhapGUI = new PhieuNhapGUI(MaTaiKhoan);
                chiTietPhieuNhapGUI = new ChiTietPhieuNhapGUI();
                NhapHangTab nhapHangTab = new NhapHangTab(phieuNhapGUI, chiTietPhieuNhapGUI);
                OpenForm(nhapHangTab);
            }
            else if (check.Text == "Thống Kê")
            {
                thongKeGUI = new ThongKeGUI();
                OpenForm(thongKeGUI);
            }

            else if (check.Text == "Đăng Xuất")
            {
                this.Dispose();
                LoginGUI loginGUI = new LoginGUI();
                loginGUI.ShowDialog();
            }

        }

        public void OpenForm(Form form)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            else
            {
                activeForm = form;
            }
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            containerPanel.Controls.Add(form);
            form.BringToFront();
            form.Show();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void containerPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sideBar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
