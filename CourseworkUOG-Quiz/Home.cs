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


namespace CourseworkUOG_Quiz
{
    public partial class Home : Form
    {
      
        public Home()
        {
            InitializeComponent();

        }


        private void Home_Load(object sender, EventArgs e)
        {
          

        }
   
     
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                var newform = new Animation();
                newform.Show();
                this.Hide();
            }

            else if (radioButton2.Checked == true)
            {
                var newform = new Animation();
                newform.Show();
                this.Hide();
            }
            else if (radioButton3.Checked == true)
            {
                var newform = new Animation();
                newform.Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
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
            public Label lblAnimation1;
            public Label lblAnimation2;
            public Timer timer1;

            public Animation()

            {

                lblAnimation1 = new Label();
                lblAnimation1.Font = new Font("ALGERIAN", 30, FontStyle.Bold);
                lblAnimation1.Size = new Size(150, 150);
                lblAnimation1.Location = new Point(115, 90);
                lblAnimation1.Text = "00";
                this.Controls.Add(lblAnimation1);
                lblAnimation1.Click += new EventHandler(label1_click);

                lblAnimation2 = new Label();
                lblAnimation2.Font = new Font("Segoe Script", 15, FontStyle.Bold);
                lblAnimation2.Size = new Size(300, 150);
                lblAnimation2.Location = new Point(10, 10);
                lblAnimation2.Text = "WELCOME TO QUIZ!..";
                this.Controls.Add(lblAnimation2);
                lblAnimation2.Click += new EventHandler(label2_click);

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
            int timeleft = 30;
            private void OnTimerEvent(object sender, EventArgs e)
            {
            Random rand = new Random();
            int A = rand.Next(0, 255);
            int R = rand.Next(0, 255);
            int G = rand.Next(0, 255);
            int B = rand.Next(0, 255);
            lblAnimation2.ForeColor = Color.FromArgb(A, R, G, B);
            if (timeleft > 0)
                {
                    timeleft = timeleft - 1;
                    lblAnimation1.Text = timeleft + "";
                }

                if (lblAnimation1.Text == "0")
                {
                    var questionOrderOption = new QuestionOrderOption();
                    Hide();
                    questionOrderOption.Show();
                    Close();

                }

                counter++;
                if (counter > len)
                {
                    counter = 0;
                    lblAnimation2.Text = "";
                }
                else
                lblAnimation2.Text = txt.Substring(0, counter);
            }

            private void label1_click(object sender, EventArgs e)
            {

            }

            private void label2_click(object sender, EventArgs e)
            {

            }

            private void JungleAnimal_Load(object sender, EventArgs e)
            {
                this.BackColor = Color.FromArgb(255, 232, 232);
                txt = lblAnimation2.Text;
                len = txt.Length;
                lblAnimation2.Text = "";
            }

        }

        public partial class QuestionOrderOption : Form
        {


            public QuestionOrderOption()

            {
            }
        }
    }


    

