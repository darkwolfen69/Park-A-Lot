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
            Parking.updateWalkin();
            if (Parking.nextWalkinAvailable != 0)
            {
                lb_WalkinHeader.Text = "Thank you for using Park-A-Lot!";
                lb_Ticket.Text = "Please proceed to parking spot: " + Parking.nextWalkinAvailable.ToString();
                lb_Ticket.Font = new System.Drawing.Font("Cambria", 20);
                lb_Ticket.Location = new Point(125, 150);
                Parking.walkin[Parking.nextWalkinAvailable - 1] = false;
                Marquee.updateMarquee();
            }
            else
            {
                lb_Ticket.Text = "There are no spaces available.\nPlease exit the garage.";
                lb_Ticket.Font = new System.Drawing.Font("Cambria", 20);
                lb_Ticket.Location = new Point(150, 150);
            }

            bn_walkin.Hide();
            bn_ResCust.Hide();
            lb_WalkinWarning.Hide();
            lb_ResCusWarning.Hide();
            lb_OptDetail.Hide();
            lb_ParkingInstructions.Show();
            lb_WalkinHeader.Show();
            lb_Ticket.Show();
            
            System.Timers.Timer myTimer = new System.Timers.Timer();
            myTimer.Elapsed += myTimer_Elapsed;
            myTimer.Interval = 5000;
            myTimer.Start();
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
            lb_WalkinHeader.Text = "Thank you for using Park-A-Lot!\n\nReading license plate.\nPlease keep your vehicle parked.";
            lb_WalkinHeader.Show();

        }

        private void EntranceDisplayScreen_Load(object sender, EventArgs e)
        {
            Marquee newMarquee = new Marquee();
            newMarquee.Show();
            ExitLicensePlate exit = new ExitLicensePlate();
            exit.Show();
        }

        
        public void myTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            System.Timers.Timer myTimer = (System.Timers.Timer)sender;
            myTimer.Stop();

            this.bn_walkin.Invoke((Action)delegate() { this.bn_walkin.Show(); });
            this.bn_ResCust.Invoke((Action)delegate() { this.bn_ResCust.Show(); });
            this.lb_WalkinWarning.Invoke((Action)delegate() { this.lb_WalkinWarning.Show(); });
            this.lb_ResCusWarning.Invoke((Action)delegate() { this.lb_ResCusWarning.Show(); });
            this.lb_OptDetail.Invoke((Action)delegate() { this.lb_OptDetail.Show(); });
            this.lb_ParkingInstructions.Invoke((Action)delegate() { this.lb_ParkingInstructions.Hide(); });
            this.lb_WalkinHeader.Invoke((Action)delegate() { this.lb_WalkinHeader.Hide(); });
            this.lb_Ticket.Invoke((Action)delegate() { this.lb_Ticket.Hide(); });
            this.lb_OptDetail.Invoke((Action)delegate() { this.lb_OptDetail.Text = "Please choose the option that applies to you!"; });
            this.lb_OptDetail.Invoke((Action)delegate() { this.lb_OptDetail.Location = new Point(164, 332); });

        }

        private void lb_OptDetail_TextChanged(object sender, EventArgs e)
        {
            if (lb_OptDetail.Text == "Please exit the garage!")
            {
                System.Timers.Timer myTimer = new System.Timers.Timer();
                myTimer.Elapsed += myTimer_Elapsed;
                myTimer.Interval = 5000;
                myTimer.Start();
            }
            else if (lb_OptDetail.Text == "Please pull towards the elevator!")
            {
                System.Timers.Timer myTimer = new System.Timers.Timer();
                myTimer.Elapsed += myTimer_Elapsed;
                myTimer.Interval = 5000;
                myTimer.Start();
            }
        }
    }
}
