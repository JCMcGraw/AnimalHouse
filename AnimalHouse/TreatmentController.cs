using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHousePersistence;
using AnimalHouseEntities;

namespace AnimalHouse
{
    class TreatmentController
    {
        ITreatmentManager treatmentManager = new TreatmentManager();

        public string CreateTreatment(Treatment treatment)
        {
            string createTreatment = treatmentManager.CreateTreatment(treatment);
            return createTreatment;
        }

        public string UpdateTreatment(Treatment treatment)
        {
            string updateTreatment = treatmentManager.UpdateTreatment(treatment);
            return updateTreatment;
        }

        public string DeleteTreatment(Treatment treatment)
        {
            string deleteTreatment = treatmentManager.DeleteTreatment(treatment);
            return deleteTreatment;
        }

        public string GetTreatment(int treatmentID)
        {
            string getTreatment = treatmentManager.GetTreatment(treatmentID);
            return getTreatment;
        }

        public string GetManyTreatmentsByEmployee(int employeeID, DateTime startTime, DateTime endTime)
        {
            string getManyTreatmentsByEmployee = treatmentManager.GetManyTreatmentsByEmployee(employeeID,startTime,endTime);
            return getManyTreatmentsByEmployee;
        }

        public string GetManyTreatmentsByAnimal(int animalID, DateTime startTime, DateTime endTime)
        {
            string getManyTreatmentsByAnimal = treatmentManager.GetManyTreatmentsByAnimal(animalID,startTime,endTime);
            return getManyTreatmentsByAnimal;
        }
    }
}
