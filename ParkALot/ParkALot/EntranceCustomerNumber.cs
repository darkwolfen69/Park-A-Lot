using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkALot
{
    public partial class EntranceCustomerNumber : Form
    {
        private EntranceDisplayScreen displayScreen;

        public EntranceCustomerNumber()
        {
            InitializeComponent();
            button1.Click += GenerateNumber;
            button2.Click += GenerateNumber;
            button3.Click += GenerateNumber;
            button4.Click += GenerateNumber;
            button5.Click += GenerateNumber;
            button6.Click += GenerateNumber;
            button7.Click += GenerateNumber;
            button8.Click += GenerateNumber;
            button9.Click += GenerateNumber;
            button10.Click += GenerateNumber;
        }

        public EntranceCustomerNumber(EntranceDisplayScreen displayScreen)
        {
            // TODO: Complete member initialization
            this.displayScreen = displayScreen;
            InitializeComponent();
        }

        public void GenerateNumber(object sender, EventArgs e)
        {
            var buttonNumber = sender as Button;
            textBox1.Text += buttonNumber.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            displayScreen.lb_WalkinWarning.Hide();
            displayScreen.lb_ResCusWarning.Hide();
            displayScreen.bn_ResCust.Hide();
            displayScreen.bn_walkin.Hide();
            displayScreen.lb_Ticket.Show();
            displayScreen.lb_Ticket.Text = "Thank you!";
            displayScreen.lb_Ticket.Font = new System.Drawing.Font("Comic Sans MS", 12);
            displayScreen.lb_OptDetail.Location = new Point(255, 409);
            displayScreen.lb_OptDetail.Text = "Please pull towards the elevator!";
            this.Close();
        }
    }
}
