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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            ShtoUdhtaret passengers = new ShtoUdhtaret();
            passengers.Show();
            this.Hide();
        }
        private void button1_MouseEnter_1(object sender, EventArgs e)
        {
            button1.BackColor = System.Drawing.Color.White;
        }
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = System.Drawing.Color.Blue;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            FluturimetTbl flights = new FluturimetTbl();
            flights.Show();
            this.Hide();
        }
        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = System.Drawing.Color.White;
        }
        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = System.Drawing.Color.Blue;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Tickets tickets = new Tickets();
            tickets.Show();
            this.Hide();
        }
        private void button4_MouseEnter_1(object sender, EventArgs e)
        {
            button4.BackColor = System.Drawing.Color.White;
        }
        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = System.Drawing.Color.Blue;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            AnulimiTbl cancel = new AnulimiTbl();
            cancel.Show();
            this.Hide();
        }
        private void button8_MouseEnter(object sender, EventArgs e)
        {
            button8.BackColor = System.Drawing.Color.White;
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
            button8.BackColor = System.Drawing.Color.Blue;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ContactButton_Click(object sender, EventArgs e)
        {
            Contact contact = new Contact();
            contact.Show();
            this.Hide();
        }

        private void ContactButton_MouseEnter(object sender, EventArgs e)
        {
            ContactButton.BackColor = System.Drawing.Color.White;
        }

        private void ContactButton_MouseLeave(object sender, EventArgs e)
        {
            ContactButton.BackColor = System.Drawing.Color.Blue;
        }
    }
}
