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
        private EntranceDisplayScreen entranceDisplayScreen;

        public ElevatorReservedParking()
        {
            InitializeComponent();
        }

        public ElevatorReservedParking(ElevatorDisplayScreen elevatorDisplayScreen, EntranceDisplayScreen entranceDisplayScreen)
        {
            // TODO: Complete member initialization
            this.elevatorDisplayScreen = elevatorDisplayScreen;
            this.entranceDisplayScreen = entranceDisplayScreen;
            InitializeComponent();
        }

        private void bn_No_Click(object sender, EventArgs e)
        {
            elevatorDisplayScreen.lb_Display.Text = "Please, exit the parking garage.";
            elevatorDisplayScreen.lb_Display.Location = new System.Drawing.Point(200,145);
            this.Close();

            System.Timers.Timer myTimer = new System.Timers.Timer();
            myTimer.Elapsed += myTimer_Elapsed;
            myTimer.Interval = 5000;
            myTimer.Start();
            //entranceDisplayScreen.lb_OptDetail.Text = "Please, exit the parking garage.";  //throws an error.
        }

        public void myTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            System.Timers.Timer myTimer = (System.Timers.Timer)sender;
            myTimer.Stop();
            this.Close();

        }

        private void bn_Yes_Click(object sender, EventArgs e)
        {
            ElevatorReservationTime newTime = new ElevatorReservationTime(elevatorDisplayScreen);
            newTime.Show();
            elevatorDisplayScreen.lb_Display.Text = "Please enter what time you will end your reservation.";
            elevatorDisplayScreen.lb_Display.Location = new System.Drawing.Point(95, 145);
            this.Close();
        }
    }
}
