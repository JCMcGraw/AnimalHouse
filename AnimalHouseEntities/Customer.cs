using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHouseEntities
{
    public class Customer
    {
       public int CustomerID {  get; private set; }
       public string name { get; private set; }
        public string address { get; private set; }
        public string phone { get; private set; }
        public string email { get; private set; }
        public bool active { get; private set; }

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
            this.CustomerID = customerID;
            
            this.name = name;
            this.address = address;
            this.phone = phone;
            this.email = email;
            this.active = true;
        }

        

    }
}
