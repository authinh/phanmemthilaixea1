using Control.DAL;
using PhanMemQuanLy;
using System;
using System.Windows.Forms;

namespace Control
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát khỏi chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr == DialogResult.Yes) Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool login = UserDAL.checkUser(txtUsername.Text, txtPassword.Text);
            if (login)
            {
                this.Hide();
                new Main().ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
