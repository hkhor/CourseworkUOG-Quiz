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
        int noOfQuestion;
        string quizCategories;
        string quizQuestion;
        string ans1;
        string ans2;
        string ans3;
        string ans4;
        string realAnswer;
        string selectedAnswer;
        string ansCorrectOrWrong;


        public int noOFQUESTION { get { return noOfQuestion; } set { noOfQuestion = value; } }
        public string quizCATEGORIES { get { return quizCategories; } set { quizCategories = value; } }

        public string quizQUESTION
        {
            get
            {
                return quizQuestion;
            }
            set
            {
                quizQuestion = value;
            }
        }

        public string ANS1
        {
            get
            {
                return ans1;
            }
            set
            {
                ans1 = value;
            }
        }

        public string ANS2
        {
            get
            {
                return ans2;
            }
            set
            {
                ans2 = value;
            }
        }

        public string ANS3
        {
            get
            {
                return ans3;
            }
            set
            {
                ans3 = value;
            }

        }

        public string ANS4
        {
            get
            {
                return ans4;
            }
            set { ans4 = value; }
        }

        public string realANSWER
        {
            get { return realAnswer; } set { realAnswer = value; }
        }
        public string selectedANSWER { get { return selectedAnswer; } set { selectedAnswer = value; } }

        public string AnsCorrectWrong { get { return ansCorrectOrWrong; } set { ansCorrectOrWrong = value; } }
    }
}
