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

        public static int nextAvailable {get; set;}

        public static void updateReserved ()
        {
            DataObject dbconnect = new DataObject();
            ReservedCounter = dbconnect.ReturnNumberOfParkingSpotsAvailable();

            nextAvailable = dbconnect.CheckNextAvailable();
        }
    }
}
