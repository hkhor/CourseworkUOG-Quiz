﻿using System;
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
        public int counter;

        SqlConnection sqlCon = new SqlConnection("Data Source=MAS-CHKHOR-NB;Initial Catalog=animalQuiz;Integrated Security=True");
        public Quiz()
        {
            InitializeComponent();
            GetPlayerSelectionFromDatabase();
            SetCategories();
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
                lblTitle.Text = "Question" + (counter + 1);
                if (qtn.quizTYPE == "Mutliple")
                {
                    //MessageBox.Show(qtn.imgFILEPATH);
                    txtFillAnswer.Hide();
                    btnAns5.Hide();
                    btnAns1.Show();
                    btnAns2.Show();
                    btnAns3.Show();
                    btnAns4.Show();
                    picBox.Image = new Bitmap(qtn.imgFILEPATH);
                    lblQuestion.Text = qtn.quizQUESTION;
                    btnAns1.Text = qtn.ansORDER1;
                    btnAns2.Text = qtn.ansORDER2;
                    btnAns3.Text = qtn.ansORDER3;
                    btnAns4.Text = qtn.ansORDER4;
                }
                else if (qtn.quizTYPE == "Fill")
                {
                    //MessageBox.Show(qtn.imgFILEPATH);
                    btnAns1.Hide();
                    btnAns2.Hide();
                    btnAns3.Hide();
                    btnAns4.Hide();
                    txtFillAnswer.Show();
                    lblQuestion.Show();
                    btnAns5.Show();
                    picBox.Image = new Bitmap(qtn.imgFILEPATH);
                    txtFillAnswer.Text = "Enter Answer Here";
                    lblQuestion.Text = qtn.quizQUESTION;
                    btnAns5.Text = "Submit";
                   
                }
                else
                {
                    MessageBox.Show("Progam Logic Error");
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

        }

        private void btnAns1_Click(object sender, EventArgs e)
        {
            if (counter != 14) {
                if (btnAns1.Text != qtn.realANSWER)
                {
                    ply.selectedANSWER = "WRONG";
                    MessageBox.Show("Wrong!");
                }
                else
                {
                    ply.selectedANSWER = "CORRECT";
                    MessageBox.Show("Correct!");
                }

                ply.selectedANSWER = btnAns1.Text;
                ply.noOFQUESTION = counter + 1;
                ply.quizQUESTION = qtn.quizQUESTION;
                ply.ANS1 = qtn.ansORDER1;
                ply.ANS2 = qtn.ansORDER2;
                ply.ANS3 = qtn.ansORDER3;
                ply.ANS4 = qtn.ansORDER4;
                ply.realANSWER = qtn.realANSWER;
                InsertAnsweredQuestionInSQL();
                SetCategories();
                counter++;
            }
            else{
                counter = 0;
                this.Hide();
                Score score = new Score();
                score.Show();
            }
        }

        private void btnAns2_Click(object sender, EventArgs e)
        {
            if (counter != 14)
            {
                if (btnAns2.Text != qtn.realANSWER)
                {
                    ply.selectedANSWER = "WRONG";
                    MessageBox.Show("Wrong!");
                }
                else
                {
                    ply.selectedANSWER = "CORRECT";
                    MessageBox.Show("Correct!");
                }

                ply.selectedANSWER = btnAns2.Text;
                ply.noOFQUESTION = counter + 1;
                ply.quizQUESTION = qtn.quizQUESTION;
                ply.ANS1 = qtn.ansORDER1;
                ply.ANS2 = qtn.ansORDER2;
                ply.ANS3 = qtn.ansORDER3;
                ply.ANS4 = qtn.ansORDER4;
                ply.realANSWER = qtn.realANSWER;
                InsertAnsweredQuestionInSQL();
                SetCategories();

                counter++;
            }
            else
            {
                counter = 0;
                this.Hide();
                Score score = new Score();
                score.Show();
            }
        }

        private void btnAns3_Click(object sender, EventArgs e)
        {
            if (counter != 14)
            {
                if (btnAns3.Text != qtn.realANSWER)
                {
                    ply.selectedANSWER = "WRONG";
                    MessageBox.Show("Wrong!");
                }
                else
                {
                    ply.selectedANSWER = "CORRECT";
                    MessageBox.Show("Correct!");
                }

                ply.selectedANSWER = btnAns3.Text;
                ply.noOFQUESTION = counter + 1;
                ply.quizQUESTION = qtn.quizQUESTION;
                ply.ANS1 = qtn.ansORDER1;
                ply.ANS2 = qtn.ansORDER2;
                ply.ANS3 = qtn.ansORDER3;
                ply.ANS4 = qtn.ansORDER4;
                ply.realANSWER = qtn.realANSWER;
                InsertAnsweredQuestionInSQL();
                SetCategories();
                counter++;
            }
            else
            {
                counter = 0;
                this.Hide();
                Score score = new Score();
                score.Show();
            }
        }

        private void btnAns4_Click(object sender, EventArgs e)
        {
            if (counter != 14)
            {
                if (btnAns4.Text != qtn.realANSWER)
                {
                    ply.selectedANSWER = "WRONG";
                    MessageBox.Show("Wrong!");
                }
                else
                {
                    ply.selectedANSWER = "CORRECT";
                    MessageBox.Show("Correct!");
                }

                ply.selectedANSWER = btnAns4.Text;
                ply.noOFQUESTION = counter + 1;
                ply.quizQUESTION = qtn.quizQUESTION;
                ply.ANS1 = qtn.ansORDER1;
                ply.ANS2 = qtn.ansORDER2;
                ply.ANS3 = qtn.ansORDER3;
                ply.ANS4 = qtn.ansORDER4;
                ply.realANSWER = qtn.realANSWER;
                SetCategories();
                counter++;
            }
            else
            {
                counter = 0;
                this.Hide();
                Score score = new Score();
                score.Show();
            }
        }

        private void btnAns5_Click(object sender, EventArgs e)
        {
            if (counter != 14)
            {
                if (txtFillAnswer.Text != qtn.realANSWER)
                {
                    ply.selectedANSWER = "WRONG";
                    MessageBox.Show("Wrong!");
                }
                else
                {
                    ply.selectedANSWER = "CORRECT";
                    MessageBox.Show("Correct!");
                }

                ply.selectedANSWER = btnAns5.Text;
                ply.noOFQUESTION = counter + 1;
                ply.quizQUESTION = qtn.quizQUESTION;
                ply.ANS1 = qtn.ansORDER1;
                ply.ANS2 = qtn.ansORDER2;
                ply.ANS3 = qtn.ansORDER3;
                ply.ANS4 = qtn.ansORDER4;
                ply.realANSWER = qtn.realANSWER;
                InsertAnsweredQuestionInSQL();
                SetCategories();
                counter++;
            }
            else
            {
                counter = 0;
                this.Hide();
                Score score = new Score();
                score.Show();

            }
        }
        public void InsertAnsweredQuestionInSQL()
        {
            //Data Source = server name
            //Initial Catalog = database name
            SqlConnection sqlCon = new SqlConnection("Data Source=MAS-CHKHOR-NB;Initial Catalog=animalQuiz;Integrated Security=True");
            try
            {
                sqlCon.Open();
                string cmdString = "INSERT INTO score(userId,quizQuestion,ans1,ans2,ans3,ans4,realAnswer,selectedAnswer) VALUES (@userId, @quizQuestion, @ans1, @ans2, @ans3, @ans4, @realAnswer, @selectedAnswer)";
                SqlCommand sqlCmd = new SqlCommand(cmdString, sqlCon);
                //sqlCmd.Parameters.AddWithValue("@sId", ply.noOFQUESTION);
                sqlCmd.Parameters.AddWithValue("@userId", ply.userID);
                sqlCmd.Parameters.AddWithValue("@quizQuestion", ply.quizQUESTION);
                sqlCmd.Parameters.AddWithValue("@ans1", ply.ANS1);
                sqlCmd.Parameters.AddWithValue("@ans2", ply.ANS2);
                sqlCmd.Parameters.AddWithValue("@ans3", ply.ANS3);
                sqlCmd.Parameters.AddWithValue("@ans4", ply.ANS4);
                sqlCmd.Parameters.AddWithValue("realAnswer", ply.realANSWER);
                sqlCmd.Parameters.AddWithValue("selectedAnswer", ply.realANSWER);
                sqlCmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                sqlCon.Close();
            }
        }
    }
}
