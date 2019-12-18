using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHouseEntities
{
    abstract public class Customer
    {
        public int customerID { get; private set; }

        public string name { get; private set; }

        public string address { get; private set; }

        public string phone { get; private set; }

        public string email { get; private set; }

        public bool active { get; private set; }

        public List<Animal> animals {get; private set; }
        
        //constructor UDEN customerID
        public Customer(string name, string address, string phone, string email, bool active)
        {
            this.customerID = customerID;
            this.name = name;
            this.address = address;
            this.phone = phone;
            this.email = email;
            this.active = active;
        }

        //constructor MED CustomerID
        public Customer(int customerID, string name, string address, string phone, string email, bool active)
        {
            this.customerID = customerID;
            this.name = name;
            this.address = address;
            this.phone = phone;
            this.email = email;
            this.active = active;
        }

        ////Bruges når vi skal hente customerID Fra DB
        public void UpdateID(int customerID)
        {
            this.customerID = customerID;
        }

        //Kommentar
        public void AddAnimalList(List<Animal> animals)
        {
            this.animals = animals;
        }
    }
}
