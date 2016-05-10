using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkALot
{
    class Parking
    {
        public static int WalkinCounter { get; set; }
        public static int ReservedCounter { get; set; }

        public static int nextResAvailable {get; set;}

        public static int nextWalkinAvailable { get; set; }

        public static bool[] walkin = new bool[10] { true, true, true, true, true, true, true, true, true, true };

        public static string[] walkinLP = new string[10];
 
        public static void updateReserved ()
        {
            DataObject dbconnect = new DataObject();
            ReservedCounter = dbconnect.ReturnNumberOfParkingSpotsAvailable();

            nextResAvailable = dbconnect.CheckNextAvailable();
        }

        public static void updateWalkin ()
        {
            //Counts through and sets the WalkinCounter
            WalkinCounter = 0;
            for (int i = 0; i < walkin.Length; i++)
            {
                if (walkin[i])
                {
                    WalkinCounter++;
                }
            }
            //Loops through and finds the next available spot.
            for (int i = 0; i < walkin.Length; i++)
            {
                if (walkin[i])
                {
                    nextWalkinAvailable = i + 1;
                    break;
                }
                else
                {
                    nextWalkinAvailable = 0;
                }
            }
        }
    }
}
