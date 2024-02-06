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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Security.Cryptography;

namespace FlightBookingSystem
{
    public partial class ShtoUdhtaret : Form
    {

        public ShtoUdhtaret()
        {
            InitializeComponent();
        }
     //   SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\shpre\OneDrive\Dokumente\AirlineDb.mdf;Integrated Security=True;Connect Timeout=30");
       SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-2MEII0K\SQLEXPRESS;Initial Catalog=AirlineDb;Integrated Security=True");
        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (PassID.Text == "" || PassAd.Text == "" || PassName.Text == "" || Passport.Text == " " || Phone.Text == "")
            {
                MessageBox.Show("Missing Information" );
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into PassengerTbl values (" + PassID.Text + ",'" + PassName.Text + "','" + Passport.Text + "','" + PassAd.Text + "','" + Nationality.SelectedItem.ToString() + "','" + Gender.SelectedItem.ToString() + "','" + Phone.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Passenger Added Successfully");
                    Con.Close();
                } catch(Exception Ex) 
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        private void ShtoUdhtaret_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            ShihUdhtaret viewpas = new ShihUdhtaret();
            viewpas.Show();
            this.Hide();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            PassID.Text = "";
            label13.Text = "";
            PassName.Text = "";
            Passport.Text = "";
            PassAd.Text = "";
            Nationality.SelectedItem = "";
            Gender.SelectedItem = "";
            Phone.Text = "";
            
        }
     /* private bool isNameValid(string name)
        {
            if (char.IsDigit(name[0]))
            {
                return false;
            }
            return true;
        }*/
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
           /* string enteredName = PassName.Text;
            if (isNameValid(enteredName))
            {
                label13.Text = "";
            }
            else
            {
                label13.ForeColor = Color.Red;
                label13.Text = "Name can't start with number";
            }*/

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
