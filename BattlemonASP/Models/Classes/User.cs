using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattlemonASP.Models.Classes
{
    public class User
    {
        public int userID { get; set; }
        public string username { get; set; }
        public string NormalizedUserName { get; set; }
        public string email { get; set; }
        public string NormalizedEmail { get; set; }
        public string password { get; set; }
        public int rankID { get; set; }

        public User(int userID, string username, string email)
        {
            this.userID = userID;
            this.username = username;
            this.email = email;
        }

        public User(int userID, string username, string email, string password)
        {
            this.userID = userID;
            this.username = username;
            this.email = email;
            this.password = password;
        }
    }
}
