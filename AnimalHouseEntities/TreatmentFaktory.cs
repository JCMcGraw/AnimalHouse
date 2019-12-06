using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHouseEntities
{
    public class TreatmentFactory
    {
        private static TreatmentFactory instance;

        private TreatmentFactory() { }

        public static TreatmentFactory Instance()
        {
            if (instance == null)
            {
                instance = new TreatmentFactory();
            }

            return instance;
        }

        public Treatment CreateTreatment(int treatmentID, TreatmentType treatmentType, OperationRoom operationRoom, Cage cage, Item item, DateTime startTime, DateTime endTime, bool payed, string headline, bool active, Animal animal, Employee employee, int status)
        {
            return new Treatment(treatmentID, treatmentType, operationRoom, cage, item, startTime, endTime, payed ,headline,active,animal,employee,status);
        }

        public Treatment CreateTreatment(TreatmentType treatmentType, OperationRoom operationRoom, Cage cage, Item item, DateTime startTime, DateTime endTime, bool payed, string headline, bool active, Animal animal, Employee employee, int status)
        {
            return new Treatment(treatmentType, operationRoom, cage, item, startTime, endTime, payed, headline, active, animal, employee, status);
        }
    }
}
