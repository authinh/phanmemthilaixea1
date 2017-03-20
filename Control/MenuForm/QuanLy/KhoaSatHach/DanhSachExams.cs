using PhanMemQuanLy.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQuanLy.MenuForm.QuanLy.KhoaSatHach
{
    public partial class DanhSachExams : Form
    {
        public DanhSachExams()
        {
            InitializeComponent();
        }

        private void DanhSachExams_Load(object sender, EventArgs e)
        {
            data.DataSource = ExamDAL.getAllExams();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddExam ae = new AddExam();
            ae.ShowDialog();
        }
    }
}
