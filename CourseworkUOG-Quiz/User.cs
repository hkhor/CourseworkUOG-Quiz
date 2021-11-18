using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseworkUOG_Quiz
{
    class User
    {
        private int userId;
        private string userName;
        private string userType;
        private string userFirstName;
        private string userLastName;


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

        public string userTYPE
        {
            get
            {
                return userType;
            }
            set
            {
                userType = value;
            }
        }

        public string userFIRSTNAME
        {
            get
            {
                return userFirstName;
            }
            set
            {
                userFirstName = value;
            }
        }

        public string userLASTNAME
        {
            get
            {
                return userLastName;
            }
            set
            {
                userLastName = value;
            }
        }


        public User()
        {
            this.userName = "";
            this.userID = 0;
            this.userType = "";
        }


    }
    class Player : User
    {

    }

    class Admin : User
    {

    }


}
