using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHouseEntities
{
    public class MedicalRecordFactory
    {
        //SingleTon
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

        //Laver Obj af MedicalRecord
        public MedicalRecord CreateMedicalRecord(int medicalRecordID,string entry, Animal animal, Treatment treatment)
        {
            MedicalRecord medicalRecord = new MedicalRecord(medicalRecordID,entry, animal, treatment);
            return medicalRecord;
        }

        //Laver Obj af MedicalRecord
        public MedicalRecord CreateMedicalRecord(string entry, Animal animal, Treatment treatment)
        {
            MedicalRecord medicalRecord = new MedicalRecord(entry, animal, treatment);
            return medicalRecord;
        }
    }
}
