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
    public partial class ChatLieuGUI : Form
    {
        ChatLieuBUS chatLieuBUS = new ChatLieuBUS();

        public ChatLieuGUI()
        {
            InitializeComponent();
            LoadDataChatLieu();
        }

        // load dữ liệu chất liệu đổ ra bảng
        public void LoadDataChatLieu()
        {
            danhSachChatLieu.RowCount = 0;
            foreach (var item in chatLieuBUS.LayDanhSachChatLieu())
            {
                danhSachChatLieu.Rows.Add(item.MaChatLieu, item.TenChatLieu);
            }
        }

        // load dữ liệu chất liệu tìm kiếm
        public void LoadDataChatLieu(string text)
        {
            danhSachChatLieu.RowCount = 0;
            foreach (var item in chatLieuBUS.TimKiemChatLieu(text))
            {
                danhSachChatLieu.Rows.Add(item.MaChatLieu, item.TenChatLieu);
            }
        }

        // hàm hiển thị dialog chi tiết
        public void ShowDialogChiTiet(ChatLieuModule module)
        {
            module.btnThem.Visible = false;
            module.btnSua.Visible = false;
            module.btnThoat.Size = new Size(320, 51);
        }

        // hàm hiển thị dialog thêm
        public void ShowDialogThem(ChatLieuModule module)
        {
            module.btnThem.Visible = true;
            module.btnSua.Visible = false;

        }
        // hàm hiển thị dialog sửa
        public void ShowDialogSua(ChatLieuModule module)
        {
            module.btnThem.Visible = false;
            module.btnSua.Visible = true;

        }


        private void danhSachChatLieu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            // tạo biến dòng được chọn
            DataGridViewRow selectedRow = danhSachChatLieu.Rows[e.RowIndex];

            // lấy ra mã chất liệu từ dòng được chọn
            int maChatLieu = Convert.ToInt32(selectedRow.Cells[0].Value.ToString());

            // lấy chất liệu qua mã chất liệu
            ChatLieu chatLieu = chatLieuBUS.LayChatLieuQuaMa(maChatLieu);

            // tạo biến tên cột tại dòng được chọn
            string selectedColumnName = danhSachChatLieu.Columns[e.ColumnIndex].Name;

            // trường hợp tên cột là Xoa
            if (selectedColumnName == "Xoa")
            {
                DialogResult result = MessageBox.Show("Bạn có muốn tiếp tục xóa ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (chatLieuBUS.XoaChatLieu(chatLieu))
                    {
                        MessageBox.Show("Bạn đã xóa thành công");
                        LoadDataChatLieu();
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
                ChatLieuModule chatLieuModule = new ChatLieuModule(maChatLieu);
                chatLieuModule.txtTenChatLieu.Text = chatLieu.TenChatLieu;
                ShowDialogSua(chatLieuModule);
                chatLieuModule.ShowDialog();
                LoadDataChatLieu();
            }

            else if (selectedColumnName == "ChiTiet")
            {
                ChatLieuModule chatLieuModule = new ChatLieuModule(maChatLieu);
                chatLieuModule.txtTenChatLieu.Text = chatLieu.TenChatLieu;
                ShowDialogSua(chatLieuModule);
                chatLieuModule.ShowDialog();
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text;
            if (txtTimKiem.Text == "" || txtTimKiem.Text == " ")
            {
                LoadDataChatLieu();
            }
            else
            {
                LoadDataChatLieu(keyword);
            }
        }

        private void btnShowDialog_Click(object sender, EventArgs e)
        {
            ChatLieuModule chatLieuModule = new ChatLieuModule();
            ShowDialogThem(chatLieuModule);
            chatLieuModule.ShowDialog();
            LoadDataChatLieu();
        }
    }
}
