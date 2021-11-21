using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;

namespace CourseworkUOG_Quiz
{
    public partial class Score : Form
    {
        int y;
        Thread t;
        Player ply = new Player();
        double score1, correct, total;
        SqlConnection sqlCon = new SqlConnection("Data Source=MAS-CHKHOR-NB;Initial Catalog=animalQuiz;Integrated Security=True");
        public Score()
        {
            InitializeComponent();
            LoadDataFromDatabaseToDataGridView();
            GetNumOfQuestion();
            GetNoCorrectAnswer();
            GetUserID();
            CalculateScore();
            ShowScoreAndName();
            RecordUserDataIntoDatabase();
            t = new Thread(RunAnimation);
            t.Start();
        }

        public void RunAnimation()
        {
            int dy = 2;
            y = 1;
            while(true)
            {
                for (int i = 0; i < 50; i++)
                {
                    y += dy;
                    Invalidate();
                    Thread.Sleep(10);
                }
                dy = -dy;
            }

  
        }

        private void Score_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.FillEllipse(Brushes.Blue, 250, y, 9, 9);
        }

        private void LoadDataFromDatabaseToDataGridView()
        {
            SqlCommand cmdString = new SqlCommand("SELECT * FROM score", sqlCon);
            SqlDataAdapter da = new SqlDataAdapter(cmdString);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridViewShowAnsweredQuestion.DataSource = table;
        }

        private void GetNumOfQuestion()
        {
            //Data Source = server name
            //Initial Catalog = database name
            SqlConnection sqlCon = new SqlConnection("Data Source=MAS-CHKHOR-NB;Initial Catalog=animalQuiz;Integrated Security=True");
            try
            {
                sqlCon.Open();
                //always start with Command
                string cmdString = "SELECT COUNT(*) as numQues FROM score";
                SqlCommand sqlCmd = new SqlCommand(cmdString, sqlCon);
                //SqlDataReader = read or retrieve data from database
                SqlDataReader read = sqlCmd.ExecuteReader();
                while (read.Read())
                {
                    ply.TotalOfQuestion = int.Parse(read["numQues"].ToString());

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

        private void GetNoCorrectAnswer()
        {
            //Data Source = server name
            //Initial Catalog = database name
            SqlConnection sqlCon = new SqlConnection("Data Source=MAS-CHKHOR-NB;Initial Catalog=animalQuiz;Integrated Security=True");
            try
            {
                sqlCon.Open();
                //always start with Command
                string cmdString = "SELECT COUNT(*) as correctAns FROM score WHERE ansCorrectOrWrong = 'CORRECT';";
                SqlCommand sqlCmd = new SqlCommand(cmdString, sqlCon);
                //SqlDataReader = read or retrieve data from database
                SqlDataReader read = sqlCmd.ExecuteReader();
                while (read.Read())
                {
                    ply.CorrectOfQuestion = int.Parse(read["correctAns"].ToString());

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

        private void GetUserID()
        {
            //Data Source = server name
            //Initial Catalog = database name
            SqlConnection sqlCon = new SqlConnection("Data Source=MAS-CHKHOR-NB;Initial Catalog=animalQuiz;Integrated Security=True");
            try
            {
                sqlCon.Open();
                //always start with Command
                string cmdString = "SELECT users.firstName, users.lastName, score.userId FROM score INNER JOIN users ON users.id=score.userId;";
                SqlCommand sqlCmd = new SqlCommand(cmdString, sqlCon);
                //SqlDataReader = read or retrieve data from database
                SqlDataReader read = sqlCmd.ExecuteReader();
                while (read.Read())
                {
                    ply.userFIRSTNAME = read["firstName"].ToString();
                    ply.userLASTNAME = read["lastName"].ToString();
                    ply.userID = int.Parse(read["userId"].ToString());

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

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you wish to quit?", "Exit Application", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                DeleteUserDataFromTable();
                Application.Exit();
            }
        }

        private void CalculateScore()
        {
            
            correct = double.Parse(ply.CorrectOfQuestion.ToString());
            total = double.Parse(ply.TotalOfQuestion.ToString());
            score1 = (correct / total) * 100;
            
        }

        private void ShowScoreAndName()
        {
            lblTitle.Text = ply.userFIRSTNAME + " " + ply.userLASTNAME + " ,Your Score is " + Math.Round(score1,2) + "%";
        }

        private void DeleteUserDataFromTable()
        {
            //Data Source = server name
            //Initial Catalog = database name
            SqlConnection sqlCon = new SqlConnection("Data Source=MAS-CHKHOR-NB;Initial Catalog=animalQuiz;Integrated Security=True");
            try
            {
                sqlCon.Open();
                //always start with Command
                string cmdString = "DELETE FROM score WHERE userId = @userId";
                SqlCommand sqlCmd = new SqlCommand(cmdString, sqlCon);
                sqlCmd.Parameters.AddWithValue("@userId", ply.userID);
                sqlCmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            sqlCon.Close();
        }

        private void RecordUserDataIntoDatabase()
        {
            //Data Source = server name
            //Initial Catalog = database name
            SqlConnection sqlCon = new SqlConnection("Data Source=MAS-CHKHOR-NB;Initial Catalog=animalQuiz;Integrated Security=True");
            try
            {
                sqlCon.Open();
                    string cmdString = "INSERT INTO user_pastscore (user_Id,session,score) VALUES(@userId,CURRENT_TIMESTAMP,@score)";
                    SqlCommand sqlCmd = new SqlCommand(cmdString, sqlCon);
                    sqlCmd.Parameters.AddWithValue("@userId", ply.userID);
                    sqlCmd.Parameters.AddWithValue("@score", Math.Round(score1,2));
                    sqlCmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            sqlCon.Close();
        }
    }   


        

}
