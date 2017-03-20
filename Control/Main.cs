using PhanMemQuanLy.MenuForm.QuanLy.CauHoi;
using PhanMemQuanLy.MenuForm.QuanLy.KhoaSatHach;
using PhanMemQuanLy.MenuForm.QuanLy.ThiSinh;
using System;
using System.Windows.Forms;

namespace PhanMemQuanLy
{
    public partial class Main : Form
    {
        DanhSachCauHoi dsch;
        DanhSachExams dse;
        ListThiSinh lts;
        public Main()
        {
            InitializeComponent();
        }

        private void MenuThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát khỏi chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes) Application.Exit();
        }

        private void menuGioiThieu_Click(object sender, EventArgs e)
        {
            new About().ShowDialog();
        }

        private void menuKhoaHoc_Click(object sender, EventArgs e)
        {
            if (dse == null || dse.IsDisposed)
            {
                dse = new DanhSachExams();
                dse.MdiParent = this;
            }
            dse.Show();
            dse.Focus();
        }

        private void menuThiSinh_Click(object sender, EventArgs e)
        {
            if (lts == null || lts.IsDisposed)
            {
                lts = new ListThiSinh();
                lts.MdiParent = this;
            }
            lts.Show();
            lts.Focus();
        }

        private void menuCauHoi_Click(object sender, EventArgs e)
        {
            if(dsch == null || dsch.IsDisposed)
            {
                dsch = new DanhSachCauHoi();
                dsch.MdiParent = this;
            }
            dsch.Show();
            dsch.Focus();
        }
    }
}
