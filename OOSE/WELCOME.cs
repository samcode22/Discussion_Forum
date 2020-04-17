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
    public partial class WELCOME : Form
    {


        string connection_string = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\samya\Documents\discuss.mdf;Integrated Security=True";

        public WELCOME(string userid)
        {
            InitializeComponent();
            label2.Text = userid;

           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            Login_Page ss = new Login_Page();
            ss.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Category cc = new Category();
            cc.Show();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            ShowTopics st = new ShowTopics(label2.Text);
            st.Show();

            
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            Questions s = new Questions(label2.Text);
            s.Show();


        }
    }
    }

