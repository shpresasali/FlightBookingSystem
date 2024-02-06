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
    public partial class AnulimiTbl : Form
    {
        public AnulimiTbl()
        {
            InitializeComponent();
        }
       // SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\shpre\OneDrive\Dokumente\AirlineDb.mdf;Integrated Security=True;Connect Timeout=30");
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-2MEII0K\SQLEXPRESS;Initial Catalog=AirlineDb;Integrated Security=True");
        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void fillTicketCode()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select TId from TicketsTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("TId", typeof(string));
            dataTable.Load(rdr);
            TidCb.ValueMember = "TId";
            TidCb.DataSource = dataTable;
            Con.Close();
        }
        private void fetchFlightcode()
        {
            Con.Open();
            string query = "select  * from TicketsTbl where TId=" + TidCb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                Fcode.Text = dr["Fcode"].ToString();
            }
            Con.Close();
        }
        private void populate()
        {
            Con.Open();
            string query = "select * from CancelTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var datas = new DataSet();
            sda.Fill(datas);
            CancellationDataGV.DataSource = datas.Tables[0];
            Con.Close();
        }
        private void AnulimiTbl_Load(object sender, EventArgs e)
        {
            fillTicketCode();
            populate();
        }
        private void TicketDataGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void TidCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchFlightcode();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            CancelId.Text = "";
            Fcode.Text = "";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();

        }
        private void deleteTicket()
        {
                try
                {
                    Con.Open();
                    string query = "delete from TicketsTbl where TId= " + TidCb.SelectedValue.ToString() + " ;";
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
        private void button1_Click(object sender, EventArgs e)
        {
            if (CancelId.Text == "" || Fcode.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into CancelTbl values (" +CancelId.Text + "," + TidCb.SelectedValue.ToString() + ",'" + Fcode.Text + "','" + CDate.Value.Date + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ticket is Cancelled Successfully");
                    Con.Close();
                   populate();
                    deleteTicket();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        
    }
}
