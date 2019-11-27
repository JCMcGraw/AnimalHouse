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

        public TreatmentType treatmentType { get; private set; }

        public int operationRoomID { get; private set; }

        public int cageID { get; private set; }

        public int itemID { get; private set; }

        public DateTime startTime { get; private set; }

        public DateTime endTime { get; private set; }

        public bool payed { get; private set; }

        public string headline { get; private set; }

        public bool active { get; private set; }

        public int animalID { get; private set; }

        public Employee employee { get; private set; }

        public Treatment(int treatmentID, TreatmentType treatmentType, int operationRoomID, int cageID, int itemID, DateTime startTime, DateTime endTime, bool payed, string headline, bool active, int animalID, Employee employee)
        {
            this.treatmentID = treatmentID;
            this.treatmentType = treatmentType;
            this.operationRoomID = operationRoomID;
            this.cageID = cageID;
            this.itemID = itemID;
            this.startTime = startTime;
            this.endTime = endTime;
            this.payed = payed;
            this.headline = headline;
            this.active = active;
            this.animalID = animalID;
            this.employee = employee;
        }

        public Treatment(TreatmentType treatmentType, int operationRoomID, int cageID, int itemID, DateTime startTime, DateTime endTime, bool payed, string headline, bool active, int animalID, Employee employee)
        {
            this.treatmentType = treatmentType;
            this.operationRoomID = operationRoomID;
            this.cageID = cageID;
            this.itemID = itemID;
            this.startTime = startTime;
            this.endTime = endTime;
            this.payed = payed;
            this.headline = headline;
            this.active = active;
            this.animalID = animalID;
            this.employee = employee;
        }

        public void UpdateID(int treatmentID)
        {
            this.treatmentID = treatmentID;
        }
    }
}       
