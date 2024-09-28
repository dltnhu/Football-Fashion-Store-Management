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
    public partial class DanhMucSanPhamTab : Form
    {
        Form activeForm = null;
        public DanhMucSanPhamTab(TheLoaiGUI theLoaiGUI , ThuongHieuGUI thuongHieuGUI, ChatLieuGUI chatLieuGUI, MauSacGUI mauSacGUI, KichCoGUI kichCoGUI)
        {
            InitializeComponent();
            OpenForm(theLoaiGUI, pageTheLoai);
            OpenForm(thuongHieuGUI, pageThuongHieu);
            OpenForm(chatLieuGUI, pageChatLieu);
            OpenForm(mauSacGUI, pageMauSac);
            OpenForm(kichCoGUI, pageKichCo);



        }

        public void OpenForm(Form form, TabPage pageContainer)
        {

            activeForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            pageContainer.Controls.Add(form);
            form.BringToFront();
            form.Show();
        }

       
    }
}
