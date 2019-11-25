using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHouseEntities
{
    public class TreatmentType
    {
        public int treatmentTypeID { get; private set; }

        public string name { get; private set; }

        public TreatmentType(int treatmentTypeID, string name)
        {
            this.treatmentTypeID = treatmentTypeID;
            this.name = name;
        }
    }
}
