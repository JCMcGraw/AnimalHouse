using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHouseEntities;
using AnimalHousePersistence;

namespace AnimalHouse
{
    public class AnimalController
    {
        private static AnimalController animalController;

        private AnimalController() { }

        public static AnimalController Instance()
        {
            if (animalController == null)
            {
                animalController = new AnimalController();
            }
            return animalController;
        }
        IAnimalManager animalManager = new AnimalManager();

        //public string CreateAnimal(string name, double weight, char gender, bool active)
        //{
        //    string createAnimal = animalManager.CreateAnimal(name, weight, gender, active);
        //    return createAnimal;
        //}
        public Animal CreateAnimal(Animal animal)
        {
            Animal createAnimal = animalManager.CreateAnimal(animal);

            return createAnimal;
        }


        public string UpdateAnimal(Animal animal)
        {
            IAnimalManager animalManager = new AnimalManager();
            string updateAnimal = animalManager.UpdateAnimal(animal);
            return updateAnimal;
        }

        public string DeleteAnimal(Animal animal)
        {
            IAnimalManager animalManager = new AnimalManager();
            string deleteAnimal = animalManager.DeleteAnimal(animal);
            return deleteAnimal;
        }

        public Animal GetAnimal(int animalID)
        {
            IAnimalManager animalManager = new AnimalManager();
            Animal getAnimal = animalManager.GetAnimal(animalID);
            return getAnimal;
        }

    }
}
