using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHouseEntities
{
    public class Animal
    {

        public int customerid { get; private set; }
        public int animalid { get; private set; }
        public string name { get; private set; }
        public string birthday { get; private set; }
        public int species { get; private set; }
        
        public double weight { get; private set; }
        public int gender { get; private set; }
        public bool active { get; private set; }

        public Animal(int customerID, int animalID, string name, string birthday, int species, double weight, int gender, bool active)
        {
            this.customerid = customerID;
            this.animalid = animalID;
            this.name = name;
            this.birthday = birthday;
            this.species = species;
            this.weight = weight;
            this.gender = gender;
            this.active = active;
        }
       
        public Animal(string name, string birthday, double weight, int gender, bool active)
        {

            this.name = name;
            this.birthday = name;
            this.weight = weight;
            this.gender = gender;
            this.active = active;
        }
        public void UpdateID(int animalID)
        {
            this.animalid = animalID;
        }

    }
}
