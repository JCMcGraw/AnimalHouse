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

        public Species Species { get; private set; }
        //public Species species { get; private set; }
        //public int species { get; private set; }
        
        public double weight { get; private set; }
        public bool gender { get; private set; }
        public int employeeid { get; private set; }
        public bool active { get; private set; }

        public Animal(int customerID, int animalID, string name, DateTime birthday, Species SpeciesType, double weight, bool gender,int employeeID, bool active)
        {
            this.customerID = customerID;
            this.animalID = animalID;
            this.name = name;
            this.birthday = birthday;
            this.Species = SpeciesType;
            this.weight = weight;
            this.gender = gender;
            this.employeeid = employeeID;
            this.active = active;
        }
        public Animal(int customerID, string name, DateTime birthday, Species speciesType, double weight, bool gender,int employeeID, bool active)
        {
            this.customerID = customerID;
            this.name = name;
            this.birthday = birthday;
            this.Species = speciesType;
            this.weight = weight;
            this.gender = gender;
            this.employeeid = employeeID;
            this.active = active;
        }

       
        public void UpdateID(int animalid)
        {
            this.animalID = animalid;
        }
        public void GetAnimalList(int animalid)
        {
            this.animalID = animalid;
        }

    }
}
