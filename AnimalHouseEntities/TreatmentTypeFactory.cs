using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHouseEntities
{
    public class TreatmentTypeFactory
    {
        //SingleTon Mønster
        private static TreatmentTypeFactory instance;

        private TreatmentTypeFactory() { }

        public static TreatmentTypeFactory Instance()
        {
            if (instance == null)
            {
                instance = new TreatmentTypeFactory();
            }

            return instance;
        }

        //Laver obj af TreatmentType
        public TreatmentType CreateTreatmentType(int treatmentTypeID, string name)
        {
            return new TreatmentType(treatmentTypeID, name);
        }
    }
}
