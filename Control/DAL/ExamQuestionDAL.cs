using Control.DAL;
using PhanMemQuanLy.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQuanLy.DAL
{
    class ExamQuestionDAL
    {
        /*
         *da cap ngu vl lam bo may code kho vl ra
         *
         */
        static public List<ExamQuestion> getAllExamQuestion()
        {
            List<ExamQuestion> res = new List<ExamQuestion>();
            SqlConnection connection = new SqlConnection(Connection.getConnectionString());
            SqlCommand command = new SqlCommand("SELECT * FROM ExamsQuestions", connection);
            SqlDataAdapter adapt = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            DataTable dt = ds.Tables[0];
            foreach (DataRow dr in dt.Rows)
            {
                int examID = Convert.ToInt32(dr["ExamID"]);
                int quesID = Convert.ToInt32(dr["QuestionID"]);
                res.Add(new ExamQuestion(ExamDAL.getAllExams().Where(x=>x.ExamID== examID).Single(),QuestionDAL.getAllQuestion().Where(x=>x.QuestionID == quesID).Single()));
            }
            return res;
        }

        static public void update(Exam exam,string ExamTitle, int ExamMark, DateTime ExamDateTime, TimeSpan ExamTime, int ExamStatus,List<int> qids)
        {
            SqlConnection connection = new SqlConnection(Connection.getConnectionString());
            connection.Open();
            try
            {
                SqlCommand command = new SqlCommand(null, connection);

                // update exam
                command.CommandText = "UPDATE [dbo].[Exams] SET [ExamTitle] = @ExamTitle  ,[ExamMark] = @ExamMark  ,[ExamDateTime] = @ExamDateTime  ,[ExamTime] = @ExamTime  ,[ExamStatus] = @ExamStatus WHERE ExamID = " + exam.ExamID;
                command.Parameters.Add("@ExamTitle", SqlDbType.NVarChar).Value = ExamTitle;
                command.Parameters.Add("@ExamMark", SqlDbType.Int).Value = ExamMark;
                command.Parameters.Add("@ExamDateTime", SqlDbType.Date).Value = ExamDateTime;
                command.Parameters.Add("@ExamTime", SqlDbType.Time).Value = ExamTime;
                command.Parameters.Add("@ExamStatus", SqlDbType.Int).Value = ExamStatus;
                command.ExecuteNonQuery();
               //update examQuestion
                var transaction = connection.BeginTransaction();
                command.Transaction = transaction;
                command.CommandText = "DELETE FROM [dbo].[ExamsQuestions] WHERE ExamID = " + exam.ExamID;
                command.ExecuteNonQuery();
                
                command.CommandText = "INSERT INTO ExamsQuestions (ExamID,QuestionID) values (" + exam.ExamID + ",@QuestionID)";
                var QuestionID = command.Parameters.Add("@QuestionID", SqlDbType.Int);
                foreach (int qid in qids)
                {
                    QuestionID.Value = qid;
                    command.ExecuteNonQuery();
                }
                transaction.Commit();
            }
            finally
            {
                connection.Close();
            }
        }
       
    }
}
