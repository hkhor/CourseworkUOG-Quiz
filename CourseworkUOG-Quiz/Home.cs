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
            }

            else if (radioButton2.Checked == true)
            {
                var newform = new Animation();
                newform.Show();
            }
            else if (radioButton3.Checked == true)
            {
                var newform = new Animation();
                newform.Show();
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
        int timeleft = 30;
        private void OnTimerEvent(object sender, EventArgs e)
        {
            if (timeleft > 0)
            {
                timeleft = timeleft - 1;
                label1.Text = timeleft + "";
            }

            if (label1.Text == "0")
            {
                var Question = new Question();
                Hide();
                Question.Show();
                Close();

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

    public partial class Question : Form
    {


        public Question()

        {
        }
    }
}
