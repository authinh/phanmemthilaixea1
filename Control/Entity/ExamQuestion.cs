using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQuanLy.Entity
{
    class ExamQuestion
    {
        public ExamQuestion(Exam exam, Question question)
        {
            Exam = exam;
            Question = question;
        }
        public ExamQuestion()
        {

        }
        public Exam Exam { get; set; }
        public Question Question { get; set; }
    }
}
