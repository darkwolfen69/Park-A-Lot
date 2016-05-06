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

        public ElevatorLicensePlate()
        {
            InitializeComponent();
        }

        public ElevatorLicensePlate(ElevatorDisplayScreen elevatorDisplayScreen)
        {
            // TODO: Complete member initialization
            this.elevatorDisplayScreen = elevatorDisplayScreen;
            InitializeComponent();
        }

        private void bn_LPRead_Click(object sender, EventArgs e)
        {
            //EntranceCustomerNumber newResCustomer = new EntranceCustomerNumber(elevatorDisplayScreen);
            //newResCustomer.Show();
            //elevatorDisplayScreen.lb_Display.Text = "License plate not found.  Please enter your Customer Number.";
            DataObject dataObject = new DataObject();


            if (dataObject.DetermineIfCustomerExistsByLicense(tb_LPNum.Text) == true)
            {
                if (Customer.Date != null) //determine if there is a reservation
                {
                    dataObject.ReturnBasedOnLicensePlateNumber(tb_LPNum.Text);
                    //ElevatorReservedParking ERP = new ElevatorReservedParking(elevatorDisplayScreen);
                    //ERP.Show();
                    ElevatorDisplayScreen EDS = new ElevatorDisplayScreen();
                    EDS.lb_Display.Text = Customer.FullName + "\n" + "Parking Spot /n" + Customer.TimeStart + " - " + Customer.TimeEnd;


                }
            }
            else
            {
                ElevatorReservationTime ERT = new ElevatorReservationTime(elevatorDisplayScreen);
                ERT.Show();

            }


            this.Close();
        }
    }
}
