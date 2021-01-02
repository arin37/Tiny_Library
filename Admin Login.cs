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
    public partial class Admin_Login : Form
    {
        public int Flag;
        public Admin_Login()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Users_Form us = new Users_Form();
            us.Show();
        }
        private void ok_Click(object sender, EventArgs e)
        {
            string Connection = "datasource = localhost; username = root; password =; database = tiny_library";
            MySqlConnection DBconnect = new MySqlConnection(Connection);
            DBconnect.Open();
            if(Flag == 0)
            {
                MySqlDataAdapter ad1 = new MySqlDataAdapter("Select * From login where UserName = '" + textBox1.Text.Trim() + "'and Password = '" + textBox2.Text.Trim() + " ' ", DBconnect);
                DataTable dt = new DataTable();
                ad1.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    Admin_Manager_Create ad_mg = new Admin_Manager_Create();
                    DBconnect.Close();
                    this.Hide();
                    ad_mg.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect Username or Password");
                }
            }
            else if(Flag == 1)
            {
                MySqlDataAdapter ad1 = new MySqlDataAdapter("Select * From managerlogin where MUserName = '" + textBox1.Text.Trim() + "'and MPassword = '" + textBox2.Text.Trim() + " ' ", DBconnect);
                MySqlCommand mc = new MySqlCommand();
                DataTable dt = new DataTable();
                ad1.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    Manager_Function mf = new Manager_Function();
                    this.Hide();
                    mf.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect Username or Password");
                }
            }
            
        }
    }
}