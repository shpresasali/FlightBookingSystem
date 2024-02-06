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
    public partial class Tickets : Form
    {
        public Tickets()
        {
            InitializeComponent();
        }
        //SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\shpre\OneDrive\Dokumente\AirlineDb.mdf;Integrated Security=True;Connect Timeout=30");
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-2MEII0K\SQLEXPRESS;Initial Catalog=AirlineDb;Integrated Security=True");
        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void populate()
        {
            Con.Open();
            string query = "select * from TicketsTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var datas = new DataSet();
            sda.Fill(datas);
            TicketDataGV.DataSource = datas.Tables[0];
            Con.Close();
        }
        private void fillPassenger ()
        {
            Con.Open ();
            SqlCommand cmd = new SqlCommand("select PassID from PassengerTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("PassID", typeof(int));
            dataTable.Load(rdr);
            PIdCb.ValueMember = "PassID";
            PIdCb.DataSource = dataTable;
            Con.Close ();
        }
        private void fillFlightCode()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select FCode from FlightTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("FCode", typeof(string));
            dataTable.Load(rdr);
            FCode.ValueMember = "FCode";
            FCode.DataSource = dataTable;
            Con.Close();
        }
        string pname, ppass, pnat;
        private void fetchpassengers()
        {
            Con.Open();
            string query = "select  * from PassengerTbl where PassID=" + PIdCb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand (query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill (dt);
            foreach (DataRow dr in dt.Rows)
            {
                pname = dr["PassName"].ToString();
                ppass = dr["Passport"].ToString();
                pnat = dr["PassNat"].ToString();
                PName.Text = pname;
                PassNo.Text = ppass;
                Nationality.Text = pnat;
            }
            Con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (TicketId.Text == "" || PName.Text == "" )
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into TicketsTbl values (" +TicketId.Text + ",'" + FCode.SelectedValue.ToString()+ "',"+PIdCb.SelectedValue.ToString() + ",'" + PName.Text + "','" +PassNo.Text + "','" + Nationality.Text + "'," + Amount.Text + ")";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ticket is Booked Successfully");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            PName.Text = "";
            PassNo.Text = "";
            Nationality.Text = "";
            Amount.Text = "";
            TicketId.Text = "";
        }
        private void Tickets_Load(object sender, EventArgs e)
        {
            fillPassenger();
            fillFlightCode();
            populate();
        }
        private void PIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchpassengers();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

       
    }
}
