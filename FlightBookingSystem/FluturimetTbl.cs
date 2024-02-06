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
namespace FlightBookingSystem
{
    public partial class FluturimetTbl : Form
    {
        public FluturimetTbl()
        {
            InitializeComponent();
        }
      // SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\shpre\OneDrive\Dokumente\AirlineDb.mdf;Integrated Security=True;Connect Timeout=30");
    SqlConnection Con =new SqlConnection(@"Data Source=DESKTOP-2MEII0K\SQLEXPRESS;Initial Catalog=AirlineDb;Integrated Security=True");
        private void label10_Click(object sender, EventArgs e)
        {
            Home Home = new Home();
            Home.Show();
            this.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (FCode.Text == "" || FSource.Text == "" || Fdestination.Text == "" || FDate.Text == " " || SeatNumber.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into FlightTbl values ('" + FCode.Text + "','" + FSource.SelectedItem.ToString()+ "','" + Fdestination.SelectedItem.ToString() + "','" + FDate.Value.ToString()+ "','" + SeatNumber.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Flight Added Successfully");
                    Con.Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            FCode.Text = "";
            SeatNumber.Text = "";

        }
        private void button3_Click(object sender, EventArgs e)
        {
            ShihFluturimet viewflt = new ShihFluturimet();
            viewflt.Show();
            this.Hide();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void FCode_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
