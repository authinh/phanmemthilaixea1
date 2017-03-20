using Control.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Control.DAL
{
    class UserDAL
    {
        public static string md5(string str)
        {
            MD5 md5Hash = MD5.Create();
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(str));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }
        public static bool checkUser(string user, string pass)
        {
            SqlConnection connection = new SqlConnection(Connection.getConnectionString());
            connection.Open();
            SqlCommand command = new SqlCommand(null, connection);
            user = user.Trim().ToLower();
            pass = md5(pass.Trim());
            command.CommandText = "SELECT * FROM Users WHERE Username=@Username AND Password=@Password";
            command.Parameters.Add(new SqlParameter("@Username", SqlDbType.NVarChar, 50));
            command.Parameters.Add(new SqlParameter("@Password", SqlDbType.NVarChar, 32));
            command.Prepare();
            command.Parameters[0].Value = user;
            command.Parameters[1].Value = pass;
            SqlDataAdapter adapt = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            DataTable dt = ds.Tables[0];
            return dt.Rows.Count > 0;
        }
        public static List<User> getAllUser(int uid, string name, string mobile, string address, DateTime birth, int examid)
        {
            List<User> res = new List<User>();
            SqlConnection connection = new SqlConnection(Connection.getConnectionString());
            connection.Open();
            SqlCommand command = new SqlCommand(null, connection);
            command.CommandText = "SELECT U.UserID, U.Username, U.FirstName+' '+U.LastName AS UName, U.Birthday, Address, Mobile FROM Users U INNER JOIN ExamsUsers EU ON U.UserID=EU.UserID WHERE U.UserType = 0";
            if (uid > 0)
            {
                command.CommandText += " AND U.UserID = "+uid;
            }
            if (examid > 0)
            {
                command.CommandText += " AND EU.ExamID = "+examid;
            }
            if(name == "")
            {
                
            }
            SqlDataAdapter adapt = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            DataTable dt = ds.Tables[0];
            foreach(DataRow dr in dt.Rows)
            {
                res.Add(new User(Convert.ToInt32(dr["UserID"]), dr["Username"].ToString(), "", dr["UName"].ToString(), "", Convert.ToDateTime(dr["Birthday"]), dr["Address"].ToString(), dr["Mobile"].ToString(), 0));
            }
            return res;
        }

    }
}
