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

namespace PhanMemQuanLy.MenuForm.QuanLy.CauHoi
{
    public partial class UpdateQuestion : Form
    {
        private int questionID;
        public UpdateQuestion(int questionID)
        {
            this.questionID = questionID;
            Question q = QuestionDAL.getQuestion(questionID);
            List<int> ansTrue = AnswerDAL.getAnswer(q.QuestionID);
            InitializeComponent();
            pbCauHoi.Load(Resources.serverLink + q.QuestionImage);
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            List<int> ansTrue = new List<int>();
            if (ans1.Checked) ansTrue.Add(1);
            if (ans2.Checked) ansTrue.Add(2);
            if (ans3.Checked) ansTrue.Add(3);
            if (ans4.Checked) ansTrue.Add(4);
            AnswerDAL.updateAnswer(questionID, ansTrue);
            this.Dispose();
        }
    }
}
