using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQuanLy.Entity
{
    class Question
    {
        public Question(int questionID, string questionImage)
        {
            QuestionID = questionID;
            QuestionImage = questionImage;
        }
        public Question()
        {

        }
        public int QuestionID { get; set; }
        public string QuestionImage { get; set; }
    }
}
