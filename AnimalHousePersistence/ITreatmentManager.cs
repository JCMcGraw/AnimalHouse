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
        string CreateTreatment(Treatment treatment);

        string UpdateTreatment(Treatment treatment);

        string DeleteTreatment(Treatment treatment);

        string GetTreatment(int treatmentID);

        string GetManyTreatmentsByEmployee(int employeeID, DateTime startTime, DateTime endTime);

        string GetManyTreatmentsByAnimal(int animalID, DateTime startTime, DateTime endTime);
    }
}
