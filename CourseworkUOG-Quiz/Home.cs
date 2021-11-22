using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
/*Import*/
using System.Data.SqlClient;
using System.Configuration;


namespace CourseworkUOG_Quiz
{
    
    public partial class Home : Form
    {
        public delegate void StoreDataCallBackFromHome(int pID,string pCategories);
        public StoreDataCallBackFromHome StoreDataFromHome;

        public Home()
        {
            InitializeComponent();

        }

        Player ply = new Player();

        public void GetDatafromUserType(int pID)
        {
            try
            {

                ply.userID = pID;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection("Data Source=MAS-CHKHOR-NB;Initial Catalog=animalQuiz;Integrated Security=True");
            
            try
            {
                sqlCon.Open();
                if (rdbAquatic.Checked == true)
                {
                    ply.quizCATEGORIES = "aquatic";
                }
                else if (rdbJungle.Checked == true)
                {
                    ply.quizCATEGORIES = "jungle";
                }
                else if (rdbBird.Checked == true)
                {
                    ply.quizCATEGORIES = "bird";
                }
                else
                {
                    MessageBox.Show("Please Select Categories");
                }
                string quizCategories = ply.quizCATEGORIES.ToString();
                int uId = ply.userID;
                string cmdString = "INSERT INTO player_selection(user_id, quiz_categories) VALUES (@uId, @quizCategories)";
                SqlCommand sqlCmd = new SqlCommand(cmdString, sqlCon);
                sqlCmd.Parameters.AddWithValue("@uId", uId);
                sqlCmd.Parameters.AddWithValue("@quizCategories", quizCategories);
                sqlCmd.ExecuteNonQuery();
                var newform = new Animation();
                newform.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                sqlCon.Close();
        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you wish to quit?", "Exit Application", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }



    public partial class Animation : Form
    {
        public Label label1;
        public Label label2;
        public Timer timer1;

        public Animation()

        {

            label1 = new Label();
            label1.Font = new Font("ALGERIAN", 30, FontStyle.Bold);
            label1.Size = new Size(150, 150);
            label1.Location = new Point(115, 90);
            label1.Text = "00";
            this.Controls.Add(label1);
            label1.Click += new EventHandler(label1_click);

            label2 = new Label();
            label2.Font = new Font("Segoe Script", 15, FontStyle.Bold);
            label2.Size = new Size(300, 150);
            label2.Location = new Point(10, 10);
            label2.Text = "WELCOME TO QUIZ!..";
            this.Controls.Add(label2);
            label2.Click += new EventHandler(label2_click);

            Timer timer1 = new Timer
            {
                Interval = 500
            };
            timer1.Enabled = true;
            timer1.Tick += new System.EventHandler(OnTimerEvent);

            Load += new EventHandler(JungleAnimal_Load);

        }
        int counter = 0;
        int len = 0;
        string txt;
        int timeleft = 18;
        private void OnTimerEvent(object sender, EventArgs e)
        {
            if (timeleft > 0)
            {
                timeleft = timeleft - 1;
                label1.Text = timeleft + "";
            }

            if (label1.Text == "0")
            {
                this.Hide();
                this.Close();
                Quiz quiz = new Quiz();
                quiz.Show();
            }

            counter++;
            if (counter > len)
            {
                counter = 0;
                label2.Text = "";
            }
            else
                label2.Text = txt.Substring(0, counter);
        }



            private void label1_click(object sender, EventArgs e)
        {

        }

        private void label2_click(object sender, EventArgs e)
        {

        }

        private void JungleAnimal_Load(object sender, EventArgs e)
        {
            txt = label2.Text;
            len = txt.Length;
            label2.Text = "";
        }

    }
}
