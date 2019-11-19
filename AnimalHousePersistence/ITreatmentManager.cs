using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHouseEntities;

namespace AnimalHousePersistence
{
    public interface ITreatmentManager
    {
        Treatment CreateTreatment(Treatment treatment);

        string UpdateTreatment(Treatment treatment);

        string DeleteTreatment(Treatment treatment);

        Treatment GetTreatment(int treatmentID);

        List<Treatment> GetManyTreatmentsByEmployee(int employeeID, DateTime startTime, DateTime endTime);

        List<Treatment> GetManyTreatmentsByAnimal(int animalID, DateTime startTime, DateTime endTime);

        List<Treatment> GetManyTreatmentsByDateTime(DateTime startTime, DateTime endTime);
        
    }
}
