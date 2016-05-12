using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace ParkALot
{
    public partial class ElevatorDisplayScreen : Form
    {
        private EntranceDisplayScreen entranceDisplayScreen;

        public ElevatorDisplayScreen()
        {
            InitializeComponent();
        }

        //  I am guess this is here so that when the registered customer is done, the elevator display screen will
        //  close and the entrance display screen will be left???
        public ElevatorDisplayScreen(EntranceDisplayScreen entranceDisplayScreen)
        {
            this.entranceDisplayScreen = entranceDisplayScreen;
            InitializeComponent();
        }



        private void bn_PullForward_Click(object sender, EventArgs e)
        {
            ElevatorLicensePlate newVehicle = new ElevatorLicensePlate(this, entranceDisplayScreen);
            bn_PullForward.Hide();
            newVehicle.Show();

            lb_Display.Text = "Reading license plate. Please, keep your vehicle stopped.";
        }

        private void lb_Display_TextChanged(object sender, EventArgs e)
        {
            if (lb_Display.Text.Contains("exit"))
            {
                System.Timers.Timer myTimer = new System.Timers.Timer();
                myTimer.Elapsed += myTimer_Elapsed;
                myTimer.Interval = 5000;
                myTimer.Start();
            }
            else if (lb_Display.Text.Contains("Parking Space:"))
            {
                System.Timers.Timer myTimer = new System.Timers.Timer();
                myTimer.Elapsed += myTimer_Elapsed;
                myTimer.Interval = 5000;
                myTimer.Start();
            }
        }

        public void myTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            System.Timers.Timer myTimer = (System.Timers.Timer)sender;
            myTimer.Stop();
            this.Invoke((Action)delegate() { this.Hide(); });
        }
    }
}
