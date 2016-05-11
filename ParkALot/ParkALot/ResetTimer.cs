using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Timers;

namespace ParkALot
{
    class ResetTimer
    {
        // Call EntranceDisplayScreen to rerun the progam
        private void Crazy(object sender, ElapsedEventArgs e)
        {
            // If you want to use this you will have to inherit from EntranceDisplayScreen
            // Line 30 in EntranceDisplayScreen.Designer.cs
            // Changed InitializeComponent method from private to protected. 
            //InitializeComponent();

            //EntranceDisplayScreen EDS = new EntranceDisplayScreen();
            //EDS.Show();

            //EDS.bn_walkin.Show();
            //EDS.bn_ResCust.Show();
            //EDS.lb_WalkinWarning.Show();
            //EDS.lb_ResCusWarning.Show();
            //EDS.lb_OptDetail.Hide();
            //EDS.lb_ParkingInstructions.Hide();
            //EDS.lb_WalkinHeader.Hide();
            //EDS.lb_Ticket.Hide();
        }

        public void ContinuumTransfunctioner()
        {

            // Create a timer with a 1.5 second interval.
            double interval = 1500.0;
            System.Timers.Timer aTimer = new System.Timers.Timer(interval);

            // Hook up the event handler for the Elapsed event.
            aTimer.Elapsed += new ElapsedEventHandler(Crazy);

            // Only raise the event the first time Interval elapses.
            //aTimer.AutoReset = false;
            //aTimer.Enabled = true;

            // Ensure the event fires before the exit message appears.
            System.Threading.Thread.Sleep((int)interval * 2);
            //Console.WriteLine("Press the Enter key to exit the program.");
            //Console.ReadLine();
        }
    }
}
