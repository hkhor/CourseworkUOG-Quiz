using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*Import*/
using System.Data.SqlClient;
using System.Configuration;

namespace CourseworkUOG_Quiz
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btbRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register rgt = new Register();
            rgt.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Data Source = server name
            //Initial Catalog = database name
            SqlConnection sqlCon = new SqlConnection("Data Source=MAS-CHKHOR-NB;Initial Catalog=animalQuiz;Integrated Security=True");
            try
            {
                sqlCon.Open();
                //always start with Command
                string cmdString = "select id, name, password from users where name = @uName and password = @uPass";
                SqlCommand sqlCmd = new SqlCommand(cmdString, sqlCon);
                sqlCmd.Parameters.AddWithValue("@uName", txtUser.Text);
                sqlCmd.Parameters.AddWithValue("@uPass", txtPassword.Text);
                //SqlDataReader = read or retrieve data from database
                SqlDataReader read = sqlCmd.ExecuteReader();
                if (read.Read())
                {
                    User usr = new User();
                    usr.userID = int.Parse(read["id"].ToString());
                    usr.userNAME = read["name"].ToString();
                    MessageBox.Show("Login Sucessfully");
                    Home home = new Home();
                    this.Hide();
                    home.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password");
                    txtUser.Text = "";
                    txtPassword.Text = "";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }
        }
    }
}
