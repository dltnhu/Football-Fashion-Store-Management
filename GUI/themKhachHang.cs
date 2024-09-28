using BUS;
using DTO;
using Microsoft.VisualBasic;
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

namespace WindowsFormsApp3.GUI
{
    public partial class themKhachHang : Form
    { //
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
        //

        public KhachHang khachHang { get; set; }
        public KhachHangBUS khachHangBUS = new KhachHangBUS();
        public KhachHangForm khachHangForm;
        public int index;
        public String state;

        public themKhachHang(KhachHangForm khachHangForm, KhachHang kh, int i, String state)
        {
            InitializeComponent();
            khachHang = kh;
            this.khachHangForm = khachHangForm;
            this.index = i;
            this.state = state;
            if (this.state.Equals("sua"))
            {
                LoadDataSua();

                this.text.Text = "SỬA THÔNG TIN KHÁCH HÀNG";
                this.btnSua.Visible = true;
                this.btnThem.Visible = false;


            }
            else if (this.state.Equals("them"))
            {
                this.text.Text = "THÊM THÔNG TIN KHÁCH HÀNG";
                this.btnSua.Visible = false;
                this.btnThem.Visible = true;
            }

        }


        private void LoadDataSua()
        {
            this.txtTen.Text = khachHang.TenKhachHang;
            this.txtSoDienThoai.Text = khachHang.SoDienThoai;
        }

        private void themKhachHang_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            String SoDienThoai = this.txtSoDienThoai.Text;
            String ten = this.txtTen.Text;
            this.khachHang.TenKhachHang = ten;

            if (check.IsPhoneNumberValid(SoDienThoai))
            {
                if (!khachHangBUS.hasInDB(SoDienThoai))
                {

                    String ThongBao = this.khachHangBUS.suaFromSoDienThoai(this.khachHang, ten, SoDienThoai);
                    this.khachHangForm.SuaDGV(ten, SoDienThoai, index);
                    MessageBox.Show(ThongBao);
                    Dispose();

                }
                else MessageBox.Show("Số điện thoại đã được đăng ký");


            }
            else
            {
                MessageBox.Show("Số điện thoại không đúng cú pháp!");
            }
        }
        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            this.khachHang = new KhachHang();
            String SoDienThoai = this.txtSoDienThoai.Text;
            String ten = this.txtTen.Text;
            this.khachHang.TenKhachHang = ten;
            if (string.IsNullOrEmpty(SoDienThoai) && string.IsNullOrEmpty(ten))
            {
                MessageBox.Show("Các trường không được để trống!");
            }
            else
            {
                if (check.IsPhoneNumberValid(SoDienThoai))
                {
                    if (!khachHangBUS.hasInDB(SoDienThoai))
                    {

                        this.khachHang.SoDienThoai = SoDienThoai;
                        String ThongBao = this.khachHangBUS.ThemThongTinKhachHang(this.khachHang);
                        this.khachHang = this.khachHangBUS.getFromSoDienThoai(this.khachHang.SoDienThoai);
                        this.khachHangForm.ThemDGV(this.khachHang);
                        MessageBox.Show(ThongBao);
                        Dispose();

                    }
                    else MessageBox.Show("Số điện thoại đã được đăng ký");


                }
                else
                {
                    MessageBox.Show("Số điện thoại không đúng cú pháp!");
                }
            }



        }
    }
}
