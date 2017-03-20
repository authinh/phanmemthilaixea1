using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQuanLy.Entity
{
    class Answer
    {   
        public int QuestionID { get; set; }
        public int AnswerTrue { get; set; }
        public Answer(int questionID, int answerTrue)
        {
            QuestionID = questionID;
            AnswerTrue = answerTrue;
        }

        public Answer()
        {

        }
    }
}
