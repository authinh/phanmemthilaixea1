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
    class ExamDAL
    {
        static public List<Exam> getAllExams()
        {
            List<Exam> res = new List<Exam>();
            SqlConnection connection = new SqlConnection(Connection.getConnectionString());
            SqlCommand command = new SqlCommand("SELECT * FROM Exams", connection);
            SqlDataAdapter adapt = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            DataTable dt = ds.Tables[0];
            foreach (DataRow dr in dt.Rows)
            {
                res.Add(new Exam(Convert.ToInt32(dr["ExamID"]), Convert.ToString(dr["ExamTitle"]), Convert.ToInt32(dr["ExamMark"]), Convert.ToDateTime(dr["ExamDateTime"]), TimeSpan.Parse(dr["ExamTime"].ToString()), Convert.ToInt32(dr["ExamStatus"])));
            }
            return res;
        }
        static public void insert(string ExamTitle, int ExamMark, DateTime ExamDateTime, TimeSpan ExamTime, int ExamStatus, List<int> qids)
        {
            SqlConnection connection = new SqlConnection(Connection.getConnectionString());
            connection.Open();
            try
            {
                SqlCommand command = new SqlCommand(null, connection);
                command.CommandText = "INSERT INTO Exams (ExamTitle, ExamMark, ExamDateTime, ExamTime, ExamStatus) OUTPUT INSERTED.ExamID VALUES (@ExamTitle, @ExamMark, @ExamDateTime, @ExamTime, @ExamStatus)";
                command.Parameters.Add("@ExamTitle", SqlDbType.NVarChar).Value = ExamTitle;
                command.Parameters.Add("@ExamMark", SqlDbType.Int).Value = ExamMark;
                command.Parameters.Add("@ExamDateTime", SqlDbType.Date).Value = ExamDateTime;
                command.Parameters.Add("@ExamTime", SqlDbType.Time).Value = ExamTime;
                command.Parameters.Add("@ExamStatus", SqlDbType.Int).Value = ExamStatus;
                var newId = -1;
                try
                {
                    newId = (int)command.ExecuteScalar();
                }
                catch (Exception ex)
                {

                }
                if (newId == -1) return;
                var transaction = connection.BeginTransaction();
                command.Transaction = transaction;
                command.CommandText = "INSERT INTO ExamsQuestions (ExamID,QuestionID) values (" + newId + ",@QuestionID)";
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
