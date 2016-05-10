﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data.Sql;
using System.Windows.Forms;

namespace ParkALot
{
    public class DataObject
    {
        public bool DetermineIfCustomerExists(int customerNumber)
        {
            SqlConnection connection = new SqlConnection();

            List<int> customers = new List<int>();

            connection.ConnectionString = "Server=cis1.actx.edu;Database=ParkALotDatabase;User Id=db2;Password = db20;";
            connection.Open();

            using (SqlCommand getAllCustomers = connection.CreateCommand())
            {
                getAllCustomers.CommandText = "select CustomerID from dbo.Demographic;";

                using (SqlDataReader reader = getAllCustomers.ExecuteReader())
                {
                    
                    while (reader.Read())
                    {
                        customers.Add(reader.GetInt32(0));
                    }
                }
            }

            connection.Close();

            bool exists = false;

            for(int i = 0; i < customers.Count; i++)
            {
                if(customers[i] == customerNumber)
                {
                    exists = true;
                    break;
                }
                else
                {
                    exists = false;
                }
            }

            return exists;
        }

        public bool DetermineIfCustomerExistsByLicense(string licenseNumber)
        {
            SqlConnection connection = new SqlConnection();

            List<string> customers = new List<string>();

            connection.ConnectionString = "Server=cis1.actx.edu;Database=ParkALotDatabase;User Id=db2;Password = db20;";
            connection.Open();

            using (SqlCommand getAllCustomers = connection.CreateCommand())
            {
                getAllCustomers.CommandText = "select PlateNumber from dbo.Demographic;";

                using (SqlDataReader reader = getAllCustomers.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        customers.Add(reader.GetString(0));
                    }
                }
            }

            connection.Close();

            bool exists = true;


            //issue with string vs int on this licenseNumber. i did this so i could run the program past it...
            //int intLicenseNumber;
            //int.TryParse(licenseNumber, out intLicenseNumber);
            //replaced licenseNumber in if statement with intLicenseNumber ....
            // Sincerely, Kris
            for (int i = 0; i < customers.Count; i++)
            {
                if (customers[i] == licenseNumber)
                {
                    exists = true;
                    break;
                }
                else
                {
                    exists = false;
                }
            }

            return exists;
        }

        public void ReturnBasedOnLicensePlateNumber(string licensePlateNumber)
        {
            SqlConnection connection = new SqlConnection();

            //List<string> output = new List<string>();

            connection.ConnectionString = "Server=cis1.actx.edu;Database=ParkALotDatabase;User Id=db2;Password = db20;";
            connection.Open();

            using (SqlCommand getAllCustomers = connection.CreateCommand())
            {
                getAllCustomers.CommandText = "SELECT dbo.Demographic.CustomerID, FirstName, LastName, dbo.Reservation.DayOfReservation, dbo.Reservation.TimeIn, dbo.Reservation.TimeOut from dbo.Demographic " + 
                                              "JOIN dbo.Reservation ON (dbo.Demographic.CustomerID = dbo.Reservation.CustomerID) WHERE PlateNumber = '"
                                               + licensePlateNumber + "';";

                using (SqlDataReader reader = getAllCustomers.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        Customer.CustNum = reader.GetInt32(0).ToString();
                        Customer.FullName = reader.GetString(1);
                        Customer.FullName += " " + reader.GetString(2);
                        Customer.Date = reader.GetDateTime(3);
                        Customer.TimeStart = reader.GetDateTime(4);
                        Customer.TimeEnd = reader.GetDateTime(5);
                    }
                }
            }

            connection.Close();
        }

        public void InsertNewReservation(int customerNumber, string licensePlateNumber, DateTime dayOfReservation,
                                         DateTime timeIn, DateTime timeOut)
        {
            //DateTime time = DateTime.Now;              // Use current time
            string format = "yyyy-MM-dd HH:mm:ss";    // modify the format depending upon input required in the column in database 
            //string insert = @" insert into Table(DateTime Column) values ('" + time.ToString(format) + "')";

            SqlConnection connection = new SqlConnection();

            connection.ConnectionString = "Server=cis1.actx.edu;Database=ParkALotDatabase;User Id=db2;Password = db20;";
            connection.Open();

            using(SqlCommand insertReservation = connection.CreateCommand())
            {
                insertReservation.CommandText = @" insert into dbo.Reservation (CustomerID, DayOfReservation, TimeIn, TimeOut) values (" + customerNumber + ", '" 
                                                + dayOfReservation.Month + "-" + dayOfReservation.Day + "-" + dayOfReservation.Year + "', '" 
                                                + DateTime.Now.ToString(format) + "', '" + timeOut.ToString(format) + "');";
                insertReservation.ExecuteNonQuery();   
            }

            connection.Close();
        }

        public void UpdateCustomerWithLicensePlate(int customerNumber, string licenseNumber)
        {

            SqlConnection connection = new SqlConnection();

            connection.ConnectionString = "Server=cis1.actx.edu;Database=ParkALotDatabase;User Id=db2;Password = db20;";
            connection.Open();

            using (SqlCommand updateCustomer = connection.CreateCommand())
            {
                updateCustomer.CommandText = "UPDATE dbo.Demographic SET PlateNumber = '" + licenseNumber + "' WHERE CustomerID = " + customerNumber + ";";
                updateCustomer.ExecuteNonQuery();
            }

            connection.Close();
        }

        public int CheckNextAvailable()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Server=cis1.actx.edu;Database=ParkALotDatabase;User Id=db2;Password = db20;";
            connection.Open();

            int parkingID = 0;

            using(SqlCommand getParkingID = connection.CreateCommand())
            {
                getParkingID.CommandText = "SELECT TOP 1 ParkingSpaceID FROM dbo.Parking WHERE IsAvailable = 'True';";

                using(SqlDataReader reader = getParkingID.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        parkingID = reader.GetInt32(0);
                    }
                }
            }
            return parkingID;
        }

        public void UpdateReservationWithParkingID(int customerNumber)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Server=cis1.actx.edu;Database=ParkALotDatabase;User Id=db2;Password = db20;";
            connection.Open();

            int parkingID = 0;

            using(SqlCommand getParkingID = connection.CreateCommand())
            {
                getParkingID.CommandText = "SELECT TOP 1 ParkingSpaceID FROM dbo.Parking WHERE IsAvailable = 'True';";

                using(SqlDataReader reader = getParkingID.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        parkingID = reader.GetInt32(0);
                    }
                }
            }

            using(SqlCommand updateReservation = connection.CreateCommand())
            {
                updateReservation.CommandText = "UPDATE dbo.Reservation SET ParkingSpaceID =" +
                                                 parkingID + " WHERE CustomerID =" + customerNumber + ";";
                updateReservation.ExecuteNonQuery();

                updateReservation.CommandText = "UPDATE dbo.Parking SET IsAvailable= 'False' WHERE ParkingSpaceID =" + parkingID + ";";
                updateReservation.ExecuteNonQuery();
            }

            connection.Close();

        }

        public int ReturnNumberOfParkingSpotsAvailable()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Server=cis1.actx.edu;Database=ParkALotDatabase;User Id=db2;Password = db20;";
            connection.Open();
            int parkingCounter = 0;
            using(SqlCommand getAvailableParkingSpots = connection.CreateCommand())
            {
                getAvailableParkingSpots.CommandText = "SELECT * FROM dbo.Parking WHERE IsAvailable = 'True';";
                using(SqlDataReader reader = getAvailableParkingSpots.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        parkingCounter++;
                    }
                }
            }

            return parkingCounter;

        }


        public void CustomerExit(string licensePlate)
        {
            //This method needs to update the end time for registered customers.  Walkin customers will also pass by this license plate
            //reader, so it only needs to work if the license plate is in the database.  Could make possible use of one of the methods above.
        }
    }
}
