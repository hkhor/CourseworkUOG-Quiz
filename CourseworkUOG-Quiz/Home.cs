using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            public JungleAnimal()

            {
 

            }

        }

        public partial class Bird : Form
        {
            public Bird()
            {

            }
        }

        public partial class AquaticAnimal : Form
        {
            public AquaticAnimal()
            {

            }
        }
    }
}
    

