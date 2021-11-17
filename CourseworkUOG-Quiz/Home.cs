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
        public Button button1;
        public Button button2;
        public RadioButton radioButton1;
        public RadioButton radioButton2;
        public RadioButton radioButton3;
        public Label label1;

        
        public Home()
        {
            InitializeComponent();

        }


        private void Home_Load(object sender, EventArgs e)
        {
            button1 = new Button();
            button1.Size = new Size(100, 40);
            button1.Location = new Point(125, 200);
            button1.Text = "Start Quiz";
            this.Controls.Add(button1);
            button1.Click += new EventHandler(button1_click);

            button2 = new Button();
            button2.Size = new Size(100, 40);
            button2.Location = new Point(375, 200);
            button2.Text = "Exit";
            this.Controls.Add(button2);
            button2.Click += new EventHandler(button2_click);

            radioButton1 = new RadioButton();
            radioButton1.Size = new Size(100, 100);
            radioButton1.Location = new Point(120, 100);
            radioButton1.Text = "JungleAnimal";
            this.Controls.Add(radioButton1);
            radioButton1.Click += new EventHandler(radioButton1_click);

            radioButton2 = new RadioButton();
            radioButton2.Size = new Size(100, 100);
            radioButton2.Location = new Point(250, 100);
            radioButton2.Text = "Bird";
            this.Controls.Add(radioButton2);
            radioButton2.Click += new EventHandler(radioButton2_click);

            radioButton3 = new RadioButton();
            radioButton3.Size = new Size(100, 100);
            radioButton3.Location = new Point(370, 100);
            radioButton3.Text = "AquaticAnimal";
            this.Controls.Add(radioButton3);
            radioButton3.Click += new EventHandler(radioButton3_click);

            label1 = new Label();
            label1.Size = new Size(250, 250);
            label1.Location = new Point(250, 50);
            label1.Text = "Zoology QUIZ";
            this.Controls.Add(label1);
            label1.Click += new EventHandler(label1_click);

        }


        
        private void button1_click(object sender, EventArgs e)
        {

            if (radioButton1.Checked == true)
            {
                var newform = new JungleAnimal();
                button1.Dispose();
                newform.Show();
            }


            else if (radioButton2.Checked == true)
            {
                var newform = new Bird();
                newform.Show();
            }
            else if (radioButton3.Checked == true)
            {
                var newform = new AquaticAnimal();
                newform.Show();
            }
        }
        private void button2_click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you wish to quit?", "Exit Application", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void radioButton1_click(object sender, EventArgs e)
        {

        }

        private void radioButton2_click(object sender, EventArgs e)
        {

        }

        private void radioButton3_click(object sender, EventArgs e)
        {

        }

        private void label1_click(object sender, EventArgs e)
        {

        }

        [STAThread]
        static void main()
        {
            Application.EnableVisualStyles();
            Application.Run(new Home());
        }

        public partial class JungleAnimal : Form
        {
            public Label label1;
            public Label label2;
            public Timer timer1;

            public JungleAnimal()

            {

                label1 = new Label();
                label1.Font= new Font("ALGERIAN", 30, FontStyle.Bold);
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
            private void OnTimerEvent(object sender,EventArgs e)
            {
                if (timeleft > 0)
                {
                    timeleft = timeleft - 1;
                    label1.Text = timeleft + "";
                }
                
                if (label1.Text == "0")
                {
                    var Form1 = new Form1();
                    Hide();
                    Form1.Show();
                    Close();

                }

                counter++;
                if(counter > len)
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

        public partial class Bird : Form
        {
            public Label label1;
            public Label label2;
            public Timer timer1;
            public Bird()
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

                Load += new EventHandler(Bird_Load);

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
                    var Form1 = new Form1();
                    Hide();
                    Form1.Show();
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

            private void Bird_Load(object sender, EventArgs e)
            {
                txt = label2.Text;
                len = txt.Length;
                label2.Text = "";
            }
        }

        public partial class AquaticAnimal : Form
        {
            public Label label1;
            public Label label2;
            public Timer timer1;
            public AquaticAnimal()
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

                Load += new EventHandler(Aquatic_Load);

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
                    var Form1 = new Form1();
                    Hide();
                    Form1.Show();
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

            private void Aquatic_Load(object sender, EventArgs e)
            {
                txt = label2.Text;
                len = txt.Length;
                label2.Text = "";
            }
        }
      

        public partial class Form1 : Form
        {


            public Form1()
            {
            }
                

        }

        public partial class Form2 : Form
        {


            public Form2()
            {
            }


        }

        public partial class Form3 : Form
        {


            public Form3()
            {
            }


        }
    }
}
    

