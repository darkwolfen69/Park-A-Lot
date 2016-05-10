using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace ParkALot
{
    public partial class EntranceDisplayScreen : Form
    {
        public EntranceDisplayScreen()
        {
            InitializeComponent();
        }

        private void bn_walkin_Click(object sender, EventArgs e)
        {
            bn_walkin.Hide();
            bn_ResCust.Hide();
            lb_WalkinWarning.Hide();
            lb_ResCusWarning.Hide();
            lb_OptDetail.Hide();
            lb_ParkingInstructions.Show();
            lb_WalkinHeader.Show();
            lb_Ticket.Show();
        }

        private void bn_ResCust_Click(object sender, EventArgs e)
        {   
            EntranceLicensePlate ELP = new EntranceLicensePlate(this);
            
            ELP.Show();
            lb_WalkinWarning.Hide();
            lb_ResCusWarning.Hide();
            bn_ResCust.Hide();
            bn_walkin.Hide();
            lb_Ticket.Hide();
            lb_ParkingInstructions.Hide();
            lb_OptDetail.Hide();
            lb_WalkinHeader.Show();
        }

        private void EntranceDisplayScreen_Load(object sender, EventArgs e)
        {
            Marquee newMarquee = new Marquee();
            newMarquee.Show();
            ExitLicensePlate exit = new ExitLicensePlate();
            exit.Show();
        }

        private void lb_WalkinHeader_TextChanged(object sender, EventArgs e)
        {

            System.Timers.Timer myTimer = new System.Timers.Timer();
            myTimer.Elapsed += myTimer_Elapsed;
            myTimer.Interval = 5000;
            myTimer.Start();
        }



        public void myTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            System.Timers.Timer myTimer = (System.Timers.Timer)sender;
            myTimer.Stop();
            //this.Hide();  //throws a Threading exception.
        }
    }
}
