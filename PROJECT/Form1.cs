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
namespace PROJECT
{
    public partial class Form2 : Form
    {
        SqlConnection con = SQL.Sqlconnection();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = textBox1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Query = "Select* From LOGIN Where USERNAME='" + textBox1.Text.Trim() + "'and PASSWORD='" + textBox2.Text.Trim() + "'";
            //SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            DataTable dt = SQL.select(Query,con);
            //sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                HOME H = new HOME();
                this.Hide();
                H.Show();
            }
            else
            {
                MessageBox.Show("CHECK YOUR USERNAME OR PASSWORD");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
