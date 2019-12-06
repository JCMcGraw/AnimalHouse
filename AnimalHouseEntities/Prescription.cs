using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHouseEntities
{
    public class Prescription
    {
        public int prescriptionID { get; private set; }

        public int amount { get; private set; }

        public DateTime prescriptionDay { get; private set; }

        public Employee employee { get; private set; }

        public Animal animal { get; private set; }

        public Item item { get; private set; }

        //Constructor MED prescriptionID
        public Prescription(int prescriptionID, int amount,DateTime prescriptionDay, Employee employee, Animal animal, Item item)
        {
            this.prescriptionID = prescriptionID;
            this.amount = amount;
            this.prescriptionDay = prescriptionDay;
            this.employee = employee;
            this.animal = animal;
            this.item = item;
        }

        //ConstructorUDEN prescriptionID
        public Prescription(int amount, DateTime prescriptionDay, Employee employee, Animal animal, Item item)
        {
            this.amount = amount;
            this.prescriptionDay = prescriptionDay;
            this.employee = employee;
            this.animal = animal;
            this.item = item;
        }

        public void UpdateID(int prescriptionID)
        {
            this.prescriptionID = prescriptionID;
        }
    }
}
