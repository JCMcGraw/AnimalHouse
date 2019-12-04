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

        public Prescription CreatePrescription(int prescriptionID, int amount, DateTime prescriptionDay, Employee employee, Animal animal, Item item)
        {
            return new Prescription(prescriptionID, amount,prescriptionDay, employee, animal, item);
        }
    }
}
