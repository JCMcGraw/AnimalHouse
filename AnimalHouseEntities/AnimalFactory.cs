using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace AnimalHouseEntities
{
    public class AnimalFactory
    {
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

        //public Animal CreateAnimal(int customerid, int animalid,string name, string birthday, int species, double weight, int gender, bool active)
        //{
        //    return new Animal(customerid, animalid, name, birthday,species, weight, gender, active);
        //}
        public Animal CreateAnimal(int customerID, int animalID,string name, DateTime birthday,int species, double weight, int gender, bool active)
        {
           
                return new Animal(customerID, animalID, name, birthday, species, weight, gender,true);

            
        }
        public Animal CreateAnimal(int customerID, string name, DateTime birthday, int species, double weight, int gender, bool active)
        {

            return new Animal(customerID, name, birthday, species, weight, gender, true);


        }

    }
}
