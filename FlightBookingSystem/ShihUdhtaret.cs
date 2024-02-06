using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightBookingSystem
{
    public partial class ShihUdhtaret : Form
    {
        public ShihUdhtaret()
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
            string query = "select * from PassengerTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query,Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var datas = new DataSet();
            sda.Fill(datas);
            PassengerDataGV.DataSource = datas.Tables[0];
            Con.Close();
        }
        private void ShihUdhtaret_Load(object sender, EventArgs e)
        {
            populate();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            ShtoUdhtaret addpas = new ShtoUdhtaret();
            addpas.Show();
            this.Hide();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if(Pid.Text == "")
            {
                MessageBox.Show("Enter The Passenger to Delete");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from PassengerTbl where PassID=" + Pid.Text + " ;";
                    SqlCommand cmd  = new SqlCommand(query , Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Passenger you wanted is deleted successfully");
                    Con.Close();
                    populate();
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void PassengerDataGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Pid.Text = PassengerDataGV.SelectedRows[0].Cells[0].Value.ToString();
            pName.Text = PassengerDataGV.SelectedRows[0].Cells[1].Value.ToString();
            pPass.Text = PassengerDataGV.SelectedRows[0].Cells[2].Value.ToString();
            pAd.Text = PassengerDataGV.SelectedRows[0].Cells[3].Value.ToString();
            nation.SelectedItem = PassengerDataGV.SelectedRows[0].Cells[4].Value.ToString();
            genderr.SelectedItem = PassengerDataGV.SelectedRows[0].Cells[5].Value.ToString();
           
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Pid.Text = "";
            pName.Text = "";
            pPass.Text = "";
            pAd.Text = "";
            nation.SelectedItem = "";
            genderr.SelectedItem = "";
            phonee.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(Pid.Text==""||pName.Text==""||pPass.Text==""||pAd.Text=="")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update PassengerTbl set PassName= '" + pName.Text + "',Passport='" + pPass.Text + "',PassAd='" + pAd.Text + "',PassNat='" + nation.SelectedItem.ToString() + "',PassGend='" + genderr.SelectedItem.ToString() + "',PassPhone='" + phonee.Text + "' where PassID=" + Pid.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Passenger table is updated successfully");
                    Con.Close();
                    populate();
                }catch(Exception )
                {
                    MessageBox.Show("Missing Information");
                }
            }
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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
           /* string enteredName=pName.Text;
            if(isNameValid(enteredName))
            {
                label11.Text = "";
            }
            else
            {
                label11.ForeColor=Color.Red;
                label11.Text = "Name can't start with number";
            }*/
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
