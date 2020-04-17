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
namespace OOSE
{
    public partial class Answer : Form
    {
        string connection_string = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\samya\Documents\discuss.mdf;Integrated Security=True";

        public Answer(DataGridViewCellEventArgs e, string userid)
        {
            InitializeComponent();
            label1.Text = userid;
            if (e.ColumnIndex == 2)
            {
                using (SqlConnection con = new SqlConnection(connection_string))
                {
                    con.Open();
                    int i = e.RowIndex + 1;
                    if (i == 1)
                    {
                        SqlDataAdapter cmd = new SqlDataAdapter("SELECT UserId,Answer FROM Answer where QuestionId = 1", con);
                        DataTable dt = new DataTable();
                        cmd.Fill(dt);
                        dataGridView1.DataSource = dt;

                    

                    }
                    if (i == 2)
                    {
                        SqlDataAdapter cmd = new SqlDataAdapter("SELECT UserId,Question FROM Ques where CategoryId = 2", con);
                        DataTable dt = new DataTable();
                        cmd.Fill(dt);
                        dataGridView1.DataSource = dt;
                       
                    }
                    if (i == 3)
                    {
                        SqlDataAdapter cmd = new SqlDataAdapter("SELECT UserId,Question FROM Ques where CategoryId = 3", con);
                        DataTable dt = new DataTable();
                        cmd.Fill(dt);
                        dataGridView1.DataSource = dt;
                       
                    }
                    if (i == 4)
                    {
                        SqlDataAdapter cmd = new SqlDataAdapter("SELECT UserId,Question FROM Ques where CategoryId = 4", con);
                        DataTable dt = new DataTable();
                        cmd.Fill(dt);
                        dataGridView1.DataSource = dt;
                       
                    }
                    if (i == 5)
                    {
                        SqlDataAdapter cmd = new SqlDataAdapter("SELECT UserId,Question FROM Ques where CategoryId = 5", con);
                        DataTable dt = new DataTable();
                        cmd.Fill(dt);
                        dataGridView1.DataSource = dt;
                     
                    }

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
