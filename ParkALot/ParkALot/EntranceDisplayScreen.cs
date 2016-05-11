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
                lb_Ticket.Text = Parking.nextWalkinAvailable.ToString();
                Parking.walkin[Parking.nextWalkinAvailable - 1] = false;
                Marquee.updateMarquee();
            }
            else
            {
                lb_Ticket.Text = "There are no spaces available.\nPlease exit the garage.";
            }

            bn_walkin.Hide();
            bn_ResCust.Hide();
            lb_WalkinWarning.Hide();
            lb_ResCusWarning.Hide();
            lb_OptDetail.Hide();
            lb_ParkingInstructions.Show();
            lb_WalkinHeader.Show();
            lb_Ticket.Show();
            
            //resetDisplay();

            System.Timers.Timer myTimer = new System.Timers.Timer();
            myTimer.Elapsed += myTimer_Elapsed;
            myTimer.Interval = 5000;
            myTimer.Start();
            

            //ResetTimer newTimer = new ResetTimer();  //This is causing the error with not displaying anything.
            //newTimer.ContinuumTransfunctioner();

            //bn_walkin.Show();
            //bn_ResCust.Show();
            //lb_WalkinWarning.Show();
            //lb_ResCusWarning.Show();
            //lb_OptDetail.Show();
            //lb_ParkingInstructions.Hide();  //This is the code that resets the form.  Good job Madison.
            //lb_WalkinHeader.Hide();
            //lb_Ticket.Hide();
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
            lb_WalkinHeader.Text += "\n\nReading license plate.\nPlease keep your vehicle parked.";
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
            this.lb_Ticket.Invoke((Action)delegate() { this.bn_ResCust.Show(); });
            this.lb_Ticket.Invoke((Action)delegate() { this.lb_WalkinWarning.Show(); });
            this.lb_Ticket.Invoke((Action)delegate() { this.lb_ResCusWarning.Show(); });
            this.lb_Ticket.Invoke((Action)delegate() { this.lb_OptDetail.Show(); });
            this.lb_Ticket.Invoke((Action)delegate() { this.lb_ParkingInstructions.Hide(); });
            this.lb_Ticket.Invoke((Action)delegate() { this.lb_WalkinHeader.Hide(); });
            this.lb_Ticket.Invoke((Action)delegate() { this.lb_Ticket.Hide(); });


            //bn_walkin.Show();
            //bn_ResCust.Show();
            //lb_WalkinWarning.Show();
            //lb_ResCusWarning.Show();
            //lb_OptDetail.Show();
            //lb_ParkingInstructions.Hide();  //This is the code that resets the form.  Good job Madison.
            //lb_WalkinHeader.Hide();
            //lb_Ticket.Hide();

        }
    }
}
