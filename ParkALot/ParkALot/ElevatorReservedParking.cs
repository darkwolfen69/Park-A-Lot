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
    public partial class ElevatorReservedParking : Form
    {
        private ElevatorDisplayScreen elevatorDisplayScreen;

        public ElevatorReservedParking()
        {
            InitializeComponent();
        }

        public ElevatorReservedParking(ElevatorDisplayScreen elevatorDisplayScreen)
        {
            // TODO: Complete member initialization
            this.elevatorDisplayScreen = elevatorDisplayScreen;
            InitializeComponent();
        }

        private void bn_No_Click(object sender, EventArgs e)
        {
            elevatorDisplayScreen.lb_Display.Text = "Please, exit the parking garage.";
            this.Close(); System.Timers.Timer myTimer = new System.Timers.Timer();
            myTimer.Elapsed += myTimer_Elapsed;
            myTimer.Interval = 5000;
            myTimer.Start();
        }

        public void myTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            System.Timers.Timer myTimer = (System.Timers.Timer)sender;
            myTimer.Stop();
            //Application.Restart();
        }

        private void bn_Yes_Click(object sender, EventArgs e)
        {
            ElevatorReservationTime newTime = new ElevatorReservationTime(elevatorDisplayScreen);
            newTime.Show();
            elevatorDisplayScreen.lb_Display.Text = "Please enter what time you will end your reservation.";
            this.Close();
        }
    }
}
