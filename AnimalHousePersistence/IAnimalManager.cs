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


        //List<MedicalRecord> GetAllMedicalRecordByAnimal(int animalID);
       void CreateMedicalRecordEntry(MedicalRecord medicalRecord);
    }
}
