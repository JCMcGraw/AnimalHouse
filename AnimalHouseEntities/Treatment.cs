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

        public OperationRoom operationRoom { get; private set; }

        public Cage cage { get; private set; }

        public Item item { get; private set; }

        public DateTime startTime { get; private set; }

        public DateTime endTime { get; private set; }

        public bool payed { get; private set; }

        public string headline { get; private set; }

        public bool active { get; private set; }

        public Animal animal { get; private set; }

        public Employee employee { get; private set; }

        public int status { get; private set; }

        public Treatment(int treatmentID, TreatmentType treatmentType, OperationRoom operationRoom, Cage cage, Item item, DateTime startTime, DateTime endTime, bool payed, string headline, bool active, Animal animal, Employee employee, int status)
        {
            this.treatmentID = treatmentID;
            this.treatmentType = treatmentType;
            this.operationRoom = operationRoom;
            this.cage = cage;
            this.item = item;
            this.startTime = startTime;
            this.endTime = endTime;
            this.payed = payed;
            this.headline = headline;
            this.active = active;
            this.animal = animal;
            this.employee = employee;
            this.status = status;
        }

        public Treatment(TreatmentType treatmentType, OperationRoom operationRoom, Cage cage, Item item, DateTime startTime, DateTime endTime, bool payed, string headline, bool active, Animal animal, Employee employee, int status)
        {
            this.treatmentType = treatmentType;
            this.operationRoom = operationRoom;
            this.cage = cage;
            this.item = item;
            this.startTime = startTime;
            this.endTime = endTime;
            this.payed = payed;
            this.headline = headline;
            this.active = active;
            this.animal = animal;
            this.employee = employee;
            this.status = status;
        }

        public void UpdateID(int treatmentID)
        {
            this.treatmentID = treatmentID;
        }
    }
}       
