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
    public partial class Questionlist : Form
    {
        string connection_string = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\samya\Documents\discuss.mdf;Integrated Security=True";

        public Questionlist(DataGridViewCellEventArgs e,string userid)
        {
            InitializeComponent();
            label1.Text = userid;
            if (e.ColumnIndex == 2)
            {
                //MessageBox.Show(e.RowIndex.ToString());
                using (SqlConnection con = new SqlConnection(connection_string))
                {
                    con.Open();
                    int i = e.RowIndex + 1;
                    if (i == 1)
                    {
                        SqlDataAdapter cmd = new SqlDataAdapter("SELECT UserId,Question FROM Ques where CategoryId = 1", con);
                        DataTable dt = new DataTable();
                        cmd.Fill(dt);
                        dataGridView1.DataSource = dt;

                        DataGridViewButtonColumn link = new DataGridViewButtonColumn();
                        dataGridView1.Columns.Add(link);
                        link.HeaderText = "Answers";
                        link.Name = "View_Topic";
                        link.Text = "Answers";
                        link.UseColumnTextForButtonValue = true;

                    }
                    if (i == 2)
                    {
                        SqlDataAdapter cmd = new SqlDataAdapter("SELECT UserId,Question FROM Ques where CategoryId = 2", con);
                        DataTable dt = new DataTable();
                        cmd.Fill(dt);
                        dataGridView1.DataSource = dt;
                        DataGridViewButtonColumn link = new DataGridViewButtonColumn();
                        dataGridView1.Columns.Add(link);
                        link.HeaderText = "Answers";
                        link.Name = "View_Topic";
                        link.Text = "Answers";
                        link.UseColumnTextForButtonValue = true;
                    }
                    if (i == 3)
                    {
                        SqlDataAdapter cmd = new SqlDataAdapter("SELECT UserId,Question FROM Ques where CategoryId = 3", con);
                        DataTable dt = new DataTable();
                        cmd.Fill(dt);
                        dataGridView1.DataSource = dt;
                        DataGridViewButtonColumn link = new DataGridViewButtonColumn();
                        dataGridView1.Columns.Add(link);
                        link.HeaderText = "Answers";
                        link.Name = "View_Topic";
                        link.Text = "Answers";
                        link.UseColumnTextForButtonValue = true;
                    }
                    if (i == 4)
                    {
                        SqlDataAdapter cmd = new SqlDataAdapter("SELECT UserId,Question FROM Ques where CategoryId = 4", con);
                        DataTable dt = new DataTable();
                        cmd.Fill(dt);
                        dataGridView1.DataSource = dt;
                        DataGridViewButtonColumn link = new DataGridViewButtonColumn();
                        dataGridView1.Columns.Add(link);
                        link.HeaderText = "Answers";
                        link.Name = "View_Topic";
                        link.Text = "Answers";
                        link.UseColumnTextForButtonValue = true;
                    }
                    if (i == 5)
                    {
                        SqlDataAdapter cmd = new SqlDataAdapter("SELECT UserId,Question FROM Ques where CategoryId = 5", con);
                        DataTable dt = new DataTable();
                        cmd.Fill(dt);
                        dataGridView1.DataSource = dt;
                        DataGridViewButtonColumn link = new DataGridViewButtonColumn();
                        dataGridView1.Columns.Add(link);
                        link.HeaderText = "Answers";
                        link.Name = "View_Topic";
                        link.Text = "Answers";
                        link.UseColumnTextForButtonValue = true;
                    }

                }
            }

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Answer a = new Answer(e,label1.Text);

            a.Show();
                
                   }
    }
}
