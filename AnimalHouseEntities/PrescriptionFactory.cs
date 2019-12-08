using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHouseEntities
{
    public class PrescriptionFactory
    {
        private static PrescriptionFactory instance;

        private PrescriptionFactory() { }

        public static PrescriptionFactory Instance()
        {
            if (instance == null)
            {
                instance = new PrescriptionFactory();
            }

            return instance;
        }

        //Prescription MED prescriptionID
        public Prescription CreatePrescription(int prescriptionID, int amount, DateTime prescriptionDay, bool payed, Employee employee, Animal animal, Item item)
        {
            return new Prescription(prescriptionID, amount,prescriptionDay,payed, employee, animal, item);
        }

        //Prescription UDEN prescriptionID
        public Prescription CreatePrescription(int amount, DateTime prescriptionDay, bool payed, Employee employee, Animal animal, Item item)
        {
            return new Prescription(amount, prescriptionDay,payed, employee, animal, item);
        }
    }
}
