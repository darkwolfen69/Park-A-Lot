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
    public partial class Marquee : Form
    {
        public Marquee()
        {
            InitializeComponent();
        }

        private void Marquee_Load(object sender, EventArgs e)
        {
            updateMarquee();
            //EntranceDisplayScreen EDS = new EntranceDisplayScreen(this);
        }

        public static void updateMarquee()
        {
            Parking.updateReserved();
            Parking.updateWalkin();
            lb_marquee.Text = "There are " + Parking.WalkinCounter.ToString() + " spots available for Walkin,\nand "
            + Parking.ReservedCounter.ToString() + " spots available for registered customers with reservations.";
        }
    }
}
