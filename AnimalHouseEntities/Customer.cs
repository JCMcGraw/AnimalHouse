using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHousePersistence;

namespace AnimalHouseEntities
{
    public class Customer
    {
        //int CustomerID;
       public string name { get; set; }
        string address { get; set; }
        string phone { get; set; }
        string email { get; set; }
        bool active { get; set; }

        //constructor UDEN customerID
        public Customer(string name, string address, string phone, string email, bool active)
        {
            this.name = name;
            this.address= address;
            this.phone = phone;
            this.email = email;
            this.active = true;
        }

        //customer MED customerID
        public Customer(int customerID, string name, string address, string phone, string email, bool active)
        {
            this.name = name;
            this.address = address;
            this.phone = phone;
            this.email = email;
            this.active = true;
        }

        

    }
}
