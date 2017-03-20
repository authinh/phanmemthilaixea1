using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQuanLy.Entity
{
    class Exam
    {
        public int ExamID { get; set; }
        public string ExamTitle { get; set; }
        public int ExamMark { get; set; }
        public DateTime ExamDateTime { get; set; }
        public TimeSpan ExamTime { get; set; }
        public int ExamStatus { get; set; }
        public Exam()
        {

        }
        public Exam(int ExamID, string ExamTitle, int ExamMark, DateTime ExamDateTime, TimeSpan ExamTime, int ExamStatus)
        {
            this.ExamID = ExamID;
            this.ExamTitle = ExamTitle;
            this.ExamMark = ExamMark;
            this.ExamDateTime = ExamDateTime;
            this.ExamTime = ExamTime;
            this.ExamStatus = ExamStatus;
        }
    }
}
