using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOSE
{
    public partial class Answerview : Form
    {
        string connection_string = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\samya\Documents\discuss.mdf;Integrated Security=True";

        public Answerview(string s)
        {
            InitializeComponent();
            textBox1.Text = s;
        }

        private void Answerview_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connection_string))
            {
                con.Open();
                string s = textBox1.Text;
                SqlDataAdapter cmd = new SqlDataAdapter("SELECT Answer FROM Answer,Questions where Answer.Question = '" + textBox1.Text + "'", con);
                DataTable dt = new DataTable();
                cmd.Fill(dt);
                dataGridView1.DataSource = dt;



            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
