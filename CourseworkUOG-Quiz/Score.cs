using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CourseworkUOG_Quiz
{
    public partial class Score : Form
    {
        SqlConnection sqlCon = new SqlConnection("Data Source=MAS-CHKHOR-NB;Initial Catalog=animalQuiz;Integrated Security=True");
        public Score()
        {
            InitializeComponent();
        }

        private void Score_Load(object sender, EventArgs e)
        {

            SqlCommand cmdString = new SqlCommand("SELECT * FROM score",sqlCon);
            SqlDataAdapter da = new SqlDataAdapter(cmdString);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridViewShowAnsweredQuestion.DataSource = table;
        }
    }
}
