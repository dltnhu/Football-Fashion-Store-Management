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
    public partial class NhaCungCapGUI : Form
    {
        NhaCungCapBUS nhaCungCapBUS = new NhaCungCapBUS();
        public NhaCungCapGUI()
        {
            InitializeComponent();
            LoadDataNhaCungCap();
        }


        public void LoadDataNhaCungCap()
        {
            danhSachNhaCungCap.RowCount = 0;
            foreach (var item in nhaCungCapBUS.LayDanhSachNhaCungCap())
            {
                danhSachNhaCungCap.Rows.Add(item.MaNhaCungCap, item.TenNhaCungCap, item.DiaChi, item.SoDienThoai);
            }
        }

        public void LoadDataNhaCungCap(string text)
        {
            danhSachNhaCungCap.RowCount = 0;
            foreach (var item in nhaCungCapBUS.TimKiemNhaCungCap(text))
            {
                danhSachNhaCungCap.Rows.Add(item.MaNhaCungCap, item.TenNhaCungCap, item.DiaChi, item.SoDienThoai);
            }
        }

        // hàm hiển thị dialog chi tiết
        public void ShowDialogChiTiet(NhaCungCapModule module)
        {
            module.btnThem.Visible = false;
            module.btnSua.Visible = false;
            module.btnThoat.Size = new Size(320, 51);
        }

        // hàm hiển thị dialog thêm
        public void ShowDialogThem(NhaCungCapModule module)
        {
            module.btnThem.Visible = true;
            module.btnSua.Visible = false;

        }
        // hàm hiển thị dialog sửa
        public void ShowDialogSua(NhaCungCapModule module)
        {
            module.btnThem.Visible = false;
            module.btnSua.Visible = true;

        }


        private void btnShowDialog_Click(object sender, EventArgs e)
        {
            NhaCungCapModule nhaCungCapModule = new NhaCungCapModule();
            ShowDialogThem(nhaCungCapModule);
            nhaCungCapModule.ShowDialog();
            LoadDataNhaCungCap();
        }

        private void danhSachNhaCungCap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            DataGridViewRow row = danhSachNhaCungCap.Rows[e.RowIndex];

            int maNhaCungCap = Convert.ToInt32(row.Cells[0].Value.ToString());
            NhaCungCap nhaCungCap = nhaCungCapBUS.LayNhaCungCapQuaMa(maNhaCungCap);


            string selectedColumnName = danhSachNhaCungCap.Columns[e.ColumnIndex].Name;
            if (selectedColumnName == "Xoa")
            {
                DialogResult result = MessageBox.Show("Bạn có muốn tiếp tục xóa ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (nhaCungCapBUS.XoaNhaCungCap(maNhaCungCap))
                    {
                        MessageBox.Show("Bạn đã xóa thành công");
                        LoadDataNhaCungCap();
                    }
                    else
                    {
                        MessageBox.Show("Thất bại");
                    }
                }
            }
            else if (selectedColumnName == "Sua")
            {
                NhaCungCapModule nhaCungCapModule = new NhaCungCapModule(maNhaCungCap);
                nhaCungCapModule.txtNhaCungCap.Text = nhaCungCap.TenNhaCungCap;
                nhaCungCapModule.txtDiaChi.Text = nhaCungCap.DiaChi;
                nhaCungCapModule.txtSoDienThoai.Text = nhaCungCap.SoDienThoai;
                ShowDialogSua(nhaCungCapModule);
                nhaCungCapModule.ShowDialog();
                LoadDataNhaCungCap();

            }
            else if (selectedColumnName == "ChiTiet")
            {
                NhaCungCapModule nhaCungCapModule = new NhaCungCapModule(maNhaCungCap);
                nhaCungCapModule.txtNhaCungCap.Text = nhaCungCap.TenNhaCungCap;
                nhaCungCapModule.txtDiaChi.Text = nhaCungCap.DiaChi;
                nhaCungCapModule.txtSoDienThoai.Text = nhaCungCap.SoDienThoai;
                ShowDialogChiTiet(nhaCungCapModule);
                nhaCungCapModule.ShowDialog();
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTimKiem.Text))
            {
                LoadDataNhaCungCap();
            }
            else
            {
                LoadDataNhaCungCap(txtTimKiem.Text);
            }
        }
    }
}
