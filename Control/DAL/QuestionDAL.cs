using Control.DAL;
using PhanMemQuanLy.Entity;
using PhanMemQuanLy.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQuanLy.DAL
{
    class QuestionDAL
    {
        public static List<PhanMemQuanLy.Entity.Question> getAllQuestion()
        {
            List<PhanMemQuanLy.Entity.Question> res = new List<PhanMemQuanLy.Entity.Question>();
            SqlConnection connection = new SqlConnection(Connection.getConnectionString());
            SqlCommand command = new SqlCommand("SELECT * FROM Questions", connection);
            SqlDataAdapter adapt = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            DataTable dt = ds.Tables[0];
            foreach(DataRow dr in dt.Rows)
            {
                res.Add(new PhanMemQuanLy.Entity.Question(Int32.Parse(dr["QuestionID"].ToString()), dr["QuestionImage"].ToString()));
            }
            return res;
        }

        public static Question getQuestion(int questionID)
        {
            SqlConnection connection = new SqlConnection(Connection.getConnectionString());
            SqlCommand command = new SqlCommand("SELECT * FROM Questions WHERE QuestionID=" + questionID, connection);
            SqlDataAdapter adapt = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            DataTable dt = ds.Tables[0];
            DataRow dr = dt.Rows[0];
            return new PhanMemQuanLy.Entity.Question(Convert.ToInt32(dr["QuestionID"]), dr["QuestionImage"].ToString());
        }

        public static int insertQuestion(string QuestionImage)
        {
            SqlConnection connection = new SqlConnection(Connection.getConnectionString());
            connection.Open();
            SqlCommand command = new SqlCommand(null, connection);
            command.CommandText = "INSERT INTO Questions (QuestionImage) OUTPUT INSERTED.QuestionID VALUES (@qi)";
            command.Parameters.Add("@qi", SqlDbType.NVarChar).Value = QuestionImage;
            var res = command.ExecuteScalar();
            connection.Close();
            return Convert.ToInt32(res);
        }
        public static void deleteQuestion(int questionID, string fileName)
        {
            SqlConnection connection = new SqlConnection(Connection.getConnectionString());
            connection.Open();
            SqlCommand command = new SqlCommand(null, connection);
            var transaction = connection.BeginTransaction();
            command.Transaction = transaction;
            command.CommandText = "DELETE FROM Answers WHERE QuestionID = "+questionID;
            command.ExecuteNonQuery();
            command.CommandText = "DELETE FROM Questions WHERE QuestionID = " + questionID;
            command.ExecuteNonQuery();
            transaction.Commit();
            connection.Close();
            if (isFileExist(fileName))
            {
                fileRemove(fileName);
            }
        }

        public static bool isFileExist(string filename)
        {
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(Resources.ftpLink + filename);
            request.Credentials = new NetworkCredential(Resources.ftpUsername, Resources.ftpPassword);
            request.Method = WebRequestMethods.Ftp.GetDateTimestamp;
            try
            {
                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                response.Close();
                return true;
            }
            catch (WebException ex)
            {
                return false;
            }
        }
        public static bool fileRemove(string filename)
        {
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(Resources.ftpLink + filename);
            request.Credentials = new NetworkCredential(Resources.ftpUsername, Resources.ftpPassword);
            request.Method = WebRequestMethods.Ftp.DeleteFile;
            try
            {
                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                response.Close();
                return true;
            }
            catch (WebException ex)
            {
                return false;
            }
        }
    }
}
