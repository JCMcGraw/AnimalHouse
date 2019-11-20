using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHouseEntities
{
    public class Customer
    {
       public int customerID {  get; private set; }
       public string name { get; private set; }
        public string address { get; private set; }
        public string phone { get; private set; }
        public string email { get; private set; }
        public bool active { get; private set; }
        public string cvr { get; private set; }

        //constructor UDEN customerID, UDEN cvr
        public Customer(string name, string address, string phone, string email, bool active)
        {
            
            this.name = name;
            this.address= address;
            this.phone = phone;
            this.email = email;
            this.active = true;
            this.cvr = cvr;
        }

        //constructor UDEN customerID, MED cvr
        public Customer(string name, string address, string phone, string email, bool active, string cvr)
        {
            this.customerID = customerID;
            this.cvr = cvr;
            
            this.name = name;
            this.address = address;
            this.phone = phone;
            this.email = email;
            this.active = true;
            this.cvr = cvr;
        }

        //constructor MED CustomerID, uden cvr
        public Customer(int customerID, string name, string address, string phone, string email, bool active)
        {
            this.customerID = customerID;
            this.cvr = cvr;

            this.name = name;
            this.address = address;
            this.phone = phone;
            this.email = email;
            this.active = true;
            this.cvr = cvr;
        }



    }
}
