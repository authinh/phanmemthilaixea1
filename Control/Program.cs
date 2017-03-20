using Control.DAL;
using PhanMemQuanLy.MenuForm.QuanLy.CauHoi;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Control
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SqlConnection connection = new SqlConnection(Connection.getConnectionString());
            DialogResult dr;
            do
            {
                dr = DialogResult.None;
                try
                {
                    connection.Open();
                }
                catch (Exception ex)
                {
                    dr = MessageBox.Show("Không thể kết nối tới server", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            } while (dr == DialogResult.Retry);
            if (connection.State == ConnectionState.Closed)
            {
                Application.Exit();
                return;
            }
            connection.Close();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());

        }
    }
}
