using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace AnimalHouseEntities
{
    public class AnimalFactory
    {
        //SingleTon Mønster
        private static AnimalFactory instance;

        private AnimalFactory() { }

        public static AnimalFactory Instance()
        {
            if (instance == null)
            {
                instance = new AnimalFactory();
            }
            return instance;
        }

        //Laver Obj af Animal
        public Animal CreateAnimal(Customer customer, string name, DateTime birthday, Species species, double weight, bool gender, Employee employee, bool active)
        {
            return new Animal(customer, name, birthday, species, weight, gender, employee, true);
        }

        //Laver Obj af Animal
        public Animal CreateAnimal(Customer customer, int animalID,string name, DateTime birthday, Species species, double weight, bool gender, Employee employee, bool active)
        {
            return new Animal(customer, animalID, name, birthday, species, weight, gender, employee, true); 
        }
    }
}
