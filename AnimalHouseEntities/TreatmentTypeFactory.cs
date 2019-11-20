using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHouseEntities
{
    public class TreatmentTypeFactory
    {
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

        public TreatmentType CreateTreatmentType(int treatmentTypeID, string name)
        {
            return new TreatmentType(treatmentTypeID, name);
        }
    }
}
