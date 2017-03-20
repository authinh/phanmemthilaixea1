using PhanMemQuanLy.DAL;
using PhanMemQuanLy.Entity;
using PhanMemQuanLy.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQuanLy.MenuForm.QuanLy.CauHoi
{
    public partial class DanhSachCauHoi : Form
    {
        public DanhSachCauHoi()
        {
            InitializeComponent();
            dataCauHoi.DataSource = QuestionDAL.getAllQuestion();
            DataGridViewButtonColumn btEdit = new DataGridViewButtonColumn();
            dataCauHoi.Columns.Insert(2, btEdit);
            btEdit.HeaderText = "Edit";
            btEdit.Text = "Edit";
            btEdit.Name = "btnEdit";
            btEdit.UseColumnTextForButtonValue = true;
            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            dataCauHoi.Columns.Insert(3, btnDelete);
            btnDelete.HeaderText = "Delete";
            btnDelete.Text = "Delete";
            btnDelete.Name = "btnDelete";
            btnDelete.UseColumnTextForButtonValue = true;
            dataCauHoi.AutoGenerateColumns = false;
        }
        private void loadAns(Question q)
        {
            pbCauHoi.Load(Resources.serverLink + q.QuestionImage);
            List<int> ansTrue = AnswerDAL.getAnswer(q.QuestionID);
            ans1.Checked = false;
            ans2.Checked = false;
            ans3.Checked = false;
            ans4.Checked = false;
            foreach (int ansT in ansTrue)
            {
                switch (ansT)
                {
                    case 1: ans1.Checked = true; break;
                    case 2: ans2.Checked = true; break;
                    case 3: ans3.Checked = true; break;
                    case 4: ans4.Checked = true; break;
                }
            }
        }
        private void dataCauHoi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            List<Question> listQuestion = (List<Question>)dataCauHoi.DataSource;
            Question q = listQuestion[e.RowIndex];
            loadAns(q);
            if (e.ColumnIndex == 2)
            {
                UpdateQuestion uq = new UpdateQuestion(q.QuestionID);
                uq.ShowDialog();
                loadAns(q);
            }
            else if (e.ColumnIndex == 3)
            {
                DialogResult dr = MessageBox.Show(this, "Are you sure?", "Are you sure?", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    QuestionDAL.deleteQuestion(q.QuestionID, q.QuestionImage);
                    MessageBox.Show("Delete Successfully!");
                    dataCauHoi.DataSource = QuestionDAL.getAllQuestion();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddNewQuestion anq = new AddNewQuestion();
            anq.ShowDialog();
            dataCauHoi.DataSource = QuestionDAL.getAllQuestion();
        }
    }
}
