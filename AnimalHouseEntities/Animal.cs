using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHouseEntities
{
    public class Animal
    {

        public int customerID { get; private set; }
        public int animalID { get; private set; }
        public string name { get; private set; }
        public DateTime birthday { get; private set; }
        public int species { get; private set; }
        
        public double weight { get; private set; }
        public int gender { get; private set; }
        public bool active { get; private set; }

        public Animal(int customerID, int animalID, string name, DateTime birthday, int species, double weight, int gender, bool active)
        {
            this.customerID = customerID;
            this.animalID = animalID;
            this.name = name;
            this.birthday = birthday;
            this.species = species;
            this.weight = weight;
            this.gender = gender;
            this.active = active;
        }
        public Animal(int customerID, string name, DateTime birthday, int species, double weight, int gender, bool active)
        {
            this.customerID = customerID;
            this.name = name;
            this.birthday = birthday;
            this.species = species;
            this.weight = weight;
            this.gender = gender;
            this.active = active;
        }

       
        public void UpdateID(int animalid)
        {
            this.animalID = animalid;
        }

    }
}
