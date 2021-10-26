using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseworkWeb
{
    public partial class Form2 : Form
    {
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;

        public Form2()
        {
            InitializeComponent();

            askQuestion(questionNumber);

            totalQuestions = 10;
        }

        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if (buttonTag == correctAnswer)
            {
                score++;
            }

            if (questionNumber == totalQuestions)
            {
                // work out the percentage

                percentage = (int)Math.Round((double)(score * 100) / totalQuestions);

                MessageBox.Show(
                    "Quiz Ended! Thank you for your answer." + Environment.NewLine +
                    "You have answered " + score + " questions correctly." + Environment.NewLine +
                    "Your total percentage is " + percentage + "%" + Environment.NewLine +
                    "Click OK to play again"
                    );

                score = 0;
                questionNumber = 0;
                askQuestion(questionNumber);

            }

            questionNumber++;
            askQuestion(questionNumber);

        }

        private void askQuestion(int qnum)
        {

            switch (qnum)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources._11;

                    label1.Text = "1. The elephant in the picture is the smaller of two elephant species. On which continent will you find it in the wild?";

                    button1.Text = "A. Africa";
                    button2.Text = "B. Asia";
                    button3.Text = "C. Australia";
                    button4.Text = "D. Europe";

                    correctAnswer = 1;

                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources._2;

                    label1.Text = "2. The giant panda, beloved all over the world, is considered a 'National Treasure  in which country?";

                    button1.Text = "A. Japan";
                    button2.Text = "B. Nepal";
                    button3.Text = "C. Tibet";
                    button4.Text = "D. China";

                    correctAnswer = 4;

                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources._3;

                    label1.Text = "3. The giraffe is the tallest land animal. Approximately how tall is it at maturity?";

                    button1.Text = "A. 10-14 feet";
                    button2.Text = "B. 14-18 feet";
                    button3.Text = "C. 6-10 feet";
                    button4.Text = "D. 8-12 feet";

                    correctAnswer = 2;

                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources._4;

                    label1.Text = "4. About how heavy are the largest rhinoceros?";
                    button1.Text = "A. 1500-2000 pounds";
                    button2.Text = "B. 1700-2500 pounds";
                    button3.Text = "C. 3500-5000 pounds";
                    button4.Text = "D. 5000-7500 pounds";

                    correctAnswer = 3;

                    break;

                case 5:
                    pictureBox1.Image = Properties.Resources._5;

                    label1.Text = "5. Which species of tiger was extinct at the start of the 21st century?";

                    button1.Text = "A. Siberian";
                    button2.Text = "B. Caspian";
                    button3.Text = "C. Bengal";
                    button4.Text = "D. Malayan";

                    correctAnswer = 4;

                    break;

                case 6:
                    pictureBox1.Image = Properties.Resources._6;

                    label1.Text = "6. What is the generic name for this ugly carrion-eating bird?";

                    button1.Text = "A. Golden Eagle";
                    button2.Text = "B. Vulture";
                    button3.Text = "C. Raven";
                    button4.Text = "D. Redtailed Hawk";

                    correctAnswer = 2;

                    break;

                case 7:
                    pictureBox1.Image = Properties.Resources._7;

                    label1.Text = "7. The zebra is an equid, a member of the horse family. About how fast can a zebra run?";

                    button1.Text = "A. Up to 25 miles per hour";
                    button2.Text = "B. Up to 5 miles per hour";
                    button3.Text = "C. Up to 35 miles per hour";
                    button4.Text = "D. Up to 15 miles per hour";

                    correctAnswer = 3;

                    break;

                case 8:
                    pictureBox1.Image = Properties.Resources._8;

                    label1.Text = "8. The common hippopotamus lives in lakes and rivers in the central part of Africa. About how long is the average hippo?";

                    button1.Text = "A. 10-16 feet";
                    button2.Text = "B. 7-10 feet";
                    button3.Text = "C. 4-7 feet";
                    button4.Text = "D. 18-20 feet";

                    correctAnswer = 1;

                    break;

                case 9:
                    pictureBox1.Image = Properties.Resources._9;

                    label1.Text = "9. What does the name 'orangutan' mean?";

                    button1.Text = "A. Tree swinger";
                    button2.Text = "B. Orange ape";
                    button3.Text = "C. Person of the forest";
                    button4.Text = "D. Hairy beast";

                    correctAnswer = 3;

                    break;

                case 10:
                    pictureBox1.Image = Properties.Resources._10;

                    label1.Text = "10. The okapi is a relative of which animal?";

                    button1.Text = "A. Llama";
                    button2.Text = "B. Giraffe";
                    button3.Text = "C. Camel";
                    button4.Text = "D. Zebra";

                    correctAnswer = 2;

                    break;

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you wish to quit?", "Exit Application", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var newform = new Form1();
            newform.Show();
        }
    }
}
