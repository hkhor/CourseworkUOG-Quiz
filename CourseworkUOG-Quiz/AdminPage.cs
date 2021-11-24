using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CourseworkUOG_Quiz
{
    public partial class AdminPage : Form
    {
        SqlConnection sqlCon = new SqlConnection("Data Source=MAS-CHKHOR-NB;Initial Catalog=animalQuiz;Integrated Security=True");
        Admin adm = new Admin();
        public AdminPage()
        {
            InitializeComponent();
            ShowQuestionList();
        }

        private void ClearFields()
        {
            cmbAnimalCategory.Text = "";
            cmbAnswerType.Text = "";
            txtAns1.Text = "";
            txtAns2.Text = "";
            txtAns3.Text = "";
            txtAns4.Text = "";
            txtQuizID.Text = "";
            lblFileName.Text = "FileName";
            txtQuestion.Text = "";
            txtRealAnswer.Text = "";
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.JPG,*.PNG,*.GIF)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                 adm.ImgFilePath = opf.FileName;
                lblFileName.Text = adm.ImgFilePath;
            }
        }

        private void ShowQuestionList()
        {
            SqlCommand cmdString = new SqlCommand("SELECT * FROM questions", sqlCon);
            SqlDataAdapter da = new SqlDataAdapter(cmdString);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridViewQuestionList.DataSource = table;
            dataGridViewQuestionList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewQuestionList.AllowUserToAddRows = false;
        }

        private void dataGridViewQuestionList_Click(object sender, EventArgs e)
        {
            txtQuizID.Text = dataGridViewQuestionList.CurrentRow.Cells[0].Value.ToString();
            cmbAnimalCategory.Text = dataGridViewQuestionList.CurrentRow.Cells[1].Value.ToString();
            cmbAnswerType.Text = dataGridViewQuestionList.CurrentRow.Cells[2].Value.ToString();
            txtQuestion.Text = dataGridViewQuestionList.CurrentRow.Cells[3].Value.ToString();
            txtAns1.Text = dataGridViewQuestionList.CurrentRow.Cells[4].Value.ToString();
            txtAns2.Text = dataGridViewQuestionList.CurrentRow.Cells[5].Value.ToString();
            txtAns3.Text = dataGridViewQuestionList.CurrentRow.Cells[6].Value.ToString();
            txtAns4.Text = dataGridViewQuestionList.CurrentRow.Cells[7].Value.ToString();
            txtRealAnswer.Text = dataGridViewQuestionList.CurrentRow.Cells[8].Value.ToString();
            lblFileName.Text = dataGridViewQuestionList.CurrentRow.Cells[9].Value.ToString();

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                sqlCon.Open();
                //always start with Command
                if (txtQuestion.Text.Length > 0)
                {
                    string cmdString = "INSERT INTO questions (quizCategories,quizType,quizQuestion,ansOrder1,ansOrder2,ansOrder3,ansOrder4,realAnswer,imgFilePath) VALUES (@qcategories, @qtype, @qquestion, @ansOrder1, @ansOrder2, @ansOrder3, @ansOrder4,@realAnswer,@imgFilePath)";
                    SqlCommand sqlCmd = new SqlCommand(cmdString, sqlCon);
                    sqlCmd.Parameters.AddWithValue("@qcategories", cmbAnimalCategory.Text);
                    sqlCmd.Parameters.AddWithValue("@qtype", cmbAnswerType.Text);
                    sqlCmd.Parameters.AddWithValue("@qquestion", txtQuestion.Text);
                    sqlCmd.Parameters.AddWithValue("@ansOrder1", txtAns1.Text);
                    sqlCmd.Parameters.AddWithValue("@ansOrder2", txtAns2.Text);
                    sqlCmd.Parameters.AddWithValue("@ansOrder3", txtAns3.Text);
                    sqlCmd.Parameters.AddWithValue("@ansOrder4", txtAns4.Text);
                    sqlCmd.Parameters.AddWithValue("@realAnswer", txtRealAnswer.Text);
                    sqlCmd.Parameters.AddWithValue("@imgFilePath", adm.ImgFilePath);
                    int RowsAffected = sqlCmd.ExecuteNonQuery();
                    if (RowsAffected > 0)
                    {
                        MessageBox.Show("Sucessfully Inserted");
                    }
                    ShowQuestionList();
                    ClearFields();


                }
                else
                {
                    MessageBox.Show("Incomplete Data");
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

        private void btnModifyImage_Click(object sender, EventArgs e)
        {
            try
            {
                sqlCon.Open();
                //always start with Command
                if (txtQuestion.Text.Length > 0)
                {
                    string cmdString = "UPDATE questions SET quizCategories=@qcategories, quizType=@qtype, quizQuestion=@qquestion, ansOrder1=@ansOrder1, ansOrder2=@ansOrder2, ansOrder3=@ansOrder3, ansOrder4=@ansOrder4, realAnswer=@realAnswer, imgFilePath=@imgFilePath WHERE qId = @qId";
                    SqlCommand sqlCmd = new SqlCommand(cmdString, sqlCon);
                    sqlCmd.Parameters.AddWithValue("@qcategories", cmbAnimalCategory.Text);
                    sqlCmd.Parameters.AddWithValue("@qtype", cmbAnswerType.Text);
                    sqlCmd.Parameters.AddWithValue("@qquestion", txtQuestion.Text);
                    sqlCmd.Parameters.AddWithValue("@ansOrder1", txtAns1.Text);
                    sqlCmd.Parameters.AddWithValue("@ansOrder2", txtAns2.Text);
                    sqlCmd.Parameters.AddWithValue("@ansOrder3", txtAns3.Text);
                    sqlCmd.Parameters.AddWithValue("@ansOrder4", txtAns4.Text);
                    sqlCmd.Parameters.AddWithValue("@realAnswer", txtRealAnswer.Text);
                    sqlCmd.Parameters.AddWithValue("@imgFilePath", lblFileName.Text);
                    sqlCmd.Parameters.AddWithValue("@qId", txtQuizID.Text);
                    int RowsAffected = sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Sucessfully Modified");
                    ShowQuestionList();
                    ClearFields();

                }
                else
                {
                    MessageBox.Show("Incomplete Data");
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

        private void btnDeleteImage_Click(object sender, EventArgs e)
        {
            //Data Source = server name
            //Initial Catalog = database name
            SqlConnection sqlCon = new SqlConnection("Data Source=MAS-CHKHOR-NB;Initial Catalog=animalQuiz;Integrated Security=True");
            try
            {
                sqlCon.Open();
                //always start with Command
                string cmdString = "DELETE FROM questions WHERE qId = @qId";
                SqlCommand sqlCmd = new SqlCommand(cmdString, sqlCon);
                sqlCmd.Parameters.AddWithValue("@qId", txtQuizID.Text);
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Data Deleted");
                ShowQuestionList();
                ClearFields();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            sqlCon.Close();
        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
