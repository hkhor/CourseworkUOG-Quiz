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
    public partial class Form3 : Form
    {
        // create a new list of integers called question numbers
        // this interger will hold how many questions we have for this quiz and we will shuffle this inside the start game function
        List<int> questionNumbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // create 3 more integers called qNum that will control which question shows on the screen, i and score
        int qNum = 0;
        int i;
        int score;
        int correctAnswer;


        public Form3()
        {
            // inside of the main constructor we will run the start game and next question function

            InitializeComponent();


            StartGame();
            NextQuestion();

        }

        private void askQuestion(List<int> questionNumbers)
        {
            throw new NotImplementedException();
        }

        private void checkAnswerEvent(object sender, MouseEventArgs e)
        {
            // this is the check answer event, this event is linked to each button on the canvas
            // when either of the buttons will be pressed we will run this event

            var senderObject = (RadioButton)sender; // first check which button sent this event and link it to a local button inside of this event
            int radiobuttontag = Convert.ToInt32(senderObject.Tag);

            // in the if statement below we will check if the button clicked on has a 1 tag inside of it, if it does then we will add 1 to the score
            if (radiobuttontag == correctAnswer)
            {
                score++;
            }

            // if the qnum is less than 0 then we will reset the qnum integer to 0
            if (qNum < 0)
            {
                qNum = 0;
            }
            else
            {
                // if the qnum is greater than 0 then we will add 1 to the qnum integer
                qNum++;
            }

            // update the score text label each time the buttons are pressed
            label1.Text = "Answered Correctly " + score + "/" + questionNumbers.Count;

            // run the next question function
            NextQuestion();
        }
        private void RestartGame()
        {
            // restart game function will load all of the default values for this game
            score = 0; // set score to 0
            qNum = -1; // set qnum to -1
            i = 0; // set i to 0
            StartGame(); // run the start game function
        }

        private void NextQuestion()
        {
            if (qNum < questionNumbers.Count)
            {
                i = questionNumbers[qNum];
            }
            else
            {
                // if we have done below the number of questions we have available then we will restart the game
                RestartGame();
            }

            switch (i)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources._111;

                    label3.Text = "1. What is the largest tree-dwelling mammal in Australian forests?";

                    radioButton1.Text = "Tree kangaroo";
                    radioButton2.Text = "Common ringtail possum";
                    radioButton3.Text = "Koala";
                    radioButton4.Text = "Wombat";

                    correctAnswer = 1;

                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources._222;

                    label3.Text = "2. Giant pandas live in bamboo forests and in zoos around the world. What is the typical gestational period of the giant panda?";

                    radioButton1.Text = "Approximately 60-75 days";
                    radioButton2.Text = "Approximately 90-160 days";
                    radioButton3.Text = "Approximately 165-180 days";
                    radioButton4.Text = "Approximately 185-195 days";

                    correctAnswer = 2;

                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources._333;

                    label3.Text = "3. Which large mammal is known as a 'true forest gardener' because some forest fruits will only germinate after passing through its digestive system?";

                    radioButton1.Text = "African bush elephant";
                    radioButton2.Text = "African forest elephant";
                    radioButton3.Text = "Asian elephant";
                    radioButton4.Text = "Sub-Asian elephant";

                    correctAnswer = 2;

                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources._1113;

                    label3.Text = "4. Rockhopper penguins are found on which of these islands?";

                    radioButton1.Text = "Sicily";
                    radioButton2.Text = "Java";
                    radioButton3.Text = "Falkland Islands";
                    radioButton4.Text = "Hawaiian Islands";

                    correctAnswer = 3;

                    break;

                case 5:
                    pictureBox1.Image = Properties.Resources._555;

                    label3.Text = "5. Which owl is named after the forest in which it lives?";
                    radioButton1.Text = "Daintree owl";
                    radioButton2.Text = "Boreal owl";
                    radioButton3.Text = "Redwood owl";
                    radioButton4.Text = "Jiuzhaigou owl";

                    correctAnswer = 2;

                    break;

                case 6:
                    pictureBox1.Image = Properties.Resources._666;

                    label3.Text = "6. Which of these forest-dwelling mammals has earthworms as their most important food source?";

                    radioButton1.Text = "European skunk";
                    radioButton2.Text = "Wolverine";
                    radioButton3.Text = "Black footed ferret";
                    radioButton4.Text = "Eurasian badger";

                    correctAnswer = 4;

                    break;

                case 7:
                    pictureBox1.Image = Properties.Resources._777;

                    label3.Text = "7. From the musical 'Hairspray', how does 'Motormouth'' Maybelle describe herself during a party at her record store?";

                    radioButton1.Text = "Timid, Shy And Inquistive";
                    radioButton2.Text = "Hairy And Horny";
                    radioButton3.Text = "big, Blonde and Beautiful";
                    radioButton4.Text = "Wild and free";

                    correctAnswer = 3;

                    break;

                case 8:
                    pictureBox1.Image = Properties.Resources._888;

                    label3.Text = "8. A subspecies of the Eurasian lynx is found in Finland in relatively healthy numbers. Which graceful ungulate, introduced from North America in the 1930s, is one of their favourite preys?";

                    radioButton1.Text = "white-tailed deer";
                    radioButton2.Text = "Barbary sheep";
                    radioButton3.Text = "water buffalo";
                    radioButton4.Text = "Greenland muskox";

                    correctAnswer = 1;


                    break;
                case 9:
                    pictureBox1.Image = Properties.Resources._999;

                    label3.Text = "9. The heraldic animal of the western region of Ostrobothnia, ermine is the name given to which small carnivore in its winter coat?";

                    radioButton1.Text = "fox";
                    radioButton2.Text = "stoat";
                    radioButton3.Text = "otter";
                    radioButton4.Text = "mongoose";

                    correctAnswer = 2;


                    break;
                case 10:
                    pictureBox1.Image = Properties.Resources._1112;

                    label3.Text = "10. As its name suggests, the Carpathian blue slug is endemic to the Carpathian mountain range. Where would you not be able to find it?";

                    radioButton1.Text = "Slovakia";
                    radioButton2.Text = "Lithuania";
                    radioButton3.Text = "Romania";
                    radioButton4.Text = "Ukraine";

                    correctAnswer = 2;


                    break;
            }
        }
        private void StartGame()
        {
            // this is the start game function
            // inside of this function we will randomise the questions list and save it back into the list 

            // create a new randomlist variable and use the line below to randomise the order of the content
            var randomList = questionNumbers.OrderBy(a => Guid.NewGuid()).ToList();

            // save the random list to the question numbers list again
            questionNumbers = randomList;

            // empty the question order label on the canvas
            label2.Text = null;

            // run a for loop to add the value which will display the randomised list to the display so we can see how the list has been ramdomised
            for (int i = 0; i < questionNumbers.Count; i++)
            {
                label2.Text += " " + questionNumbers[i].ToString();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            var newform = new Form1();
            newform.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you wish to quit?", "Exit Application", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}





