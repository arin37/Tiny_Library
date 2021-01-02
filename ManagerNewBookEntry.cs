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
    public partial class ManagerNewBookEntry : Form
    {
        public ManagerNewBookEntry()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Connection = "datasource = localhost; username = root; password =; database = tiny_library";
            MySqlConnection DBconnect = new MySqlConnection(Connection);
            DBconnect.Open();
            MySqlCommand cmd = new MySqlCommand("insert into `managerbookentry`(`BookName`, `BookPublishYear`, `WriterName`, `QuantityOfBook`, `CatagoryName`, `EntryDate`, `AvaliableBook`) VALUES ('" + this.textBox1.Text +"','"+this.comboBox2.SelectedItem+"','"+ this.textBox2.Text +"', '"+ this.textBox3.Text +"', '"+ this.comboBox1.SelectedItem + "', '"+ this.dateTimePicker2.Text +"', '" + this.textBox3.Text + "')", DBconnect);
            MySqlDataReader dr = cmd.ExecuteReader();
            MessageBox.Show("Saved");
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Manager_Function mf = new Manager_Function();
            this.Hide();
            mf.Show();
        }
    }
}
