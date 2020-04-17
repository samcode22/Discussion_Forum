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
    public partial class ShowTopics : Form
    {
        string connection_string = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\samya\Documents\discuss.mdf;Integrated Security=True";

        public ShowTopics(string userid)
        {
            InitializeComponent();
            label1.Text = userid;

           
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connection_string))
            {
                con.Open();
                SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM Category", con);
                DataTable dtbl = new DataTable();
                cmd.Fill(dtbl);
                dataGridView1.DataSource = dtbl;


                DataGridViewLinkColumn link = new DataGridViewLinkColumn();
                dataGridView1.Columns.Add(link);
                link.HeaderText = "Link";
                link.Name = "View_Topic";
                link.Text = "view_questions";
                link.UseColumnTextForLinkValue = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Questionlist q = new Questionlist(e, label1.Text);
            q.Show();
        }
    }
}
