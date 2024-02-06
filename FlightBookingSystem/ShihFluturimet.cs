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
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Data.Common;

namespace FlightBookingSystem
{
    public partial class ShihFluturimet : Form
    {
        public ShihFluturimet()
        {
            InitializeComponent();
        }
       // SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\shpre\OneDrive\Dokumente\AirlineDb.mdf;Integrated Security=True;Connect Timeout=30");
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-2MEII0K\SQLEXPRESS;Initial Catalog=AirlineDb;Integrated Security=True");
        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void populate()
        {
            Con.Open();
            string query = "select * from FlightTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var datas = new DataSet();
            sda.Fill(datas);
            FlightDataGV.DataSource = datas.Tables[0];
            Con.Close();
        }
        private void ShihFluturimet_Load(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select * from FlightTbl",Con);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            FlightDataGV.DataSource = dt;
            Con.Close();
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FluturimetTbl AddFl = new FluturimetTbl();
            AddFl.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Fcodee.Text = "";
            Seatnumbers.Text = "";
        }

        private void FlightDataGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (FlightDataGV.CurrentRow.Index != -1)
            {
                Fcodee.Text = FlightDataGV.Rows[0].Cells[0].Value.ToString();
                Source.SelectedItem = FlightDataGV.SelectedRows[0].Cells[1].Value.ToString();
                Destination.SelectedItem = FlightDataGV.SelectedRows[0].Cells[2].Value.ToString();
                Seatnumbers.Text = FlightDataGV.SelectedRows[0].Cells[3].Value.ToString();
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (Fcodee.Text == "")
            {
                MessageBox.Show("Enter The Flight to Delete");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from FlightTbl where FCode= '" + Fcodee.Text + "' ;";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("The flight you wanted is deleted successfully");
                    Con.Close();
                    populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void Source_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Fcodee.Text == "" || Seatnumbers.Text == "" )
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update FlightTbl set FSource='" + Source.SelectedItem.ToString() + "',FDestination='" + Destination.SelectedItem.ToString()+ "',FDate='" + Fdate.Value.Date.ToString() + "',FCap='" + Seatnumbers.Text + "' where FCode='"+Fcodee.Text +"';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Flights table is updated successfully");
                    Con.Close();
                    populate();
                }
                catch (Exception)
                {
                    MessageBox.Show("Missing Information");
                }
            }
        }
    }
}
