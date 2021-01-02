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
    public partial class Manager_Edit_Book_Info : Form
    {
        public Manager_Edit_Book_Info()
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
                MySqlDataAdapter Ad = new MySqlDataAdapter("SELECT * FROM `managerbookentry` WHERE `BookName` = '" + this.textBox3.Text + "'", DBconnect);
                DataTable dt = new DataTable();
                Ad.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (Convert.ToString(this.comboBox1.SelectedItem) == "WriterName")
            {
                MySqlDataAdapter Ad = new MySqlDataAdapter("SELECT * FROM `managerbookentry` WHERE `WriterName` = '" + this.textBox3.Text + "'", DBconnect);
                DataTable dt = new DataTable();
                Ad.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (Convert.ToString(this.comboBox1.SelectedItem) == "CatagoryName")
            {
                MySqlDataAdapter Ad = new MySqlDataAdapter("SELECT * FROM `managerbookentry` WHERE `CatagoryName` = '" + this.textBox3.Text + "'", DBconnect);
                DataTable dt = new DataTable();
                Ad.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            string Connection = "datasource = localhost; username = root; password =; database = tiny_library";
            MySqlConnection DBconnect = new MySqlConnection(Connection);
            DBconnect.Open();
            this.textBox5.Text = Convert.ToString(Convert.ToInt32(this.textBox4.Text) + Convert.ToInt32(this.textBox5.Text));
            MySqlCommand cmd = new MySqlCommand("DELETE FROM `managerbookentry` WHERE `BookName` = '" + textBox1.Text + "'", DBconnect);
            cmd.ExecuteNonQuery();
            MySqlCommand cmd1 = new MySqlCommand("INSERT INTO `managerbookentry`(`BookName`, `BookPublishYear`, `WriterName`, `QuantityOfBook`, `CatagoryName`, `EntryDate`, `AvaliableBook`) VALUES ('" + this.textBox1.Text + "','" + this.comboBox2.SelectedItem + "','" + this.textBox2.Text + "', '" + this.textBox5.Text + "', '" + this.comboBox3.SelectedItem + "', '" + this.dateTimePicker2.Text + "', '" + this.textBox5.Text + "')", DBconnect);
            cmd1.ExecuteNonQuery();
            MessageBox.Show("Updated");
            MySqlDataAdapter Ad = new MySqlDataAdapter("SELECT * FROM `managerbookentry` WHERE `BookName` = '" + this.textBox1.Text + "'", DBconnect);
            DataTable dt = new DataTable();
            Ad.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Manager_Function mf = new Manager_Function();
            this.Hide();
            mf.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Manager_Function mf = new Manager_Function();
            this.Hide();
            mf.Show();
        }
    }
}
