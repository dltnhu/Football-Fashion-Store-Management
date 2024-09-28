using BUS;
using DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using DTO;
using GUI;
using WindowsFormsApp3.GUI;

namespace WindowsFormsApp3.GUI
{
    public partial class HoaDonForm : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        public BanHangFrom banHang { get; set; }
        public int SoLuongSanPham { get; set; }
        public float TongTienDonHang { get; set; }
        public float MucKhuyenMai { get; set; }
        public float MucThue { get; set; }
        public float TongThanhTien { get; set; }
        public float ThoiLai { get; set; }
        public float KhachDua { get; set; }
        public int MaNhanVien { get; set; }
        public int MaKhachHang { get; set; }
        public String SoDienThoai { get; set; }
        public int MaHoaDon { get; set; }
        public Thue Thue { get; set; }
        public float TongTMP { get; set; }
        public KhachHang KhachHang;
        public KhuyenMai KhuyenMai { get; set; }
        public ArrayList listThue { get; set; }
        public ArrayList listKhuyenMai { get; set; }
        public ArrayList listKhachHang { get; set; }
        public ArrayList listHoaDon { get; set; }
        public HoaDon hd { get; set; }
        ChatLieuBUS ChatLieuBUS = new ChatLieuBUS();
        ChiTietHoaDonBUS ChiTietHoaDonBUS = new ChiTietHoaDonBUS();
        ChiTietSanPhamBUS ChiTietSanPhamBUS = new ChiTietSanPhamBUS();
        HoaDonBUS HoaDonBUS = new HoaDonBUS();
        KhuyenMaiBUS KhuyenMaiBUS = new KhuyenMaiBUS();
        KichCoBUS KichCoBUS = new KichCoBUS();
        BUS.MauSacBUS MauSacBUS = new MauSacBUS();
        SanPhamBUS SanPhamBUS = new SanPhamBUS();
        TheLoaiBUS TheLoaiBUS = new TheLoaiBUS();
        ThueBUS ThueBUS = new ThueBUS();
        ThuongHieuBUS ThuongHieuBUS = new ThuongHieuBUS();
        KhachHangBUS KhachHangBUS = new KhachHangBUS();

        public HoaDonForm(BanHangFrom banHang)
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            this.banHang = banHang;
            this.TongTienDonHang = 0;
            this.TongThanhTien = 0;
            this.ThoiLai = -1;
            TongTMP = 0;
            this.listThue = new ArrayList();
            this.listKhuyenMai = new ArrayList();
            this.listHoaDon = new ArrayList();
            this.listHoaDon = HoaDonBUS.getAllList();
            this.listKhachHang = KhachHangBUS.GetAllList();
            this.txtMaNhanVien.Text = this.banHang.TrangChuGUI.MaTaiKhoan.ToString();

        }

        private void init()
        {

        }

        private void loadCombobox()
        {
            //Thuế

            this.listThue = ThueBUS.getAllList();
            foreach (Thue x in this.listThue)
            {
                this.cbThue.Items.Add(x.TenThue);
            }
            //Khuyến Mãi
            this.listKhuyenMai = KhuyenMaiBUS.getAllList();
            foreach (KhuyenMai x in this.listKhuyenMai)
            {
                this.cbKhuyenMai.Items.Add(x.DieuKien);
            }

        }


        private void loadData()
        {
            this.SoLuongSanPham = this.banHang.listCTHD.Count;
            for (int i = 0; i < this.SoLuongSanPham; i++)
            {
                ChiTietHoaDon cthd = (ChiTietHoaDon)this.banHang.listCTHD[i];
                SanPham sp = SanPhamBUS.getFromCTSP(cthd.MaChiTietSanPham + "");
                TheLoai tl = TheLoaiBUS.getFromsSP(sp.MaSanPham + "");
                ThuongHieu th = ThuongHieuBUS.getFromSP(sp.MaSanPham + "");
                ChatLieu cl = ChatLieuBUS.getFromSP(sp.MaSanPham + "");
                MauSac ms = MauSacBUS.getFromCTSP(cthd.MaChiTietSanPham + "");
                KichCo kc = KichCoBUS.getFromCTSP(cthd.MaChiTietSanPham + "");
                this.dgvDonHang.Rows.Add(cthd.MaChiTietSanPham, sp.TenSanPham, th.TenThuongHieu, cl.TenChatLieu, tl.TenTheLoai
                , ms.TenMauSac, kc.TenKichCo, cthd.SoLuong, cthd.ThanhTien);
                this.TongTienDonHang += cthd.ThanhTien;
                this.TongTMP += cthd.ThanhTien;
                this.TongThanhTien += cthd.ThanhTien;
            }
            this.txtTongTien.Text = this.TongTienDonHang + " VNĐ";
            this.txtTongThanhTien.Text = this.TongTienDonHang + " VNĐ";

        }

        private void HoaDonForm_Load(object sender, EventArgs e)
        {
            loadData();
            loadCombobox();
        }

        private void cbKhuyenMai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.txtKhachDua.Text != "")
            {
                this.txtKhachDua.Text = "";
            }
            int index = this.cbKhuyenMai.SelectedIndex;
            KhuyenMai = (KhuyenMai)this.listKhuyenMai[index];
            this.MucKhuyenMai = this.TongTienDonHang * KhuyenMai.MucKhuyenMai / 100;
            this.txtKhuyenMai.Text = this.MucKhuyenMai + " VNĐ";
            if (this.cbThue.SelectedIndex != -1)
            {
                this.TongTMP -= this.MucKhuyenMai;
                this.txtTongThanhTien.Text = String.Format("{0:0.0,0}", this.TongTMP) + "VNĐ";

            }
            else
            {
                this.TongTMP = this.TongTienDonHang - this.MucKhuyenMai;
                this.txtTongThanhTien.Text = String.Format("{0:0.0,0}", this.TongTMP) + "VNĐ";
            }
            if (this.txtKhachDua.Text != "")
            {
                MessageBox.Show("Mời bạn nhập lại số tiền mà Khách Đưa");
                this.txtKhachDua.Text = "";
                this.lbThoiLai.Text = "0.00 VNĐ";
            }
        }

        private void cbThue_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(this.listThue.Count + "");
            int index = this.cbThue.SelectedIndex;
            MessageBox.Show(index + "");
            if (index != -1)
            {
                this.Thue = (Thue)this.listThue[index];

                this.MucThue = (this.TongTienDonHang * this.Thue.MucThue) / 100;
                this.txtThue.Text = this.MucThue + " VNĐ";
                if (this.cbKhuyenMai.SelectedIndex != -1)
                {
                    this.TongTMP += this.MucThue;
                    this.txtTongThanhTien.Text = String.Format("{0:0.0,0}", this.TongTMP) + " VNĐ";
                }
                else
                {
                    this.TongTMP = this.TongTienDonHang + this.MucThue;
                    this.txtTongThanhTien.Text = String.Format("{0:0.0,0}", this.TongTMP) + "VNĐ";
                }
                if (this.txtKhachDua.Text != "")
                {
                    MessageBox.Show("Mời bạn nhập lại số tiền mà Khách Đưa");
                    this.txtKhachDua.Text = "";
                    this.lbThoiLai.Text = "0.0 VNĐ";
                }
            }


        }

        private void txtKhachDua_TextChanged(object sender, EventArgs e)
        {
            if (this.txtKhachDua.Text.Length > 0 && check.IsNumeric(this.txtKhachDua.Text))
            {
                KhachDua = Convert.ToSingle(this.txtKhachDua.Text.ToString());
                if (KhachDua >= this.TongTMP)
                {
                    ThoiLai = KhachDua - this.TongTMP;
                    this.lbThoiLai.Text = String.Format("{0:0,0.0}", ThoiLai) + " VNĐ";
                }
                else
                {
                    this.lbThoiLai.Text = "0.0 VNĐ";
                }

            }
            else
            {
                MessageBox.Show("Số Tiền Khách Đưa phải là 1 số lớn hơn 0!");
                this.txtKhachDua.Text = "";
            }
        }
        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            bool checksdt = false;

            foreach (KhachHang kh in listKhachHang)
            {
                if (kh.SoDienThoai.Equals(this.txtSoDienThoai.Text.Trim()))
                {
                    checksdt = true;
                    break;
                }
            }
            if (checksdt == true)
            {
                if (txtKhachDua.Text == "")
                {
                    MessageBox.Show("Bạn chưa Nhập số tiền khách đưa!");
                }
                else if (this.KhachDua < this.TongTMP) MessageBox.Show("Số tiền khách đưa không đủ!");
                else
                {
                    DialogResult resultMaKhach = DialogResult.Yes;
                    if (this.txtSoDienThoai.Text == "")
                    {
                        resultMaKhach = MessageBox.Show("Bạn chưa nhập Mã Khách Hàng, Bạn có muốn tiếp tục!", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    }
                    if (resultMaKhach == DialogResult.Yes)
                    {
                        DialogResult result = MessageBox.Show("Bạn có chắc là muốn In hóa đơn hong!", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            if (this.ThoiLai >= 0)
                            {
                                hd = createHoaDon();
                                bool check = HoaDonBUS.insert(hd);

                                if (check)
                                {

                                    foreach (ChiTietHoaDon cthd in this.banHang.listCTHD)
                                    {
                                        ChiTietHoaDonBUS.insert(cthd, hd.MaHoaDon);
                                        ChiTietSanPhamBUS.updateSoLuong(cthd.SoLuong, cthd.MaChiTietSanPham + "");
                                        SanPham tmp = SanPhamBUS.getFromCTSP(cthd.MaChiTietSanPham + "");
                                        SanPhamBUS.updateSoLuong(cthd.SoLuong, tmp.MaSanPham + "");
                                    }
                                    export();
                                    MessageBox.Show("Thanh toán thành công!");
                                    this.banHang.resetALL();
                                    Dispose();

                                }
                                else
                                {
                                    MessageBox.Show("Thanh toán thất bại!");
                                }

                            }
                            else
                            {
                                MessageBox.Show("Số Tiền Khách Đưa Không Đủ!");
                            }


                        }
                    }

                }
            }
            else
            {
                MessageBox.Show("Khách Hàng chưa có Số Điện Thoại Tích điểm, Mời Bạn Tạo Tài Khoản Cho Khách Hàng!");

            }




        }

        private void export()
        {

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument1;
            DialogResult result = printDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private HoaDon createHoaDon()
        {

            if (this.cbKhuyenMai.SelectedIndex == -1)
            {
                KhuyenMai = new KhuyenMai();
                KhuyenMai.MaKhuyenMai = 1;

            }
            if (this.cbThue.SelectedIndex == -1)
            {
                Thue = new Thue();
                Thue.MaThue = 1;
            }
            HoaDon hd = new HoaDon();
            if (this.txtSoDienThoai.Text == "") hd.MaKhachHang = 1;
            else
            {
                KhachHang = KhachHangBUS.getFromSoDienThoai(this.txtSoDienThoai.Text.Trim());
            }//////;
            this.MaNhanVien = Convert.ToInt32(this.txtMaNhanVien.Text);
            this.TongThanhTien = this.TongTMP;
            hd.MaHoaDon = updateMaHoaDon();
            hd.MaKhachHang = KhachHang.MaKhachHang;
            hd.MaNhanVien = this.MaNhanVien;
            hd.MaThue = this.Thue.MaThue;
            hd.MaKhuyenMai = this.KhuyenMai.MaKhuyenMai;
            hd.TenHoaDon = "HOADON" + MaHoaDon;
            hd.NgayLapHoaDon = DateTime.Now;
            hd.TongTien = this.TongTienDonHang;
            hd.TongTienKhuyenMai = this.MucKhuyenMai;
            hd.TongTienThue = this.MucThue;
            hd.HinhThucThanhToan = "Tại Quầy";
            hd.ThanhTien = TongThanhTien;
            //MessageBox.Show(Thue.MaThue + "");
            return hd;
        }



        private int updateMaHoaDon()
        {
            if (this.listHoaDon.Count != 0)
            {
                HoaDon tmp = (HoaDon)this.listHoaDon[listHoaDon.Count - 1];
                MaHoaDon = tmp.MaHoaDon + 1;
                return MaHoaDon;
            }
            return 1;

        }

        private void btn_cancle_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void txtTongThanhTien_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaKhachHang_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            /*  e.Graphics.DrawString("Mã Hóa Đơn:       " + hd.TenHoaDon, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(50, 50));
              e.Graphics.DrawString("Mã Nhân Viên:       " + hd.MaNhanVien, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(50, 75));
              e.Graphics.DrawString("Mã Khách Hàng:       " + hd.MaKhachHang, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(50, 100));
              e.Graphics.DrawString("Ngày:       " + DateTime.Now, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(50, 130));
              e.Graphics.DrawString("Tên Sản Phẩm                                                                               Số Lượng              Giá                  Thành Tiền", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(50, 165));
              e.Graphics.DrawString("_______________________________________________________________________________", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(1, 170));
              int local_x = 180;
              foreach (ChiTietHoaDon cthd in this.banHang.listCTHD)
              {
                  local_x += 20;
                  SanPham sp = new SanPham();
                  sp = SanPhamBUS.getFromCTSP(cthd.MaChiTietSanPham + "");
                  e.Graphics.DrawString(sp.TenSanPham + "                                                                               " + cthd.SoLuong + "              +" + cthd.GiaSanPham + " VNĐ                " + cthd.ThanhTien + " VNĐ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(50, local_x));
              }
              local_x += 10;
              e.Graphics.DrawString("_______________________________________________________________________________", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(1, local_x));
              local_x += 30;
              e.Graphics.DrawString("Tổng tiền sản phẩm:      " + this.TongTienDonHang + " VNĐ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(1, local_x));
              local_x += 25;
              e.Graphics.DrawString("Khuyến Mãi:      " + this.MucKhuyenMai + " VNĐ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(1, local_x));
              local_x += 25;
              e.Graphics.DrawString("Thuế:      " + this.MucThue + " VNĐ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(1, local_x));
              local_x += 25;
              e.Graphics.DrawString("Tổng Thành Tiền:      " + this.TongThanhTien + " VNĐ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(1, local_x));
              local_x += 25;
              e.Graphics.DrawString("Tổng Khách Đưa:      " + this.KhachDua + " VNĐ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(1, local_x));
              local_x += 25;
              e.Graphics.DrawString("Thối lại:      " + this.ThoiLai + " VNĐ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(1, local_x));
              local_x += 25;
              e.Graphics.DrawString("_______________________________________________________________________________", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(1, local_x));
              local_x += 25;
              e.Graphics.DrawString("|                                                    Xin Cảm Ơn Quý Khách đã Mua Hàng!                                                 |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(1, local_x));
              local_x += 25;
              e.Graphics.DrawString("|_____________________________________________________________________________|", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(1, local_x));
  */
            e.Graphics.DrawString("HÓA ĐƠN", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(350, 20));
            e.Graphics.DrawString("Mã Hóa Đơn: " + this.hd.MaHoaDon, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(20, 60));
            e.Graphics.DrawString("Tên Hóa Đơn: " + this.hd.TenHoaDon, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(20, 85));
            e.Graphics.DrawString("Mã Nhân Viên: " + txtMaNhanVien.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(20, 105));
            e.Graphics.DrawString("Ngày Lập: " + DateTime.Now + "", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(360, 60));
            e.Graphics.DrawString("Khách Hàng: " + txtTenKhachHang.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(360, 85));
            e.Graphics.DrawString("Số điện thoại: " + txtSoDienThoai.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(360, 105));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------------------------------------------",
                new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(20, 175));
            e.Graphics.DrawString("STT", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(20, 190));
            e.Graphics.DrawString("Tên Sản Phẩm", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(90, 190));
            e.Graphics.DrawString("Màu Sắc", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(340, 190));
            e.Graphics.DrawString("Kích Cỡ", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(450, 190));
            e.Graphics.DrawString("Số Lượng ", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(600, 190));
            e.Graphics.DrawString("Tổng tiền", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(700, 190));

            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------------------------------------------",
                new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(20, 200));
            int point = 220;
            for (int i = 0; i < this.dgvDonHang.Rows.Count; i++)
            {
                e.Graphics.DrawString((i + 1) + "", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(20, point));
                e.Graphics.DrawString(dgvDonHang.Rows[i].Cells[1].Value.ToString(), new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(90, point));
                e.Graphics.DrawString(dgvDonHang.Rows[i].Cells[5].Value.ToString(), new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(340, point));
                e.Graphics.DrawString(dgvDonHang.Rows[i].Cells[6].Value.ToString(), new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(450, point));
                e.Graphics.DrawString(dgvDonHang.Rows[i].Cells[7].Value.ToString(), new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(600, point));
                e.Graphics.DrawString(dgvDonHang.Rows[i].Cells[8].Value.ToString(), new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(700, point));
                point += 25;
            }
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------------------------------------------",
                new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(20, point));
            e.Graphics.DrawString("Tổng tiền đơn hàng: " + this.txtTongTien.Text + "VND",
                new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(600, point += 25));
            e.Graphics.DrawString("Tiền Thuế: " + this.txtThue.Text + "VND",
                new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(600, point += 25));
            e.Graphics.DrawString("Tiền Khuyến Mãi: " + txtKhuyenMai.Text + "VND",
               new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(600, point += 25));
            e.Graphics.DrawString("Thành Tiền: " + txtTongThanhTien.Text + "VND",
               new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(600, point += 25));

        }

        private void txtMaKhachHang_TextChanged(object sender, EventArgs e)
        {
            String sdt = this.txtSoDienThoai.Text.ToString().Trim();
            if (check.IsPhoneNumberValid(sdt))
            {
                if (KhachHangBUS.hasInDB(sdt))
                {
                    KhachHang kh = KhachHangBUS.getFromSoDienThoai(sdt);
                    this.txtTenKhachHang.Text = kh.TenKhachHang.ToString();
                }
                else
                {
                    MessageBox.Show("Số điện thoại chưa được đăng ký");
                }
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnThemKhachHang_Click(object sender, EventArgs e)
        {
            String SoDienThoai = this.txtDangKySoDienThoai.Text.Trim();
            String ten = this.txtDangKyTen.Text.Trim();
            MessageBox.Show(SoDienThoai);
            bool checkEmpty = false;
            if (String.IsNullOrEmpty(SoDienThoai) || string.IsNullOrEmpty(ten))
            {
                MessageBox.Show("các trường thông tin không được để trống!");
            }
            else if (!check.IsPhoneNumberValid(SoDienThoai))
            {
                MessageBox.Show("Số điện thoại không đúng định dạng!");
            }
            else
            {

                if (!KhachHangBUS.hasInDB(SoDienThoai))
                {

                    KhachHang kh = new KhachHang();
                    kh.SoDienThoai = SoDienThoai;
                    kh.TenKhachHang = ten;
                    KhachHangBUS.ThemThongTinKhachHang(kh);
                    this.listKhachHang.Add(kh);
                    MessageBox.Show("Bạn đã thêm 1 khách hàng mới");
                }
                else MessageBox.Show("Số điện thoại đã được đăng ký");
            }

        }

        private void txtSoDienThoai_TabStopChanged(object sender, EventArgs e)
        {
            /* if(this.txtSoDienThoai.Text.Trim().Length != 10)
             {
                 MessageBox.Show("Số điện thoại bạn nhập không đủ!");
             }    */
        }

        private void txtMaNhanVien_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_cancle_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtThue_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
