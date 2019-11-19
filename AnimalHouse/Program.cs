using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHousePersistence;
using AnimalHouseEntities;

namespace AnimalHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            Treatment treatment = TreatmentFaktory.Instance().CreateTreatment(0,0,0,0,0, Convert.ToDateTime("1905 - 05 - 27"), Convert.ToDateTime("1905 - 08 - 22"), false);

            TreatmentController.Instance().CreateTreatment(treatment);

            TreatmentController.Instance().UpdateTreatment(treatment);

            
            

            
            Console.ReadKey();
        }
    }
}
