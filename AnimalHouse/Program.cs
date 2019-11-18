using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHousePersistence;

namespace AnimalHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            TreatmentController.Instance().CreateTreatment(Convert.ToDateTime("1905 - 03 - 27"), Convert.ToDateTime("1905 - 09 - 22"), true);

            //TreatmentController.Instance().UpdateTreatment(Convert.ToDateTime("1905 - 05 - 27"), Convert.ToDateTime("1905 - 08 - 22"), false);
            

            Console.ReadKey();
        }
    }
}
