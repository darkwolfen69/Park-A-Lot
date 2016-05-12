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
            this.elevatorDisplayScreen = elevatorDisplayScreen;
            InitializeComponent();
        }

        private void ElevatorReservationTime_Load(object sender, EventArgs e)
        {
            if (timeHour > 12)
            {
                timeHour -= 12;

                lb_Now.Text = timeHour + ":" + timeMin.ToString("00") + " PM";
            }
            else if (timeHour == 0)
            {
                timeHour = 12;

                lb_Now.Text = timeHour + ":" + timeMin.ToString("00") + " AM";
            }
            else if (timeHour == 12)
            {
                lb_Now.Text = timeHour + ":" + timeMin.ToString("00") + " PM";
            }
            else
            {
                lb_Now.Text = timeHour + ":" + timeMin.ToString("00") + " AM";
            }
        }

        private void bn_Submit_Click(object sender, EventArgs e)
        {
            DataObject DO = new DataObject();
            DO.ReturnBasedOnLicensePlateNumber(Customer.LicensePlate);
            DateTime timeEnd = DateTime.Parse(textBox2.Text);
            int custNum = int.Parse(Customer.CustNum);

            if (Parking.ReservedCounter > 0)
            {
                DO.InsertNewReservation(custNum,Customer.LicensePlate, DateTime.Now.Date,DateTime.Now,timeEnd);
                DO.ReturnBasedOnLicensePlateNumber(Customer.LicensePlate);
                DO.UpdateReservationWithParkingID(custNum);
                Parking.updateReserved();
                Marquee.updateMarquee();
                elevatorDisplayScreen.lb_Display.Text = Customer.FullName + "\nParking Space: " + Parking.nextResAvailable.ToString() + "\n" + Customer.TimeStart + " - " + Customer.TimeEnd;
                this.Close();
            }
            else
            {
                this.Close();
                elevatorDisplayScreen.lb_Display.Text = "No reservations available at this time.\nPlease exit the garage.";
            }  
        }
    }
}
