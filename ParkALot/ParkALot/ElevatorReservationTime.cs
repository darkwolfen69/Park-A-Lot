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
            DataObject DO = new DataObject();

            DateTime timeEnd = DateTime.Parse(textBox2.Text);
            int custNum = int.Parse(Customer.CustNum);

            if (Parking.ReservedCounter < 50)
            {
                DO.InsertNewReservation(custNum,Customer.LicensePlate, DateTime.Now.Date,DateTime.Now,timeEnd);
                DO.ReturnBasedOnLicensePlateNumber(Customer.LicensePlate);
                DO.UpdateReservationWithParkingID(custNum);
                Parking.updateReserved();
                elevatorDisplayScreen.lb_Display.Text = Customer.FullName + "\n" + Parking.nextAvailable.ToString() + "\n" + Customer.TimeStart + " - " + Customer.TimeEnd;
                this.Close();
            }
            else
            {
                this.Close();
                elevatorDisplayScreen.lb_Display.Text = "No reservations available at this time.\nPlease exit the garage.";
            }
            
            
        }

        public void myTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            System.Timers.Timer myTimer = (System.Timers.Timer)sender;
            myTimer.Stop();
            //Application.Restart();
        }
    }
}
