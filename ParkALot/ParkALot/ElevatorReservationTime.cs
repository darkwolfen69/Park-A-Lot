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
    public partial class ElevatorReservationTime : Form
    {
        private ElevatorDisplayScreen elevatorDisplayScreen;

        private int timeHour = DateTime.Now.Hour;
        private int timeMin = DateTime.Now.Minute;

        public ElevatorReservationTime()
        {
            InitializeComponent();
        }

        public ElevatorReservationTime(ElevatorDisplayScreen elevatorDisplayScreen)
        {
            // TODO: Complete member initialization
            this.elevatorDisplayScreen = elevatorDisplayScreen;
            InitializeComponent();
        }

        private void ElevatorReservationTime_Load(object sender, EventArgs e)
        {
            if (timeHour > 12)
            {
                timeHour -= 12;

                lb_Now.Text = timeHour + ":" + timeMin + " PM";
            }
            else if (timeHour == 0)
            {
                timeHour = 12;

                lb_Now.Text = timeHour + ":" + timeMin + " AM";
            }
            else if (timeHour == 12)
            {
                lb_Now.Text = timeHour + ":" + timeMin + " PM";
            }
            else
            {
                lb_Now.Text = timeHour + ":" + timeMin + " AM";
            }
        }

        private void bn_Submit_Click(object sender, EventArgs e)
        {
            this.Close();
            elevatorDisplayScreen.lb_Display.Text = "No reservations for that time.\nPlease exit the garage.";
            System.Timers.Timer myTimer = new System.Timers.Timer();
            myTimer.Elapsed += myTimer_Elapsed;
            myTimer.Interval = 5000;
            myTimer.Start();
        }

        public void myTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            System.Timers.Timer myTimer = (System.Timers.Timer)sender;
            myTimer.Stop();
            Application.Restart();
        }
    }
}
