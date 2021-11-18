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
    public partial class UserType : Form
    {
        public UserType()
        {
            InitializeComponent();
            
        }

        //Delegate Data from form Login
        public void GetData(int uID,string uFirstName, string uLastName, string uName, string type )
        {
            try
            {
                User usr = new User();
                usr.userID = uID;
                usr.userFIRSTNAME = uFirstName;
                usr.userLASTNAME = uLastName;
                usr.userNAME = uName;
                usr.userTYPE = type;

                lblTitle.Text = "Welcome, " + usr.userFIRSTNAME + " " + usr.userLASTNAME;

                if (usr.userTYPE == "normal")
                {
                    Button btnUser = new Button();
                    btnUser.Text = "Play Game";
                    btnUser.AutoSize = true;
                    btnUser.Font = new Font("Open Sans", 18);
                    btnUser.Location = new Point(200, 200);
                    this.Controls.Add(btnUser);
                    btnUser.Click += (s, e) => {
                        this.Hide();
                        Home hm = new Home();
                        hm.Show();
                    };

                }
                else if (usr.userTYPE == "admin")
                {
                    Button btnUser = new Button();
                    btnUser.Text = "Play Game";
                    btnUser.AutoSize = true;
                    btnUser.Font = new Font("Open Sans", 18);
                    btnUser.Location = new Point(150, 200);
                    this.Controls.Add(btnUser);
                    Button btnAdmin = new Button();
                    btnAdmin.Text = "Edit Quiz";
                    btnAdmin.AutoSize = true;
                    btnAdmin.Font = new Font("Open Sans", 18);
                    btnAdmin.Location = new Point(300, 200);
                    this.Controls.Add(btnAdmin);
                    btnUser.Click += (s, e) => {
                        this.Hide();
                        Home hm = new Home();
                        hm.Show();
                    };

                    btnAdmin.Click += (s, e) =>
                    {
                        this.Hide();
                        AdminPage adm = new AdminPage();
                        adm.Show();
                    };



                }
                else
                {
                    MessageBox.Show("Unable To Detect User Type");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
