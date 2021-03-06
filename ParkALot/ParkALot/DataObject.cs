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
        //This method will return true or false
        //based on if the customer exists in the database
        //based on their customerNumber.
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

        //This method will return true or false
        //based on if the customer exists in the database
        //based on their licenseNumber.
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

        //This method will return the customer's information
        //based on licensePlateNumber
        public void ReturnBasedOnLicensePlateNumber(string licensePlateNumber)
        {
            SqlConnection connection = new SqlConnection();

            connection.ConnectionString = "Server=cis1.actx.edu;Database=ParkALotDatabase;User Id=db2;Password = db20;";
            connection.Open();

            using (SqlCommand getAllCustomers = connection.CreateCommand())
            {
                getAllCustomers.CommandText = "SELECT TOP 1 dbo.Demographic.CustomerID, FirstName, LastName, dbo.Reservation.DayOfReservation, "
                                              + "dbo.Reservation.TimeIn, dbo.Reservation.TimeOut from dbo.Demographic "
                                              + "JOIN dbo.Reservation ON (dbo.Demographic.CustomerID = dbo.Reservation.CustomerID) WHERE PlateNumber = '"
                                               + licensePlateNumber + "' ORDER BY TimeIn DESC ;";

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

        //This method will insert a new reservation into the database
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

        //This method will update the customer's information with 
        //an end-user entered license plate number.
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

        //This method will return the next available
        //parking space id
        public int CheckNextAvailable()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Server=cis1.actx.edu;Database=ParkALotDatabase;User Id=db2;Password = db20;";
            connection.Open();

            int parkingID = 0;
            //int resID = 0;

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

        //THis method will update a customer's reservation
        //with a parking space and then it will update the 
        //parking space to not available
        public void UpdateReservationWithParkingID(int customerNumber)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Server=cis1.actx.edu;Database=ParkALotDatabase;User Id=db2;Password = db20;";
            connection.Open();

            int parkingID = 0;
            int resvID = 0;

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

            using (SqlCommand getResID = connection.CreateCommand())
            {
                getResID.CommandText = "SELECT TOP 1 ReservationID FROM dbo.Reservation WHERE CustomerID = " + customerNumber + " ORDER BY TimeIn DESC;";

                using (SqlDataReader reader = getResID.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        resvID = reader.GetInt32(0);
                    }
                }
            }

            using(SqlCommand updateReservation = connection.CreateCommand())
            {
                updateReservation.CommandText = "UPDATE dbo.Reservation SET ParkingSpaceID =" +
                                                 parkingID + " WHERE CustomerID =" + customerNumber + " AND ReservationID = " + resvID + ";";
                updateReservation.ExecuteNonQuery();

                updateReservation.CommandText = "UPDATE dbo.Parking SET IsAvailable= 'False' WHERE ParkingSpaceID =" + parkingID + ";";
                updateReservation.ExecuteNonQuery();
            }

            connection.Close();

        }

        //This method will return the number of parkings spots that
        //are open
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

        //This method will delete the customer's
        //reservation when they exit and then
        //update the parking spot that they were 
        //using back to available
        public void CustomerExit(string licensePlate)
        {
            
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Server=cis1.actx.edu;Database=ParkALotDatabase;User Id=db2;Password = db20;";
            connection.Open();

            int customerNumber = 0;

            using (SqlCommand getCustomerID = connection.CreateCommand())
            {
                getCustomerID.CommandText = "SELECT TOP 1 CustomerID FROM dbo.Demographic WHERE PlateNumber = '" + licensePlate + "';";

                using (SqlDataReader reader = getCustomerID.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        customerNumber = reader.GetInt32(0);
                    }
                }
            }

            int parkingId = 0;

            using (SqlCommand getParkingID = connection.CreateCommand())
            {
                getParkingID.CommandText = "SELECT Top 1 ParkingSpaceID FROM dbo.Reservation WHERE CustomerID = " + customerNumber + ";";

                using (SqlDataReader reader = getParkingID.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        parkingId = reader.GetInt32(0);
                    }
                }
            }

            using(SqlCommand updateReservation = connection.CreateCommand())
            {
                updateReservation.CommandText = "UPDATE dbo.Parking SET IsAvailable = 'True' WHERE ParkingSpaceID =" + parkingId + ";";
                updateReservation.ExecuteNonQuery();
            }

            using(SqlCommand deleteReservation = connection.CreateCommand())
            {
                deleteReservation.CommandText = "DELETE FROM dbo.Reservation WHERE ParkingSpaceID = (SELECT TOP 1 ParkingSpaceID FROM dbo.Reservation WHERE ParkingSpaceID = " + parkingId + " ORDER BY TimeIn DESC);";
                deleteReservation.ExecuteNonQuery();
            }

            Marquee.updateMarquee();
            connection.Close();
        }
    }
}
