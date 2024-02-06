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
using System.Net;
using System.Security.Cryptography;

namespace FlightBookingSystem
{
    public partial class Contact : Form
    {
        public Contact()
        {
            InitializeComponent();
        }
        SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-2MEII0K\SQLEXPRESS;Initial Catalog=AirlineDb;Integrated Security=True");
        int ContactId = 0;
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
                if (btnSave.Text == "Save")
                {
                    SqlCommand sqlCmd = new SqlCommand("contactssAddOrEdit", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@mode", "Add");
                    sqlCmd.Parameters.AddWithValue("@CID", 0);
                    sqlCmd.Parameters.AddWithValue("@Name", txtName.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@FlightCode", txtMobileNumber.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Review", txtAddress.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Review saved successfully");
                }
                else
                {
                    SqlCommand sqlCmd = new SqlCommand("contactssAddOrEdit", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@mode", "Edit");
                    sqlCmd.Parameters.AddWithValue("@CID", ContactId);
                    sqlCmd.Parameters.AddWithValue("@Name", txtName.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@MFlightCode", txtMobileNumber.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Review", txtAddress.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Updated successfully");
                }
                Reset();
                fillDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
            finally { sqlCon.Close(); }

        }
        void fillDataGridView()
        {
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            SqlDataAdapter sqlDaa = new SqlDataAdapter("contacttsVieworSearch", sqlCon);
            sqlDaa.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDaa.SelectCommand.Parameters.AddWithValue("@ContactName",txtSearch.Text.Trim());
            DataTable dtbl = new DataTable();
            sqlDaa.Fill(dtbl);
            dgvContacts.DataSource= dtbl;
            dgvContacts.Columns[0].Visible=false;
            sqlCon.Close();
        }
        private void dgvContacts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvContacts.CurrentRow.Index != -1)
            {
                ContactId = Convert.ToInt32(dgvContacts.CurrentRow.Cells[0].Value.ToString());
                txtName.Text = dgvContacts.CurrentRow.Cells[1].Value.ToString();
                txtMobileNumber.Text = dgvContacts.CurrentRow.Cells[2].Value.ToString();
                txtAddress.Text = dgvContacts.CurrentRow.Cells[3].Value.ToString();
                btnSave.Text = "Update";
                btnDelete.Enabled = true;
            }
        }
        void Reset()
        {
            txtName.Text = txtMobileNumber.Text = txtAddress.Text = "";
            btnSave.Text = "Save";
            ContactId = 0;
            btnDelete.Enabled=false;
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                fillDataGridView();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }

        private void Contact_Load(object sender, EventArgs e)
        {
            Reset();
            fillDataGridView();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open(); 
                    SqlCommand sqlCmd = new SqlCommand("ContacttDeletion", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@ContactId",ContactId);
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Contact Deleted successfully");
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
