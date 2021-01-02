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
    public partial class Manager_Book_Search : Form
    {
        public Manager_Book_Search()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Connection = "datasource = localhost; username = root; password =; database = tiny_library";
            MySqlConnection DBconnect = new MySqlConnection(Connection);
            DBconnect.Open();
            if (Convert.ToString(this.comboBox2.SelectedItem) == "BookName")
            {
                MySqlDataAdapter Ad = new MySqlDataAdapter("SELECT * FROM `managerbookentry` WHERE `BookName` = '"+ this.textBox1.Text + "'", DBconnect);
                DataTable dt = new DataTable();
                Ad.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (Convert.ToString(this.comboBox2.SelectedItem) == "WriterName")
            {
                MySqlDataAdapter Ad = new MySqlDataAdapter("SELECT * FROM `managerbookentry` WHERE `WriterName` = '" + this.textBox1.Text + "'", DBconnect);
                DataTable dt = new DataTable();
                Ad.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (Convert.ToString(this.comboBox2.SelectedItem) == "CatagoryName")
            {
                MySqlDataAdapter Ad = new MySqlDataAdapter("SELECT * FROM `managerbookentry` WHERE `CatagoryName` = '" + this.textBox1.Text + "'", DBconnect);
                DataTable dt = new DataTable();
                Ad.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Manager_Function mf = new Manager_Function();
            this.Hide();
            mf.Show();
        }
    }
}
