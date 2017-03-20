using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control.DAL
{
    class Connection
    {
        public static string getConnectionString()
        {
            return @"server=127.0.0.1;database=ThiA1;uid=sa;pwd=123456";
        }
    }
}
