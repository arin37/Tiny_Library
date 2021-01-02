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
    public partial class Manager_Delete_Book : Form
    {
        public Manager_Delete_Book()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            string Connection = "datasource = localhost; username = root; password =; database = tiny_library";
            MySqlConnection DBconnect = new MySqlConnection(Connection);
            DBconnect.Open();
            if (Convert.ToString(this.comboBox1.SelectedItem) == "BookName")
            {
                MySqlCommand cmd = new MySqlCommand("DELETE FROM `managerbookentry` WHERE `BookName` = '" + this.textBox1.Text + "'", DBconnect);
                MySqlDataAdapter ad1 = new MySqlDataAdapter("Select * From managerbookentry where BookName = '" + this.textBox1.Text + "'", DBconnect);
                DataTable dt = new DataTable();
                ad1.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Delete");
                }
                else
                {
                    MessageBox.Show("No such entry");
                }
            }
            else if (Convert.ToString(this.comboBox1.SelectedItem) == "WriterName")
            {
                MySqlCommand cmd = new MySqlCommand("DELETE FROM `managerbookentry` WHERE `WriterName` = '" + this.textBox1.Text + "'", DBconnect);
                MySqlDataAdapter ad1 = new MySqlDataAdapter("Select * From managerbookentry where WriterName = '" + this.textBox1.Text + "'", DBconnect);
                DataTable dt = new DataTable();
                ad1.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Delete");
                }
                else
                {
                    MessageBox.Show("No such entry");
                }
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Manager_Function mf = new Manager_Function();
            this.Hide();
            mf.Show();
        }
    }
}
