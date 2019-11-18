using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace AnimalHouseEntities
{
    public class TreatmentFaktory
    {
        private static TreatmentFaktory instance;

        private TreatmentFaktory() { }

        public static TreatmentFaktory Instance()
        {
            if (instance == null)
            {
                instance = new TreatmentFaktory();
            }

            return instance;
        }

        public Treatment CreateTreatment(int treatmentID, int treatmentTypeID, int operationRoomID, int cageID, int itemID, DateTime startTime, DateTime endTime, bool payed)
        {
            return new Treatment(treatmentID, treatmentTypeID, operationRoomID, cageID, itemID, startTime, endTime, payed);
        }

        public Treatment CreateTreatment(int treatmentTypeID, int operationRoomID, int cageID, int itemID, DateTime startTime, DateTime endTime, bool payed)
        {
            return new Treatment(treatmentTypeID, operationRoomID, cageID, itemID, startTime, endTime, payed);
        }
    }
}
