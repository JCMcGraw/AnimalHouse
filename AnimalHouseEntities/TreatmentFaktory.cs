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

        public Treatment CreateTreatment(int treatmentID, TreatmentType treatmentTypeID, int operationRoomID, int cageID, Item item, DateTime startTime, DateTime endTime, bool payed, string headline, bool active, int animalID, Employee employee)
        {
            return new Treatment(treatmentID, treatmentTypeID, operationRoomID, cageID, item, startTime, endTime, payed ,headline,active,animalID,employee);
        }

        public Treatment CreateTreatment(TreatmentType treatmentTypeID, int operationRoomID, int cageID, Item item, DateTime startTime, DateTime endTime, bool payed, string headline, bool active, int animalID, Employee employee)
        {
            return new Treatment(treatmentTypeID, operationRoomID, cageID, item, startTime, endTime, payed, headline, active, animalID, employee);
        }
    }
}
