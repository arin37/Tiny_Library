using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Tiny_Library_Book_Store_Management_System
{
    public partial class Admin_Manager_Create : Form
    {
        public Admin_Manager_Create()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Connection = "datasource = localhost; username = root; password =; database = tiny_library";
            MySqlConnection DBconnect = new MySqlConnection(Connection);
            DBconnect.Open();
            MySqlDataAdapter Ad = new MySqlDataAdapter("Select * From managerlogin", DBconnect);
            DataTable dt = new DataTable();
            Ad.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string Connection = "datasource = localhost; username = root; password =; database = tiny_library";
            MySqlConnection DBconnect = new MySqlConnection(Connection);
            DBconnect.Open();
            MySqlCommand cmd = new MySqlCommand("Insert into managerlogin(MUsername,MPassword)Values('" + this.textBox1.Text + "', '" + this.textBox2.Text + "')", DBconnect);
            if((textBox1.Text == "") || (textBox2.Text == ""))
            {
                MessageBox.Show("Enter 'Manager Name' or 'Password'");
            }
            else
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Saved");
                MySqlDataAdapter Ad = new MySqlDataAdapter("Select * From managerlogin", DBconnect);
                DataTable dt = new DataTable();
                Ad.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string Connection = "datasource = localhost; username = root; password =; database = tiny_library";
            MySqlConnection DBconnect = new MySqlConnection(Connection);
            DBconnect.Open();
            MySqlCommand cmd = new MySqlCommand("Delete From managerlogin where MUsername = '"+ this.textBox3.Text +"'", DBconnect);
            if (textBox3.Text == "")
            {
                MessageBox.Show("Enter 'Manager Name'");
            }
            else
            {
                MySqlDataAdapter ad1 = new MySqlDataAdapter("Select * From managerlogin where MUserName = '" + this.textBox3.Text +"'", DBconnect);
                DataTable dt = new DataTable();
                ad1.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Delete");
                    MySqlDataAdapter Ad = new MySqlDataAdapter("Select * From managerlogin", DBconnect);
                    DataTable dt1 = new DataTable();
                    Ad.Fill(dt1);
                    dataGridView1.DataSource = dt1;
                }
                else
                {
                    MessageBox.Show("No such entry");
                }
             }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Users_Form us = new Users_Form();
            us.Show();
        }
    }
}
