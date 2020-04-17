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
    public partial class SIGNUP : Form
    {
        public SIGNUP()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\samya\Documents\discuss.mdf;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) From LOGIN Where userid = '" + textBox1.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(int.Parse(dt.Rows[0][0].ToString()) == 0)
            {
                label4.Text = textBox1.Text + " is available";
                this.label4.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                label4.Text = textBox1.Text + " is not available";
                this.label4.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\samya\Documents\discuss.mdf;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) From LOGIN Where userid = '" + textBox1.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (int.Parse(dt.Rows[0][0].ToString()) == 0)
            {
                label4.Text = textBox1.Text + " is available";
                this.label4.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                label4.Text = textBox1.Text + " is not available";
                this.label4.ForeColor = System.Drawing.Color.Red;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\samya\Documents\discuss.mdf;Integrated Security=True");
                con.Open();
            if (label4.ForeColor == System.Drawing.Color.Green)
            {
                if (textBox2.Text == textBox3.Text)
                {
                    SqlCommand cmd = new SqlCommand("Insert into Login(userid,Password) Values('" + textBox1.Text + "' ,'" + textBox3.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("user registered successfully!!!");
                    con.Close();
                }
                else
                {
                    MessageBox.Show("your password doesnt match!!!");
                }
            }
            else
            {
                MessageBox.Show("Please use available username!!!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
