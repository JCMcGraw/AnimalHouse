using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHouseEntities
{
    public class MedicalRecord
    {
        public int medicalRecordID { get; private set; }

        public string entry { get; private set; }

        public MedicalRecord(int medicalRecordID, string entry)
        {
            this.medicalRecordID = medicalRecordID;
            this.entry = entry;
        }
    }
}
