﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace ParkALot
{
    public partial class EntranceCustomerNumber : Form
    {
        private EntranceDisplayScreen displayScreen;
        private EntranceLicensePlate lpReader;

        public EntranceCustomerNumber()
        {
            InitializeComponent();
            button1.Click += GenerateNumber;
            button2.Click += GenerateNumber;
            button3.Click += GenerateNumber;
            button4.Click += GenerateNumber;
            button5.Click += GenerateNumber;
            button6.Click += GenerateNumber;
            button7.Click += GenerateNumber;
            button8.Click += GenerateNumber;
            button9.Click += GenerateNumber;
            button10.Click += GenerateNumber;
        }

        public EntranceCustomerNumber(EntranceDisplayScreen displayScreen, EntranceLicensePlate lpReader)
        {
            // TODO: Complete member initialization
            this.displayScreen = displayScreen;
            this.lpReader = lpReader;
            InitializeComponent();
            button1.Click += GenerateNumber;
            button2.Click += GenerateNumber;
            button3.Click += GenerateNumber;
            button4.Click += GenerateNumber;
            button5.Click += GenerateNumber;
            button6.Click += GenerateNumber;
            button7.Click += GenerateNumber;
            button8.Click += GenerateNumber;
            button9.Click += GenerateNumber;
            button10.Click += GenerateNumber;
        }

        public void GenerateNumber(object sender, EventArgs e)
        {
            var buttonNumber = sender as Button;
            txbx_cusNum.Text += buttonNumber.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Customer.CustNum = txbx_cusNum.Text;

            DataObject dbConnect = new DataObject();

            int custNumber = int.Parse(txbx_cusNum.Text);
            if (dbConnect.DetermineIfCustomerExists(custNumber))
            {
                displayScreen.lb_WalkinWarning.Hide();
                displayScreen.lb_ResCusWarning.Hide();
                displayScreen.bn_ResCust.Hide();
                displayScreen.bn_walkin.Hide();
                displayScreen.lb_WalkinHeader.Text = "Thank you for using Park-A-Lot.\n\nPlease pull forward.";
                displayScreen.lb_Ticket.Text = "Thank you!";
                displayScreen.lb_Ticket.Font = new System.Drawing.Font("Cambria", 12);
                displayScreen.lb_OptDetail.Location = new Point(255, 255);
                displayScreen.lb_OptDetail.Text = "Please pull towards the elevator!";
                dbConnect.UpdateCustomerWithLicensePlate(custNumber, lpReader.tb_LPNum.Text);
                Customer.LicensePlate = lpReader.tb_LPNum.Text;
                dbConnect.ReturnBasedOnLicensePlateNumber(Customer.LicensePlate);
                System.Timers.Timer myTimer = new System.Timers.Timer();
                myTimer.Elapsed += myTimer_Elapsed;
                myTimer.Interval = 5000;
                myTimer.Start();
                ElevatorDisplayScreen elevator = new ElevatorDisplayScreen(displayScreen);
                elevator.Show();
            }
            else
            {
                displayScreen.lb_WalkinHeader.Hide();
                displayScreen.lb_WalkinWarning.Hide();
                displayScreen.lb_ResCusWarning.Hide();
                displayScreen.bn_ResCust.Hide();
                displayScreen.bn_walkin.Hide();
                displayScreen.lb_Ticket.Show();
                displayScreen.lb_Ticket.Text = "You are not a registered customer!";
                displayScreen.lb_Ticket.Font = new System.Drawing.Font("Cambria", 12);
                displayScreen.lb_OptDetail.Location = new Point(255, 255);
                displayScreen.lb_OptDetail.Text = "Please exit the garage!";
                displayScreen.lb_OptDetail.Show();
            }
            this.Close();
        }

        private void myTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            System.Timers.Timer myTimer = (System.Timers.Timer)sender;
            myTimer.Stop();

            //ElevatorDisplayScreen elevator = new ElevatorDisplayScreen(displayScreen);
            //elevator.Show();
        }
        //  Clears customer number text box
        private void btn_clear_Click(object sender, EventArgs e)
        {
            txbx_cusNum.Clear();
        }
    }
}

            