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
        List<PhanMemQuanLy.Entity.Exam> list;
        public DanhSachExams()
        {
            InitializeComponent();
        }

        private void DanhSachExams_Load(object sender, EventArgs e)
        {
            list = PhanMemQuanLy.DAL.ExamDAL.getAllExams();
            data.DataSource = list;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddExam ae = new AddExam();
            ae.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            UpdateExam ae1 = new UpdateExam();
            ae1.ShowDialog();
        }

        private void data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            switch (e.ColumnIndex)
            {
                case 0: UpdateExam ae = new UpdateExam(list[e.RowIndex].ExamID);
                    ae.ShowDialog();
                    break;

                case 1:
                    if (MessageBox.Show(null,"bạn muốn xóa không?","xóa", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
                    
                    ExamDAL.Delete(list[e.RowIndex].ExamID);
                    try
                    {
                        list.RemoveAt(e.RowIndex);
                    }
                    catch { }
                    break;
                default:
                    list = PhanMemQuanLy.DAL.ExamDAL.getAllExams();
                    data.DataSource = list;
                    break;
            }
        }

        private void data_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
