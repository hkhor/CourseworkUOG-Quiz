using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;

namespace CourseworkUOG_Quiz
{
    public partial class Score : Form
    {
        int y;
        Thread t;
        SqlConnection sqlCon = new SqlConnection("Data Source=MAS-CHKHOR-NB;Initial Catalog=animalQuiz;Integrated Security=True");
        public Score()
        {
            InitializeComponent();
            t = new Thread(RunAnimation);
        }

        public void RunAnimation()
        {
            int dy = 2;
            y = 1;
            while(true)
            {
                for (int i = 0; i < 150; i++)
                {
                    y += dy;
                    Invalidate();
                    Thread.Sleep(10);
                }
                dy = -dy;
            }

  
            }

        private void Score_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.FillEllipse(Brushes.Blue, 150, y, 9, 9);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            t.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            t.Abort();
            t.Join();
        }
    }
  
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
