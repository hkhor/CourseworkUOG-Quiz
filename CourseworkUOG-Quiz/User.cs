using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseworkUOG_Quiz
{
    class User
    {
        private int userId;
        private string userName;

        public int userID
        {
            get
            {
                return userId;
            }
            set
            {
                userId = value;
            }
        }

        public string userNAME
        {
            get
            {
                return userName;
            }
            set
            {
                userName = value;
            }

        }
        public User()
        {
            this.userName = "";
        }

        public User(int userId, string userName)
        {
            this.userName = userName;
            this.userID = userID;

        }
    }


}
