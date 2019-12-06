using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHouseEntities
{
    public class Animal
    {
        //lav customer om til object
        public Customer customer { get; private set; }

        public int animalID { get; private set; }

        public string name { get; private set; }

        public DateTime birthday { get; private set; }

        public Species Species { get; private set; }
        //public Species species { get; private set; }
        //public int species { get; private set; }

        public List<Prescription> prescriptions { get; private set; }


        public double weight { get; private set; }

        public bool gender { get; private set; }

        public Employee Employee { get; private set; }

        public bool active { get; private set; }

        public Animal(Customer customer, int animalID, string name, DateTime birthday, Species SpeciesType, double weight, bool gender,Employee employee, bool active)
        {
            this.customer = customer;
            this.animalID = animalID;
            this.name = name;
            this.birthday = birthday;
            this.Species = SpeciesType;
            this.weight = weight;
            this.gender = gender;
            this.Employee = employee;
            this.active = active;
        }
        public Animal(Customer customer, string name, DateTime birthday, Species speciesType, double weight, bool gender,Employee employee, bool active)
        {
            this.customer = customer;
            this.name = name;
            this.birthday = birthday;
            this.Species = speciesType;
            this.weight = weight;
            this.gender = gender;
            this.Employee = employee;
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
        public void AddPrescriptionList(List<Prescription> prescriptions)
        {
            this.prescriptions = prescriptions;
        }
    }
}
