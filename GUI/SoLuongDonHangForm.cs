using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace WindowsFormsApp3.GUI
{


    public partial class SoLuongDonHangForm : Form
    {

        #region
        public BanHangFrom BanHangFrom { get; set; }
        public int mactsp { get; set; }
        public SanPham sp { get; set; }
        public MauSac ms { get; set; }
        public KichCo kc { get; set; }
        public int SoLuong { get; set; }
        public float ThanhTien { get; set; }
        public int ctsp { get; set; }


        ChatLieuBUS ChatLieuBUS = new ChatLieuBUS();
        ChiTietHoaDonBUS ChiTietHoaDonBUS = new ChiTietHoaDonBUS();
        ChiTietSanPhamBUS ChiTietSanPhamBUS = new ChiTietSanPhamBUS();
        HoaDonBUS HoaDonBUS = new HoaDonBUS();
        KhuyenMaiBUS KhuyenMaiBUS = new KhuyenMaiBUS();
        KichCoBUS KichCoBUS = new KichCoBUS();
        MauSacBUS MauSacBUS = new MauSacBUS();
        SanPhamBUS SanPhamBUS = new SanPhamBUS();
        TheLoaiBUS TheLoaiBUS = new TheLoaiBUS();
        ChiTietSanPham chiTietSanPham = null;
        ThueBUS ThueBUS = new ThueBUS();
        ThuongHieuBUS ThuongHieuBUS = new ThuongHieuBUS();
        ChiTietSanPhamBUS chiTietSanPhamBUS = new ChiTietSanPhamBUS();

        #endregion
        public SoLuongDonHangForm(BanHangFrom banHangFrom, int mactsp)
        {
            InitializeComponent();
            BanHangFrom = banHangFrom;
            this.mactsp = mactsp;
            /*MessageBox.Show(this.mactsp+ " sau");
            MessageBox.Show(this.BanHangFrom.listCTSP.Count+"");*/
        }

        private void SoLuongDonHangForm_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            /*            String ctsp = this.BanHangFrom.listCTSP[mactsp].ToString();
            */            //MessageBox.Show(ctsp + "");
            this.chiTietSanPham = chiTietSanPhamBUS.LaySanPhamChiTietQuaMa(Convert.ToInt32(mactsp));
            sp = SanPhamBUS.getFromCTSP(mactsp + "");
            ms = MauSacBUS.getFromCTSP(mactsp + "");
            kc = KichCoBUS.getFromCTSP(mactsp + "");

            // load dữ liệu lên lb
            KichCoBUS kichCoBUS = new KichCoBUS();
            MauSacBUS mauSacBUS = new MauSacBUS();
            SanPhamBUS sanPhamBUS = new SanPhamBUS();
            this.lbKichCo.Text = kichCoBUS.LayKichCoQuaMa(chiTietSanPham.MaKichCo).TenKichCo;
            this.lbMauSac.Text = mauSacBUS.LayMauSacQuaMa(chiTietSanPham.MaMauSac).TenMauSac;
            this.lbTen.Text = sanPhamBUS.LaySanPhamQuaMa(chiTietSanPham.MaSanPham).TenSanPham;
            this.txtGia.Text = sp.GiaSanPham+"";
            /*            this.ctsp = (int)this.BanHangFrom.listCTSP[mactsp];
            */
            /*  Image image = Image.FromFile(ChiTiet.HinhAnh);

              this.pictureBox1.Image = image;*/


            byte[] img = (byte[])(chiTietSanPham.HinhAnh);
            MemoryStream ms1 = new MemoryStream(img);
            this.pictureBox1.Image = Image.FromStream(ms1);
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            if (check.IsInt(this.txtSoLuong.Text))
            {

                SoLuong = Convert.ToInt32(this.txtSoLuong.Text);
                if (SoLuong < 0)
                {
                    this.txtSoLuong.Text = "";
                    MessageBox.Show("Số lượng bạn cần nhập phải là 1 số nguyên dương!");

                }
                else
                {

                    float sum = SanPhamBUS.LaySanPhamQuaMa(this.chiTietSanPham.MaSanPham).GiaSanPham;
                    /*this.txtTongTien.Text = String.Format("{0:00,0.00}", sum) + " VNĐ";*/
                }
            }
            else if (!this.txtSoLuong.Text.Equals(""))
            {
                this.txtSoLuong.Text = "";
                MessageBox.Show("Số lượng bạn cần nhập phải là 1 số nguyên dương!");
            }
        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {

        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTiepTuc_Click_1(object sender, EventArgs e)
        {
            if (!this.txtSoLuong.Text.Equals(""))
            {

                //MessageBox.Show(ms.MaMau + " " + kc.MaKichCo);
                this.SoLuong = Convert.ToInt32(this.txtSoLuong.Text.Trim());
                this.ThanhTien = SoLuong * SanPhamBUS.LaySanPhamQuaMa(chiTietSanPham.MaSanPham).GiaSanPham;

                this.BanHangFrom.AddCTHD(this.sp, ms, kc, this.SoLuong, this.ThanhTien, this.mactsp + "");
                this.Dispose();



            }
            else
            {
                /*MauSac ms = (MauSac)this.listMauSac[cbMauSac.Selectedmactsp];
                kichco kc = (kichco)this.listKichCo[cbKichCo.Selectedmactsp];
                this.soLuong = Convert.ToInt32(this.txtSoLuong.Text.Trim());
                this.thanhTien = Convert.ToInt32(this.txtSoLuong.Text.Trim()) * this.sanPham.GiaSanPham;
                this.banHang.AddCTHD(this.sanPham, ms, kc, this.soLuong, this.thanhTien);
                this.Dispose();
                MessageBox.Show("Bạn đã thêm sản phẩm vào hóa đơn!");*/

                MessageBox.Show("các trường thông tin không được để trống");
            }
        }

        private void btnHuyBo_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
