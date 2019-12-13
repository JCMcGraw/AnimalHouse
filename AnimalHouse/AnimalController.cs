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

        public Animal CreateAnimal(Animal animal)
        {
            Animal createAnimal = animalManager.CreateAnimal(animal);
            return createAnimal;
        }

        public List<Animal> GetManyAnimalByCustomerID(Customer customer)
        {
            List<Animal>animals = animalManager.GetManyAnimalByCustomerID(customer);
            return animals;
        }

        public string UpdateAnimal(Animal animal)
        {
            string updateAnimal = animalManager.UpdateAnimal(animal);
            return updateAnimal;
        }

        public string DeleteAnimal(Animal animal)
        {
            string deleteAnimal = animalManager.DeleteAnimal(animal);
            return deleteAnimal;
        }

        //Denne bliver ikke brugt og er ikke med i Class Dia-----------------------------------
        public Animal GetAnimal(int animalID)
        {
            Animal getAnimal = animalManager.GetAnimal(animalID);
            return getAnimal;
        }
        //-------------------------------------------------------------------------------------

        public List<Species> GetSpecies()
        {
            List<Species> animals = animalManager.GetAllSpecies();
            return animals;
        }

        public List<MedicalRecord> GetAllMedicalRecordByAnimal(Animal animal)
        {
            List<MedicalRecord> getAllMedicalRecordByAnimal = animalManager.GetAllMedicalRecordEntriesByAnimalID(animal);
            return getAllMedicalRecordByAnimal;
        }

        public void CreateMedicalRecordEntry(MedicalRecord medicalRecord)
        {
            animalManager.CreateMedicalRecordEntry(medicalRecord);
        }
      
        public List<Prescription> GetAllPrescriptionByAnimal(int animalID)
        {
            List<Prescription> getAllPrescriptionByAnimal = animalManager.GetAllPrescriptionByAnimal(animalID);
            return getAllPrescriptionByAnimal;
        }

        public List<Prescription> GetUnpaidPrescriptionByCustomer(Customer customer)
        {
            List<Prescription> unpaidPrescriptionByCustomer = animalManager.GetUnpaidPrescriptionByCustomer(customer);
            return unpaidPrescriptionByCustomer;
        }

        public Prescription CreatePrescription(Prescription prescription)
        {
            Prescription createPrescription = animalManager.CreatePrescription(prescription);
            return createPrescription;
        }
    }
}
