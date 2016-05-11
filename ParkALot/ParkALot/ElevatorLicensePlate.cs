using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Data.Sql;

namespace ParkALot
{
    public partial class ElevatorLicensePlate : Form
    {
        private ElevatorDisplayScreen elevatorDisplayScreen;
        private EntranceDisplayScreen entranceDisplayScreen;

        public ElevatorLicensePlate()
        {
            InitializeComponent();
        }

        public ElevatorLicensePlate(ElevatorDisplayScreen elevatorDisplayScreen, EntranceDisplayScreen entranceDisplayScreen)
        {
            // TODO: Complete member initialization
            this.elevatorDisplayScreen = elevatorDisplayScreen;
            this.entranceDisplayScreen = entranceDisplayScreen;
            InitializeComponent();
        }

        private void bn_LPRead_Click(object sender, EventArgs e)
        {
            //EntranceCustomerNumber newResCustomer = new EntranceCustomerNumber(elevatorDisplayScreen);
            //newResCustomer.Show();
            //elevatorDisplayScreen.lb_Display.Text = "License plate not found.  Please enter your Customer Number.";

            DataObject dataObject = new DataObject();
            dataObject.ReturnBasedOnLicensePlateNumber(tb_LPNum.Text);
            string today = DateTime.Now.ToString();
            
            if (dataObject.DetermineIfCustomerExistsByLicense(tb_LPNum.Text))
            {
                if (Customer.TimeStart > DateTime.Now && Customer.TimeEnd < DateTime.Now) //determine if there is a reservation
                {
                    elevatorDisplayScreen.lb_Display.Text = Customer.FullName + "\n" + "Parking Spot \n" + Customer.TimeStart + " - " + Customer.TimeEnd;
                }
                else
                {
                    elevatorDisplayScreen.lb_Display.Text = "You do not have a reservation at this time.\nWould you like to make a reservation?";
                    ElevatorReservedParking question = new ElevatorReservedParking(elevatorDisplayScreen, entranceDisplayScreen);
                    question.Show();
                }
            }
            else
            {
                elevatorDisplayScreen.lb_Display.Text = "You are not a registered customer.\nPlease exit the garage.";

            }
            this.Close();
        }
    }
}
