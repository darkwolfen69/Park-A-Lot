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
        public EntranceLicensePlate()
        {
            InitializeComponent();
        }

        private void bn_LPRead_Click(object sender, EventArgs e)
        {
            
            DataObject databaseConnection = new DataObject();
            ElevatorDisplayScreen eleDisplay = new ElevatorDisplayScreen();
            EntranceCustomerNumber customerNumber = new EntranceCustomerNumber();
            if (databaseConnection.DetermineIfCustomerExistsByLicense(tb_LPNum.Text) == true)
            {
                MessageBox.Show("Please pull to the elevator!");
                eleDisplay.Show();
            }
            else
            {
                customerNumber.Show();
            }
        }
    }
}
