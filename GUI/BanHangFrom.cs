using DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using BUS;
using DTO;
using GUI;

namespace WindowsFormsApp3.GUI
{

    public partial class BanHangFrom : Form
    {
        ChiTietSanPhamBUS chiTietSanPhamBUS = new ChiTietSanPhamBUS();


        //
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
        #region khai báo biến
        public ArrayList listDonHang { get; set; }
        public ArrayList listSanPham { get; set; }
        public ArrayList listCTSP { get; set; }
        public ArrayList listCTHD { get; set; }
        public static String CongTru = "CongTru";
        public static String Them = "Them";
        ChatLieuBUS ChatLieuBUS = new ChatLieuBUS();
        ChiTietHoaDonBUS ChiTietHoaDonBUS = new ChiTietHoaDonBUS();
        ChiTietSanPhamBUS ChiTietSanPhamBUS = new ChiTietSanPhamBUS();
        HoaDonBUS HoaDonBUS = new HoaDonBUS();
        KhuyenMaiBUS KhuyenMaiBUS = new KhuyenMaiBUS();
        KichCoBUS KichCoBUS = new KichCoBUS();
        MauSacBUS MauSacBUS = new MauSacBUS();
        SanPhamBUS SanPhamBUS = new SanPhamBUS();
        TheLoaiBUS TheLoaiBUS = new TheLoaiBUS();
        ThueBUS ThueBUS = new ThueBUS();
        ThuongHieuBUS ThuongHieuBUS = new ThuongHieuBUS();
        public TrangChuGUI TrangChuGUI { get; set; }
        public int MaTaiKhoan { get; set; }


        public ArrayList listSanPhamDGV { get; set; }


        #endregion
        public BanHangFrom(TrangChuGUI TrangChuGUI)

        {

            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            this.TrangChuGUI = TrangChuGUI;
            loadAllList();
        }

        private void loadAllList()
        {
            this.listDonHang = new ArrayList();
            this.listSanPham = new ArrayList();
            this.listCTHD = new ArrayList();
            this.listCTSP = ChiTietSanPhamBUS.getAllListCTSP();
            this.listSanPham = SanPhamBUS.getAllList();
        }

        public void LoadDanhSachChiTietSanPham()
        {
            foreach (var item in ChiTietSanPhamBUS.getAllListCTSP())
            {

            }
        }

        private void BanHangFrom_Load(object sender, EventArgs e)
        {
            // this.dgvSanPham.DataSource = SanPhamBUS.getAllDataTable();
            this.listSanPhamDGV = new ArrayList();
            this.listSanPhamDGV = SanPhamBUS.timkiemDGV("");
            foreach (string item in this.listSanPhamDGV)
            {
                string[] arr = item.Split(',');

                this.dgvSanPham.Rows.Add(arr[0], arr[1], arr[2], arr[3], arr[4], arr[5], arr[6], arr[7]);
            }
        }

        private void dgvSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            String cln = this.dgvSanPham.Columns[e.ColumnIndex].Name;
            DataGridViewRow row = this.dgvSanPham.Rows[rowIndex];
            if (cln.Equals("them2"))
            {
                var ma = row.Cells["MaChiTietSanPham"].Value.ToString();
                SanPham sp = new SanPham();
                sp = (SanPham)SanPhamBUS.getFromCTSP(ma);
                //MessageBox.Show(e.RowIndex + "");
                GUI.SoLuongDonHangForm soLuongDonHangForm = new SoLuongDonHangForm(this, Convert.ToInt32(ma));
                soLuongDonHangForm.ShowDialog();
            }
        }

        internal void AddCTHD(SanPham sp, MauSac ms, KichCo kc, int soLuong, float thanhTien, String ctsp)
        {

            int soLuongTon = ChiTietSanPhamBUS.getSoLuongTon(ctsp);
            if (soLuong <= soLuongTon)
            {
                if (soLuong > 0)
                {

                    if (listDonHang.Contains(ctsp))
                    {
                        int i = 0;
                        int count = listDonHang.Count;
                        for (; i < count; i++)
                        {

                            int sldh = (int)this.dgvDonHang.Rows[i].Cells["soLuongDonHang"].Value;

                            if (this.listDonHang[i].ToString().Equals(ctsp) && (soLuongTon >= (soLuong + sldh)))
                            {
                                updateCTHD(soLuong, i, sp, BanHangFrom.Them);

                                break;
                            }
                            else if ((soLuongTon < (soLuong + sldh)))
                            {
                                MessageBox.Show("Số lượng ở cửa hàng không đủ!");
                                break;
                            }
                        }
                    }

                    if (!this.listDonHang.Contains(ctsp) && (soLuongTon >= soLuong))
                    {
                        String tmp = ctsp.ToString();
                        this.listDonHang.Add(tmp);
                        ChiTietHoaDon cthd = createCTHD(Convert.ToInt32(ctsp), sp, ms, kc, soLuong, thanhTien);
                        this.listCTHD.Add(cthd);
                        addToDGVOrder(ctsp, sp, ms, kc, soLuong, thanhTien);
                        MessageBox.Show("Bạn đã thêm sản phầm vào danh sách order!");

                    }
                    else if (soLuongTon < soLuong)
                    {
                        MessageBox.Show("Số lượng sản phẩm " + sp.TenSanPham + " chỉ còn " + soLuongTon + "!");
                    }

                }
                else
                    MessageBox.Show("Số lượng bàn nhập phải lơn hơn 0!");

            }
            else MessageBox.Show("Số lượng sản phẩm không hợp lệ");

        }
        private void addToDGVOrder(String ctsp, SanPham sanPham, MauSac ms, KichCo kc, int soluong, float thanhtien)
        {
            TheLoai tl = TheLoaiBUS.getFromsSP(sanPham.MaSanPham + "");
            ThuongHieu th = ThuongHieuBUS.getFromSP(sanPham.MaSanPham + "");
            ChatLieu cl = ChatLieuBUS.getFromSP(sanPham.MaSanPham + "");


            this.dgvDonHang.Rows.Add(ctsp, sanPham.TenSanPham, tl.TenTheLoai, cl.TenChatLieu, th.TenThuongHieu
                , ms.TenMauSac, kc.TenKichCo, soluong, thanhtien);
        }

        private void updateCTHD(int soLuong, int i, SanPham sanPham, String station)
        {
            int sl = Convert.ToInt32(this.dgvDonHang.Rows[i].Cells["soLuongDonHang"].Value.ToString());
            bool check = false;
            String ctsp = (String)this.listDonHang[i];
            int soLuongTon = ChiTietSanPhamBUS.getSoLuongTon(ctsp);
            if (station.Equals(BanHangFrom.Them))
            {
                if (soLuong > 0 && ((sl + soLuong) <= soLuongTon)) check = true;
                else
                    MessageBox.Show("Số lượng sản phẩm phải lớn hơn 0!");
            }
            else if (station.Equals(BanHangFrom.CongTru))
            {
                if ((soLuong == 1 && sl >= 1) || (soLuong == -1 && sl >= 2)) check = true;
                else
                    MessageBox.Show("Số lượng sản phẩm phải lớn hơn 1!");
            }

            if (check)
            {
                sl += soLuong;
                float sum = sl * sanPham.GiaSanPham;
                float thanhTien = sum;
                ChiTietHoaDon tmp = (ChiTietHoaDon)this.listCTHD[i];
                tmp.SoLuong = sl;
                tmp.ThanhTien = thanhTien;
                this.dgvDonHang.Rows[i].Cells["soLuongDonHang"].Value = sl;
                this.dgvDonHang.Rows[i].Cells["tongTienDonHang"].Value = tmp.ThanhTien;
                MessageBox.Show("Bạn đã thêm " + soLuong + " " + sanPham.TenSanPham + " vào thêm trong danh sách!"); ;
            }

        }
        private ChiTietHoaDon createCTHD(int maCTSP, SanPham sp, MauSac ms, KichCo kc, int soLuong, float thanhTien)
        {
            ChiTietHoaDon CTHD = new ChiTietHoaDon(maCTSP, sp.GiaSanPham, soLuong, thanhTien);
            return CTHD;
        }

        private void dgvDonHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String cln = this.dgvDonHang.Columns[e.ColumnIndex].Name;
            int index = this.dgvDonHang.SelectedCells[0].RowIndex;
            ChiTietHoaDon cthd = (ChiTietHoaDon)this.listCTHD[index];
            SanPham sp = SanPhamBUS.getFromCTSP(cthd.MaChiTietSanPham.ToString());
            int slt = ChiTietSanPhamBUS.getSoLuongTon(cthd.MaChiTietSanPham.ToString());
            if (cln == "Cong")
            {

                int sl = Convert.ToInt32(this.dgvDonHang.Rows[index].Cells["soLuongDonHang"].Value.ToString());
                if ((sl + 1) <= slt)
                {
                    updateCTHD(1, index, sp, BanHangFrom.CongTru);
                }
                else
                {
                    MessageBox.Show("Số lượng "
                        + sp.TenSanPham + " ở cửa hàng chỉ còn " + this.SoLuongTon + " cái!");
                }


            }
            else if (cln == "Tru")
            {

                updateCTHD(-1, index, sp, BanHangFrom.CongTru);


            }
            else if (cln == "Xoa")
            {
                this.dgvDonHang.Rows.RemoveAt(index);
                this.listCTHD.RemoveAt(index);
                this.listDonHang.RemoveAt(index);
                // MessageBox.Show(this.listCTHD.Count + " " + this.listCTSP.Count);

            }
        }

        private void dgvSanPham_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex == -1) return;

            String cln = this.dgvSanPham.Columns[e.ColumnIndex].Name;
            DataGridViewRow row = this.dgvSanPham.Rows[rowIndex];
            if (cln.Equals("them2"))
            {
                var ma = row.Cells["MaChiTietSanPham"].Value.ToString();
                SanPham sp = new SanPham();
                sp = (SanPham)SanPhamBUS.getFromCTSP(ma);
                //MessageBox.Show(e.RowIndex + "");
                ChiTietSanPham chiTietSanPham = chiTietSanPhamBUS.LaySanPhamChiTietQuaMa(Convert.ToInt32(ma));
                GUI.SoLuongDonHangForm soLuongDonHangForm = new SoLuongDonHangForm(this, Convert.ToInt32(ma));
                soLuongDonHangForm.ShowDialog();
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (this.dgvDonHang.Rows.Count > 0)
            {
                HoaDonForm hd = new HoaDonForm(this);
                hd.ShowDialog();
            }
            else
            {
                MessageBox.Show("Số Lượng Đơn Hàng trong Danh Sách Order chưa có!");
            }

        }

        internal void resetALL()
        {
            this.listCTHD.Clear();
            this.listDonHang.Clear();
            this.dgvDonHang.Rows.Clear();
            this.dgvSanPham.DataSource = SanPhamBUS.getAllDataTable();

        }

        private void btnDSHD_Click(object sender, EventArgs e)
        {
            QuanLyHoaDonForm qlhd = new QuanLyHoaDonForm();
            qlhd.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.dgvSanPham.Rows.Clear();
            String find = this.txtFind.Text.Trim();
            this.listSanPhamDGV = new ArrayList();
            this.listSanPhamDGV = SanPhamBUS.timkiemDGV(find);
            foreach (string item in this.listSanPhamDGV)
            {
                string[] arr = item.Split(',');

                this.dgvSanPham.Rows.Add(arr[0], arr[1], arr[2], arr[3], arr[4], arr[5], arr[6], arr[7]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.txtFind.Text = "";
        }
    }



}
