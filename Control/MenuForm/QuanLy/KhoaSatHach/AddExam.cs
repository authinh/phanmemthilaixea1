using PhanMemQuanLy.DAL;
using PhanMemQuanLy.Entity;
using PhanMemQuanLy.Properties;
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
    public partial class AddExam : Form
    {
        List<int> qids = new List<int>();
        public AddExam()
        {
            InitializeComponent();
        }
        private Bitmap getImage(string url) {
            System.Net.WebRequest request = System.Net.WebRequest.Create(url);
            System.Net.WebResponse response = request.GetResponse();
            System.IO.Stream responseStream = response.GetResponseStream();
            return new Bitmap(responseStream);
        }
        private void AddExam_Load(object sender, EventArgs e)
        {
            List<Question> qList = PhanMemQuanLy.DAL.QuestionDAL.getAllQuestion();
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Image", typeof(Bitmap));
            dt.Columns.Add("Choice", typeof(Boolean));
            foreach (Question q in qList)
            {
                DataRow dr =  dt.NewRow();
                dr["ID"] = q.QuestionID; 
                dr["Image"] = getImage(Resources.serverLink + q.QuestionImage);
                dr["Choice"] = false;
                dt.Rows.Add(dr);
            }
            dataGridView1.DataSource = dt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string ExamTitle = txtTitle.Text;
            int ExamMark = Convert.ToInt32(txtMark.Text);
            DateTime ExamDateTime = txtdate.Value;
            TimeSpan ExamTime = txtTime.Value.TimeOfDay;
            int ExamStatus = (radioButton1.Checked)? 1:0;
            ExamDAL.insert(ExamTitle, ExamMark, ExamDateTime, ExamTime, ExamStatus, qids);
            MessageBox.Show("OK");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1 && e.ColumnIndex == 2)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                int id = Convert.ToInt32(((DataGridViewTextBoxCell)dataGridView1.Rows[e.RowIndex].Cells[0]).Value);
                if (Convert.ToBoolean(chk.Value))
                {
                    chk.Value = 0;
                    qids.Remove(id);
                }else
                {
                    chk.Value = 1;
                    qids.Add(id);
                }
                selected.Text = "Selected: " + qids.Count;
            }
        }
    }
}
