using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHouseEntities
{
    public class MedicalRecordFactory
    {
        private static MedicalRecordFactory instance;

        private MedicalRecordFactory() { }

        public static MedicalRecordFactory Instance()
        {
            if (instance == null)
            {
                instance = new MedicalRecordFactory();
            }

            return instance;
        }

        public MedicalRecord CreateMedicalRecord(int medicalRecordID,string entry)
        {
            MedicalRecord medicalRecord = new MedicalRecord(medicalRecordID,entry);
            return medicalRecord;
        }
    }
}
