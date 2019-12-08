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
        public List<Animal> GetManyAnimalByCustomerID(Customer customer)
        {
            IAnimalManager animalManager = new AnimalManager();
            List<Animal>animals = animalManager.GetManyAnimalByCustomerID(customer);
            return animals;
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
        public List<Species> GetSpecies()
        {
            IAnimalManager animalManager = new AnimalManager();
            List<Species> animals = animalManager.GetAllSpecies();
            return animals;
        }

        public void CreateMedicalRecordEntry(MedicalRecord medicalRecord)
        {
            IAnimalManager animalManager = new AnimalManager();
            animalManager.CreateMedicalRecordEntry(medicalRecord);
        }

        public List<Prescription> GetAllPrescriptionByAnimal(int animalID)
        {
            IAnimalManager animalManager = new AnimalManager();
            List<Prescription> getAllPrescriptionByAnimal = animalManager.GetAllPrescriptionByAnimal(animalID);
            return getAllPrescriptionByAnimal;
        }

        public List<Prescription> GetUnpaidPrescriptionByCustomer(Customer customer)
        {
            IAnimalManager animalManager = new AnimalManager();
            List<Prescription> unpaidPrescriptionByCustomer = animalManager.GetUnpaidPrescriptionByCustomer(customer);
            return unpaidPrescriptionByCustomer;
        }

        public Prescription CreatePrescription(Prescription prescription)
        {
            IAnimalManager animalManager = new AnimalManager();
            
            return animalManager.CreatePrescription(prescription);
        }
    }
}
