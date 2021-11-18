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
    public partial class Quiz : Form
    {

        public Quiz()
        {
            InitializeComponent();
            function();
        }
        Player player = new Player();
        private void function()
        {
            Button btnUser = new Button();
            btnUser.Text = player.userID.ToString();
            btnUser.AutoSize = true;
            btnUser.Font = new Font("Open Sans", 18);
            btnUser.Location = new Point(150, 200);
            this.Controls.Add(btnUser);
            //MessageBox.Show(player.userID + player.quizCATEGORIES);
        }
        public void GetDatafromHome(int pID, string plyCategories)
        {
            try
            {

                player.userID = pID;
                player.quizCATEGORIES = plyCategories;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
