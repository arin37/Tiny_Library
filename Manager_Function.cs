using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tiny_Library_Book_Store_Management_System
{
    public partial class Manager_Function : Form
    {
        public Manager_Function()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Manager_Edit_Book_Info mg_ed = new Manager_Edit_Book_Info();
            this.Hide();
            mg_ed.Show();
        }

        private void New_Book_Entry_Click(object sender, EventArgs e)
        {
            ManagerNewBookEntry mg_be = new ManagerNewBookEntry();
            this.Hide();
            mg_be.Show();

        }

        private void Search_Click(object sender, EventArgs e)
        {
            Manager_Book_Search mg_bs = new Manager_Book_Search();
            this.Hide();
            mg_bs.Show();

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            Manager_Delete_Book mg_dt = new Manager_Delete_Book();
            this.Hide();
            mg_dt.Show();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Users_Form us = new Users_Form();
            us.Show();
        }
    }
}
