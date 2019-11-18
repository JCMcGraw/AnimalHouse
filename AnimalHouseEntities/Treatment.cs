using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHouseEntities
{
    public class Treatment
    {
        public int treatmentID { get; private set; }

        public int treatmentTypeID { get; private set; }

        public int operationRoomID { get; private set; }

        public int cageID { get; private set; }

        public int itemID { get; private set; }

        public DateTime startTime { get; private set; }

        public DateTime endTime { get; private set; }

        public bool payed { get; private set; }

        public Treatment(int treatmentID, int treatmentTypeID, int operationRoomID, int cageID, int itemID, DateTime startTime, DateTime endTime, bool payed)
        {
            this.treatmentID = treatmentID;
            this.treatmentTypeID = treatmentTypeID;
            this.operationRoomID = operationRoomID;
            this.cageID = cageID;
            this.itemID = itemID;
            this.startTime = startTime;
            this.endTime = endTime;
            this.payed = payed;
        }

        public Treatment(int treatmentTypeID, int operationRoomID, int cageID, int itemID, DateTime startTime, DateTime endTime, bool payed)
        {
            this.treatmentTypeID = treatmentTypeID;
            this.operationRoomID = operationRoomID;
            this.cageID = cageID;
            this.itemID = itemID;
            this.startTime = startTime;
            this.endTime = endTime;
            this.payed = payed;
        }

        public void UpdateID(int treatmentID)
        {
            this.treatmentID = treatmentID;
        }
    }
}
