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
        public delegate void StoreDataCallBack(int uId, string uFirstName, string uLastName, string uName, string uType);
        public StoreDataCallBack StoreData;
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
                string cmdString = "select id, firstName, lastName, name, password, type from users where name = @uName and password = @uPass";
                SqlCommand sqlCmd = new SqlCommand(cmdString, sqlCon);
                sqlCmd.Parameters.AddWithValue("@uName", txtUser.Text);
                sqlCmd.Parameters.AddWithValue("@uPass", txtPassword.Text);
                //SqlDataReader = read or retrieve data from database
                SqlDataReader read = sqlCmd.ExecuteReader();
                if (read.Read())
                {
                    User usr = new User();
                    usr.userID = int.Parse(read["id"].ToString());
                    usr.userFIRSTNAME = read["firstName"].ToString();
                    usr.userLASTNAME = read["lastName"].ToString();
                    usr.userNAME = read["name"].ToString();
                    usr.userTYPE = read["type"].ToString();
                    //MessageBox.Show(usr.userID + usr.userNAME + usr.userTYPE);
                    MessageBox.Show("Login Sucessfully");
                    UserType usrTypeInterface = new UserType();
                    this.Hide();
                    this.StoreData += new StoreDataCallBack(usrTypeInterface.GetData);
                    StoreData(usr.userID,usr.userFIRSTNAME,usr.userLASTNAME,usr.userNAME,usr.userTYPE);
                    //StoreData(usr.userID);
                    usrTypeInterface.Show();
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
