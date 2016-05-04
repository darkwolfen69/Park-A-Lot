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
    public partial class ExitLicensePlate : Form
    {
        public ExitLicensePlate()
        {
            InitializeComponent();
        }

        private void bn_LPRead_Click(object sender, EventArgs e)
        {
            DataObject exit = new DataObject();
            exit.CustomerExit(tb_LPNum.Text);
        }
    }
}
