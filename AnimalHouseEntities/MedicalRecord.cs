using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHouseEntities;

namespace AnimalHouseEntities
{
    public class MedicalRecord
    {
        public int medicalRecordID { get; private set; }

        public string entry { get; private set; }

        public Animal animal { get; private set; }
        public Treatment treatment { get; private set; }

        public MedicalRecord(int medicalRecordID, string entry, Animal animal, Treatment treatment)
        {
            this.medicalRecordID = medicalRecordID;
            this.entry = entry;
            this.animal = animal;
            this.treatment = treatment;

        }
    }
}
