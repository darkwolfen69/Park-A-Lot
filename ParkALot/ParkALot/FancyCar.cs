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
    public partial class FancyCar : Form
    {
        public FancyCar()
        {
            InitializeComponent();
        }

        //Determine if the customer has a premium car
        //if they do, let them continue, if they don't 
        //exit the application
        private void btnSubmitName_Click(object sender, EventArgs e)
        {
            if(txtCarName.Text == "Ferrari" || txtCarName.Text == "Bugatti" || 
                txtCarName.Text == "Lamborghini")
            {
                MessageBox.Show("You have a premium car.\nYou may now enter.");
                this.Location = new System.Drawing.Point(10, 250);
                EntranceDisplayScreen newEnteranceDisplayScreen = new EntranceDisplayScreen();
                newEnteranceDisplayScreen.ShowDialog();
                
                
            }
            else
            {
                MessageBox.Show("You have an inferior car. Please Leave");
                Application.Exit();
            }
        }
    }
}
