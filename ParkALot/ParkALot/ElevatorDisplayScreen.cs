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
    public partial class ElevatorDisplayScreen : Form
    {
        public ElevatorDisplayScreen()
        {
            InitializeComponent();
        }

        private void bn_PullForward_Click(object sender, EventArgs e)
        {
            ElevatorLicensePlate newVehicle = new ElevatorLicensePlate(this);
            newVehicle.Show();
        }
    }
}
