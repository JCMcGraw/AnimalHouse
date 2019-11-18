using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHousePersistence;
using AnimalHouseEntities;

namespace AnimalHouse
{
    public class TreatmentController
    {
        private static TreatmentController treatmentController;

        private TreatmentController() { }

        public static TreatmentController instance()
        {
            if (treatmentController == null)
            {
                treatmentController = new TreatmentController();
            }

            return treatmentController;
        }

        ITreatmentManager treatmentManager = new TreatmentManager();

        public Treatment CreateTreatment(Treatment treatment)
        {
            Treatment createTreatment = treatmentManager.CreateTreatment(treatment);
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

        public Treatment GetTreatment(int treatmentID)
        {
            Treatment getTreatment = treatmentManager.GetTreatment(treatmentID);
            return getTreatment;
        }

        public List<Treatment> GetManyTreatmentsByEmployee(int employeeID, DateTime startTime, DateTime endTime)
        {
            List<Treatment> getManyTreatmentsByEmployee = treatmentManager.GetManyTreatmentsByEmployee(employeeID,startTime,endTime);
            return getManyTreatmentsByEmployee;
        }

        public string GetManyTreatmentsByAnimal(int animalID, DateTime startTime, DateTime endTime)
        {
            string getManyTreatmentsByAnimal = treatmentManager.GetManyTreatmentsByAnimal(animalID,startTime,endTime);
            return getManyTreatmentsByAnimal;
        }
    }
}
