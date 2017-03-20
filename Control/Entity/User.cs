using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control.Entity
{
    class User
    {
        public int UserID { set; get; }
        public string Username { set; get; }
        public string Password { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public DateTime Birthday { set; get; }
        public string Address { set; get; } 
        public string Mobile { set; get; }
        public int UserType { set; get; }
        public User()
        {

        }
        public User(int UserID, string Username, string Password, string FirstName, string LastName, DateTime Birthday, string Address, string Mobile, int UserType)
        {
            this.UserID = UserID;
            this.Username = Username;
            this.Password = Password;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Birthday = Birthday;
            this.Address = Address;
            this.Mobile = Mobile;
            this.UserType = UserType;
        }
    }
}
