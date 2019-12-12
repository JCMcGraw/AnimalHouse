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

        public static TreatmentController Instance()
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

        public string DeleteTreatment(int treatmentID)
        {
            string deleteTreatment = treatmentManager.DeleteTreatment(treatmentID);
            return deleteTreatment;
        }

        public List<Treatment> GetTreatment(int treatmentID)
        {
            List<Treatment> getTreatment = treatmentManager.GetTreatment(treatmentID);
            return getTreatment;
        }

        public List<Treatment> GetManyTreatmentsByEmployee(int employeeID, DateTime startTime, DateTime endTime)
        {
            List<Treatment> getManyTreatmentsByEmployee = treatmentManager.GetManyTreatmentsByEmployee(employeeID,startTime,endTime);
            return getManyTreatmentsByEmployee;
        }

        public List<Treatment> GetManyTreatmentsByAnimal(int animalID, DateTime startTime, DateTime endTime)
        {
            List<Treatment> getManyTreatmentsByAnimal = treatmentManager.GetManyTreatmentsByAnimal(animalID,startTime,endTime);
            return getManyTreatmentsByAnimal;
        }

        public List<Treatment> GetManyTreatmentsByDateTime(DateTime startTime, DateTime endTime)
        {
            List<Treatment> getManyTreatmentsByDateTime = treatmentManager.GetManyTreatmentsByDateTime(startTime, endTime);
            return getManyTreatmentsByDateTime;
        }

        public List<Treatment> GetManyTreatmentsForSendingRminders(DateTime startTime, DateTime endTime)
        {
            List<Treatment> getManyTreatmentsForSendingRminders = treatmentManager.GetManyTreatmentsForSendingRminders(startTime, endTime);
            return getManyTreatmentsForSendingRminders;
        }

        public List<Treatment> GetUnpaidTreatmentsByCustomer(Customer customer)
        {
            List<Treatment> unpaidTreatmentsByCustomer = treatmentManager.GetUnpaidTreatmentsByCustomer(customer);
            return unpaidTreatmentsByCustomer;
        }

        public List<TreatmentType> GetAllTreatmentTypes()
        {
            List<TreatmentType> getManyTreatmentTypes = treatmentManager.GetAllTreatmentTypes();
            return getManyTreatmentTypes;
        }

        public List<Cage> GetAllCages()
        {
            List<Cage> getAllCages = treatmentManager.GetAllCages();
            return getAllCages;
        }

        public List<OperationRoom> GetAllOperationRooms()
        {
            List<OperationRoom> getAllOperationRooms = treatmentManager.GetAllOperationRooms();
            return getAllOperationRooms;
        }
    }
}
