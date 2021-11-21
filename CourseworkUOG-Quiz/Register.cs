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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //Data Source = server name
            //Initial Catalog = database name
            SqlConnection sqlCon = new SqlConnection("Data Source=MAS-CHKHOR-NB;Initial Catalog=animalQuiz;Integrated Security=True");
            try
            {
                sqlCon.Open();
                //always start with Command
                if(txtPassword.Text == txtConfirmPassword.Text)
                {
                    var type = "normal";
                    string cmdString = "INSERT INTO users(firstName,lastName, name, password, email, age, type) VALUES (@fName, @lName, @userName, @userPassword, @userEmail, @userAge, @usertype)";
                    SqlCommand sqlCmd = new SqlCommand(cmdString, sqlCon);
                    sqlCmd.Parameters.AddWithValue("@fName", txtFirstName.Text);
                    sqlCmd.Parameters.AddWithValue("@lName", txtLastName.Text);
                    sqlCmd.Parameters.AddWithValue("@userName", txtUsername.Text);
                    sqlCmd.Parameters.AddWithValue("@userPassword", txtPassword.Text);
                    sqlCmd.Parameters.AddWithValue("@userEmail", txtEmail.Text);
                    sqlCmd.Parameters.AddWithValue("@userAge", txtAge.Text);
                    sqlCmd.Parameters.AddWithValue("@userType", type);
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Sucessfully Register");
                    this.Hide(); // Hide Register Page
                    Login lgn = new Login(); // Create New Form Object;
                    lgn.Show();// Show Login Page


                }
                else
                {
                    MessageBox.Show("Invalid Password");
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally { sqlCon.Close(); }
            
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lgn = new Login();
            lgn.Show();
        }
    }
}
