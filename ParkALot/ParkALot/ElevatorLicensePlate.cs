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
            elevatorDisplayScreen.lb_Display.Text = Customer.LicensePlate;

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

            this.Close();
        }
    }
}
