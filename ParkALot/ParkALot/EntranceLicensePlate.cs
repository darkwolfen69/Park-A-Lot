using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkALot
{
    public partial class EntranceLicensePlate : Form
    {
        private EntranceDisplayScreen entranceDisplayScreen;

        public EntranceLicensePlate()
        {
            InitializeComponent();
        }

        public EntranceLicensePlate(EntranceDisplayScreen entranceDisplayScreen)
        {
            // TODO: Complete member initialization
            this.entranceDisplayScreen = entranceDisplayScreen;
            InitializeComponent();
        }

        private void bn_LPRead_Click(object sender, EventArgs e)
        {
            
            DataObject databaseConnection = new DataObject();
            ElevatorDisplayScreen eleDisplay = new ElevatorDisplayScreen();
            EntranceCustomerNumber customerNumber = new EntranceCustomerNumber(entranceDisplayScreen, this);
            bool test = databaseConnection.DetermineIfCustomerExistsByLicense(tb_LPNum.Text);
            //bool test = false;
            if (test)
            {
                Customer.LicensePlate = tb_LPNum.Text;
                databaseConnection.ReturnBasedOnLicensePlateNumber(tb_LPNum.Text);
                entranceDisplayScreen.lb_WalkinHeader.Text = "Please pull towards the elevator!";
                entranceDisplayScreen.lb_OptDetail.Text = "Please pull towards the elevator!";
                this.Close();
                eleDisplay.Show();
            }
            else
            {
                entranceDisplayScreen.lb_WalkinHeader.Text = "\nYour license plate number was not found.\nPlease enter your customer number.";
                customerNumber.Show();
                this.Hide();
            }
        }
    }
}
