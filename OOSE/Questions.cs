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
    public partial class Questions : Form
    {
        string connection_string = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\samya\Documents\discuss.mdf;Integrated Security=True";

        public Questions(string userid)
        {
            InitializeComponent();
            label3.Text = userid;

        }


        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\samya\Documents\discuss.mdf;Integrated Security=True");
            con.Open();
            
                
            
                SqlCommand cmd = new SqlCommand("Insert into Ques(Question,CategoryId,UserId) Values('" + textBox1.Text + "' ,'" + textBox2.Text + "','" + label3.Text + "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Question added successfully!!!");
            
            con.Close();

        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
