using System;
using PhanMemQuanLy.DAL;
using PhanMemQuanLy.Entity;
using PhanMemQuanLy.Properties;
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
    public partial class UpdateExam : Form
    {
        List<int> qids = new List<int>();
        Exam exam;

        public UpdateExam()
        {
            InitializeComponent();

        }
        public UpdateExam(int examID)
        {

            InitializeComponent();
            exam = ExamDAL.getAllExams().Where(x => x.ExamID == examID).Single();
        }

        private Bitmap getImage(string url)
        {
            System.Net.WebRequest request = System.Net.WebRequest.Create(url);
            System.Net.WebResponse response = request.GetResponse();
            System.IO.Stream responseStream = response.GetResponseStream();
            return new Bitmap(responseStream);
        }

        private void UpdateExam_Load(object sender, System.EventArgs e)
        {
            /**
             * display cac truong hien thi thong tin
             * 
             */
            txtTitle.Text = exam.ExamTitle;
            txtdate.Value = exam.ExamDateTime;
            txtMark.Text = exam.ExamMark.ToString();
            //txtTime.Value = new DateTime(exam.ExamTime.Ticks);
            radioButton1.Checked = (exam.ExamStatus == 1) ? true : false;
            radioButton2.Checked = (exam.ExamStatus == 1) ? true : false;


            List<Question> qList = QuestionDAL.getAllQuestion();
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Image", typeof(Bitmap));
            dt.Columns.Add("Choice", typeof(Boolean));

            List<ExamQuestion> listExamQuestion = ExamQuestionDAL.getAllExamQuestion().Where(x => x.Exam.ExamID == exam.ExamID).ToList();

            foreach (Question q in qList)
            {
                DataRow dr = dt.NewRow();
                dr["ID"] = q.QuestionID;
                // xoa comment de chay file anh
                // dr["Image"] = getImage(Resources.serverLink + q.QuestionImage);
                if (listExamQuestion.Where(x => x.Question.QuestionID == q.QuestionID).Count() == 1)
                {
                    dr["Choice"] = true;
                    qids.Add(q.QuestionID);
                    
                }
                else dr["Choice"] = false;
                dt.Rows.Add(dr);

            }
            dataGridView1.DataSource = dt;
            selected.Text = "Selected: " + qids.Count;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex == 2)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                int id = Convert.ToInt32(((DataGridViewTextBoxCell)dataGridView1.Rows[e.RowIndex].Cells[0]).Value);
                if (Convert.ToBoolean(chk.Value))
                {
                    chk.Value = 0;
                    qids.Remove(id);
                }
                else
                {
                    chk.Value = 1;
                    qids.Add(id);
                }
                selected.Text = "Selected: " + qids.Count;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ExamTitle = txtTitle.Text;
            int ExamMark = Convert.ToInt32(txtMark.Text);
            DateTime ExamDateTime = txtdate.Value;
            TimeSpan ExamTime = txtTime.Value.TimeOfDay;
            int ExamStatus = (radioButton1.Checked) ? 1 : 0;
            ExamQuestionDAL.update(exam, ExamTitle, ExamMark, ExamDateTime, ExamTime, ExamStatus, qids);
            MessageBox.Show("OK");
        }


    }
}
