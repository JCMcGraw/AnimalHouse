using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHouseEntities;

namespace AnimalHousePersistence
{
    public interface IAnimalManager
    {
        Animal CreateAnimal(Animal animal);

        string UpdateAnimal(Animal animal);

        string DeleteAnimal(Animal animal);

        Animal GetAnimal(int animalID);

     
        List<Animal> GetAnimalList(SQLQueryResult sQLQueryResult);

        //List<Animal>GetAnimalList(int ani);

        List<Animal>GetManyAnimalByCustomerID(Customer customer);

        
        //List<Species> GetSpecies();

        List<Species> GetAllSpecies();

        List<Prescription> GetUnpaidPrescriptionByCustomer(Customer customer);


        List<MedicalRecord>GetAllMedicalRecordEntriesByAnimalID(Animal animal);
        // skal det være en void?
        //void CreateMedicalRecordEntry(MedicalRecord medicalRecord);
        MedicalRecord CreateMedicalRecordEntry(MedicalRecord medicalRecord);
        List<Prescription> GetAllPrescriptionByAnimal(int animalID);

        Prescription CreatePrescription(Prescription prescription);
    }
}
