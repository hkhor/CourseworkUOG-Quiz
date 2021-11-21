using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseworkUOG_Quiz
{
    class Question
    {
        int qId;
        string quizType;
        string quizQuestion;
        string ansOrder1;
        string ansOrder2;
        string ansOrder3;
        string ansOrder4;
        string realAnswer;
        string imgFilePath;

        public int qID { get { return qId; } set { qId = value; } }
        public string quizTYPE { get{return quizType;} set { quizType = value; } }
        public string quizQUESTION { get { return quizQuestion; } set {quizQuestion = value; } }
        public string ansORDER1 { get { return ansOrder1; } set { ansOrder1 = value; } }
        public string ansORDER2 { get { return ansOrder2; } set { ansOrder2 = value; } }
        public string ansORDER3 { get { return ansOrder3; } set { ansOrder3 = value; } }
        public string ansORDER4 { get { return ansOrder4; } set { ansOrder4 = value; } }
        public string realANSWER { get { return realAnswer; } set { realAnswer = value; } }
        public string imgFILEPATH { get { return imgFilePath; } set { imgFilePath = value; } }
    }

}
