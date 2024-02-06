using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightBookingSystem
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Username.Text = "";
            Password.Text = "";
            ConfirmPassword.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
           if(Username.Text == "" || Password.Text == "" )
            {
                MessageBox.Show("Enter The User Id and Password");
            }
           else if(Username.Text =="Shpresa" &&  Password.Text =="Shpresa")
            {
                Home home = new Home();
                home.Show();
                this.Hide();
            }
           else
            {
                MessageBox.Show("The Username or Password you just entered its wrong");
            }

        }

        private void ConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            ConfirmPassword.UseSystemPasswordChar = true;
            if (ConfirmPassword.Text==Password.Text)
            {
                label8.ForeColor = Color.Green;
                label8.Text = "Password confirmed";
            }
            else
            {
                label8.ForeColor = Color.Red;
                label8.Text = "Wrong password";
            }
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
             Password.UseSystemPasswordChar=true;
        }
    }
}
