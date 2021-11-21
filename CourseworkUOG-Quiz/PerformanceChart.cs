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
    public partial class PerformanceChart : Form
    {
        Player ply = new Player();
        public PerformanceChart()
        {
            InitializeComponent();
        }

        public void GetDataFromUserType(int uID)
        {
            try
            {
                ply.userID = uID;
                SetGraph();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void SetGraph()
        {
            SqlConnection sqlCon = new SqlConnection("Data Source=MAS-CHKHOR-NB;Initial Catalog=animalQuiz;Integrated Security=True");
            try
            {
                SqlCommand cmdString = new SqlCommand("SELECT * FROM user_pastscore WHERE user_Id = @userId", sqlCon);
                cmdString.Parameters.AddWithValue("@userId", ply.userID);
                SqlDataAdapter da = new SqlDataAdapter(cmdString);
                DataSet ds = new DataSet();
                da.Fill(ds);
                this.chartPerformance.DataSource = ds.Tables[0];

                this.chartPerformance.Series[0].XValueMember = "session";

                this.chartPerformance.Series[0].YValueMembers = "score";

                this.chartPerformance.DataBind();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
