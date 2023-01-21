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

namespace sample_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
       
        private void username_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            //Set the username and password
            if(username.Text == "admin" && password.Text=="123")
            {
                // transition to another windows form
                new dashboard().Show();
                this.Hide();
            }
            else 
            {
                //To show incorrect input
                MessageBox.Show("The Username or Password is Incorrect");
                username.Clear();
                password.Clear();
                username.Focus();
            }

        }

        private void show_CheckedChanged(object sender, EventArgs e)
        {
            //To hide or show the password text

            //show password
            if(show.Checked == true)
            {
                password.UseSystemPasswordChar = false;
            }
            //hide password
            else
            {
                password.UseSystemPasswordChar = true;
            }
        }
    }
}
