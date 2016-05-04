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
    public partial class LicensePlate : Form 
    {
        private ElevatorDisplayScreen elevatorDisplayScreen;

        public LicensePlate()
        {
            InitializeComponent();
        }

        public LicensePlate(ElevatorDisplayScreen elevatorDisplayScreen)
        {
            // TODO: Complete member initialization
            this.elevatorDisplayScreen = elevatorDisplayScreen;
            InitializeComponent();
        }

        private void bn_LPRead_Click(object sender, EventArgs e)
        {
            ElevatorCustomerNumber newResCustomer = new ElevatorCustomerNumber(elevatorDisplayScreen);
            newResCustomer.Show();
            elevatorDisplayScreen.lb_Display.Text = "License plate not found.  Please enter your Customer Number.";
            this.Close();
        }

        private void ElevatorLicensePlate_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Server=cis1.actx.edu;Database=ParkALotDatabase;User Id=db2;Password = db20;";
            connection.Open();
            connection.Close();

            // Compare entered text with text in the database
            // If it matches a number then go to reservation screen
            // If not go to 
            DataObject connection2 = new DataObject();
            //List<String> list1 = connection2.ReturnBasedOnLicensePlateNumber(tb_LPNum.Text);

            if (connection2.DetermineIfCustomerExistsByLicense(tb_LPNum.Text))
            {
                // Display customer information and reservation
            }
            else
            {
                // Display no reservation
            }
   
        }
    }
}
