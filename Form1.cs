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


namespace Tiny_Library_Book_Store_Management_System
{
    public partial class Users_Form : Form
    {
        public Users_Form()
        {
            InitializeComponent();
        }
        private void Admin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Login al = new Admin_Login();
            al.Flag = 0;
            al.Show();
        }

        private void Manager_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Login al = new Admin_Login();
            al.Flag = 1;
            al.Show();
        }
    }
}
