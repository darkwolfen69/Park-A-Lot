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
        static Marquee thisForm;
        public Marquee()
        {
            InitializeComponent();
            thisForm = this;
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
            thisForm.lb_marquee.Text = Parking.WalkinCounter.ToString() + "   Parking spots available for Dirve-in Customers\n\n"
            + Parking.ReservedCounter.ToString() + "   Parking spots available for Registered Customers";
            //thisForm.lb_marquee.Text = "There are " + Parking.WalkinCounter.ToString() + " spots available for Dirve-in Customers,\nand "
            //+ Parking.ReservedCounter.ToString() + " spots available for registered customers with reservations.";
        }
    }
}
