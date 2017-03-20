using Control.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQuanLy.DAL
{
    class AnswerDAL
    {
        public static List<int> getAnswer(int questionID)
        {
            List<int> res = new List<int>();
            SqlConnection connection = new SqlConnection(Connection.getConnectionString());
            SqlCommand command = new SqlCommand("SELECT * FROM Answers WHERE QuestionID="+questionID, connection);
            SqlDataAdapter adapt = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            DataTable dt = ds.Tables[0];
            foreach (DataRow dr in dt.Rows)
            {
                res.Add(Convert.ToInt32(dr["AnswerTrue"]));
            }
            return res;
        }
        public static void updateAnswer(int questionID, List<int> ansTrue)
        {
            SqlConnection connection = new SqlConnection(Connection.getConnectionString());
            connection.Open();
            try
            {
                var transaction = connection.BeginTransaction();
                SqlCommand command = new SqlCommand(null, connection);
                command.Transaction = transaction;
                command.CommandText = "DELETE FROM Answers WHERE QuestionID=" + questionID;
                command.ExecuteNonQuery();
                command.CommandText = "INSERT INTO Answers (QuestionID,AnswerTrue) VALUES (@qid,@ans)";
                var qid = command.Parameters.Add("@qid", SqlDbType.Int);
                var ans = command.Parameters.Add("@ans", SqlDbType.Int);
                for (int i = 0; i < ansTrue.Count; i++)
                {
                    qid.Value = questionID;
                    ans.Value = ansTrue[i];
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
