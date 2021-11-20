using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
    /*Import*/
using System.Data.SqlClient;
using System.Configuration;

namespace CourseworkUOG_Quiz
{
    public partial class Quiz : Form
    {
        Player ply = new Player();
        Question qtn = new Question();
        
        SqlConnection sqlCon = new SqlConnection("Data Source=MAS-CHKHOR-NB;Initial Catalog=animalQuiz;Integrated Security=True");
        public Quiz()
        {
            InitializeComponent();
            GetPlayerSelectionFromDatabase();
            SetCategories();
            //RandomQuestion();
        }
        public void GetPlayerSelectionFromDatabase()
        {
            //Data Source = server name
            //Initial Catalog = database name
            SqlConnection sqlCon = new SqlConnection("Data Source=MAS-CHKHOR-NB;Initial Catalog=animalQuiz;Integrated Security=True");
            try
            {
                sqlCon.Open();
                //always start with Command
                string cmdString = "select user_id, quiz_categories from player_selection order by id DESC";
                SqlCommand sqlCmd = new SqlCommand(cmdString, sqlCon);
                SqlDataReader read = sqlCmd.ExecuteReader();
               while (read.Read())
                {
                    ply.userID = int.Parse(read["user_id"].ToString());
                    ply.quizCATEGORIES = read["quiz_categories"].ToString();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }
        }

        public void SetCategories()
        {

            try
            {
                sqlCon.Open();
                //always start with Command
                string cmdString = "SELECT TOP 1 * FROM questions where quizCategories = @qc ORDER BY NEWID()";
                SqlCommand sqlCmd = new SqlCommand(cmdString, sqlCon);
                sqlCmd.Parameters.AddWithValue("@qc", ply.quizCATEGORIES);
                //SqlDataReader = read or retrieve data from database
                SqlDataReader read = sqlCmd.ExecuteReader();
                

                while (read.Read())
                {
                    qtn.quizTYPE = read["quizType"].ToString();
                    qtn.quizQUESTION = read["quizQuestion"].ToString();
                    qtn.ansORDER1 = read["ansOrder1"].ToString();
                    qtn.ansORDER2 = read["ansOrder2"].ToString();
                    qtn.ansORDER3 = read["ansOrder3"].ToString();
                    qtn.ansORDER4 = read["ansOrder4"].ToString();
                    qtn.realANSWER = read["realAnswer"].ToString();
                    qtn.imgFILEPATH = read["imgFilePath"].ToString();

                }
                if (qtn.quizTYPE == "Mutliple")
                {
                    txtFillAnswer.Hide();
                    btnAns5.Hide();
                    lblQuestion.Text = qtn.quizQUESTION;
                    btnAns1.Text = qtn.ansORDER1;
                    btnAns2.Text = qtn.ansORDER2;
                    btnAns3.Text = qtn.ansORDER3;
                    btnAns4.Text = qtn.ansORDER4;
                }
                else if (qtn.quizTYPE == "Fill")
                {
                    txtFillAnswer.Text = "Enter Answer Here";
                    lblQuestion.Text = qtn.quizQUESTION;
                    btnAns5.Text = "Submit";
                    btnAns1.Hide();
                    btnAns2.Hide();
                    btnAns3.Hide();
                    btnAns4.Hide();

                }
                /*else
                {
                    MessageBox.Show("Program Logic Error GGWP");
                }
                */

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }

            /*Random r = new Random();
            int index = r.Next(qID.Count);
            //string randomQuestionId = qID[1];
            int randomQuestionId = 3;
            Question qtn = new Question();*/
            /*
            try
            {
                sqlCon.Open();
                //always start with Command
                string cmdString = "SELECT quizType, quizQuestion, ansOrder1, ansOrder2, ansOrder3, ansOrder4, realAnswer, imgFilePath FROM questions where qId = @qId";
                SqlCommand sqlCmd = new SqlCommand(cmdString, sqlCon);
                sqlCmd.Parameters.AddWithValue("@qId", randomQuestionId);
                //SqlDataReader = read or retrieve data from database
                SqlDataReader read = sqlCmd.ExecuteReader();

                while (read.Read())
                {
                    qtn.quizTYPE = read["quizType"].ToString();
                    qtn.quizQUESTION = read["quizQuestion"].ToString();
                    qtn.ansORDER1 = read["ansOrder1"].ToString();
                    qtn.ansORDER2 = read["ansOrder2"].ToString();
                    qtn.ansORDER3 = read["ansOrder3"].ToString();
                    qtn.ansORDER4 = read["ansOrder4"].ToString();
                    qtn.realANSWER = read["realAnswer"].ToString();
                    qtn.imgFILEPATH = read["imgFilePath"].ToString();

                }
                if (qtn.quizTYPE == "Mutliple")
                {
                    txtFillAnswer.Hide();
                    btnAns5.Hide();
                    lblQuestion.Text = qtn.quizQUESTION;
                    btnAns1.Text = qtn.ansORDER1;
                    btnAns2.Text = qtn.ansORDER2;
                    btnAns3.Text = qtn.ansORDER3;
                    btnAns4.Text = qtn.ansORDER4;
                }
                else if (qtn.quizTYPE == "Fill")
                {
                    txtFillAnswer.Text = "Enter Answer Here";
                    lblQuestion.Text = qtn.quizQUESTION;
                    btnAns5.Text = "Submit";
                    btnAns1.Hide();
                    btnAns2.Hide();
                    btnAns3.Hide();
                    btnAns4.Hide();

                }
                else
                {
                    MessageBox.Show("Program Logic Error GGWP");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }
            */


            


        }
    }
}
