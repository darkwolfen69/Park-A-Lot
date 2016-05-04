﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data.Sql;

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
                getAllCustomers.CommandText = "select * from dbo.Demographic;";

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
                getAllCustomers.CommandText = "select * from dbo.Demographic;";

                using (SqlDataReader reader = getAllCustomers.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        customers.Add(reader.GetInt32(0).ToString());
                    }
                }
            }

            connection.Close();

            bool exists = false;


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
                }
                else
                {
                    exists = false;
                }
            }

            return exists;
        }

        public List<string> ReturnBasedOnLicensePlateNumber(string licensePlateNumber)
        {
            Customer newCust = new Customer();
            SqlConnection connection = new SqlConnection();

            List<string> output = new List<string>();

            connection.ConnectionString = "Server=cis1.actx.edu;Database=ParkALotDatabase;User Id=db2;Password = db20;";
            connection.Open();

            using (SqlCommand getAllCustomers = connection.CreateCommand())
            {
                getAllCustomers.CommandText = "select CustomerID, FirstName, LastName, DayOfReservation, TimeIn, TimeOut from dbo.Demographic JOIN dbo.Reservation WHERE PlateNumber = "
                                               + licensePlateNumber + " AND dbo.Demographic.CustomerID = dbo.Reservation.CustomerID;";

                using (SqlDataReader reader = getAllCustomers.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        newCust.CustNum = reader.GetInt32(0).ToString();
                        newCust.FullName = reader.GetString(1);
                        newCust.FullName += " " + reader.GetString(2);
                        newCust.Date = reader.GetSqlDateTime(3).ToString();
                        newCust.TimeStart = reader.GetSqlDateTime(4).ToString();
                        newCust.TimeEnd = reader.GetSqlDateTime(5).ToString();
                    }
                }
            }

            connection.Close();

            return output;
        }

        public void InsertNewReservation(int customerNumber, int licensePlateNumber, int dayOfReservation,
                                         int timeIn, int timeOut)
        {
            SqlConnection connection = new SqlConnection();

            connection.ConnectionString = "Server=cis1.actx.edu;Database=ParkALotDatabase;User Id=db2;Password = db20;";
            connection.Open();

            using(SqlCommand insertReservation = new SqlCommand())
            {
                insertReservation.CommandText = "insert into dbo.Reservation values (" + customerNumber + 
                                                 licensePlateNumber + dayOfReservation + timeIn + timeOut + 
                                                 ");";
                insertReservation.ExecuteNonQuery();   
            }

            connection.Close();
        }
    }
}
